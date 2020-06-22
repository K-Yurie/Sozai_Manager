using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Media;



namespace SozaiManager
{
    public partial class Form1 : Form
    {
        XDocument _supplyDocu = XDocument.Load("source.xml");
        XDocument _dataDocu = XDocument.Load("sozaidata.xml");
        private System.Media.SoundPlayer player = null;
        string tinSound = "Sound.wav";
        string latestData = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                XElement source = _supplyDocu.Element("source");
                IEnumerable<XElement> supplyes = source.Elements("supply");
                foreach (XElement supply in supplyes)
                {
                    cmbTeikyo.Items.Add(supply.Value);
                }
                cmbJanru.Items.Add("");
                cmbJanru.Items.Add("画像");
                cmbJanru.Items.Add("BGM");
                cmbJanru.Items.Add("SE");
                cmbJanru.Items.Add("動画");
                cmbJanru.Items.Add("スクリプト");
                cmbJanru.Items.Add("アプリケーション");
                set_Lamda();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("申し訳ございません。エラーが発生しました");
            }
        }


        private void set_Lamda()
        {
            btnClear.Click += (_sender, _e) =>
            {
                try
                {
                    cmbJanru.Text = "";
                    cmbTeikyo.Text = "";
                    txFileName.Text = "";
                    checkBox1.Checked = false;
                    txNikname.Text = "";
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("申し訳ございません。エラーが発生しました");
                }
            };

            btnAdd.Click += (_sender, _e) =>
            {
                try
                {
                    if (cmbJanru.Text != "" && cmbTeikyo.Text != "" && txFileName.Text != "")
                    {
                        int flgOfNotMust = 0;
                        if (checkBox1.Checked) { flgOfNotMust = 1; }
                        if (txNikname.Text != "") { flgOfNotMust = 2; }
                        if (checkBox1.Checked && txNikname.Text != "") { flgOfNotMust = 3; }
                        WriteDataXml(cmbJanru.Text, flgOfNotMust);

                        label3.Text = "前回：" + latestData;
                        txFileName.Text = "";
                        txNikname.Text = "";
                        PlaySound();
                    }
                    else
                    {
                        MessageBox.Show("必須項目を入力をしてください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    txFileName.Focus();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("申し訳ございません。エラーが発生しました");
                }
            };

            KeyDown += (_sender, _e) => 
            {
                try
                {
                    switch (_e.KeyData)
                    {
                        case Keys.F1:
                            cmbJanru.Text = "画像";
                            break;

                        case Keys.F2:
                            cmbJanru.Text = "BGM";
                            break;

                        case Keys.F3:
                            cmbJanru.Text = "SE";
                            break;

                        case Keys.F5:
                            cmbJanru.Text = "動画";
                            break;

                        case Keys.F6:
                            cmbJanru.Text = "スクリプト";
                            break;

                        case Keys.F7:
                            cmbJanru.Text = "アプリケーション";
                            break;
                        default: return;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("申し訳ございません。エラーが発生しました");
                }
            };

            txFileName.KeyDown += (_sender, _e) => 
            {
                try
                {
                    if (_e.KeyCode == Keys.Enter)
                    {
                        btnAdd.Focus();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("申し訳ございません。エラーが発生しました");
                }
            };
        }


        private void WriteDataXml(string JanruText, int flg)
        {
            try
            {
                string nodetype = "";
                switch (JanruText)
                {
                    case "画像":
                        nodetype = "picture";
                        break;

                    case "BGM":
                        nodetype = "BGM";
                        break;

                    case "SE":
                        nodetype = "SE";
                        break;

                    case "動画":
                        nodetype = "Movie";
                        break;

                    case "スクリプト":
                        nodetype = "Script";
                        break;

                    case "アプリケーション":
                        nodetype = "Application";
                        break;
                }

                XElement sozaidatas = _dataDocu.Element("sozaidatas");
                switch (flg)
                {
                    case 0:

                        XElement inputTo0 = sozaidatas.Element(nodetype);
                        XElement inputDatas0 = new XElement("data",
                            new XElement("supply", cmbTeikyo.Text),
                            new XElement("name", txFileName.Text),
                            new XElement("needDisplay", "false"),
                            new XElement("nikname", "-"));
                        inputTo0.Add(inputDatas0);
                        _dataDocu.Save("sozaidata.xml");
                        break;

                    case 1:
                        XElement inputTo1 = sozaidatas.Element(nodetype);
                        XElement inputDatas1 = new XElement("data",
                            new XElement("supply", cmbTeikyo.Text),
                            new XElement("name", txFileName.Text),
                            new XElement("needDisplay", "true"),
                            new XElement("nikname", "-"));
                        inputTo1.Add(inputDatas1);
                        _dataDocu.Save("sozaidata.xml");
                        break;

                    case 2:
                        XElement inputTo2 = sozaidatas.Element(nodetype);
                        XElement inputDatas2 = new XElement("data",
                            new XElement("supply", cmbTeikyo.Text),
                            new XElement("name", txFileName.Text),
                            new XElement("needDisplay", "false"),
                            new XElement("nikname", txNikname.Text));
                        inputTo2.Add(inputDatas2);
                        _dataDocu.Save("sozaidata.xml");
                        break;

                    case 3:
                        XElement inputTo3 = sozaidatas.Element(nodetype);
                        XElement inputDatas3 = new XElement("data",
                            new XElement("supply", cmbTeikyo.Text),
                            new XElement("name", txFileName.Text),
                            new XElement("needDisplay", "true"),
                            new XElement("nikname", txNikname.Text));
                        inputTo3.Add(inputDatas3);
                        _dataDocu.Save("sozaidata.xml");
                        break;
                }
                latestData = txFileName.Text;
            }
            catch(Exception ex) 
            {
                MessageBox.Show("申し訳ございません。エラーが発生しました"); 
            }
        }

        private void PlaySound() 
        {
            try
            {
                player = new System.Media.SoundPlayer(tinSound);
                player.Play();
            }
            catch(Exception ex)
            {
                MessageBox.Show("申し訳ございません。エラーが発生しました");
            }
        }

        #region ToolStripMenu
        private void データ整理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataedit jump = new dataedit();
                jump.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("申し訳ございません。エラーが発生しました");
            }
        }


        private void データの抽出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ShowAndCopy jump = new ShowAndCopy();
                jump.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("申し訳ございません。エラーが発生しました");
            }
        }
        private void 提供元の追加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                editsupply jump = new editsupply();
                jump.ShowDialog();
                cmbTeikyo.Items.Clear();
                _supplyDocu = XDocument.Load("source.xml");
                XElement source = _supplyDocu.Element("source");
                IEnumerable<XElement> supplyes = source.Elements("supply");
                foreach (XElement supply in supplyes)
                {
                    cmbTeikyo.Items.Add(supply.Value);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("申し訳ございません。エラーが発生しました");
            }

        }

        private void 素材データの全消去ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult goreject = MessageBox.Show("素材データを完全削除します。よろしいですか？", "データの完全削除", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (goreject == DialogResult.OK)
                {
                    XElement fomatedXml = new XElement("sozaidatas",
                        new XElement("picture"),
                        new XElement("BGM"),
                        new XElement("SE"),
                        new XElement("Movie"),
                        new XElement("Script"),
                        new XElement("Application"));
                    XDocument fomatedDocu = new XDocument();
                    fomatedDocu.Add(fomatedXml);
                    fomatedDocu.Save("sozaidata.xml");
                    _dataDocu = XDocument.Load("sozaidata.xml");

                }
                label3.Text = "前回：";
            }
            catch(Exception ex)
            { 
                MessageBox.Show("申し訳ございません。エラーが発生しました"); 
            }
        }
        #endregion
    }
}
