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

namespace SozaiManager
{
    public partial class dataedit : Form
    {
        XDocument _dataDocu = XDocument.Load("sozaidata.xml");
        XDocument _supplyDocu = XDocument.Load("source.xml");
        DataTable _dispDT = new DataTable();
        string[] _beforeChangeNames = new string[10];

        public dataedit()
        {
            InitializeComponent();
            _beforeChangeNames[0] = "";
            _beforeChangeNames[1] = "";
            _beforeChangeNames[2] = "";
            _beforeChangeNames[3] = "";
            _beforeChangeNames[4] = "";
            _beforeChangeNames[5] = "";
            _beforeChangeNames[6] = "";
            _beforeChangeNames[7] = "";
            _beforeChangeNames[8] = "";
            _beforeChangeNames[9] = "";

        }
        private void dataedit_Load(object sender, EventArgs e)
        {
            Set_Lamda();
            fomatDT();
            dataGridView1.DataSource = _dispDT;

            SetTypeCombo(cmbType1);
            SetTypeCombo(cmbType2);
            SetTypeCombo(cmbType3);
            SetTypeCombo(cmbType4);
            SetTypeCombo(cmbType5);
            SetTypeCombo(cmbType6);
            SetTypeCombo(cmbType7);
            SetTypeCombo(cmbType8);
            SetTypeCombo(cmbType9);
            SetTypeCombo(cmbType10);

            DataTable supply1 = new DataTable();
            SetSupplyCombo(supply1, cmbSupply1);
            DataTable supply2 = new DataTable();
            SetSupplyCombo(supply2, cmbSupply2);
            DataTable supply3 = new DataTable();
            SetSupplyCombo(supply3, cmbSupply3);
            DataTable supply4 = new DataTable();
            SetSupplyCombo(supply4, cmbSupply4);
            DataTable supply5 = new DataTable();
            SetSupplyCombo(supply5, cmbSupply5);
            DataTable supply6 = new DataTable();
            SetSupplyCombo(supply6, cmbSupply6);
            DataTable supply7 = new DataTable();
            SetSupplyCombo(supply7, cmbSupply7);
            DataTable supply8 = new DataTable();
            SetSupplyCombo(supply8, cmbSupply8);
            DataTable supply9 = new DataTable();
            SetSupplyCombo(supply9, cmbSupply9);
            DataTable supply10 = new DataTable();
            SetSupplyCombo(supply10, cmbSupply10);

        }

        private void Set_Lamda()
        {
            #region クリア
            btn1clear.Click += (_sender, _e) =>
            {
                RowClear(cmbType1, cmbSupply1, tbname1, tbnikname1, chkneed1);
            };

            btn2clear.Click += (_sender, _e) =>
            {
                RowClear(cmbType2, cmbSupply2, tbname2, tbnikname2, chkneed2);
            };

            btn3clear.Click += (_sender, _e) =>
            {
                RowClear(cmbType3, cmbSupply3, tbname3, tbnikname3, chkneed3);
            };

            btn4clear.Click += (_sender, _e) =>
            {
                RowClear(cmbType4, cmbSupply4, tbname4, tbnikname4, chkneed4);
            };

            btn5clear.Click += (_sender, _e) =>
            {
                RowClear(cmbType5, cmbSupply5, tbname5, tbnikname5, chkneed5);
            };

            btn6clear.Click += (_sender, _e) =>
            {
                RowClear(cmbType6, cmbSupply6, tbname6, tbnikname6, chkneed6);
            };

            btn7clear.Click += (_sender, _e) =>
            {
                RowClear(cmbType7, cmbSupply7, tbname7, tbnikname7, chkneed7);
            };

            btn8clear.Click += (_sender, _e) =>
            {
                RowClear(cmbType8, cmbSupply8, tbname8, tbnikname8, chkneed8);
            };

            btn9clear.Click += (_sender, _e) =>
            {
                RowClear(cmbType9, cmbSupply9, tbname9, tbnikname9, chkneed9);
            };

            btn10clear.Click += (_sender, _e) =>
            {
                RowClear(cmbType10, cmbSupply10, tbname10, tbnikname10, chkneed10);
            };

            btnClear.Click += (_sender, _e) =>
            {
                RowClear(cmbType1, cmbSupply1, tbname1, tbnikname1, chkneed1);
                RowClear(cmbType2, cmbSupply2, tbname2, tbnikname2, chkneed2);
                RowClear(cmbType3, cmbSupply3, tbname3, tbnikname3, chkneed3);
                RowClear(cmbType4, cmbSupply4, tbname4, tbnikname4, chkneed4);
                RowClear(cmbType5, cmbSupply5, tbname5, tbnikname5, chkneed5);
                RowClear(cmbType6, cmbSupply6, tbname6, tbnikname6, chkneed6);
                RowClear(cmbType7, cmbSupply7, tbname7, tbnikname7, chkneed7);
                RowClear(cmbType8, cmbSupply8, tbname8, tbnikname8, chkneed8);
                RowClear(cmbType9, cmbSupply9, tbname9, tbnikname9, chkneed9);
                RowClear(cmbType10, cmbSupply10, tbname10, tbnikname10, chkneed10);
                fomatDT();
                dataGridView1.DataSource = _dispDT;
            };

            #endregion

            dataGridView1.CellDoubleClick += (_sender, _e) =>
            {
                bool complateflg = false;
                for (int rowNumber= 0; rowNumber<11; rowNumber++)
                {
                    string[] inputedStrings = null;
                    switch (rowNumber)
                    {
                        case 1:
                            inputedStrings = catchRowValues(cmbType1, cmbSupply1, tbname1, tbnikname1, chkneed1);
                            string margedText1 = inputedStrings[0] + inputedStrings[1] + inputedStrings[2] + inputedStrings[3];

                            if (margedText1 == "" && inputedStrings[4] == "false")
                            {
                                sendFromGrid(cmbType1, cmbSupply1, tbname1, tbnikname1, chkneed1, _e.RowIndex);
                                _beforeChangeNames[0] = tbname1.Text;
                                complateflg = true;
                            }
                            break;

                        case 2:
                            inputedStrings = catchRowValues(cmbType2, cmbSupply2, tbname2, tbnikname2, chkneed2);
                            string margedText2 = inputedStrings[0] + inputedStrings[1] + inputedStrings[2] + inputedStrings[3];

                            if (margedText2 == "" && inputedStrings[4] == "false")
                            {
                                sendFromGrid(cmbType2, cmbSupply2, tbname2, tbnikname2, chkneed2, _e.RowIndex);
                                _beforeChangeNames[2] = tbname2.Text;
                                complateflg = true;
                            }
                            break;


                        case 3:
                            inputedStrings = catchRowValues(cmbType3, cmbSupply3, tbname3, tbnikname3, chkneed3);
                            string margedText3 = inputedStrings[0] + inputedStrings[1] + inputedStrings[2] + inputedStrings[3];

                            if (margedText3 == "" && inputedStrings[4] == "false")
                            {
                                sendFromGrid(cmbType3, cmbSupply3, tbname3, tbnikname3, chkneed3, _e.RowIndex);
                                _beforeChangeNames[2]= tbname3.Text;
                                complateflg = true;
                            }
                            break;


                        case 4:
                            inputedStrings = catchRowValues(cmbType4, cmbSupply4, tbname4, tbnikname4, chkneed4);
                            string margedText4 = inputedStrings[0] + inputedStrings[1] + inputedStrings[2] + inputedStrings[3];

                            if (margedText4 == "" && inputedStrings[4] == "false")
                            {
                                sendFromGrid(cmbType4, cmbSupply4, tbname4, tbnikname4, chkneed4, _e.RowIndex);
                                _beforeChangeNames[3] = tbname4.Text;
                                complateflg = true;
                            }
                            break;


                        case 5:
                            inputedStrings = catchRowValues(cmbType5, cmbSupply5, tbname5, tbnikname5, chkneed5);
                            string margedText5 = inputedStrings[0] + inputedStrings[1] + inputedStrings[2] + inputedStrings[3];

                            if (margedText5 == "" && inputedStrings[4] == "false")
                            {
                                sendFromGrid(cmbType5, cmbSupply5, tbname5, tbnikname5, chkneed5, _e.RowIndex);
                                _beforeChangeNames[4] = tbname5.Text;
                                complateflg = true;
                            }
                            break;


                        case 6:
                            inputedStrings = catchRowValues(cmbType6, cmbSupply6, tbname6, tbnikname6, chkneed6);
                            string margedText6 = inputedStrings[0] + inputedStrings[1] + inputedStrings[2] + inputedStrings[3];

                            if (margedText6 == "" && inputedStrings[4] == "false")
                            {
                                sendFromGrid(cmbType6, cmbSupply6, tbname6, tbnikname6, chkneed6, _e.RowIndex);
                                _beforeChangeNames[5] = tbname6.Text;
                                complateflg = true;
                            }
                            break;

                        case 7:
                            inputedStrings = catchRowValues(cmbType7, cmbSupply7, tbname7, tbnikname7, chkneed7);
                            string margedText7 = inputedStrings[0] + inputedStrings[1] + inputedStrings[2] + inputedStrings[3];

                            if (margedText7 == "" && inputedStrings[4] == "false")
                            {
                                sendFromGrid(cmbType7, cmbSupply7, tbname7, tbnikname7, chkneed7, _e.RowIndex);
                                _beforeChangeNames[6] = tbname7.Text;
                                complateflg = true;
                            }
                            break;


                        case 8:
                            inputedStrings = catchRowValues(cmbType8, cmbSupply8, tbname8, tbnikname8, chkneed8);
                            string margedText8 = inputedStrings[0] + inputedStrings[1] + inputedStrings[2] + inputedStrings[3];

                            if (margedText8 == "" && inputedStrings[4] == "false")
                            {
                                sendFromGrid(cmbType8, cmbSupply8, tbname8, tbnikname8, chkneed8, _e.RowIndex);
                                _beforeChangeNames[7] = tbname8.Text;
                                complateflg = true;
                            }
                            break;


                        case 9:
                            inputedStrings = catchRowValues(cmbType9, cmbSupply9, tbname9, tbnikname9, chkneed9);
                            string margedText9 = inputedStrings[0] + inputedStrings[1] + inputedStrings[2] + inputedStrings[3];

                            if (margedText9 == "" && inputedStrings[4] == "false")
                            {
                                sendFromGrid(cmbType9, cmbSupply9, tbname9, tbnikname9, chkneed9, _e.RowIndex);
                                _beforeChangeNames[8] = tbname9.Text;
                                complateflg = true;
                            }
                            break;


                        case 10:
                            inputedStrings = catchRowValues(cmbType10, cmbSupply10, tbname10, tbnikname10, chkneed10);
                            string margedText10 = inputedStrings[0] + inputedStrings[1] + inputedStrings[2] + inputedStrings[3];

                            if (margedText10 == "" && inputedStrings[4] == "false")
                            {
                                sendFromGrid(cmbType10, cmbSupply10, tbname10, tbnikname10, chkneed10, _e.RowIndex);
                                _beforeChangeNames[9] = tbname10.Text;
                                complateflg = true;
                            }
                            break;
                    }

                    if (complateflg) { break; }
                }

                if (!complateflg) { MessageBox.Show("空の情報欄がありません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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

            private void AddRow(string type, IEnumerable<XElement> elements)
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


            private void RowClear(ComboBox type, ComboBox supply, TextBox name, TextBox Nikname, CheckBox need)
            {
                type.Text = "";
                supply.Text = "";
                name.Text = "";
                Nikname.Text = "";
                need.Checked = false;
            }


            private string[] catchRowValues(ComboBox type, ComboBox supply, TextBox name, TextBox Nikname, CheckBox need)
            {
                var Rowvalues = new string[5];
                Rowvalues[0] = type.Text;
                Rowvalues[1] = supply.Text;
                Rowvalues[2] = name.Text;
                Rowvalues[3] = Nikname.Text;
                
                if (need.Checked)
                {
                    Rowvalues[4] = "true";
                }
                else
                {
                    Rowvalues[4] = "false";
                }

                return Rowvalues;
            }

            private void sendFromGrid(ComboBox type, ComboBox supply, TextBox name, TextBox Nikname, CheckBox need, int rowindex)
            {
                type.Text = dataGridView1["type", rowindex].Value.ToString();
                supply.Text = dataGridView1["supply", rowindex].Value.ToString();
                name.Text = dataGridView1["name", rowindex].Value.ToString();
                if (dataGridView1["nikName", rowindex].Value.ToString() == "-")
                {
                    Nikname.Text = "";
                }
                else
                {
                    Nikname.Text = dataGridView1["nikName", rowindex].Value.ToString();
                }
                if (dataGridView1["Display", rowindex].Value.ToString() == "必須")
                {
                    need.Checked = true;
                }
                else
                {
                    need.Checked = false;
                }
            }

            private void SetTypeCombo(ComboBox combo)
            {
                combo.Items.Add("画像");
                combo.Items.Add("BGM");
                combo.Items.Add("SE");
                combo.Items.Add("動画");
                combo.Items.Add("スクリプト");
                combo.Items.Add("アプリ");
            }

            private void SetSupplyCombo(DataTable dt, ComboBox combo)
            {
                dt.Columns.Add("supplyname");

                XElement supplyBody = _supplyDocu.Element("source");
                IEnumerable<XElement> supplynames = supplyBody.Elements("supply");
                foreach (XElement supply in supplynames)
                {
                    DataRow onesupply = dt.NewRow();
                    onesupply["supplyname"] = supply.Value;
                    dt.Rows.Add(onesupply);
                }
                foreach (DataRow dr in dt.Rows)
                {
                    combo.Items.Add(dr["supplyname"].ToString());
                }
            }
        
    }
}
