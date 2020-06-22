namespace SozaiManager
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbJanru = new System.Windows.Forms.ComboBox();
            this.cmbTeikyo = new System.Windows.Forms.ComboBox();
            this.lbljanru = new System.Windows.Forms.Label();
            this.lblTeikyo = new System.Windows.Forms.Label();
            this.txFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.メニューToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.データの抽出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.データ整理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.素材データの全消去ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.提供元の追加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txNikname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbJanru
            // 
            this.cmbJanru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJanru.FormattingEnabled = true;
            this.cmbJanru.Location = new System.Drawing.Point(14, 54);
            this.cmbJanru.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbJanru.Name = "cmbJanru";
            this.cmbJanru.Size = new System.Drawing.Size(226, 26);
            this.cmbJanru.TabIndex = 0;
            // 
            // cmbTeikyo
            // 
            this.cmbTeikyo.FormattingEnabled = true;
            this.cmbTeikyo.Location = new System.Drawing.Point(14, 109);
            this.cmbTeikyo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbTeikyo.Name = "cmbTeikyo";
            this.cmbTeikyo.Size = new System.Drawing.Size(226, 26);
            this.cmbTeikyo.TabIndex = 1;
            // 
            // lbljanru
            // 
            this.lbljanru.AutoSize = true;
            this.lbljanru.Location = new System.Drawing.Point(12, 32);
            this.lbljanru.Name = "lbljanru";
            this.lbljanru.Size = new System.Drawing.Size(128, 18);
            this.lbljanru.TabIndex = 2;
            this.lbljanru.Text = "*素材ジャンル：";
            // 
            // lblTeikyo
            // 
            this.lblTeikyo.AutoSize = true;
            this.lblTeikyo.Location = new System.Drawing.Point(12, 87);
            this.lblTeikyo.Name = "lblTeikyo";
            this.lblTeikyo.Size = new System.Drawing.Size(112, 18);
            this.lblTeikyo.TabIndex = 3;
            this.lblTeikyo.Text = "*素材提供元：";
            // 
            // txFileName
            // 
            this.txFileName.Location = new System.Drawing.Point(270, 54);
            this.txFileName.Name = "txFileName";
            this.txFileName.Size = new System.Drawing.Size(313, 26);
            this.txFileName.TabIndex = 4;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(267, 33);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(112, 18);
            this.lblFileName.TabIndex = 5;
            this.lblFileName.Text = "*素材正式名：";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAdd.Location = new System.Drawing.Point(431, 118);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 40);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "追加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(270, 118);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(152, 40);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.メニューToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(595, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // メニューToolStripMenuItem
            // 
            this.メニューToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.データの抽出ToolStripMenuItem,
            this.データ整理ToolStripMenuItem,
            this.素材データの全消去ToolStripMenuItem,
            this.提供元の追加ToolStripMenuItem});
            this.メニューToolStripMenuItem.Name = "メニューToolStripMenuItem";
            this.メニューToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.メニューToolStripMenuItem.Text = "メニュー";
            // 
            // データの抽出ToolStripMenuItem
            // 
            this.データの抽出ToolStripMenuItem.Name = "データの抽出ToolStripMenuItem";
            this.データの抽出ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.データの抽出ToolStripMenuItem.Text = "データの抽出";
            this.データの抽出ToolStripMenuItem.Click += new System.EventHandler(this.データの抽出ToolStripMenuItem_Click);
            // 
            // データ整理ToolStripMenuItem
            // 
            this.データ整理ToolStripMenuItem.Name = "データ整理ToolStripMenuItem";
            this.データ整理ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.データ整理ToolStripMenuItem.Text = "素材データ編集";
            this.データ整理ToolStripMenuItem.Click += new System.EventHandler(this.データ整理ToolStripMenuItem_Click);
            // 
            // 素材データの全消去ToolStripMenuItem
            // 
            this.素材データの全消去ToolStripMenuItem.Name = "素材データの全消去ToolStripMenuItem";
            this.素材データの全消去ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.素材データの全消去ToolStripMenuItem.Text = "素材データの全消去";
            this.素材データの全消去ToolStripMenuItem.Click += new System.EventHandler(this.素材データの全消去ToolStripMenuItem_Click);
            // 
            // 提供元の追加ToolStripMenuItem
            // 
            this.提供元の追加ToolStripMenuItem.Name = "提供元の追加ToolStripMenuItem";
            this.提供元の追加ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.提供元の追加ToolStripMenuItem.Text = "提供元編集";
            this.提供元の追加ToolStripMenuItem.Click += new System.EventHandler(this.提供元の追加ToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(270, 87);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 22);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "表示の義務あり";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "ニックネーム：";
            // 
            // txNikname
            // 
            this.txNikname.Location = new System.Drawing.Point(14, 161);
            this.txNikname.Name = "txNikname";
            this.txNikname.Size = new System.Drawing.Size(226, 26);
            this.txNikname.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "＊：必須項目";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(246, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "前回：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 195);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txNikname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txFileName);
            this.Controls.Add(this.lblTeikyo);
            this.Controls.Add(this.lbljanru);
            this.Controls.Add(this.cmbTeikyo);
            this.Controls.Add(this.cmbJanru);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "素材情報の追加";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbJanru;
        private System.Windows.Forms.ComboBox cmbTeikyo;
        private System.Windows.Forms.Label lbljanru;
        private System.Windows.Forms.Label lblTeikyo;
        private System.Windows.Forms.TextBox txFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem メニューToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem データの抽出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 提供元の追加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem データ整理ToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNikname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem 素材データの全消去ToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}

