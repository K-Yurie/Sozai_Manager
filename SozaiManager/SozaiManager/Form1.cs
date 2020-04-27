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



namespace SozaiManager
{
    public partial class Form1 : Form
    {
        XDocument _supplyDocu = XDocument.Load("source.xml");
        XDocument _dataDocu = XDocument.Load("sozaidata.xml");

        //XmlDocument _supplyXml = new XmlDocument();
        //XmlDocument _dataXml = new XmlDocument();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //_supplyXml.Load(@"source.xml");
            //var supplyes = _supplyXml.SelectNodes("source/supply");
            //foreach (XmlNode onesupply in supplyes)
            //{
            //    cmbTeikyo.Items.Add(onesupply.InnerText);
            //}

            //XElement source = XElement.Load(@"source.xml");

            //IEnumerable<XElement> supplyes = from items in source.Elements("source").Elements("supply")
            //                               select items;

            //foreach(String supply in supplyes) 
            //{
            //    cmbTeikyo.Items.Add(supply.ToString());
            //}

            XElement source = _supplyDocu.Element("source");
            IEnumerable<XElement> supplyes = source.Elements("supply");

            foreach(XElement supply in supplyes) 
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


        private void set_Lamda() 
        {
            btnClear.Click += (_sender, _e) =>
            {
                cmbJanru.Text = "";
                cmbTeikyo.Text = "";
                txFileName.Text = "";
                checkBox1.Checked = false;
                txNikname.Text = "";
            };

            btnAdd.Click += (_sender, _e) =>
            {
                if (cmbJanru.Text != "" && cmbTeikyo.Text != "" && txFileName.Text != "")
                {
                    int flgOfNotMust = 0;
                    if (checkBox1.Checked) { flgOfNotMust = 1; }
                    if (txNikname.Text != "") { flgOfNotMust = 2; }
                    if (checkBox1.Checked && txNikname.Text != "") { flgOfNotMust = 3; }
                    WriteDataXml(cmbJanru.Text, flgOfNotMust);

                    txFileName.Text = "";
                    txNikname.Text = "";
                }
                else 
                {
                    MessageBox.Show("必須項目を入力をしてください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };



        }


        private void WriteDataXml(string JanruText,int flg) 
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
                            new XElement("supply",cmbTeikyo.Text),
                            new XElement("name",txFileName.Text),
                            new XElement("needDisplay", "false"),
                            new XElement("nikname", "-"));

                        inputTo0.Add(inputDatas0);
                        _dataDocu.Save("sozaidata.xml");

                        break;

                    case 1:
                        XElement inputTo1= sozaidatas.Element(nodetype);
                        XElement inputDatas1 = new XElement("data",
                            new XElement("supply", cmbTeikyo.Text),
                            new XElement("name", txFileName.Text),
                            new XElement("needDisplay","true"),
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
            

        }

        #region ToolStripMenu
        private void データ整理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataedit jump = new dataedit();
            jump.ShowDialog();
        }

        #endregion

        private void データの抽出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAndCopy jump = new ShowAndCopy();
            jump.ShowDialog();
        }

        private void 提供元の追加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editsupply jump = new editsupply();
            jump.ShowDialog();
        }
    }
}
