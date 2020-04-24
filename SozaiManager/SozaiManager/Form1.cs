using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Linq;
using System.Xml.Linq;


namespace SozaiManager
{
    public partial class Form1 : Form
    {
        XmlDocument _supplyXml = new XmlDocument();
        XmlDocument _dataXml = new XmlDocument();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _supplyXml.Load(@"source.xml");
            var supplyes = _supplyXml.SelectNodes("source/supply");
            foreach (XmlNode onesupply in supplyes)
            {
                cmbTeikyo.Items.Add(onesupply.InnerText);
            }

            //XElement source = XElement.Load(@"source.xml");

            //IEnumerable<XElement> supplyes = from items in source.Elements("source").Elements("supply")
            //                               select items;

            //foreach(String supply in supplyes) 
            //{
            //    cmbTeikyo.Items.Add(supply.ToString());
            //}

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

            XElement datasXml = XElement.Load(@"sozaidata.xml");
            if (JanruText == "画像")
            {
                switch (flg)
                {

                    //シリアライズが必要
                    case 0:
                        XElement datas0 = new XElement(nodetype,
                        new XElement("supply", cmbTeikyo.Text),
                        new XElement("name", txFileName.Text));
                        datasXml.Add(datas0);
                        datasXml.Save(@"sozaidata.xml");
                        break;

                    case 1:
                        XElement datas1 = new XElement(nodetype,
                        new XElement("supply", cmbTeikyo.Text),
                        new XElement("name", txFileName.Text),
                        new XElement("must","表示必須"));
                        datasXml.Add(datas1);
                        datasXml.Save(@"sozaidata.xml");
                        break;

                    case 2:
                        XElement datas2 = new XElement(nodetype,
                        new XElement("supply", cmbTeikyo.Text),
                        new XElement("name", txFileName.Text),
                        new XElement("Nikname", txNikname.Text));
                        datasXml.Add(datas2);
                        datasXml.Save(@"sozaidata.xml");
                        break;

                    case 3:
                        XElement datas3 = new XElement(nodetype,
                        new XElement("supply", cmbTeikyo.Text),
                        new XElement("name", txFileName.Text),
                        new XElement("must", "表示必須"),
                        new XElement("Nikname", txNikname.Text));
                        datasXml.Add(datas3);
                        datasXml.Save(@"sozaidata.xml");
                        break;
                }
            }

        }


    }
}
