using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Xls;

namespace FirstProject
{
    class Convert
    {
        public static void ConvertToPDF(string fcsv,string pdfName)
        {
            Workbook wb = new Workbook();
            
            wb.LoadFromFile(fcsv, ";", 1, 1,ExcelVersion.Version2007,Encoding.GetEncoding(1251));
            
            wb.ConverterSetting.SheetFitToPage = true;
            
            Worksheet sheet = wb.Worksheets[0];
            
            for (int i = 1; i < sheet.Columns.Length; i++)
                
            {
                
                sheet.AutoFitColumn(i);
                
            }
            
            sheet.SaveToPdf(pdfName);

        }
    }
}
