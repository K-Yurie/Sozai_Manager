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
    public partial class ShowAndCopy : Form
    {
        DataTable _dispDT = new DataTable();
        XDocument _dataDocu = XDocument.Load("sozaidata.xml");
        string _soatQuely = "";

        public ShowAndCopy()
        {
            InitializeComponent();
            //_dataDocu.Load("sozaidata.xml");
            //_dispDT.Columns.Add("type");
            //_dispDT.Columns.Add("supply");
            //_dispDT.Columns.Add("name");
            //_dispDT.Columns.Add("needDisp");
            //_dispDT.Columns.Add("nikName");
        }

        private void ShowAndCopy_Load(object sender, EventArgs e)
        {
            Set_Lamda();
            fomatDT();
            dataGrid.DataSource = _dispDT;
        }


        private void Set_Lamda() 
        {
            btnSoat.Click += (_sender, _e) => 
            {
                fomatDT();
                _soatQuely = "";
                if (chkPictureDisp.Checked)
                { AddQuely("type", "画像"); }
                if (chkBgmDisp.Checked) 
                { AddQuely("type", "BGM"); }
                if (chkSeDisp.Checked) 
                { AddQuely("type", "SE"); }
                if (chkMovieDisp.Checked) 
                { AddQuely("type", "動画"); }
                if (chkScriptDisp.Checked) 
                { AddQuely("type", "スクリプト"); }
                if (chkApplicationDisp.Checked) 
                { AddQuely("type", "アプリ"); }
                if (chkNeedOnlyDisp.Checked) 
                {
                    if (_soatQuely == "") 
                    { _soatQuely = "needDisp ='必須'"; }
                    else { _soatQuely = "("+_soatQuely+")and needDisp ='必須'"; }
                }

                DataRow[] soartedRows = _dispDT.Select(_soatQuely);
                _dispDT = soartedRows.CopyToDataTable();
                dataGrid.DataSource = _dispDT;
                //_dispDT = new DataTable();
                //_dispDT.Columns.Add("type");
                //_dispDT.Columns.Add("supply");
                //_dispDT.Columns.Add("name");
                //_dispDT.Columns.Add("needDisp");
                //_dispDT.Columns.Add("nikName");
                //foreach (DataRow row in soartedRows) 
                //{
                //    _dispDT.Rows.Add(row);
                //}

            };

            btnExportText.Click += (_sender, _e) =>
            {
                txDisplay.Text = "";
                string head = "";
                if (rdoDotHead.Checked) { head = "・"; }
                if (rdoAstaHead.Checked) { head = "＊"; }
                if (rdoBrankHead.Checked) { head = " "; }
                if (rdoOriginalHead.Checked) { head = tbOriginalHead.Text; }
                if (rdoHeadLess.Checked) { head = ""; }

                string hoot = "";
                if (rdoNewrowHoot.Checked) { hoot = "\r\n"; }
                if (rdoSrashHoot.Checked) { hoot = "/"; }
                if (rdoBrankHoot.Checked) { hoot = " "; }
                if (rdoOriginalHoot.Checked) { hoot = tbOriginalHoot.Text; }
                if (rdoHootLess.Checked) { hoot = ""; }

                string exportedText = "";
                string typeValue = "";
                //DataTable gridDT = _dispDT;

                if (_dispDT.Rows.Count > 0)
                {
                    foreach (DataRow dr in _dispDT.Rows)
                    {
                        if (typeValue != dr["type"].ToString())
                        {
                            if (exportedText == "")
                            {
                                exportedText = dr["type"].ToString() + "\r\n";
                            }
                            else
                            {
                                if (hoot != "\r\n")
                                {
                                    exportedText = exportedText + "\r\n" + dr["type"].ToString() + "\r\n";
                                }
                                else
                                {
                                    exportedText = exportedText + dr["type"].ToString() + "\r\n";
                                }
                            }
                            typeValue = dr["type"].ToString();
                        }

                        exportedText = exportedText + head + dr["name"].ToString() + hoot;
                    }
                    txDisplay.Text = exportedText;
                }
                else 
                {
                    MessageBox.Show("データがありません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            };

            btnExportSupply.Click += (_sender, _e) =>
            {
                txDisplay.Text = "";
                string head = "";
                if (rdoDotHead.Checked) { head = "・"; }
                if (rdoAstaHead.Checked) { head = "＊"; }
                if (rdoBrankHead.Checked) { head = " "; }
                if (rdoOriginalHead.Checked) { head = tbOriginalHead.Text; }
                if (rdoHeadLess.Checked) { head = ""; }

                string hoot = "";
                if (rdoNewrowHoot.Checked) { hoot = "\r\n"; }
                if (rdoSrashHoot.Checked) { hoot = "/"; }
                if (rdoBrankHoot.Checked) { hoot = " "; }
                if (rdoOriginalHoot.Checked) { hoot = tbOriginalHoot.Text; }
                if (rdoHootLess.Checked) { hoot = ""; }

                string exportedText = "";
                string typeValue = "";
                string latestSupply = "";
                bool janruChange = false;
                //DataTable gridDT = _dispDT;

                if (_dispDT.Rows.Count > 0)
                {
                    foreach (DataRow dr in _dispDT.Rows)
                    {
                        if (typeValue != dr["type"].ToString())
                        {
                            if (exportedText == "")
                            {
                                exportedText = dr["type"].ToString() + "\r\n";
                            }
                            else
                            {
                                if (hoot != "\r\n")
                                {
                                    exportedText = exportedText + "\r\n" + dr["type"].ToString() + "\r\n";
                                    janruChange = true;
                                }
                                else
                                {
                                    exportedText = exportedText + dr["type"].ToString() + "\r\n";
                                    janruChange = true;
                                }
                            }
                            typeValue = dr["type"].ToString();
                        }

                        if (latestSupply != dr["supply"].ToString()||janruChange)
                        {
                            latestSupply = dr["supply"].ToString();
                            exportedText = exportedText + head + dr["supply"].ToString() + hoot;
                            janruChange = false;
                        }
                    }
                    txDisplay.Text = exportedText;
                }
                else
                {
                    MessageBox.Show("データがありません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            };

            chkAllDisp.CheckedChanged += (_sender, _e) => 
            {
                if (chkAllDisp.Checked) 
                {
                    chkPictureDisp.Checked = true;
                    chkBgmDisp.Checked = true;
                    chkSeDisp.Checked = true;
                    chkMovieDisp.Checked = true;
                    chkScriptDisp.Checked = true;
                    chkApplicationDisp.Checked = true;
                    chkPictureDisp.Enabled = false;
                    chkBgmDisp.Enabled = false;
                    chkSeDisp.Enabled = false;
                    chkMovieDisp.Enabled = false;
                    chkScriptDisp.Enabled = false;
                    chkApplicationDisp.Enabled = false;
                }
                else 
                {
                    chkPictureDisp.Enabled = true;
                    chkBgmDisp.Enabled = true;
                    chkSeDisp.Enabled = true;
                    chkMovieDisp.Enabled = true;
                    chkScriptDisp.Enabled = true;
                    chkApplicationDisp.Enabled = true;
                }
            };

            rdoOriginalHead.CheckedChanged += (_sender, _e) => 
            {
                if (rdoOriginalHead.Checked) 
                {
                    tbOriginalHead.Enabled = true;
                }
                else 
                {
                    tbOriginalHead.Enabled = false;
                }
            };

            rdoOriginalHoot.CheckedChanged += (_sender, _e) => 
            {
                if (rdoOriginalHoot.Checked) 
                {
                    tbOriginalHoot.Enabled = true;
                }
                else 
                {
                    tbOriginalHoot.Enabled = false;
                }
            };

            btnClear.Click += (_sender, _e) => 
            {
                txDisplay.Text = "";
                tbOriginalHead.Text = "";
                tbOriginalHoot.Text = "";
                chkAllDisp.Checked = false;
                chkPictureDisp.Checked = false;
                chkBgmDisp.Checked = false;
                chkSeDisp.Checked = false;
                chkMovieDisp.Checked = false;
                chkScriptDisp.Checked = false;
                chkApplicationDisp.Checked = false;
                chkNeedOnlyDisp.Checked = false;
                rdoDotHead.Checked = true;
                rdoNewrowHoot.Checked = true;
                fomatDT();

            };

        }

        private void fomatDT() 
        {
            _dispDT = new DataTable();
            _dispDT.Columns.Add("type");
            _dispDT.Columns.Add("supply");
            _dispDT.Columns.Add("name");
            _dispDT.Columns.Add("needDisp");
            _dispDT.Columns.Add("nikName");
            XElement sozaidatas = _dataDocu.Element("sozaidatas");
            XElement pic = sozaidatas.Element("picture");
            IEnumerable<XElement> picdatas = pic.Elements("data");
            AddRow("画像", picdatas);
            XElement bgm = sozaidatas.Element("BGM");
            IEnumerable<XElement> bgmDatas = bgm.Elements("data");
            AddRow("BGM", bgmDatas);
            XElement se = sozaidatas.Element("SE");
            IEnumerable<XElement> seDatas = se.Elements("data");
            AddRow("SE", seDatas);
            XElement movie = sozaidatas.Element("Movie");
            IEnumerable<XElement> movieDatas = movie.Elements("data");
            AddRow("動画", movieDatas);
            XElement script = sozaidatas.Element("Script");
            IEnumerable<XElement> scriptDatas = script.Elements("data");
            AddRow("スクリプト", scriptDatas);
            XElement appli = sozaidatas.Element("Application");
            IEnumerable<XElement> appliDatas = appli.Elements("data");
            AddRow("アプリ", appliDatas);
        }

        private void AddRow(string type,IEnumerable<XElement> elements) 
        {
            if (elements.Count() > 0)
            {
                foreach (XElement ele in elements)
                {
                    DataRow eleRow = _dispDT.NewRow();
                    eleRow["type"] = type;
                    eleRow["supply"] = ele.Element("supply").Value;
                    eleRow["name"] = ele.Element("name").Value;
                    if (ele.Element("needDisplay").Value == "true")
                    {
                        eleRow["needDisp"] = "必須";
                    }
                    else
                    {
                        eleRow["needDisp"] = "";
                    }
                    eleRow["nikName"] = ele.Element("nikname").Value;

                    _dispDT.Rows.Add(eleRow);

                }
            }
        
        
        }
        private void AddQuely(string column,string value) 
        {
            if (_soatQuely == "") 
            {
                _soatQuely = column + " = '" + value + "'";
            }
            else 
            {
                _soatQuely = _soatQuely + " or " + column + " = '" + value + "'";
            }
        }
    }
}
