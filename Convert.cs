using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Xls;
using Aspose.Cells;

namespace FirstProject
{
    class Convert
    {
        public static void ConvertToPDF(string fcsv,string pdfName,string sep=";")
        {
            Spire.Xls.Workbook wb = new Spire.Xls.Workbook();
            
            wb.LoadFromFile(fcsv, sep, 1, 1,ExcelVersion.Version2007,Encoding.GetEncoding(1251));
            
            wb.ConverterSetting.SheetFitToPage = true;

            Spire.Xls.Worksheet sheet = wb.Worksheets[0];

            for (int i = 1; i < sheet.Columns.Length; i++)

            {
                sheet.AutoFitColumn(i);
            }
            
            sheet.SaveToPdf(pdfName);
        }
        public static void ConvertToXML(string fcsv,string fxml, char sep=';')
        {
            TxtLoadOptions txtLoadOptions = new TxtLoadOptions(Aspose.Cells.LoadFormat.Csv);

            txtLoadOptions.Encoding = System.Text.Encoding.UTF8;

            txtLoadOptions.Separator = sep;

            var book = new Aspose.Cells.Workbook(fcsv, txtLoadOptions);

            book.Save(fxml, Aspose.Cells.SaveFormat.Auto);
        }
    }
}
