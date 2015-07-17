using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace FNChanger2
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.All;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
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
            string folder = Path.GetDirectoryName(file);
            string filename = Path.GetFileNameWithoutExtension(file);
            string extension = Path.GetExtension(file);
            if (chkExtension.Checked)
            {
                filename += extension;
                extension = "";
            }
            if (chkFolder.Checked)
            {
                filename = Path.Combine(folder, filename);
                folder = "";
            }
            if (nudRemoveLeft.Value > 0 && filename.Length >= nudRemoveLeft.Value)
            {
                filename = filename.Substring((int)nudRemoveLeft.Value);
            }
            if (!string.IsNullOrEmpty(txtAddLeft.Text))
            {
                filename = txtAddLeft.Text + filename;
            }
            if (nudRemoveRight.Value > 0 && filename.Length >= nudRemoveRight.Value)
            {
                filename = filename.Substring(0, filename.Length - (int)nudRemoveRight.Value);
            }
            if (!string.IsNullOrEmpty(txtAddRight.Text))
            {
                filename += txtAddRight.Text;
            }
            if (!string.IsNullOrEmpty(txtBefore.Text))
            {
                if (!chkRegex.Checked)
                {
                    filename = filename.Replace(txtBefore.Text, txtAfter.Text);
                }
                else
                {
                    filename = Regex.Replace(filename, txtBefore.Text, txtAfter.Text);
                }
            }
            // 何もしない
            //if (radNoCase.Checked) ;
            if (radWordCase.Checked)
            {
                filename = Regex.Replace(filename, @"\w+", ReplaceProperCase);
            }
            else if (radUpperCase.Checked)
            {
                filename = filename.ToUpper();
            }
            else if (radLowerCase.Checked)
            {
                filename = filename.ToLower();
            }
            string newfile = Path.Combine(folder, filename + extension);
            if (!chkPreview.Checked && file != newfile) File.Move(file, newfile);
            return newfile;
        }

        public string ReplaceProperCase(Match m)
        {
            string match = m.Value;
            return match.Substring(0, 1).ToUpper() + match.Substring(1).ToLower();
        }

        private void cmbFile_TextUpdate(object sender, EventArgs e)
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

        private void btnLoad_Click(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
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

        private void cmbFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }
    }
}
