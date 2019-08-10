using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace FLAME_TEST
{
    public partial class CASE3 : Form
    {
        string path;
        private List<PostCodeAndCityClass> postCodeAndCities;

        public CASE3()
        {
            InitializeComponent();
            path = (System.Windows.Forms.Application.StartupPath + @"\ExcelData\PostCodeAndCity.xlsx");
        }

        private void CASE3_Load(object sender, EventArgs e)
        {
            postCodeAndCities = ReadPostCodeAndCityExcelFile(path);
        }

        private void printResultCount(List<SpacialChar> list)
        {
            string res ="";
            //print count >0
            foreach (SpacialChar item in list) {
                if (item.count > 0) {
                    res +=( item.specialChar  + " = " +item.count +"\r\n");
                }
            }
            //settext
            txtResult.Text = res;
        }
        private void printResultRepleace ()
        {
            string res ="";
            //print count >0
            foreach (PostCodeAndCityClass item in postCodeAndCities) {
                
                    res +=(item.city + " => " + repleaceChar(item.city) + "\r\n");
              
            }
            //settext
            txtResult.Text = res;
        }

        string repleaceChar(string str) {
            str = str.Replace("Ä", "A");
            str =str.Replace("ä", "a");
            str =str.Replace("Ö", "O");
            str =str.Replace("ö", "o");
            str =str.Replace("Ü", "U");
            str =str.Replace("ü", "u");
            str =str.Replace("ẞ", "S");
            str = str.Replace("ß", "s");  
            return str;
        }
        List<SpacialChar> countChar(List<PostCodeAndCityClass> s) {
            //init special char
            List<SpacialChar> result = new List<SpacialChar>();
            result.Add(new SpacialChar('Ä', 0));
            result.Add(new SpacialChar('ä', 0));
            result.Add(new SpacialChar('Ö', 0));
            result.Add(new SpacialChar('ö', 0));
            result.Add(new SpacialChar('Ü', 0));
            result.Add(new SpacialChar('ü', 0));
            result.Add(new SpacialChar('ẞ', 0));
            result.Add(new SpacialChar('ß', 0));
            //loop all row 
            foreach (PostCodeAndCityClass item in s) {
                //loop city char
                for (int a = 0; a < item.city.Length; a++) { 
                    //loop check special char
                    for (int a2 = 0; a2 < result.Count; a2++) {  
                        if (result[a2].specialChar == item.city[a]) {
                            result[a2].count++;
                        }
                    }
                }
            }
            return result;
        }
        private List<PostCodeAndCityClass> ReadPostCodeAndCityExcelFile(string filePath)
        {
            List<PostCodeAndCityClass> list = new List<PostCodeAndCityClass>();
            PostCodeAndCityClass item;
            Excel.Application xlApp;
            Workbook xlWorkBook;
            Worksheet xlWorkSheet;
            Range range;
            int rw = 0;

            xlApp = new Excel.Application();
            //open the excel
            xlWorkBook = xlApp.Workbooks.Open(filePath);
            //get the first sheet of the excel
            xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);
            range = xlWorkSheet.UsedRange;
            // get the total row count
            rw = range.Rows.Count;
            for (int a = 2; a <= rw; a++)
            {
                item = new PostCodeAndCityClass();
                item.postCode = (string)(range.Cells[a, 1] as Range).Value2.ToString();
                item.city = (string)(range.Cells[a, 2] as Range).Value2.ToString();
                list.Add(item);
            }
            //release the resources
            xlWorkBook.Close(true, null, null);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            return list;
        }
        class PostCodeAndCityClass {
            public string postCode { get; set; }
            public string city { get; set; }
        }
        class SpacialChar
        {
            public SpacialChar()
            {
            }
            public SpacialChar(char postCode, int count)
            {
                this.specialChar = postCode;
                this.count = count;
            }
            public char specialChar { get; set; }
            public int count { get; set; }
        }

        private void BtnCountSpecialChar_Click(object sender, EventArgs e)
        {
            printResultCount(countChar(postCodeAndCities));
        }

        private void BtnReplaceChar_Click(object sender, EventArgs e)
        {
            printResultRepleace();
        }
    }
}
