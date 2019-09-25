using OfficeOpenXml;
using System.IO;
using System;
using System.Xml;
using Mixogo.ClassesLibraries.Constants;
using Newtonsoft.Json;

namespace Mixogo.ClassesLibraries.Helpers
{
    public class XLSReportHelper
    {
        ExcelPackage excelPackage;
        ExcelWorksheet wsSheet1;

        public XLSReportHelper()
        {

        }

        public bool ConfigureDocumentTemplate(string fullDestinationPath)
        {
            try
            {
                excelPackage = new ExcelPackage();
                excelPackage.Workbook.Properties.Author = "Projects RSCV";
                excelPackage.Workbook.Properties.Title = "Generated Report";
                excelPackage.Workbook.Properties.Subject = "Generated with EPPlus";
                excelPackage.Workbook.Properties.Created = DateTime.Now;
                wsSheet1 = excelPackage.Workbook.Worksheets.Add(BaseConstants.SHEET1_DEFAULT_NAME);


                var headers = BaseConstants.GetExcelFormatColumnTitles();
                for (int i = 0; i < headers.Count; i++)
                {
                    using (var headerRow = wsSheet1.Cells[1, i + 1])
                    {
                        headerRow.Value = headers[i];
                        headerRow.Style.Font.Size = 12;
                        headerRow.Style.Font.Bold = false;
                        headerRow.Style.Font.Italic = true;
                        headerRow.AutoFitColumns();
                    }
                }
                wsSheet1.Protection.IsProtected = false;
                wsSheet1.Protection.AllowSelectLockedCells = false;
                excelPackage.SaveAs(new FileInfo(string.Format(@"{0}", fullDestinationPath)));
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format(BaseConstants.ERROR_CONFIGURE_DOC_TEMPLATE, ex.Message));
            }
            

        }


        public void AddDocumentContent(string destinationExcelFile, string[] xmlPaths)
        {
            try
            {
                for (int i = 0; i < xmlPaths.Length; i++)
                {
                    var fileHelper = new FileManagementHelper();
                    FileInfo file = new FileInfo(string.Format(@"{0}", destinationExcelFile));
                        using (ExcelPackage excelPackage2 = new ExcelPackage(file))
                        {
                            ExcelWorkbook excelWorkBook = excelPackage2.Workbook;
                            var excelWorksheet = excelWorkBook.Worksheets[1];

                            var currentXMLDoc = new XmlDocument();
                            currentXMLDoc.LoadXml(fileHelper.GetFileContent(xmlPaths[i]));
                            string jsonText = JsonConvert.SerializeXmlNode(currentXMLDoc);
                            //excelWorksheet.Cells[2, i+1].Value = fileHelper.GetFileContent(xmlPaths[i]);
                            //excelWorksheet.Cells[3, i+1].Value = fileHelper.GetFileContent(xmlPaths[i]);
                            //excelWorksheet.Cells[4, i+1].Value = fileHelper.GetFileContent(xmlPaths[i]);

                        excelPackage2.Save();
                        }

                    }
           
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format(BaseConstants.ERROR_ADD_DOCUMENT_CONTENT, ex));
            }
        }
    }
}
