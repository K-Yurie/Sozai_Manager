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
    public partial class editsupply : Form
    {
        XDocument _supplyDocu = XDocument.Load("source.xml");
        string _beforetext = "";

        public editsupply()
        {
            InitializeComponent();
        }

        private void editsupply_Load(object sender, EventArgs e)
        {
            try
            {
                tbname.Text = "";
                Set_Lamda();
                fomatDt();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("申し訳ございません。エラーが発生しました");
            }
        }

        private void Set_Lamda()
        {
            btnInput.Click += (_sender, _e) =>
            {
                try
                {
                    XElement supplyes = _supplyDocu.Element("source");
                    XElement inputsupply = new XElement("supply", tbname.Text);
                    supplyes.Add(inputsupply);
                    _supplyDocu.Save("source.xml");
                    fomatDt();
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("申し訳ございません。エラーが発生しました");
                }
             };

            btnUpdate.Click += (_sender, _e) => 
            {
                try
                {
                    XElement supplyes = _supplyDocu.Element("source");
                    IEnumerable<XElement> supplyNames = supplyes.Elements("supply");
                    foreach (XElement sup in supplyNames)
                    {
                        if (sup.Value == _beforetext)
                        {
                            sup.Value = tbname.Text;
                        }
                    }
                    _supplyDocu.Save("source.xml");
                    fomatDt();
                    tbname.Text = "";
                    _beforetext = "";
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("申し訳ございません。エラーが発生しました");
                }
            };

            btndelete.Click += (_sender, _e) =>
            {
                try
                {
                    XElement supplyes = _supplyDocu.Element("source");
                    IEnumerable<XElement> supplyNames = supplyes.Elements("supply");
                    foreach (XElement sup in supplyNames)
                    {
                        if (sup.Value == _beforetext)
                        {
                            sup.Remove();
                        }
                    }
                    _supplyDocu.Save("source.xml");
                    fomatDt();
                    tbname.Text = "";
                    _beforetext = "";
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("申し訳ございません。エラーが発生しました");
                }
            };

            dataGridView1.CellDoubleClick += (_sender, _e) => 
            {
                try
                {
                    tbname.Text = dataGridView1["name", _e.RowIndex].Value.ToString();
                    _beforetext = tbname.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("申し訳ございません。エラーが発生しました");
                }
            };

        }
        private void fomatDt()
        {
            DataTable DT = new DataTable();
            DT.Columns.Add("name");
            XElement supplyes = _supplyDocu.Element("source");
            IEnumerable<XElement> supplyNames = supplyes.Elements("supply");

            foreach (XElement sup in supplyNames)
            {
                DataRow dr = DT.NewRow();
                dr["name"] = sup.Value;
                DT.Rows.Add(dr);
            }
            dataGridView1.DataSource = DT;
        }

    }
}
