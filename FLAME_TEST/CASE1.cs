using CrystalDecisions.CrystalReports.Engine;
using FLAME_TEST.Reports;
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
//ref add excel assambly-> https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/interop/how-to-access-office-onterop-objects
//ref read excel -> https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/interop/how-to-access-office-onterop-objects
namespace FLAME_TEST
{
    public partial class CASE1 : Form
    {
        string productPathPath, masterSalePersonPath, masterProductsPath, masterProductCategoryPath, masterCustomerPath, transactionsSaleDetailPath, transactionsSaleHeaderPath;
        List<MasterProducts> masterProducts;
        List<MasterProductCategory> masterProductCategories;
        List<MasterCustomer> masterCustomers;
        List<MasterSalePerson> masterSalePerson;
        List<TransactionsSaleHeader> transHD;
            List<TransactionsSaleDetail> transDT;
        ReportDocument report;
        public CASE1()
        {
            InitializeComponent();
            masterCustomerPath = (System.Windows.Forms.Application.StartupPath + @"\ExcelData\MasterCustomer.xlsx");
            masterProductCategoryPath = (System.Windows.Forms.Application.StartupPath + @"\ExcelData\MasterProductCategory.xlsx");
            masterProductsPath = (System.Windows.Forms.Application.StartupPath + @"\ExcelData\MasterProducts.xlsx");
            masterSalePersonPath = (System.Windows.Forms.Application.StartupPath + @"\ExcelData\MasterSalePerson.xlsx");
            transactionsSaleDetailPath = (System.Windows.Forms.Application.StartupPath + @"\ExcelData\TransactionsSaleDetail.xlsx");
            transactionsSaleHeaderPath = (System.Windows.Forms.Application.StartupPath + @"\ExcelData\TransactionsSaleHeader.xlsx");

            report = new ReportDocument();
            report.Load(@"C:\Users\JaoJao\source\repos\FLAME_TEST\FLAME_TEST\Reports\CrystalReportCASE1.rpt");
        }

        private void CASE1_Load(object sender, EventArgs e)
        {
           //load master
            masterProducts = ReadMasterProductExcelFile(masterProductsPath);
            masterProductCategories = ReadMasterProductCategoryExcelFile(masterProductCategoryPath);
            masterCustomers = ReadMasterCustomerExcelFile(masterCustomerPath);
            masterSalePerson = ReadMasterSalePersonExcelFile(masterSalePersonPath);
            //load Transaction
            transHD = ReadTransactionsSaleHeaderExcelFile(transactionsSaleHeaderPath);
            transDT = ReadTransactionsSaleDetailExcelFile(transactionsSaleDetailPath);
            //create report data

            List<MasterProductCategory> cbProCatData = new List<MasterProductCategory>() ;
            List<MasterCustomer> cbCusData = new List<MasterCustomer>();
            List<MasterSalePerson> cbSalePersonData = new List<MasterSalePerson>();
            //add item view all
            cbProCatData.Add(new MasterProductCategory {categoryCode ="",categoryName="All" });
            cbCusData.Add(new MasterCustomer {customerCode="",customerName="All" });
            cbSalePersonData.Add(new MasterSalePerson {salePersonCode ="",salePersonName="All" });
            //clone data 
            cbProCatData.AddRange(masterProductCategories);
            cbCusData.AddRange(masterCustomers);
            cbSalePersonData.AddRange(masterSalePerson); 
            //set combobox data   
            cbProductCate.DataSource = cbProCatData;
            cbProductCate.DisplayMember = "categoryName";
            cbProductCate.ValueMember = "categoryCode";

            cbCustomer.DataSource = cbCusData;
            cbCustomer.DisplayMember = "customerName";
            cbCustomer.ValueMember = "customerCode";

            cbSalePerson.DataSource = cbSalePersonData;
            cbSalePerson.DisplayMember = "salePersonName";
            cbSalePerson.ValueMember = "salePersonCode";

            reloadReport();
           
        }

        private void reloadReport()
        { 
            report.SetDataSource(createReportData());
            crystalReportViewer1.ReportSource = report;

            //CrystalReportCASE1 cr = new CrystalReportCASE1();
            //crystalReportViewer1.ReportSource = cr;
            //cr.SetDataSource(createReportData());
        }

        private List<ReportSale> createReportData()
        {
            List<ReportSale> reportData = (from hd in transHD
                                           join dt in transDT on hd.docno equals dt.docno
                                           join pro in masterProducts on dt.produCode equals pro.productCode
                                           join cus in masterCustomers on hd.customerCode equals cus.customerCode
                                           join salP in masterSalePerson on hd.salePersonCode equals salP.salePersonCode
                                           join proCat in masterProductCategories on pro.categoryCode equals proCat.categoryCode
                                           where hd.saleDate >= dpDateFrom.Value.Date && hd.saleDate <= dpDateTo.Value.Date &&
                                           cus.customerCode.Contains(cbCustomer.SelectedValue.ToString()) &&
                                           proCat.categoryCode.Contains(cbProductCate.SelectedValue.ToString()) &&
                                           salP.salePersonCode.Contains(cbSalePerson.SelectedValue.ToString())
                                           select new ReportSale
                                           {
                                               docno = hd.docno,
                                               customerCode = cus.customerCode,
                                               customerName = cus.customerName,
                                               saleDate = hd.saleDate,
                                               productName = pro.productName,
                                               salePrice = pro.salePrice,
                                               salePersonCode = salP.salePersonCode,
                                               salePersonName = salP.salePersonName,
                                               productCode = pro.productCode

                                           }).ToList();
            return reportData;
        }

        private List<TransactionsSaleHeader> ReadTransactionsSaleHeaderExcelFile(string filePath)
        {
            List<TransactionsSaleHeader> list = new List<TransactionsSaleHeader>();
            TransactionsSaleHeader item;
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
            for (int a = 2; a <= rw; a++) {
                item = new TransactionsSaleHeader();
                item.docno= (string)(range.Cells[a, 1] as Range).Value2.ToString();
                item.saleDate= Convert.ToDateTime((range.Cells[a, 2] as Range).Value2.ToString());
                item.customerCode = (string)(range.Cells[a, 3] as Range).Value2.ToString();
                item.salePersonCode = (string)(range.Cells[a, 4] as Range).Value2.ToString();
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

        private void BtnReloadReport_Click(object sender, EventArgs e)
        {
            reloadReport();
        }

        private List<TransactionsSaleDetail> ReadTransactionsSaleDetailExcelFile(string filePath)
        {
            List<TransactionsSaleDetail> list = new List<TransactionsSaleDetail>();
            TransactionsSaleDetail item;
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
            for (int a = 2; a <= rw; a++) {
                item = new TransactionsSaleDetail();
                item.docno= (string)(range.Cells[a, 1] as Range).Value2.ToString();
                item.produCode= (string)(range.Cells[a, 2] as Range).Value2.ToString(); 
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
        private List<MasterProducts> ReadMasterProductExcelFile(string filePath)
        {
            List<MasterProducts> list = new List<MasterProducts>();
            MasterProducts item;
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
            for (int a = 2; a <= rw; a++) {
                item = new MasterProducts();
                item.productCode= (string)(range.Cells[a, 1] as Range).Value2.ToString();
                item.productName= (string)(range.Cells[a, 2] as Range).Value2.ToString();
                item.salePrice = Convert.ToDouble((range.Cells[a, 3] as Range).Value2);
                item.categoryCode = (string)(range.Cells[a, 4] as Range).Value2.ToString();
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
        
        private List<MasterProductCategory> ReadMasterProductCategoryExcelFile(string filePath)
        {
            List<MasterProductCategory> list = new List<MasterProductCategory>();
            MasterProductCategory item;
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
            for (int a = 2; a <= rw; a++) {
                item = new MasterProductCategory();
                item.categoryCode= (string)(range.Cells[a, 1] as Range).Value2.ToString();
                item.categoryName= (string)(range.Cells[a, 2] as Range).Value2.ToString(); 
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
        
        private List<MasterCustomer> ReadMasterCustomerExcelFile(string filePath)
        {
            List<MasterCustomer> list = new List<MasterCustomer>();
            MasterCustomer item;
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
            for (int a = 2; a <= rw; a++) {
                item = new MasterCustomer();
                item.customerCode= (string)(range.Cells[a, 1] as Range).Value2.ToString();
                item.customerName= (string)(range.Cells[a, 2] as Range).Value2.ToString(); 
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
        
        private List<MasterSalePerson> ReadMasterSalePersonExcelFile(string filePath)
        {
            List<MasterSalePerson> list = new List<MasterSalePerson>();
            MasterSalePerson item;
            Excel.Application xlApp;
            Workbook xlWorkBook;
            Worksheet xlWorkSheet;
            Range range;
            int rCnt;
            int rw = 0;
            int cl = 0;

            xlApp = new Excel.Application();
            //open the excel
            xlWorkBook = xlApp.Workbooks.Open(filePath);
            //get the first sheet of the excel
            xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);
            range = xlWorkSheet.UsedRange;
            // get the total row count
            rw = range.Rows.Count;
            for (int a = 2; a <= rw; a++) {
                item = new MasterSalePerson();
                item.salePersonCode= (string)(range.Cells[a, 1] as Range).Value2.ToString();
                item.salePersonName= (string)(range.Cells[a, 2] as Range).Value2.ToString(); 
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

        public void DisplayInExcel(List<MasterProducts> listProduct)
        {
            var excelApp = new Excel.Application();
            // Make the object visible.
            excelApp.Visible = true;

            // Create a new, empty workbook and add it to the collection returned 
            // by property Workbooks. The new workbook becomes the active workbook.
            // Add has an optional parameter for specifying a praticular template. 
            // Because no argument is sent in this example, Add creates a new workbook. 
            excelApp.Workbooks.Add();

            // This example uses a single workSheet. The explicit type casting is
            // removed in a later procedure.
            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
            // Establish column headings in cells A1 and B1.
            workSheet.Cells[1, "A"] = "productCode";
            workSheet.Cells[1, "B"] = "productName";

            var row = 1;
            foreach (var product in listProduct)
            {
                row++;
                workSheet.Cells[row, "A"] = product.productCode;
                workSheet.Cells[row, "B"] = product.productName;
            }
            workSheet.Columns[1].AutoFit();
            workSheet.Columns[2].AutoFit();
        }
    }
}
