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
        bool _removedFlg = false;
        int changedCount = 0;
        string[] _beforeChangeType = new string[10];
        string[] _beforeChangeNames = new string[10];
        string[] _beforeChangeSupply = new string[10];
        string[] _beforeChangeNikname = new string[10];
        string[] _beforeChangeNeed = new string[10];

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
                RowClear(0,cmbType1, cmbSupply1, tbname1, tbnikname1, chkneed1);
            };

            btn2clear.Click += (_sender, _e) =>
            {
                RowClear(1,cmbType2, cmbSupply2, tbname2, tbnikname2, chkneed2);
            };

            btn3clear.Click += (_sender, _e) =>
            {
                RowClear(2,cmbType3, cmbSupply3, tbname3, tbnikname3, chkneed3);
            };

            btn4clear.Click += (_sender, _e) =>
            {
                RowClear(3,cmbType4, cmbSupply4, tbname4, tbnikname4, chkneed4);
            };

            btn5clear.Click += (_sender, _e) =>
            {
                RowClear(4,cmbType5, cmbSupply5, tbname5, tbnikname5, chkneed5);
            };

            btn6clear.Click += (_sender, _e) =>
            {
                RowClear(5,cmbType6, cmbSupply6, tbname6, tbnikname6, chkneed6);
            };

            btn7clear.Click += (_sender, _e) =>
            {
                RowClear(6,cmbType7, cmbSupply7, tbname7, tbnikname7, chkneed7);
            };

            btn8clear.Click += (_sender, _e) =>
            {
                RowClear(7,cmbType8, cmbSupply8, tbname8, tbnikname8, chkneed8);
            };

            btn9clear.Click += (_sender, _e) =>
            {
                RowClear(8,cmbType9, cmbSupply9, tbname9, tbnikname9, chkneed9);
            };

            btn10clear.Click += (_sender, _e) =>
            {
                RowClear(9,cmbType10, cmbSupply10, tbname10, tbnikname10, chkneed10);
            };

            btnClear.Click += (_sender, _e) =>
            {
                FormFomat();

                //RowClear(cmbType1, cmbSupply1, tbname1, tbnikname1, chkneed1);
                //RowClear(cmbType2, cmbSupply2, tbname2, tbnikname2, chkneed2);
                //RowClear(cmbType3, cmbSupply3, tbname3, tbnikname3, chkneed3);
                //RowClear(cmbType4, cmbSupply4, tbname4, tbnikname4, chkneed4);
                //RowClear(cmbType5, cmbSupply5, tbname5, tbnikname5, chkneed5);
                //RowClear(cmbType6, cmbSupply6, tbname6, tbnikname6, chkneed6);
                //RowClear(cmbType7, cmbSupply7, tbname7, tbnikname7, chkneed7);
                //RowClear(cmbType8, cmbSupply8, tbname8, tbnikname8, chkneed8);
                //RowClear(cmbType9, cmbSupply9, tbname9, tbnikname9, chkneed9);
                //RowClear(cmbType10, cmbSupply10, tbname10, tbnikname10, chkneed10);

                //cmbType1.BackColor = Color.White; cmbSupply1.BackColor = Color.White;tbname1.BackColor = Color.White;
                //cmbType2.BackColor = Color.White; cmbSupply2.BackColor = Color.White; tbname2.BackColor = Color.White;
                //cmbType3.BackColor = Color.White; cmbSupply3.BackColor = Color.White; tbname3.BackColor = Color.White;
                //cmbType4.BackColor = Color.White; cmbSupply4.BackColor = Color.White; tbname4.BackColor = Color.White;
                //cmbType5.BackColor = Color.White; cmbSupply5.BackColor = Color.White; tbname5.BackColor = Color.White;
                //cmbType6.BackColor = Color.White; cmbSupply6.BackColor = Color.White; tbname6.BackColor = Color.White;
                //cmbType7.BackColor = Color.White; cmbSupply7.BackColor = Color.White; tbname7.BackColor = Color.White;
                //cmbType8.BackColor = Color.White; cmbSupply8.BackColor = Color.White; tbname8.BackColor = Color.White;
                //cmbType9.BackColor = Color.White; cmbSupply9.BackColor = Color.White; tbname9.BackColor = Color.White;
                //cmbType10.BackColor = Color.White; cmbSupply10.BackColor = Color.White; tbname10.BackColor = Color.White;

                //fomatDT();
                //dataGridView1.DataSource = _dispDT;
            };

            #endregion

            dataGridView1.CellDoubleClick += (_sender, _e) =>
            {
                bool complateflg = false;
                for (int rowNumber = 0; rowNumber < 11; rowNumber++)
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
                                _beforeChangeType[0] = cmbType1.Text;
                                _beforeChangeSupply[0] = cmbSupply1.Text; ;
                                _beforeChangeNikname[0] = tbnikname1.Text;
                                if (chkneed1.Checked) 
                                {
                                    _beforeChangeNeed[0] = "true";
                                }
                                else 
                                {
                                    _beforeChangeNeed[0] = "false";
                                }
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
                                _beforeChangeType[1] = cmbType2.Text;
                                _beforeChangeSupply[1] = cmbSupply2.Text; ;
                                _beforeChangeNikname[1] = tbnikname2.Text;
                                if (chkneed2.Checked)
                                {
                                    _beforeChangeNeed[1] = "true";
                                }
                                else
                                {
                                    _beforeChangeNeed[1] = "false";
                                }

                                complateflg = true;
                            }
                            break;


                        case 3:
                            inputedStrings = catchRowValues(cmbType3, cmbSupply3, tbname3, tbnikname3, chkneed3);
                            string margedText3 = inputedStrings[0] + inputedStrings[1] + inputedStrings[2] + inputedStrings[3];

                            if (margedText3 == "" && inputedStrings[4] == "false")
                            {
                                sendFromGrid(cmbType3, cmbSupply3, tbname3, tbnikname3, chkneed3, _e.RowIndex);
                                _beforeChangeNames[2] = tbname3.Text;
                                _beforeChangeType[2] = cmbType3.Text;
                                _beforeChangeSupply[2] = cmbSupply3.Text; ;
                                _beforeChangeNikname[2] = tbnikname3.Text;
                                if (chkneed3.Checked)
                                {
                                    _beforeChangeNeed[2] = "true";
                                }
                                else
                                {
                                    _beforeChangeNeed[2] = "false";
                                }

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
                                _beforeChangeType[3] = cmbType4.Text;
                                _beforeChangeSupply[3] = cmbSupply4.Text; ;
                                _beforeChangeNikname[3] = tbnikname4.Text;
                                if (chkneed4.Checked)
                                {
                                    _beforeChangeNeed[3] = "true";
                                }
                                else
                                {
                                    _beforeChangeNeed[3] = "false";
                                }

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
                                _beforeChangeType[4] = cmbType5.Text;
                                _beforeChangeSupply[4] = cmbSupply5.Text; ;
                                _beforeChangeNikname[4] = tbnikname5.Text;
                                if (chkneed5.Checked)
                                {
                                    _beforeChangeNeed[4] = "true";
                                }
                                else
                                {
                                    _beforeChangeNeed[4] = "false";
                                }

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
                                _beforeChangeType[5] = cmbType6.Text;
                                _beforeChangeSupply[5] = cmbSupply6.Text; ;
                                _beforeChangeNikname[5] = tbnikname6.Text;
                                if (chkneed6.Checked)
                                {
                                    _beforeChangeNeed[5] = "true";
                                }
                                else
                                {
                                    _beforeChangeNeed[5] = "false";
                                }

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
                                _beforeChangeType[6] = cmbType7.Text;
                                _beforeChangeSupply[6] = cmbSupply7.Text; ;
                                _beforeChangeNikname[6] = tbnikname7.Text;
                                if (chkneed7.Checked)
                                {
                                    _beforeChangeNeed[6] = "true";
                                }
                                else
                                {
                                    _beforeChangeNeed[6] = "false";
                                }

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
                                _beforeChangeType[7] = cmbType8.Text;
                                _beforeChangeSupply[7] = cmbSupply8.Text; ;
                                _beforeChangeNikname[7] = tbnikname8.Text;
                                if (chkneed8.Checked)
                                {
                                    _beforeChangeNeed[7] = "true";
                                }
                                else
                                {
                                    _beforeChangeNeed[7] = "false";
                                }

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
                                _beforeChangeType[8] = cmbType9.Text;
                                _beforeChangeSupply[8] = cmbSupply9.Text; ;
                                _beforeChangeNikname[8] = tbnikname9.Text;
                                if (chkneed9.Checked)
                                {
                                    _beforeChangeNeed[8] = "true";
                                }
                                else
                                {
                                    _beforeChangeNeed[8] = "false";
                                }

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
                                _beforeChangeType[9] = cmbType10.Text;
                                _beforeChangeSupply[9] = cmbSupply10.Text; ;
                                _beforeChangeNikname[9] = tbnikname10.Text;
                                if (chkneed10.Checked)
                                {
                                    _beforeChangeNeed[9] = "true";
                                }
                                else
                                {
                                    _beforeChangeNeed[9] = "false";
                                }

                                complateflg = true;
                            }
                            break;
                    }

                    if (complateflg) { break; }
                }

                if (!complateflg) { MessageBox.Show("空の情報欄がありません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            };

            btnInput.Click += (_sender, _e) =>
            {
                bool missFlg = false;
                int doneCount = 0;
                var doneId = new List<int>();
                if (cmbType1.Text != "" || cmbSupply1.Text != "" || tbname1.Text != "" || tbnikname1.Text != "" || chkneed1.Checked) 
                {
                    if (needCheck(cmbType1, cmbSupply1, tbname1)) 
                    {
                        WriteDataXml(cmbType1, cmbSupply1, tbname1, tbnikname1, chkneed1);
                        doneCount++;
                        doneId.Add(1);
                    }
                    else 
                    {
                        missFlg = true;
                    }
                }

                if (cmbType2.Text != "" || cmbSupply2.Text != "" || tbname2.Text != "" || tbnikname2.Text != "" || chkneed2.Checked)
                {
                    if (needCheck(cmbType2, cmbSupply2, tbname2))
                    {
                        WriteDataXml(cmbType2, cmbSupply2, tbname2, tbnikname2, chkneed2);
                        doneCount++;
                        doneId.Add(2);
                    }
                    else
                    {
                        missFlg = true;
                    }
                }

                if (cmbType3.Text != "" || cmbSupply3.Text != "" || tbname3.Text != "" || tbnikname3.Text != "" || chkneed3.Checked)
                {
                    if (needCheck(cmbType3, cmbSupply3, tbname3))
                    {
                        WriteDataXml(cmbType3, cmbSupply3, tbname3, tbnikname3, chkneed3);
                        doneCount++;
                        doneId.Add(3);
                    }
                    else
                    {
                        missFlg = true;
                    }
                }

                if (cmbType4.Text != "" || cmbSupply4.Text != "" || tbname4.Text != "" || tbnikname4.Text != "" || chkneed4.Checked)
                {
                    if (needCheck(cmbType4, cmbSupply4, tbname4))
                    {
                        WriteDataXml(cmbType4, cmbSupply4, tbname4, tbnikname4, chkneed4);
                        doneCount++;
                        doneId.Add(4);
                    }
                    else
                    {
                        missFlg = true;
                    }
                }

                if (cmbType5.Text != "" || cmbSupply5.Text != "" || tbname5.Text != "" || tbnikname5.Text != "" || chkneed5.Checked)
                {
                    if (needCheck(cmbType5, cmbSupply5, tbname5))
                    {
                        WriteDataXml(cmbType5, cmbSupply5, tbname5, tbnikname5, chkneed5);
                        doneCount++;
                        doneId.Add(5);
                    }
                    else
                    {
                        missFlg = true;
                    }
                }

                if (cmbType6.Text != "" || cmbSupply6.Text != "" || tbname6.Text != "" || tbnikname6.Text != "" || chkneed6.Checked)
                {
                    if (needCheck(cmbType6, cmbSupply6, tbname6))
                    {
                        WriteDataXml(cmbType6, cmbSupply6, tbname6, tbnikname6, chkneed6);
                        doneCount++;
                        doneId.Add(6);
                    }
                    else
                    {
                        missFlg = true;
                    }
                }

                if (cmbType7.Text != "" || cmbSupply7.Text != "" || tbname7.Text != "" || tbnikname7.Text != "" || chkneed7.Checked)
                {
                    if (needCheck(cmbType7, cmbSupply7, tbname7))
                    {
                        WriteDataXml(cmbType7, cmbSupply7, tbname7, tbnikname7, chkneed7);
                        doneCount++;
                        doneId.Add(7);
                    }
                    else
                    {
                        missFlg = true;
                    }
                }

                if (cmbType8.Text != "" || cmbSupply8.Text != "" || tbname8.Text != "" || tbnikname8.Text != "" || chkneed8.Checked)
                {
                    if (needCheck(cmbType8, cmbSupply8, tbname8))
                    {
                        WriteDataXml(cmbType8, cmbSupply8, tbname8, tbnikname8, chkneed8);
                        doneCount++;
                        doneId.Add(8);
                    }
                    else
                    {
                        missFlg = true;
                    }
                }

                if (cmbType9.Text != "" || cmbSupply9.Text != "" || tbname9.Text != "" || tbnikname9.Text != "" || chkneed9.Checked)
                {
                    if (needCheck(cmbType9, cmbSupply9, tbname9))
                    {
                        WriteDataXml(cmbType9, cmbSupply9, tbname9, tbnikname9, chkneed9);
                        doneCount++;
                        doneId.Add(9);
                    }
                    else
                    {
                        missFlg = true;
                    }
                }

                if (cmbType10.Text != "" || cmbSupply10.Text != "" || tbname10.Text != "" || tbnikname10.Text != "" || chkneed10.Checked)
                {
                    if (needCheck(cmbType10, cmbSupply10, tbname10))
                    {
                        WriteDataXml(cmbType10, cmbSupply10, tbname10, tbnikname10, chkneed10);
                        doneCount++;
                        doneId.Add(10);
                    }
                    else
                    {
                        missFlg = true;
                    }
                }

                if (missFlg) 
                {
                    MessageBox.Show(doneCount.ToString() + "件のデータを登録しました", "登録完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("必須項目に記述漏れがありました", "情報", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    MessageBox.Show(doneCount.ToString() + "件のデータを登録しました", "登録完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                foreach(int id in doneId) 
                {
                    switch (id) 
                    {
                        case 1: RowClear(0,cmbType1, cmbSupply1, tbname1, tbnikname1, chkneed1);
                               break;
                        case 2: RowClear(1,cmbType2, cmbSupply2, tbname2, tbnikname2, chkneed2);
                               break;
                        case 3:RowClear(2,cmbType3, cmbSupply3, tbname3, tbnikname3, chkneed3);
                               break;
                        case 4:RowClear(3,cmbType4, cmbSupply4, tbname4, tbnikname4, chkneed4);
                               break;
                        case 5:RowClear(4,cmbType5, cmbSupply5, tbname5, tbnikname5, chkneed5);
                               break;
                        case 6:RowClear(5,cmbType6, cmbSupply6, tbname6, tbnikname6, chkneed6);
                               break;
                        case 7: RowClear(6,cmbType7, cmbSupply7, tbname7, tbnikname7, chkneed7);
                               break;
                        case 8:RowClear(7,cmbType8, cmbSupply8, tbname8, tbnikname8, chkneed8);
                               break;
                        case 9:RowClear(8,cmbType9, cmbSupply9, tbname9, tbnikname9, chkneed9);
                               break;
                        case 10:RowClear(9,cmbType10, cmbSupply10, tbname10, tbnikname10, chkneed10);
                               break;
                    }
                }
                fomatDT();
                dataGridView1.DataSource = _dispDT;
            };

            btnUpdate.Click += (_sender, _e) =>
            {
                var doneId = new List<int>();
                bool perfectFlg = true;

              for(int count = 0;count<10; count++)
              {
                    bool[] isInputs = new bool[5];
                    if (getNowValue("type", count) == "") 
                    {
                        isInputs[0] = false;
                    }
                    else 
                    {
                        isInputs[0] = true;
                    }
                    if (getNowValue("supply", count)=="") 
                    {
                        isInputs[1] = false;
                    }
                    else 
                    {
                        isInputs[1] = true;
                    }
                    if (getNowValue("name", count) == "") 
                    {
                        isInputs[2] = false;
                    }
                    else 
                    {
                        isInputs[2] = true;
                    }
                    if (getNowValue("Nikname", count) == "")
                    {
                        isInputs[3] = false;
                    }
                    else 
                    {
                        isInputs[3] = true;
                    }

                    if (isInputs[0] && isInputs[1] && isInputs[2])
                    {
                        if (_beforeChangeType[count] == getNowValue("type", count))
                        {
                            NomalUpdate(count);
                            doneId.Add(count);
                        }
                        else
                        {
                            TypeUpdate(count);
                            doneId.Add(count);
                        }
                    }
                        if (isInputs[0] || isInputs[1] || isInputs[2] || isInputs[3] || getNowValue("need", count) == "true")
                        {
                            switch (count)
                            {
                                case 0:
                                bool flg0= needCheck(cmbType1, cmbSupply1, tbname1);
                                if (flg0)
                                {
                                    RowClear(0, cmbType1, cmbSupply1, tbname1, tbnikname1, chkneed1);
                                }
                                else
                                {
                                    perfectFlg = false;
                                }
                                    break;

                                case 1:
                                bool flg1 = needCheck(cmbType2, cmbSupply2, tbname2);
                                if (flg1)
                                {
                                    RowClear(1, cmbType2, cmbSupply2, tbname2, tbnikname2, chkneed2);
                                }
                                else
                                {
                                    perfectFlg = false;
                                }
                                    break;

                                case 2:
                                bool flg2 = needCheck(cmbType3, cmbSupply3, tbname3); 
                                if (flg2)
                                {
                                    RowClear(2, cmbType3, cmbSupply3, tbname3, tbnikname3, chkneed3);
                                }
                                else
                                {
                                    perfectFlg = false;
                                }
                                    break;

                                case 3:
                                bool flg3 = needCheck(cmbType3, cmbSupply3, tbname3);
                                if (flg3)
                                {
                                    RowClear(3, cmbType4, cmbSupply4, tbname4, tbnikname4, chkneed4);
                                }
                                else
                                {
                                    perfectFlg = false;
                                }
                                break;

                                case 4:
                                bool flg4 = needCheck(cmbType5, cmbSupply5, tbname5);
                                if (flg4)
                                {
                                    RowClear(4, cmbType5, cmbSupply5, tbname5, tbnikname5, chkneed5);
                                }
                                else
                                {
                                    perfectFlg = false;
                                }
                                    break;

                                case 5:
                                bool flg5 = needCheck(cmbType6, cmbSupply6, tbname6);
                                if (flg5)
                                {
                                    RowClear(5, cmbType6, cmbSupply6, tbname6, tbnikname6, chkneed6);
                                }
                                else
                                {
                                    perfectFlg = false;
                                } 
                                    break;
                                case 6:
                                bool flg6 = needCheck(cmbType7, cmbSupply7, tbname7);
                                if (flg6)
                                {
                                    RowClear(6, cmbType7, cmbSupply7, tbname7, tbnikname7, chkneed7);
                                }
                                else
                                {
                                    perfectFlg = false;
                                }
                                    break;
                                case 7:
                                bool flg7 = needCheck(cmbType8, cmbSupply8, tbname8);
                                if (flg7)
                                {
                                    RowClear(7, cmbType8, cmbSupply8, tbname8, tbnikname8, chkneed8);
                                }
                                else
                                {
                                    perfectFlg = false;
                                }
                                    break;
                                case 8:
                                bool flg8 = needCheck(cmbType9, cmbSupply9, tbname9);
                                if (flg8)
                                {
                                    RowClear(8, cmbType9, cmbSupply9, tbname9, tbnikname9, chkneed9);
                                }
                                else
                                {
                                    perfectFlg = false;
                                }
                                    break;
                                case 9:
                                bool flg9 = needCheck(cmbType10, cmbSupply10, tbname10);
                                if (flg9)
                                {
                                    RowClear(9, cmbType10, cmbSupply10, tbname10, tbnikname10, chkneed10);
                                }
                                else
                                {
                                    perfectFlg = false;
                                }
                                    break;
                            }
                        }
              }
              if (perfectFlg) 
                {
                    MessageBox.Show(doneId.Count.ToString()+"件の更新が完了しました", "登録完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(doneId.Count.ToString() + "件の更新が完了しました", "登録完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("必須項目にぬけのあるデータがありました", "情報", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                fomatDT();
                dataGridView1.DataSource = _dispDT;
            };

            btnDelete.Click += (_sender, _e) =>
            {
                var doneId = new List<int>();
                bool perfectFlg = true;
                var deletedId = new List<int>();

                for (int count = 0; count < 10; count++)
                {
                    bool[] isInputs = new bool[4];
                    if (getNowValue("type", count) == "")
                    {
                        isInputs[0] = false;
                    }
                    else
                    {
                        isInputs[0] = true;
                    }
                    if (getNowValue("supply", count) == "")
                    {
                        isInputs[1] = false;
                    }
                    else
                    {
                        isInputs[1] = true;
                    }
                    if (getNowValue("name", count) == "")
                    {
                        isInputs[2] = false;
                    }
                    else
                    {
                        isInputs[2] = true;
                    }
                    if (getNowValue("Nikname", count) == "")
                    {
                        isInputs[3] = false;
                    }
                    else
                    {
                        isInputs[3] = true;
                    }

                    if (isInputs[0] && isInputs[1] && isInputs[2])
                    {
                        DeleteOneData(count, false);
                        if (_removedFlg) 
                        {
                            deletedId.Add(count); 
                        }
                        else if(isInputs[0] || isInputs[1] || isInputs[2] || isInputs[3] || getNowValue("need", count) == "true") 
                        {
                            perfectFlg = false;
                        }
                        _removedFlg = false;
                    }
                }

                foreach(int removedItem in deletedId) 
                {
                    switch (removedItem) 
                    {
                        case 0:RowClear(0, cmbType1, cmbSupply1, tbname1, tbnikname1, chkneed1);
                            break;

                        case 1:
                            RowClear(1, cmbType2, cmbSupply2, tbname2, tbnikname2, chkneed2);
                            break;

                        case 2:
                            RowClear(2, cmbType3, cmbSupply3, tbname3, tbnikname3, chkneed3);
                            break;
                        case 3:
                            RowClear(3, cmbType4, cmbSupply4, tbname4, tbnikname4, chkneed4);
                            break;
                        case 4:
                            RowClear(4, cmbType5, cmbSupply5, tbname5, tbnikname5, chkneed5);
                            break;
                        case 5:
                            RowClear(5, cmbType6, cmbSupply6, tbname6, tbnikname6, chkneed6);
                            break;
                        case 6:
                            RowClear(6, cmbType7, cmbSupply7, tbname7, tbnikname7, chkneed7);
                            break;
                        case 7:
                            RowClear(7, cmbType8, cmbSupply8, tbname8, tbnikname8, chkneed8);
                            break;
                        case 8:
                            RowClear(8, cmbType9, cmbSupply9, tbname9, tbnikname9, chkneed9);
                            break;
                        case 9:
                            RowClear(9, cmbType10, cmbSupply10, tbname10, tbnikname10, chkneed10);
                            break;
                    }

                }
                if (perfectFlg)
                {
                    MessageBox.Show(deletedId.Count.ToString()+"件の削除が完了しました", "削除完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show(deletedId.Count.ToString()+"件の削除が完了しました", "削除完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("削除データを発見できないデータがありました","情報",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                fomatDT();
                dataGridView1.DataSource = _dispDT;
            };
        }

        private void FormFomat() 
        {
            RowClear(0,cmbType1, cmbSupply1, tbname1, tbnikname1, chkneed1);
            RowClear(1,cmbType2, cmbSupply2, tbname2, tbnikname2, chkneed2);
            RowClear(2,cmbType3, cmbSupply3, tbname3, tbnikname3, chkneed3);
            RowClear(3,cmbType4, cmbSupply4, tbname4, tbnikname4, chkneed4);
            RowClear(4,cmbType5, cmbSupply5, tbname5, tbnikname5, chkneed5);
            RowClear(5,cmbType6, cmbSupply6, tbname6, tbnikname6, chkneed6);
            RowClear(6,cmbType7, cmbSupply7, tbname7, tbnikname7, chkneed7);
            RowClear(7,cmbType8, cmbSupply8, tbname8, tbnikname8, chkneed8);
            RowClear(8,cmbType9, cmbSupply9, tbname9, tbnikname9, chkneed9);
            RowClear(9,cmbType10, cmbSupply10, tbname10, tbnikname10, chkneed10);

            cmbType1.BackColor = Color.White; cmbSupply1.BackColor = Color.White; tbname1.BackColor = Color.White;
            cmbType2.BackColor = Color.White; cmbSupply2.BackColor = Color.White; tbname2.BackColor = Color.White;
            cmbType3.BackColor = Color.White; cmbSupply3.BackColor = Color.White; tbname3.BackColor = Color.White;
            cmbType4.BackColor = Color.White; cmbSupply4.BackColor = Color.White; tbname4.BackColor = Color.White;
            cmbType5.BackColor = Color.White; cmbSupply5.BackColor = Color.White; tbname5.BackColor = Color.White;
            cmbType6.BackColor = Color.White; cmbSupply6.BackColor = Color.White; tbname6.BackColor = Color.White;
            cmbType7.BackColor = Color.White; cmbSupply7.BackColor = Color.White; tbname7.BackColor = Color.White;
            cmbType8.BackColor = Color.White; cmbSupply8.BackColor = Color.White; tbname8.BackColor = Color.White;
            cmbType9.BackColor = Color.White; cmbSupply9.BackColor = Color.White; tbname9.BackColor = Color.White;
            cmbType10.BackColor = Color.White; cmbSupply10.BackColor = Color.White; tbname10.BackColor = Color.White;

            fomatDT();
            dataGridView1.DataSource = _dispDT;
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

        private void RowClear(int Listid,ComboBox type, ComboBox supply, TextBox name, TextBox Nikname, CheckBox need)
        {
            type.Text = "";
            supply.Text = "";
            name.Text = "";
            Nikname.Text = "";
            need.Checked = false;
            type.BackColor = Color.White;
            supply.BackColor = Color.White;
            name.BackColor = Color.White;
            _beforeChangeNames[Listid] = "";
            _beforeChangeType[Listid] = "";
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
        private void WriteDataXml(ComboBox type, ComboBox supply, TextBox name, TextBox Nikname, CheckBox need)
        {
            string nodetype = "";
            switch (type.Text)
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

                case "アプリ":
                    nodetype = "Application";
                    break;
            }

            XElement sozaidatas = _dataDocu.Element("sozaidatas");

            int flg = 0;
            if (need.Checked) { flg = 1; }
            if (Nikname.Text != "") { flg = 2; }
            if (need.Checked && Nikname.Text != "") { flg = 3; }

            switch (flg)
            {
                case 0:

                    XElement inputTo0 = sozaidatas.Element(nodetype);
                    XElement inputDatas0 = new XElement("data",
                        new XElement("supply", supply.Text),
                        new XElement("name", name.Text),
                        new XElement("needDisplay", "false"),
                        new XElement("nikname", "-"));

                    inputTo0.Add(inputDatas0);
                    _dataDocu.Save("sozaidata.xml");

                    break;

                case 1:
                    XElement inputTo1 = sozaidatas.Element(nodetype);
                    XElement inputDatas1 = new XElement("data",
                        new XElement("supply", supply.Text),
                        new XElement("name", name.Text),
                        new XElement("needDisplay", "true"),
                        new XElement("nikname", "-"));

                    inputTo1.Add(inputDatas1);
                    _dataDocu.Save("sozaidata.xml");

                    break;

                case 2:
                    XElement inputTo2 = sozaidatas.Element(nodetype);
                    XElement inputDatas2 = new XElement("data",
                        new XElement("supply", supply.Text),
                        new XElement("name", name.Text),
                        new XElement("needDisplay", "false"),
                        new XElement("nikname", Nikname.Text));

                    inputTo2.Add(inputDatas2);
                    _dataDocu.Save("sozaidata.xml");
                    break;

                case 3:
                    XElement inputTo3 = sozaidatas.Element(nodetype);
                    XElement inputDatas3 = new XElement("data",
                        new XElement("supply", supply.Text),
                        new XElement("name", name.Text),
                        new XElement("needDisplay", "true"),
                        new XElement("nikname", Nikname.Text));

                    inputTo3.Add(inputDatas3);
                    _dataDocu.Save("sozaidata.xml");
                    break;
            }


        }

        private bool needCheck(ComboBox type, ComboBox supply, TextBox name) 
        {
            bool answer = false;
            if (type.Text != "" && supply.Text != "" && name.Text != "")
            {
                answer = true;
                type.BackColor = Color.White;
                supply.BackColor = Color.White;
                name.BackColor=Color.White;
            }
            else 
            {
                if (type.Text == "")
                {
                    type.BackColor = Color.Orange;
                }
                else 
                {
                     type.BackColor = Color.White;

                }
                if (supply.Text == "") 
                {
                    supply.BackColor = Color.Orange;
                }
                else 
                {
                    supply.BackColor = Color.White;
                }
                if (name.Text == "") 
                {
                    name.BackColor = Color.Orange;
                }
                else 
                {
                　　name.BackColor=Color.White;
                }
            }
            return answer;
        }

        private void NomalUpdate(int ListId)
        {
            string xmlTypeName = "";
            switch (_beforeChangeType[ListId]) 
            {
                case "画像": xmlTypeName = "picture";
                          break;

                case "BGM":xmlTypeName = "BGM";
                          break;

                case "SE":xmlTypeName = "SE";
                          break;

                case "動画":xmlTypeName = "Movie";
                          break;

                case "スクリプト":xmlTypeName = "アプリ";
                          break;
            }

            XElement sozaidatas = _dataDocu.Element("sozaidatas");
            XElement typeNode = sozaidatas.Element(xmlTypeName);
            IEnumerable<XElement> datas = typeNode.Elements("data");


            bool oneChanged = false;
            foreach(XElement data in datas) 
            {
                if (!oneChanged)
                {
                    if (data.Element("name").Value == _beforeChangeNames[ListId]
                        && data.Element("supply").Value == _beforeChangeSupply[ListId]
                        && data.Element("needDisplay").Value == _beforeChangeNeed[ListId]
                        &&( data.Element("nikname").Value == _beforeChangeNikname[ListId]
                        ||(data.Element("nikname").Value =="-" && _beforeChangeNikname[ListId]==""))
                        )

                    {
                        string nowvalue = "";

                        nowvalue = getNowValue("supply", ListId);
                        if (data.Element("supply").Value != nowvalue)
                        {
                            data.Element("supply").Value = nowvalue;
                        }

                        nowvalue = getNowValue("name", ListId);
                        if (data.Element("name").Value != nowvalue)
                        {
                            data.Element("name").Value = nowvalue;
                        }

                        nowvalue = getNowValue("need", ListId);
                        if (data.Element("needDisplay").Value != nowvalue)
                        {
                            data.Element("needDisplay").Value = nowvalue;
                        }

                        nowvalue = getNowValue("Nikname", ListId);
                        if (data.Element("nikname").Value != nowvalue)
                        {
                            if (nowvalue == "")
                            {
                                data.Element("nikname").Value = "-";
                            }
                            else
                            {
                                data.Element("nikname").Value = nowvalue;
                            }

                        }

                        if (rdoOneChange.Checked) { oneChanged = true; }
                        changedCount++;
                    }
                }
                _dataDocu.Save("sozaidata.xml");
            }
        }

        private void TypeUpdate(int ListId) 
        {
            NomalUpdate(ListId);


                string niknameString = getNowValue("Nikname", ListId);
                if (niknameString == "") { niknameString = "-"; }

                XElement typeChangeData = new XElement("data",
                    new XElement("supply", getNowValue("supply", ListId)),
                    new XElement("name", getNowValue("name", ListId)),
                    new XElement("needDisplay", getNowValue("need", ListId)),
                    new XElement("nikname", niknameString));

            for (int redo = 0; redo < changedCount; redo++)
            {
                XElement sozaidatas = _dataDocu.Element("sozaidatas");
                switch (getNowValue("type", ListId))
                {
                    case "画像":
                        XElement picture = sozaidatas.Element("picture");
                        picture.Add(typeChangeData);
                        break;

                    case "BGM":
                        XElement BGM = sozaidatas.Element("BGM");
                        BGM.Add(typeChangeData);
                        break;

                    case "SE":
                        XElement SE = sozaidatas.Element("SE");
                        SE.Add(typeChangeData);
                        break;

                    case "動画":
                        XElement Movie = sozaidatas.Element("Movie");
                        Movie.Add(typeChangeData);
                        break;

                    case "スクリプト":
                        XElement Script = sozaidatas.Element("Script");
                        Script.Add(typeChangeData);
                        break;

                    case "アプリ":
                        XElement Application = sozaidatas.Element("Application");
                        Application.Add(typeChangeData);
                        break;
                }
            }
            _dataDocu.Save("sozaidata.xml");

            DeleteOneData(ListId, true);
        }

        private void DeleteOneData(int ListId,bool updateMode)
        {
            string xmlTypeName = "";
            switch (_beforeChangeType[ListId])
            {
                case "画像":
                    xmlTypeName = "picture";
                    break;

                case "BGM":
                    xmlTypeName = "BGM";
                    break;

                case "SE":
                    xmlTypeName = "SE";
                    break;

                case "動画":
                    xmlTypeName = "Movie";
                    break;

                case "スクリプト":
                    xmlTypeName = "Script";
                    break;
                case "アプリ":
                    xmlTypeName = "Application";
                    break;
            }

            XElement sozaidatas = _dataDocu.Element("sozaidatas");
            XElement typeNode = sozaidatas.Element(xmlTypeName);
            IEnumerable<XElement> datas = typeNode.Elements("data");
            var targets = new List<XElement>();

            bool oneDeleted = false;
            if (updateMode)
            {
                if (rdoOneChange.Checked)
                {
                    foreach (XElement data in datas)
                    {
                        if (!oneDeleted)
                        {
                            if (data.Element("name").Value == _beforeChangeNames[ListId]
                                && data.Element("supply").Value == _beforeChangeSupply[ListId]
                                && data.Element("needDisplay").Value == _beforeChangeNeed[ListId]
                                && (data.Element("nikname").Value == _beforeChangeNikname[ListId]
                                || (data.Element("nikname").Value == "-" && _beforeChangeNikname[ListId] == "")))
                            {
                                data.Remove();
                                if (rdoOneChange.Checked) { oneDeleted = true; }
                            }

                        }

                    }
                }
                else 
                {
                    foreach (XElement data2 in datas)
                    {
                        if (!oneDeleted)
                        {
                            if (data2.Element("name").Value == _beforeChangeNames[ListId]
                                && data2.Element("supply").Value == _beforeChangeSupply[ListId]
                                && data2.Element("needDisplay").Value == _beforeChangeNeed[ListId]
                                && (data2.Element("nikname").Value == _beforeChangeNikname[ListId]
                                || (data2.Element("nikname").Value == "-" && _beforeChangeNikname[ListId] == "")))
                            {
                                targets.Add(data2);
                                _removedFlg = true;
                                //fomatDT();
                                //sozaidatas = _dataDocu.Element("sozaidatas");
                                //typeNode = sozaidatas.Element(xmlTypeName);
                                //datas = typeNode.Elements("data");
                                if (rdoOneChange.Checked) { oneDeleted = true; }
                            }
                        }
                    }

                    foreach (XElement target in targets)
                    {
                        target.Remove();
                    }

                }
            }
            else
            {

                if (rdoOneChange.Checked)
                {
                    foreach (XElement data in datas)
                    {
                        if (!oneDeleted)
                        {
                            if (data.Element("name").Value == getNowValue("name", ListId)
                                && data.Element("supply").Value == getNowValue("supply", ListId)
                                && data.Element("needDisplay").Value == getNowValue("need", ListId)
                                && (data.Element("nikname").Value == getNowValue("Nikname", ListId)
                                || (data.Element("nikname").Value == "-" && getNowValue("Nikname", ListId) == "")))
                            {
                                data.Remove();
                                _removedFlg = true;
                                if (rdoOneChange.Checked) { oneDeleted = true; }
                            }
                        }
                    }
                }
                else
                {
                    foreach (XElement data2 in datas)
                    {
                        if (!oneDeleted)
                        {
                            if (data2.Element("name").Value == getNowValue("name", ListId)
                                && data2.Element("supply").Value == getNowValue("supply", ListId)
                                && data2.Element("needDisplay").Value == getNowValue("need", ListId)
                                && (data2.Element("nikname").Value == getNowValue("Nikname", ListId)
                                || (data2.Element("nikname").Value == "-" && getNowValue("Nikname", ListId) == "")))
                            {
                                targets.Add(data2);
                                _removedFlg = true;
                                //fomatDT();
                                //sozaidatas = _dataDocu.Element("sozaidatas");
                                //typeNode = sozaidatas.Element(xmlTypeName);
                                //datas = typeNode.Elements("data");
                                if (rdoOneChange.Checked) { oneDeleted = true; }
                            }
                        }
                    }

                    foreach (XElement target in targets)
                    {
                        target.Remove();
                    }
                }
            }
            _dataDocu.Save("sozaidata.xml");

        }

        private string getNowValue(string control,int listId) 
        {
            string answer = "";
            string[] nowStrings = new string[10];
            switch (control) 
            {
                case "type":
                    nowStrings[0] = cmbType1.Text;
                    nowStrings[1] = cmbType2.Text;
                    nowStrings[2] = cmbType3.Text;
                    nowStrings[3] = cmbType4.Text;
                    nowStrings[4] = cmbType5.Text;
                    nowStrings[5] = cmbType6.Text;
                    nowStrings[6] = cmbType7.Text;
                    nowStrings[7] = cmbType8.Text;
                    nowStrings[8] = cmbType9.Text;
                    nowStrings[9] = cmbType10.Text;
                    answer = nowStrings[listId];
                    break;

                case "supply":
                    nowStrings[0] = cmbSupply1.Text;
                    nowStrings[1] = cmbSupply2.Text;
                    nowStrings[2] = cmbSupply3.Text;
                    nowStrings[3] = cmbSupply4.Text;
                    nowStrings[4] = cmbSupply5.Text;
                    nowStrings[5] = cmbSupply6.Text;
                    nowStrings[6] = cmbSupply7.Text;
                    nowStrings[7] = cmbSupply8.Text;
                    nowStrings[8] = cmbSupply9.Text;
                    nowStrings[9] = cmbSupply10.Text;
                    answer = nowStrings[listId];
                    break;

                case "name":
                    nowStrings[0] = tbname1.Text;
                    nowStrings[1] = tbname2.Text;
                    nowStrings[2] = tbname3.Text;
                    nowStrings[3] = tbname4.Text;
                    nowStrings[4] = tbname5.Text;
                    nowStrings[5] = tbname6.Text;
                    nowStrings[6] = tbname7.Text;
                    nowStrings[7] = tbname8.Text;
                    nowStrings[8] = tbname9.Text;
                    nowStrings[9] = tbname10.Text;
                    answer = nowStrings[listId];
                    break;

                case "need":
                    if (chkneed1.Checked)
                    {
                        nowStrings[0] = "true";
                    }
                    else
                    {
                        nowStrings[0] = "false";
                    }
                    if (chkneed2.Checked)
                    {
                        nowStrings[1] = "true";
                    }
                    else
                    {
                        nowStrings[1] = "false";
                    }
                    if (chkneed3.Checked)
                    {
                        nowStrings[2] = "true";
                    }
                    else
                    {
                        nowStrings[2] = "false";
                    }
                    if (chkneed4.Checked)
                    {
                        nowStrings[3] = "true";
                    }
                    else
                    {
                        nowStrings[3] = "false";
                    }
                    if (chkneed5.Checked)
                    {
                        nowStrings[4] = "true";
                    }
                    else
                    {
                        nowStrings[4] = "false";
                    }
                    if (chkneed6.Checked)
                    {
                        nowStrings[5] = "true";
                    }
                    else
                    {
                        nowStrings[5] = "false";
                    }
                    if (chkneed7.Checked)
                    {
                        nowStrings[6] = "true";
                    }
                    else
                    {
                        nowStrings[6] = "false";
                    }
                    if (chkneed8.Checked)
                    {
                        nowStrings[7] = "true";
                    }
                    else
                    {
                        nowStrings[7] = "false";
                    }
                    if (chkneed9.Checked)
                    {
                        nowStrings[8] = "true";
                    }
                    else
                    {
                        nowStrings[8] = "false";
                    }
                    if (chkneed10.Checked)
                    {
                        nowStrings[9] = "true";
                    }
                    else
                    {
                        nowStrings[9] = "false";
                    }
                    answer = nowStrings[listId];
                    break;
   
                case "Nikname":
                    nowStrings[0] = tbnikname1.Text;
                    nowStrings[1] = tbnikname2.Text;
                    nowStrings[2] = tbnikname3.Text;
                    nowStrings[3] = tbnikname4.Text;
                    nowStrings[4] = tbnikname5.Text;
                    nowStrings[5] = tbnikname6.Text;
                    nowStrings[6] = tbnikname7.Text;
                    nowStrings[7] = tbnikname8.Text;
                    nowStrings[8] = tbnikname9.Text;
                    nowStrings[9] = tbnikname10.Text;
                    answer = nowStrings[listId];
                    break;

            }

            return answer;
        }

    }
}
