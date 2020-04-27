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


        public ShowAndCopy()
        {
            InitializeComponent();
            //_dataDocu.Load("sozaidata.xml");
            _dispDT.Columns.Add("supply");
            _dispDT.Columns.Add("name");
            _dispDT.Columns.Add("needDisp");
            _dispDT.Columns.Add("nikName");
        }

        private void ShowAndCopy_Load(object sender, EventArgs e)
        {
            XElement sozaidatas = _dataDocu.Element("sozaidatas");
            XElement pic = sozaidatas.Element("picture");
            IEnumerable<XElement> picdatas = pic.Elements("data");
            AddRow(picdatas);
            XElement bgm = sozaidatas.Element("BGM");
            IEnumerable<XElement> bgmDatas = bgm.Elements("data");
            AddRow(bgmDatas);
            XElement se = sozaidatas.Element("SE");
            IEnumerable<XElement> seDatas = se.Elements("data");
            AddRow(seDatas);
            XElement movie = sozaidatas.Element("Movie");
            IEnumerable<XElement> movieDatas = movie.Elements("data");
            AddRow(movieDatas);
            XElement script = sozaidatas.Element("Script");
            IEnumerable<XElement> scriptDatas = script.Elements("data");
            AddRow(scriptDatas);
            XElement appli = sozaidatas.Element("Application");
            IEnumerable<XElement> appliDatas = appli.Elements("data");
            AddRow(appliDatas);

            dataGrid.DataSource = _dispDT;
        }



        private void AddRow(IEnumerable<XElement> elements) 
        {
            if (elements.Count() > 0)
            {
                foreach (XElement ele in elements)
                {
                    DataRow eleRow = _dispDT.NewRow();
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
    }
}
