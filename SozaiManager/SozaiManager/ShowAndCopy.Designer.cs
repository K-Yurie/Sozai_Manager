namespace SozaiManager
{
    partial class ShowAndCopy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAndCopy));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nikname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txDisplay = new System.Windows.Forms.TextBox();
            this.rdoNewrowHoot = new System.Windows.Forms.RadioButton();
            this.rdoSrashHoot = new System.Windows.Forms.RadioButton();
            this.rdoBrankHoot = new System.Windows.Forms.RadioButton();
            this.gbWriteHoot = new System.Windows.Forms.GroupBox();
            this.rdoHootLess = new System.Windows.Forms.RadioButton();
            this.tbOriginalHoot = new System.Windows.Forms.TextBox();
            this.rdoOriginalHoot = new System.Windows.Forms.RadioButton();
            this.btnExportText = new System.Windows.Forms.Button();
            this.gbWriteHead = new System.Windows.Forms.GroupBox();
            this.rdoHeadLess = new System.Windows.Forms.RadioButton();
            this.tbOriginalHead = new System.Windows.Forms.TextBox();
            this.rdoOriginalHead = new System.Windows.Forms.RadioButton();
            this.rdoBrankHead = new System.Windows.Forms.RadioButton();
            this.rdoDotHead = new System.Windows.Forms.RadioButton();
            this.rdoAstaHead = new System.Windows.Forms.RadioButton();
            this.chkAllDisp = new System.Windows.Forms.CheckBox();
            this.chkPictureDisp = new System.Windows.Forms.CheckBox();
            this.chkBgmDisp = new System.Windows.Forms.CheckBox();
            this.chkSeDisp = new System.Windows.Forms.CheckBox();
            this.chkScriptDisp = new System.Windows.Forms.CheckBox();
            this.chkMovieDisp = new System.Windows.Forms.CheckBox();
            this.chkApplicationDisp = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbSoat = new System.Windows.Forms.GroupBox();
            this.chkNeedOnlyDisp = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSoat = new System.Windows.Forms.Button();
            this.btnExportSupply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.gbWriteHoot.SuspendLayout();
            this.gbWriteHead.SuspendLayout();
            this.gbSoat.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type,
            this.supply,
            this.name,
            this.disp,
            this.nikname});
            this.dataGrid.Location = new System.Drawing.Point(17, 23);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowTemplate.Height = 21;
            this.dataGrid.Size = new System.Drawing.Size(687, 267);
            this.dataGrid.TabIndex = 0;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "タイプ";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // supply
            // 
            this.supply.DataPropertyName = "supply";
            this.supply.HeaderText = "提供元";
            this.supply.Name = "supply";
            this.supply.ReadOnly = true;
            this.supply.Width = 150;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "素材正式名";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 180;
            // 
            // disp
            // 
            this.disp.DataPropertyName = "needDisp";
            this.disp.HeaderText = "表示";
            this.disp.Name = "disp";
            this.disp.ReadOnly = true;
            this.disp.Width = 80;
            // 
            // nikname
            // 
            this.nikname.DataPropertyName = "nikName";
            this.nikname.HeaderText = "ニックネーム";
            this.nikname.Name = "nikname";
            this.nikname.ReadOnly = true;
            this.nikname.Width = 180;
            // 
            // txDisplay
            // 
            this.txDisplay.Location = new System.Drawing.Point(17, 298);
            this.txDisplay.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.txDisplay.Multiline = true;
            this.txDisplay.Name = "txDisplay";
            this.txDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txDisplay.Size = new System.Drawing.Size(687, 146);
            this.txDisplay.TabIndex = 1;
            // 
            // rdoNewrowHoot
            // 
            this.rdoNewrowHoot.AutoSize = true;
            this.rdoNewrowHoot.Checked = true;
            this.rdoNewrowHoot.Location = new System.Drawing.Point(11, 23);
            this.rdoNewrowHoot.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.rdoNewrowHoot.Name = "rdoNewrowHoot";
            this.rdoNewrowHoot.Size = new System.Drawing.Size(56, 21);
            this.rdoNewrowHoot.TabIndex = 2;
            this.rdoNewrowHoot.TabStop = true;
            this.rdoNewrowHoot.Text = "改行";
            this.rdoNewrowHoot.UseVisualStyleBackColor = true;
            // 
            // rdoSrashHoot
            // 
            this.rdoSrashHoot.AutoSize = true;
            this.rdoSrashHoot.Location = new System.Drawing.Point(78, 24);
            this.rdoSrashHoot.Name = "rdoSrashHoot";
            this.rdoSrashHoot.Size = new System.Drawing.Size(125, 21);
            this.rdoSrashHoot.TabIndex = 3;
            this.rdoSrashHoot.Text = "/(スラッシュ)";
            this.rdoSrashHoot.UseVisualStyleBackColor = true;
            // 
            // rdoBrankHoot
            // 
            this.rdoBrankHoot.AutoSize = true;
            this.rdoBrankHoot.Location = new System.Drawing.Point(209, 24);
            this.rdoBrankHoot.Name = "rdoBrankHoot";
            this.rdoBrankHoot.Size = new System.Drawing.Size(56, 21);
            this.rdoBrankHoot.TabIndex = 4;
            this.rdoBrankHoot.Text = "空白";
            this.rdoBrankHoot.UseVisualStyleBackColor = true;
            // 
            // gbWriteHoot
            // 
            this.gbWriteHoot.Controls.Add(this.rdoHootLess);
            this.gbWriteHoot.Controls.Add(this.tbOriginalHoot);
            this.gbWriteHoot.Controls.Add(this.rdoOriginalHoot);
            this.gbWriteHoot.Controls.Add(this.rdoBrankHoot);
            this.gbWriteHoot.Controls.Add(this.rdoNewrowHoot);
            this.gbWriteHoot.Controls.Add(this.rdoSrashHoot);
            this.gbWriteHoot.Location = new System.Drawing.Point(15, 621);
            this.gbWriteHoot.Name = "gbWriteHoot";
            this.gbWriteHoot.Size = new System.Drawing.Size(558, 58);
            this.gbWriteHoot.TabIndex = 5;
            this.gbWriteHoot.TabStop = false;
            this.gbWriteHoot.Text = "接尾辞";
            // 
            // rdoHootLess
            // 
            this.rdoHootLess.AutoSize = true;
            this.rdoHootLess.Location = new System.Drawing.Point(496, 25);
            this.rdoHootLess.Name = "rdoHootLess";
            this.rdoHootLess.Size = new System.Drawing.Size(56, 21);
            this.rdoHootLess.TabIndex = 7;
            this.rdoHootLess.Text = "なし";
            this.rdoHootLess.UseVisualStyleBackColor = true;
            // 
            // tbOriginalHoot
            // 
            this.tbOriginalHoot.Enabled = false;
            this.tbOriginalHoot.Location = new System.Drawing.Point(331, 24);
            this.tbOriginalHoot.Name = "tbOriginalHoot";
            this.tbOriginalHoot.Size = new System.Drawing.Size(147, 25);
            this.tbOriginalHoot.TabIndex = 6;
            // 
            // rdoOriginalHoot
            // 
            this.rdoOriginalHoot.AutoSize = true;
            this.rdoOriginalHoot.Location = new System.Drawing.Point(269, 24);
            this.rdoOriginalHoot.Name = "rdoOriginalHoot";
            this.rdoOriginalHoot.Size = new System.Drawing.Size(56, 21);
            this.rdoOriginalHoot.TabIndex = 5;
            this.rdoOriginalHoot.Text = "指定";
            this.rdoOriginalHoot.UseVisualStyleBackColor = true;
            // 
            // btnExportText
            // 
            this.btnExportText.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExportText.Location = new System.Drawing.Point(652, 555);
            this.btnExportText.Name = "btnExportText";
            this.btnExportText.Size = new System.Drawing.Size(67, 124);
            this.btnExportText.TabIndex = 6;
            this.btnExportText.Text = "データ\r\n抽出";
            this.btnExportText.UseVisualStyleBackColor = true;
            // 
            // gbWriteHead
            // 
            this.gbWriteHead.Controls.Add(this.rdoHeadLess);
            this.gbWriteHead.Controls.Add(this.tbOriginalHead);
            this.gbWriteHead.Controls.Add(this.rdoOriginalHead);
            this.gbWriteHead.Controls.Add(this.rdoBrankHead);
            this.gbWriteHead.Controls.Add(this.rdoDotHead);
            this.gbWriteHead.Controls.Add(this.rdoAstaHead);
            this.gbWriteHead.Location = new System.Drawing.Point(17, 555);
            this.gbWriteHead.Name = "gbWriteHead";
            this.gbWriteHead.Size = new System.Drawing.Size(556, 58);
            this.gbWriteHead.TabIndex = 7;
            this.gbWriteHead.TabStop = false;
            this.gbWriteHead.Text = "接頭辞";
            // 
            // rdoHeadLess
            // 
            this.rdoHeadLess.AutoSize = true;
            this.rdoHeadLess.Location = new System.Drawing.Point(494, 21);
            this.rdoHeadLess.Name = "rdoHeadLess";
            this.rdoHeadLess.Size = new System.Drawing.Size(56, 21);
            this.rdoHeadLess.TabIndex = 7;
            this.rdoHeadLess.Text = "なし";
            this.rdoHeadLess.UseVisualStyleBackColor = true;
            // 
            // tbOriginalHead
            // 
            this.tbOriginalHead.Enabled = false;
            this.tbOriginalHead.Location = new System.Drawing.Point(329, 17);
            this.tbOriginalHead.Name = "tbOriginalHead";
            this.tbOriginalHead.Size = new System.Drawing.Size(147, 25);
            this.tbOriginalHead.TabIndex = 6;
            // 
            // rdoOriginalHead
            // 
            this.rdoOriginalHead.AutoSize = true;
            this.rdoOriginalHead.Location = new System.Drawing.Point(269, 23);
            this.rdoOriginalHead.Name = "rdoOriginalHead";
            this.rdoOriginalHead.Size = new System.Drawing.Size(56, 21);
            this.rdoOriginalHead.TabIndex = 5;
            this.rdoOriginalHead.Text = "指定";
            this.rdoOriginalHead.UseVisualStyleBackColor = true;
            // 
            // rdoBrankHead
            // 
            this.rdoBrankHead.AutoSize = true;
            this.rdoBrankHead.Location = new System.Drawing.Point(207, 23);
            this.rdoBrankHead.Name = "rdoBrankHead";
            this.rdoBrankHead.Size = new System.Drawing.Size(56, 21);
            this.rdoBrankHead.TabIndex = 4;
            this.rdoBrankHead.Text = "空白";
            this.rdoBrankHead.UseVisualStyleBackColor = true;
            // 
            // rdoDotHead
            // 
            this.rdoDotHead.AutoSize = true;
            this.rdoDotHead.Checked = true;
            this.rdoDotHead.Location = new System.Drawing.Point(9, 23);
            this.rdoDotHead.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.rdoDotHead.Name = "rdoDotHead";
            this.rdoDotHead.Size = new System.Drawing.Size(86, 21);
            this.rdoDotHead.TabIndex = 2;
            this.rdoDotHead.TabStop = true;
            this.rdoDotHead.Text = "・（点）";
            this.rdoDotHead.UseVisualStyleBackColor = true;
            // 
            // rdoAstaHead
            // 
            this.rdoAstaHead.AutoSize = true;
            this.rdoAstaHead.Location = new System.Drawing.Point(96, 23);
            this.rdoAstaHead.Name = "rdoAstaHead";
            this.rdoAstaHead.Size = new System.Drawing.Size(105, 21);
            this.rdoAstaHead.TabIndex = 3;
            this.rdoAstaHead.Text = "＊(ｱｽﾀﾘｽｸ)";
            this.rdoAstaHead.UseVisualStyleBackColor = true;
            // 
            // chkAllDisp
            // 
            this.chkAllDisp.AutoSize = true;
            this.chkAllDisp.Location = new System.Drawing.Point(21, 19);
            this.chkAllDisp.Name = "chkAllDisp";
            this.chkAllDisp.Size = new System.Drawing.Size(72, 21);
            this.chkAllDisp.TabIndex = 8;
            this.chkAllDisp.Text = "すべて";
            this.chkAllDisp.UseVisualStyleBackColor = true;
            // 
            // chkPictureDisp
            // 
            this.chkPictureDisp.AutoSize = true;
            this.chkPictureDisp.Location = new System.Drawing.Point(124, 19);
            this.chkPictureDisp.Name = "chkPictureDisp";
            this.chkPictureDisp.Size = new System.Drawing.Size(57, 21);
            this.chkPictureDisp.TabIndex = 9;
            this.chkPictureDisp.Text = "画像";
            this.chkPictureDisp.UseVisualStyleBackColor = true;
            // 
            // chkBgmDisp
            // 
            this.chkBgmDisp.AutoSize = true;
            this.chkBgmDisp.Location = new System.Drawing.Point(201, 19);
            this.chkBgmDisp.Name = "chkBgmDisp";
            this.chkBgmDisp.Size = new System.Drawing.Size(51, 21);
            this.chkBgmDisp.TabIndex = 10;
            this.chkBgmDisp.Text = "BGM";
            this.chkBgmDisp.UseVisualStyleBackColor = true;
            // 
            // chkSeDisp
            // 
            this.chkSeDisp.AutoSize = true;
            this.chkSeDisp.Location = new System.Drawing.Point(272, 19);
            this.chkSeDisp.Name = "chkSeDisp";
            this.chkSeDisp.Size = new System.Drawing.Size(43, 21);
            this.chkSeDisp.TabIndex = 11;
            this.chkSeDisp.Text = "SE";
            this.chkSeDisp.UseVisualStyleBackColor = true;
            // 
            // chkScriptDisp
            // 
            this.chkScriptDisp.AutoSize = true;
            this.chkScriptDisp.Location = new System.Drawing.Point(413, 19);
            this.chkScriptDisp.Name = "chkScriptDisp";
            this.chkScriptDisp.Size = new System.Drawing.Size(102, 21);
            this.chkScriptDisp.TabIndex = 12;
            this.chkScriptDisp.Text = "スクリプト";
            this.chkScriptDisp.UseVisualStyleBackColor = true;
            // 
            // chkMovieDisp
            // 
            this.chkMovieDisp.AutoSize = true;
            this.chkMovieDisp.Location = new System.Drawing.Point(333, 19);
            this.chkMovieDisp.Name = "chkMovieDisp";
            this.chkMovieDisp.Size = new System.Drawing.Size(57, 21);
            this.chkMovieDisp.TabIndex = 13;
            this.chkMovieDisp.Text = "動画";
            this.chkMovieDisp.UseVisualStyleBackColor = true;
            // 
            // chkApplicationDisp
            // 
            this.chkApplicationDisp.AutoSize = true;
            this.chkApplicationDisp.Location = new System.Drawing.Point(521, 19);
            this.chkApplicationDisp.Name = "chkApplicationDisp";
            this.chkApplicationDisp.Size = new System.Drawing.Size(147, 21);
            this.chkApplicationDisp.TabIndex = 14;
            this.chkApplicationDisp.Text = "アプリケーション";
            this.chkApplicationDisp.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(579, 622);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 57);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "画面クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // gbSoat
            // 
            this.gbSoat.Controls.Add(this.chkAllDisp);
            this.gbSoat.Controls.Add(this.chkPictureDisp);
            this.gbSoat.Controls.Add(this.chkApplicationDisp);
            this.gbSoat.Controls.Add(this.chkBgmDisp);
            this.gbSoat.Controls.Add(this.chkMovieDisp);
            this.gbSoat.Controls.Add(this.chkSeDisp);
            this.gbSoat.Controls.Add(this.chkScriptDisp);
            this.gbSoat.Location = new System.Drawing.Point(12, 451);
            this.gbSoat.Name = "gbSoat";
            this.gbSoat.Size = new System.Drawing.Size(707, 46);
            this.gbSoat.TabIndex = 16;
            this.gbSoat.TabStop = false;
            this.gbSoat.Text = "素材タイプ";
            // 
            // chkNeedOnlyDisp
            // 
            this.chkNeedOnlyDisp.AutoSize = true;
            this.chkNeedOnlyDisp.Location = new System.Drawing.Point(529, 513);
            this.chkNeedOnlyDisp.Name = "chkNeedOnlyDisp";
            this.chkNeedOnlyDisp.Size = new System.Drawing.Size(87, 21);
            this.chkNeedOnlyDisp.TabIndex = 17;
            this.chkNeedOnlyDisp.Text = "必須のみ";
            this.chkNeedOnlyDisp.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(13, 546);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 3);
            this.panel1.TabIndex = 18;
            // 
            // btnSoat
            // 
            this.btnSoat.Location = new System.Drawing.Point(622, 504);
            this.btnSoat.Name = "btnSoat";
            this.btnSoat.Size = new System.Drawing.Size(97, 36);
            this.btnSoat.TabIndex = 19;
            this.btnSoat.Text = "絞り込み";
            this.btnSoat.UseVisualStyleBackColor = true;
            // 
            // btnExportSupply
            // 
            this.btnExportSupply.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExportSupply.Location = new System.Drawing.Point(579, 555);
            this.btnExportSupply.Name = "btnExportSupply";
            this.btnExportSupply.Size = new System.Drawing.Size(67, 58);
            this.btnExportSupply.TabIndex = 20;
            this.btnExportSupply.Text = "提供元\r\n抽出";
            this.btnExportSupply.UseVisualStyleBackColor = true;
            // 
            // ShowAndCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 685);
            this.Controls.Add(this.btnExportSupply);
            this.Controls.Add(this.btnSoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkNeedOnlyDisp);
            this.Controls.Add(this.gbSoat);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbWriteHead);
            this.Controls.Add(this.btnExportText);
            this.Controls.Add(this.gbWriteHoot);
            this.Controls.Add(this.txDisplay);
            this.Controls.Add(this.dataGrid);
            this.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.Name = "ShowAndCopy";
            this.Text = "データ抽出";
            this.Load += new System.EventHandler(this.ShowAndCopy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.gbWriteHoot.ResumeLayout(false);
            this.gbWriteHoot.PerformLayout();
            this.gbWriteHead.ResumeLayout(false);
            this.gbWriteHead.PerformLayout();
            this.gbSoat.ResumeLayout(false);
            this.gbSoat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox txDisplay;
        private System.Windows.Forms.RadioButton rdoNewrowHoot;
        private System.Windows.Forms.RadioButton rdoSrashHoot;
        private System.Windows.Forms.RadioButton rdoBrankHoot;
        private System.Windows.Forms.GroupBox gbWriteHoot;
        private System.Windows.Forms.RadioButton rdoHootLess;
        private System.Windows.Forms.TextBox tbOriginalHoot;
        private System.Windows.Forms.RadioButton rdoOriginalHoot;
        private System.Windows.Forms.Button btnExportText;
        private System.Windows.Forms.GroupBox gbWriteHead;
        private System.Windows.Forms.RadioButton rdoHeadLess;
        private System.Windows.Forms.TextBox tbOriginalHead;
        private System.Windows.Forms.RadioButton rdoOriginalHead;
        private System.Windows.Forms.RadioButton rdoBrankHead;
        private System.Windows.Forms.RadioButton rdoDotHead;
        private System.Windows.Forms.RadioButton rdoAstaHead;
        private System.Windows.Forms.CheckBox chkAllDisp;
        private System.Windows.Forms.CheckBox chkPictureDisp;
        private System.Windows.Forms.CheckBox chkBgmDisp;
        private System.Windows.Forms.CheckBox chkSeDisp;
        private System.Windows.Forms.CheckBox chkScriptDisp;
        private System.Windows.Forms.CheckBox chkMovieDisp;
        private System.Windows.Forms.CheckBox chkApplicationDisp;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbSoat;
        private System.Windows.Forms.CheckBox chkNeedOnlyDisp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSoat;
        private System.Windows.Forms.Button btnExportSupply;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn supply;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn disp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nikname;
    }
}