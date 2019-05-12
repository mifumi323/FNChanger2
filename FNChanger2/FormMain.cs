using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace FNChanger2
{
    public partial class FormMain : Form
    {
        public string FileName
        {
            get
            {
                if (cmbFile.Text.Length == 0) throw new Exception("保存名が指定されていません。");
                var chars = Path.GetInvalidFileNameChars();
                foreach (var c in chars)
                {
                    if (cmbFile.Text.Contains(c.ToString())) throw new Exception("保存名に使えない文字が含まれています。");
                }
                return Path.Combine(UserAppDataPath, cmbFile.Text + ".fnc");
            }
        }

        readonly Random random = new Random();

        /// <summary>バージョンに依存しないユーザーのアプリケーションデータのパス</summary>
        public static string UserAppDataPath
        {
            get
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                    "\\" + Application.CompanyName + "\\" + Application.ProductName;
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                return path;
            }
        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName;

            // 初期レイアウト
            int lineHeight = tlpAddRemove.Margin.Top + tlpAddRemove.Margin.Bottom + Math.Max(label1.Height, txtAddLeft.Height);
            int lineWidth = this.ClientSize.Width;
            tlpAddRemove.SetBounds(0, 0, lineWidth, lineHeight * 2);
            tlpReplace.SetBounds(0, tlpAddRemove.Bottom, lineWidth, lineHeight);
            tlpCase.SetBounds(0, tlpReplace.Bottom, lineWidth, lineHeight * 4);
            btnSave.Height = btnLoad.Height = btnDelete.Height = cmbFile.Height;
            tlpFile.SetBounds(0, this.ClientSize.Height - lineHeight, lineWidth, lineHeight);
            txtLog.SetBounds(0, tlpCase.Bottom, lineWidth, tlpFile.Top - tlpCase.Bottom);
            this.Icon = FNChanger2.Properties.Resources.FncIcon;

            UpdateFileList();
            UpdateButtons();
        }

        private void UpdateFileList()
        {
            var files = Directory.GetFiles(UserAppDataPath, "*.fnc", SearchOption.TopDirectoryOnly);
            cmbFile.Items.Clear();
            foreach (var file in files)
            {
                cmbFile.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
        }

        private void FormMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.All;
        }

        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            StringBuilder log = new StringBuilder();
            int succeeded = 0, failed = 0;
            if (chkPreview.Checked)
            {
                log.AppendLine("プレビューモード(実際のファイル名変更無し)");
                log.AppendLine();
            }
            foreach (var file in files)
            {
                try
                {
                    log.AppendLine(file);
                    string newfile = this.Rename(file);
                    if (newfile == file)
                    {
                        log.AppendLine("変更なし");
                    }
                    else
                    {
                        log.AppendLine("変更後: " + newfile);
                    }
                    succeeded++;
                }
                catch (Exception ex)
                {
                    log.AppendLine("エラー: " + ex.Message);
                    failed++;
                }
                log.AppendLine();
            }
            log.Append(string.Format("成功:{0} 失敗:{1}", succeeded, failed));
            txtLog.Text = log.ToString();
        }

        private string Rename(string file)
        {
            var rule = new RenameRule
            {
                WithExtension = chkExtension.Checked,
                WithDirectory = chkFolder.Checked,
                RemoveLeftLength = (int)nudRemoveLeft.Value,
                AddLeft = txtAddLeft.Text,
                RemoveRightLength = (int)nudRemoveRight.Value,
                AddRight = txtAddRight.Text,
                ReplaceFrom = txtBefore.Text,
                ReplaceTo = txtAfter.Text,
                ReplaceRegex = chkRegex.Checked,
                Random = random,
                Case =
                    radWordCase.Checked ? RenameRule.CaseRule.Word :
                    radUpperCase.Checked ? RenameRule.CaseRule.Upper :
                    radLowerCase.Checked ? RenameRule.CaseRule.Lower :
                    RenameRule.CaseRule.None,
            };
            var newfile = rule.Apply(file);
            if (!chkPreview.Checked && file != newfile) File.Move(file, newfile);
            return newfile;
        }

        public string ReplaceProperCase(Match m)
        {
            string match = m.Value;
            return match.Substring(0, 1).ToUpper() + match.Substring(1).ToLower();
        }

        private void CmbFile_TextUpdate(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            try
            {
                string filename = FileName;
                btnSave.Enabled = true;
                btnLoad.Enabled = btnDelete.Enabled = File.Exists(filename);
            }
            catch
            {
                btnLoad.Enabled = btnSave.Enabled = btnDelete.Enabled = false;
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using (var sr = new StreamReader(FileName))
                {
                    nudRemoveLeft.Value = decimal.Parse(sr.ReadLine());
                    txtAddLeft.Text = sr.ReadLine();
                    nudRemoveRight.Value = decimal.Parse(sr.ReadLine());
                    txtAddRight.Text = sr.ReadLine();
                    txtBefore.Text = sr.ReadLine();
                    txtAfter.Text = sr.ReadLine();
                    radNoCase.Checked = bool.Parse(sr.ReadLine());
                    radWordCase.Checked = bool.Parse(sr.ReadLine());
                    radUpperCase.Checked = bool.Parse(sr.ReadLine());
                    radLowerCase.Checked = bool.Parse(sr.ReadLine());
                    chkExtension.Checked = bool.Parse(sr.ReadLine());
                    chkFolder.Checked = bool.Parse(sr.ReadLine());
                    chkRegex.Checked = bool.Parse(sr.ReadLine());
                    chkPreview.Checked = bool.Parse(sr.ReadLine());
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "プリセットファイルを開くのに失敗しました。");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = FileName;
                if (File.Exists(filename))
                {
                    if (MessageBox.Show(this, string.Format("{0} に上書き保存します。", cmbFile.Text), "プリセットファイルの保存", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        return;
                }
                using (var sw = new StreamWriter(filename))
                {
                    sw.WriteLine(nudRemoveLeft.Value);
                    sw.WriteLine(txtAddLeft.Text);
                    sw.WriteLine(nudRemoveRight.Value);
                    sw.WriteLine(txtAddRight.Text);
                    sw.WriteLine(txtBefore.Text);
                    sw.WriteLine(txtAfter.Text);
                    sw.WriteLine(radNoCase.Checked);
                    sw.WriteLine(radWordCase.Checked);
                    sw.WriteLine(radUpperCase.Checked);
                    sw.WriteLine(radLowerCase.Checked);
                    sw.WriteLine(chkExtension.Checked);
                    sw.WriteLine(chkFolder.Checked);
                    sw.WriteLine(chkRegex.Checked);
                    sw.WriteLine(chkPreview.Checked);
                }
                UpdateFileList();
                UpdateButtons();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "プリセットの保存に失敗しました。");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, string.Format("{0} を削除します。", cmbFile.Text), "プリセットファイルの削除", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    File.Delete(FileName);
                    UpdateFileList();
                    UpdateButtons();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "プリセットファイルの削除に失敗しました。");
            }
        }

        private void CmbFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }
    }
}
