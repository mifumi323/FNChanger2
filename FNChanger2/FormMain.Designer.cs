namespace FNChanger2
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlpAddRemove = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddLeft = new System.Windows.Forms.TextBox();
            this.txtAddRight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudRemoveLeft = new System.Windows.Forms.NumericUpDown();
            this.nudRemoveRight = new System.Windows.Forms.NumericUpDown();
            this.btnAddLeftPattern = new System.Windows.Forms.Button();
            this.btnAddRightPattern = new System.Windows.Forms.Button();
            this.tlpReplace = new System.Windows.Forms.TableLayoutPanel();
            this.txtBefore = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAfter = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAfterPattern = new System.Windows.Forms.Button();
            this.tlpCase = new System.Windows.Forms.TableLayoutPanel();
            this.radNoCase = new System.Windows.Forms.RadioButton();
            this.radWordCase = new System.Windows.Forms.RadioButton();
            this.radUpperCase = new System.Windows.Forms.RadioButton();
            this.radLowerCase = new System.Windows.Forms.RadioButton();
            this.chkExtension = new System.Windows.Forms.CheckBox();
            this.chkFolder = new System.Windows.Forms.CheckBox();
            this.chkRegex = new System.Windows.Forms.CheckBox();
            this.chkPreview = new System.Windows.Forms.CheckBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.cmbFolderDrop = new System.Windows.Forms.ComboBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.tlpFile = new System.Windows.Forms.TableLayoutPanel();
            this.cmbFile = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cmsInsert = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiInsertRandom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertNow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertCTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertMTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertATimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpAddRemove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemoveLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemoveRight)).BeginInit();
            this.tlpReplace.SuspendLayout();
            this.tlpCase.SuspendLayout();
            this.tlpFile.SuspendLayout();
            this.cmsInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpAddRemove
            // 
            this.tlpAddRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpAddRemove.ColumnCount = 7;
            this.tlpAddRemove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpAddRemove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tlpAddRemove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpAddRemove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpAddRemove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tlpAddRemove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tlpAddRemove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpAddRemove.Controls.Add(this.label2, 2, 0);
            this.tlpAddRemove.Controls.Add(this.label1, 0, 0);
            this.tlpAddRemove.Controls.Add(this.label3, 3, 0);
            this.tlpAddRemove.Controls.Add(this.label4, 6, 0);
            this.tlpAddRemove.Controls.Add(this.label5, 0, 1);
            this.tlpAddRemove.Controls.Add(this.label6, 2, 1);
            this.tlpAddRemove.Controls.Add(this.label7, 3, 1);
            this.tlpAddRemove.Controls.Add(this.txtAddLeft, 4, 0);
            this.tlpAddRemove.Controls.Add(this.txtAddRight, 4, 1);
            this.tlpAddRemove.Controls.Add(this.label8, 6, 1);
            this.tlpAddRemove.Controls.Add(this.nudRemoveLeft, 1, 0);
            this.tlpAddRemove.Controls.Add(this.nudRemoveRight, 1, 1);
            this.tlpAddRemove.Controls.Add(this.btnAddLeftPattern, 5, 0);
            this.tlpAddRemove.Controls.Add(this.btnAddRightPattern, 5, 1);
            this.tlpAddRemove.Location = new System.Drawing.Point(12, 12);
            this.tlpAddRemove.Name = "tlpAddRemove";
            this.tlpAddRemove.RowCount = 2;
            this.tlpAddRemove.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAddRemove.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAddRemove.Size = new System.Drawing.Size(421, 72);
            this.tlpAddRemove.TabIndex = 0;
            this.tlpAddRemove.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.tlpAddRemove.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "文字を削除";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "最初の";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "最初に";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "を追加";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "最後の";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "文字を削除";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "最後に";
            // 
            // txtAddLeft
            // 
            this.txtAddLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddLeft.HideSelection = false;
            this.txtAddLeft.Location = new System.Drawing.Point(235, 3);
            this.txtAddLeft.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtAddLeft.Name = "txtAddLeft";
            this.txtAddLeft.Size = new System.Drawing.Size(123, 19);
            this.txtAddLeft.TabIndex = 4;
            // 
            // txtAddRight
            // 
            this.txtAddRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddRight.HideSelection = false;
            this.txtAddRight.Location = new System.Drawing.Point(235, 28);
            this.txtAddRight.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtAddRight.Name = "txtAddRight";
            this.txtAddRight.Size = new System.Drawing.Size(123, 19);
            this.txtAddRight.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "を追加";
            // 
            // nudRemoveLeft
            // 
            this.nudRemoveLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudRemoveLeft.Location = new System.Drawing.Point(48, 3);
            this.nudRemoveLeft.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRemoveLeft.Name = "nudRemoveLeft";
            this.nudRemoveLeft.Size = new System.Drawing.Size(69, 19);
            this.nudRemoveLeft.TabIndex = 1;
            this.nudRemoveLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudRemoveRight
            // 
            this.nudRemoveRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudRemoveRight.Location = new System.Drawing.Point(48, 28);
            this.nudRemoveRight.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRemoveRight.Name = "nudRemoveRight";
            this.nudRemoveRight.Size = new System.Drawing.Size(69, 19);
            this.nudRemoveRight.TabIndex = 8;
            this.nudRemoveRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAddLeftPattern
            // 
            this.btnAddLeftPattern.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddLeftPattern.Location = new System.Drawing.Point(358, 3);
            this.btnAddLeftPattern.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnAddLeftPattern.Name = "btnAddLeftPattern";
            this.btnAddLeftPattern.Size = new System.Drawing.Size(15, 19);
            this.btnAddLeftPattern.TabIndex = 5;
            this.btnAddLeftPattern.TabStop = false;
            this.btnAddLeftPattern.UseVisualStyleBackColor = true;
            this.btnAddLeftPattern.Click += new System.EventHandler(this.BtnPattern_Click);
            // 
            // btnAddRightPattern
            // 
            this.btnAddRightPattern.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddRightPattern.Location = new System.Drawing.Point(358, 28);
            this.btnAddRightPattern.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnAddRightPattern.Name = "btnAddRightPattern";
            this.btnAddRightPattern.Size = new System.Drawing.Size(15, 19);
            this.btnAddRightPattern.TabIndex = 12;
            this.btnAddRightPattern.TabStop = false;
            this.btnAddRightPattern.UseVisualStyleBackColor = true;
            this.btnAddRightPattern.Click += new System.EventHandler(this.BtnPattern_Click);
            // 
            // tlpReplace
            // 
            this.tlpReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpReplace.ColumnCount = 5;
            this.tlpReplace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpReplace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpReplace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpReplace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tlpReplace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpReplace.Controls.Add(this.txtBefore, 0, 0);
            this.tlpReplace.Controls.Add(this.label9, 1, 0);
            this.tlpReplace.Controls.Add(this.txtAfter, 2, 0);
            this.tlpReplace.Controls.Add(this.label10, 4, 0);
            this.tlpReplace.Controls.Add(this.btnAfterPattern, 3, 0);
            this.tlpReplace.Location = new System.Drawing.Point(12, 90);
            this.tlpReplace.Name = "tlpReplace";
            this.tlpReplace.RowCount = 1;
            this.tlpReplace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpReplace.Size = new System.Drawing.Size(295, 39);
            this.tlpReplace.TabIndex = 1;
            this.tlpReplace.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.tlpReplace.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            // 
            // txtBefore
            // 
            this.txtBefore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBefore.HideSelection = false;
            this.txtBefore.Location = new System.Drawing.Point(3, 3);
            this.txtBefore.Name = "txtBefore";
            this.txtBefore.Size = new System.Drawing.Size(100, 19);
            this.txtBefore.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "を";
            // 
            // txtAfter
            // 
            this.txtAfter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAfter.HideSelection = false;
            this.txtAfter.Location = new System.Drawing.Point(129, 3);
            this.txtAfter.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.Size = new System.Drawing.Size(103, 19);
            this.txtAfter.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(253, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "に置換";
            // 
            // btnAfterPattern
            // 
            this.btnAfterPattern.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAfterPattern.Location = new System.Drawing.Point(232, 3);
            this.btnAfterPattern.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnAfterPattern.Name = "btnAfterPattern";
            this.btnAfterPattern.Size = new System.Drawing.Size(15, 19);
            this.btnAfterPattern.TabIndex = 3;
            this.btnAfterPattern.TabStop = false;
            this.btnAfterPattern.UseVisualStyleBackColor = true;
            this.btnAfterPattern.Click += new System.EventHandler(this.BtnPattern_Click);
            // 
            // tlpCase
            // 
            this.tlpCase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCase.ColumnCount = 4;
            this.tlpCase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpCase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpCase.Controls.Add(this.radNoCase, 0, 0);
            this.tlpCase.Controls.Add(this.radWordCase, 2, 0);
            this.tlpCase.Controls.Add(this.radUpperCase, 0, 1);
            this.tlpCase.Controls.Add(this.radLowerCase, 2, 1);
            this.tlpCase.Controls.Add(this.chkExtension, 0, 2);
            this.tlpCase.Controls.Add(this.chkFolder, 2, 2);
            this.tlpCase.Controls.Add(this.chkRegex, 0, 4);
            this.tlpCase.Controls.Add(this.chkPreview, 2, 4);
            this.tlpCase.Controls.Add(this.btnApply, 3, 4);
            this.tlpCase.Controls.Add(this.cmbFolderDrop, 0, 3);
            this.tlpCase.Location = new System.Drawing.Point(12, 135);
            this.tlpCase.Name = "tlpCase";
            this.tlpCase.RowCount = 5;
            this.tlpCase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCase.Size = new System.Drawing.Size(388, 109);
            this.tlpCase.TabIndex = 2;
            this.tlpCase.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.tlpCase.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            // 
            // radNoCase
            // 
            this.radNoCase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radNoCase.AutoSize = true;
            this.radNoCase.Checked = true;
            this.tlpCase.SetColumnSpan(this.radNoCase, 2);
            this.radNoCase.Location = new System.Drawing.Point(3, 3);
            this.radNoCase.Name = "radNoCase";
            this.radNoCase.Size = new System.Drawing.Size(157, 15);
            this.radNoCase.TabIndex = 0;
            this.radNoCase.TabStop = true;
            this.radNoCase.Text = "大文字小文字を変換しない";
            this.radNoCase.UseVisualStyleBackColor = true;
            // 
            // radWordCase
            // 
            this.radWordCase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radWordCase.AutoSize = true;
            this.tlpCase.SetColumnSpan(this.radWordCase, 2);
            this.radWordCase.Location = new System.Drawing.Point(197, 3);
            this.radWordCase.Name = "radWordCase";
            this.radWordCase.Size = new System.Drawing.Size(135, 15);
            this.radWordCase.TabIndex = 1;
            this.radWordCase.Text = "単語の先頭を大文字に";
            this.radWordCase.UseVisualStyleBackColor = true;
            // 
            // radUpperCase
            // 
            this.radUpperCase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radUpperCase.AutoSize = true;
            this.tlpCase.SetColumnSpan(this.radUpperCase, 2);
            this.radUpperCase.Location = new System.Drawing.Point(3, 24);
            this.radUpperCase.Name = "radUpperCase";
            this.radUpperCase.Size = new System.Drawing.Size(89, 15);
            this.radUpperCase.TabIndex = 2;
            this.radUpperCase.Text = "全て大文字に";
            this.radUpperCase.UseVisualStyleBackColor = true;
            // 
            // radLowerCase
            // 
            this.radLowerCase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radLowerCase.AutoSize = true;
            this.tlpCase.SetColumnSpan(this.radLowerCase, 2);
            this.radLowerCase.Location = new System.Drawing.Point(197, 24);
            this.radLowerCase.Name = "radLowerCase";
            this.radLowerCase.Size = new System.Drawing.Size(89, 15);
            this.radLowerCase.TabIndex = 3;
            this.radLowerCase.Text = "全て小文字に";
            this.radLowerCase.UseVisualStyleBackColor = true;
            // 
            // chkExtension
            // 
            this.chkExtension.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkExtension.AutoSize = true;
            this.tlpCase.SetColumnSpan(this.chkExtension, 2);
            this.chkExtension.Location = new System.Drawing.Point(3, 45);
            this.chkExtension.Name = "chkExtension";
            this.chkExtension.Size = new System.Drawing.Size(117, 15);
            this.chkExtension.TabIndex = 4;
            this.chkExtension.Text = "拡張子部分も変換";
            this.chkExtension.UseVisualStyleBackColor = true;
            // 
            // chkFolder
            // 
            this.chkFolder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkFolder.AutoSize = true;
            this.tlpCase.SetColumnSpan(this.chkFolder, 2);
            this.chkFolder.Location = new System.Drawing.Point(197, 45);
            this.chkFolder.Name = "chkFolder";
            this.chkFolder.Size = new System.Drawing.Size(145, 15);
            this.chkFolder.TabIndex = 5;
            this.chkFolder.Text = "パスのフォルダ部分も変換";
            this.chkFolder.UseVisualStyleBackColor = true;
            // 
            // chkRegex
            // 
            this.chkRegex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkRegex.AutoSize = true;
            this.tlpCase.SetColumnSpan(this.chkRegex, 2);
            this.chkRegex.Location = new System.Drawing.Point(3, 88);
            this.chkRegex.Name = "chkRegex";
            this.chkRegex.Size = new System.Drawing.Size(133, 16);
            this.chkRegex.TabIndex = 6;
            this.chkRegex.Text = "置換に正規表現を使う";
            this.chkRegex.UseVisualStyleBackColor = true;
            // 
            // chkPreview
            // 
            this.chkPreview.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkPreview.AutoSize = true;
            this.chkPreview.Location = new System.Drawing.Point(197, 88);
            this.chkPreview.Name = "chkPreview";
            this.chkPreview.Size = new System.Drawing.Size(96, 16);
            this.chkPreview.TabIndex = 7;
            this.chkPreview.Text = "プレビューモード";
            this.chkPreview.UseVisualStyleBackColor = true;
            this.chkPreview.CheckedChanged += new System.EventHandler(this.chkPreview_CheckedChanged);
            // 
            // btnApply
            // 
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApply.Location = new System.Drawing.Point(345, 87);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(40, 19);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "適用";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // cmbFolderDrop
            // 
            this.tlpCase.SetColumnSpan(this.cmbFolderDrop, 4);
            this.cmbFolderDrop.DisplayMember = "Name";
            this.cmbFolderDrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFolderDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFolderDrop.FormattingEnabled = true;
            this.cmbFolderDrop.Location = new System.Drawing.Point(3, 66);
            this.cmbFolderDrop.Name = "cmbFolderDrop";
            this.cmbFolderDrop.Size = new System.Drawing.Size(382, 20);
            this.cmbFolderDrop.TabIndex = 9;
            this.cmbFolderDrop.ValueMember = "Value";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(34, 250);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(296, 26);
            this.txtLog.TabIndex = 3;
            // 
            // tlpFile
            // 
            this.tlpFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpFile.ColumnCount = 4;
            this.tlpFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFile.Controls.Add(this.cmbFile, 0, 0);
            this.tlpFile.Controls.Add(this.btnDelete, 3, 0);
            this.tlpFile.Controls.Add(this.btnSave, 2, 0);
            this.tlpFile.Controls.Add(this.btnLoad, 1, 0);
            this.tlpFile.Location = new System.Drawing.Point(34, 282);
            this.tlpFile.Name = "tlpFile";
            this.tlpFile.RowCount = 1;
            this.tlpFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFile.Size = new System.Drawing.Size(395, 33);
            this.tlpFile.TabIndex = 4;
            // 
            // cmbFile
            // 
            this.cmbFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFile.FormattingEnabled = true;
            this.cmbFile.Location = new System.Drawing.Point(3, 6);
            this.cmbFile.Name = "cmbFile";
            this.cmbFile.Size = new System.Drawing.Size(233, 20);
            this.cmbFile.TabIndex = 0;
            this.cmbFile.SelectedIndexChanged += new System.EventHandler(this.CmbFile_SelectedIndexChanged);
            this.cmbFile.TextUpdate += new System.EventHandler(this.CmbFile_TextUpdate);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Location = new System.Drawing.Point(346, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(46, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(294, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(46, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.AutoSize = true;
            this.btnLoad.Location = new System.Drawing.Point(242, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(46, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "開く";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // cmsInsert
            // 
            this.cmsInsert.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInsertRandom,
            this.tsmiInsertNow,
            this.tsmiInsertCTimeToolStripMenuItem,
            this.tsmiInsertMTimeToolStripMenuItem,
            this.tsmiInsertATimeToolStripMenuItem});
            this.cmsInsert.Name = "cmsPatternSelect";
            this.cmsInsert.Size = new System.Drawing.Size(337, 136);
            // 
            // tsmiInsertRandom
            // 
            this.tsmiInsertRandom.Name = "tsmiInsertRandom";
            this.tsmiInsertRandom.Size = new System.Drawing.Size(336, 22);
            this.tsmiInsertRandom.Tag = "<random>";
            this.tsmiInsertRandom.Text = "<random>";
            this.tsmiInsertRandom.Click += new System.EventHandler(this.TsmiInsert_Click);
            // 
            // tsmiInsertNow
            // 
            this.tsmiInsertNow.Name = "tsmiInsertNow";
            this.tsmiInsertNow.Size = new System.Drawing.Size(336, 22);
            this.tsmiInsertNow.Tag = "<now:yyyyMMddHHmmss>";
            this.tsmiInsertNow.Text = "<now:yyyyMMddHHmmss> - 現在時刻";
            this.tsmiInsertNow.Click += new System.EventHandler(this.TsmiInsert_Click);
            // 
            // tsmiInsertCTimeToolStripMenuItem
            // 
            this.tsmiInsertCTimeToolStripMenuItem.Name = "tsmiInsertCTimeToolStripMenuItem";
            this.tsmiInsertCTimeToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            this.tsmiInsertCTimeToolStripMenuItem.Tag = "<ctime:yyyyMMddHHmmss>";
            this.tsmiInsertCTimeToolStripMenuItem.Text = "<ctime:yyyyMMddHHmmss> - ファイル作成日時";
            this.tsmiInsertCTimeToolStripMenuItem.Click += new System.EventHandler(this.TsmiInsert_Click);
            // 
            // tsmiInsertMTimeToolStripMenuItem
            // 
            this.tsmiInsertMTimeToolStripMenuItem.Name = "tsmiInsertMTimeToolStripMenuItem";
            this.tsmiInsertMTimeToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            this.tsmiInsertMTimeToolStripMenuItem.Tag = "<mtime:yyyyMMddHHmmss>";
            this.tsmiInsertMTimeToolStripMenuItem.Text = "<mtime:yyyyMMddHHmmss> - ファイル変更日時";
            this.tsmiInsertMTimeToolStripMenuItem.Click += new System.EventHandler(this.TsmiInsert_Click);
            // 
            // tsmiInsertATimeToolStripMenuItem
            // 
            this.tsmiInsertATimeToolStripMenuItem.Name = "tsmiInsertATimeToolStripMenuItem";
            this.tsmiInsertATimeToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            this.tsmiInsertATimeToolStripMenuItem.Tag = "<atime:yyyyMMddHHmmss>";
            this.tsmiInsertATimeToolStripMenuItem.Text = "<atime:yyyyMMddHHmmss> - ファイルアクセス日時";
            this.tsmiInsertATimeToolStripMenuItem.Click += new System.EventHandler(this.TsmiInsert_Click);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 327);
            this.Controls.Add(this.tlpFile);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.tlpCase);
            this.Controls.Add(this.tlpReplace);
            this.Controls.Add(this.tlpAddRemove);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            this.tlpAddRemove.ResumeLayout(false);
            this.tlpAddRemove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemoveLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemoveRight)).EndInit();
            this.tlpReplace.ResumeLayout(false);
            this.tlpReplace.PerformLayout();
            this.tlpCase.ResumeLayout(false);
            this.tlpCase.PerformLayout();
            this.tlpFile.ResumeLayout(false);
            this.tlpFile.PerformLayout();
            this.cmsInsert.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAddRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddLeft;
        private System.Windows.Forms.TextBox txtAddRight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudRemoveLeft;
        private System.Windows.Forms.NumericUpDown nudRemoveRight;
        private System.Windows.Forms.TableLayoutPanel tlpReplace;
        private System.Windows.Forms.TextBox txtBefore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAfter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tlpCase;
        private System.Windows.Forms.RadioButton radNoCase;
        private System.Windows.Forms.RadioButton radWordCase;
        private System.Windows.Forms.RadioButton radUpperCase;
        private System.Windows.Forms.RadioButton radLowerCase;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.CheckBox chkExtension;
        private System.Windows.Forms.CheckBox chkFolder;
        private System.Windows.Forms.CheckBox chkRegex;
        private System.Windows.Forms.CheckBox chkPreview;
        private System.Windows.Forms.TableLayoutPanel tlpFile;
        private System.Windows.Forms.ComboBox cmbFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddLeftPattern;
        private System.Windows.Forms.ContextMenuStrip cmsInsert;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertRandom;
        private System.Windows.Forms.Button btnAddRightPattern;
        private System.Windows.Forms.Button btnAfterPattern;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox cmbFolderDrop;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertNow;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertCTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertMTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertATimeToolStripMenuItem;
    }
}

