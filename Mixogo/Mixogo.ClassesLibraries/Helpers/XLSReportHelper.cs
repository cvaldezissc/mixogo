using Mixogo.ClassesLibraries.Constants;
using Mixogo.ClassesLibraries.Models;
using Newtonsoft.Json;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Mixogo.ClassesLibraries.Helpers
{

    public class XLSReportHelper
    {
        public int StartingRowIndex { get; set; }
        ExcelPackage excelPackage;
        ExcelWorksheet wsSheet1;

        public XLSReportHelper()
        {
            StartingRowIndex = 2;
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
                //wsSheet1.Cells[1, 1, 100, 100].AutoFitColumns();

                var headers = BaseConstants.GetExcelFormatColumnTitles();
                for (int i = 0; i < headers.Count; i++)
                {
                    using (var headerRow = wsSheet1.Cells[1, i + 1])
                    {
                        headerRow.Value = headers[i];
                        headerRow.Style.Font.Size = 12;
                        headerRow.Style.Font.Bold = true;
                        headerRow.Style.Font.Italic = true;
                        
                    }
                }
                wsSheet1.Cells[wsSheet1.Dimension.Address].AutoFilter = true;
                wsSheet1.Cells[wsSheet1.Dimension.Address].AutoFitColumns();
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


        public bool AddDocumentContent(string destinationExcelFile, string[] xmlPaths)
        {
            bool completed = false;
            try
            {
                var counter = 0;
                for (int i = 0; i < xmlPaths.Length; i++)
                {
                    counter = i+1;
                    var fileHelper = new FileManagementHelper();
                    FileInfo file = new FileInfo(string.Format(@"{0}", destinationExcelFile));
                        using (ExcelPackage excelPackage2 = new ExcelPackage(file))
                        {
                            ExcelWorkbook excelWorkBook = excelPackage2.Workbook;
                            var excelWorksheet = excelWorkBook.Worksheets[1];

                            var currentXMLDoc = new XmlDocument();
                            currentXMLDoc.LoadXml(fileHelper.GetFileContent(xmlPaths[i]));
                            string jsonText = "["+JsonConvert.SerializeXmlNode(currentXMLDoc)+"]";
                            string newText = string.Join("", jsonText.Split('@','?', ';', '\''));


                            var comprobantes = JsonConvert.DeserializeObject<List<Invoice>>(newText);
                            //var rowIndex = StartingRowIndex + i;
                            var fecha = comprobantes[i].Comprobante.Fecha;


                        //COUNT (1)
                        excelWorksheet.Cells[2, 1].Value = counter.ToString();

                        //FECHA (2)
                        excelWorksheet.Cells[2, 2].Value = comprobantes[i].Comprobante.Fecha.ToString();

                        //TIPO (3)
                        excelWorksheet.Cells[2, 3].Value = comprobantes[i].Comprobante.TipoDeComprobante.ToString();

                        //RFC_REC (4)
                        excelWorksheet.Cells[2, 4].Value = comprobantes[i].Comprobante.Receptor.Rfc.ToString();

                        //RECEPTOR (5)
                        excelWorksheet.Cells[2, 5].Value = comprobantes[i].Comprobante.Receptor.Nombre.ToString();

                        //RFC_EMI(6)
                        excelWorksheet.Cells[2, 6].Value = comprobantes[i].Comprobante.Emisor.Rfc.ToString();

                        //EMISOR(7)
                        excelWorksheet.Cells[2, 7].Value = comprobantes[i].Comprobante.Emisor.Nombre.ToString();

                        //SERIE (8)
                        excelWorksheet.Cells[2, 8].Value = comprobantes[i].Comprobante.Serie.ToString();

                        //FOLIO (9)
                        excelWorksheet.Cells[2, 9].Value = comprobantes[i].Comprobante.Folio.ToString();

                        //UUID (10)
                        excelWorksheet.Cells[2, 10].Value = comprobantes[i].Comprobante.Complemento.TimbreFiscalDigital.UUID.ToString();

                        //METODOPAGO (11)
                        excelWorksheet.Cells[2, 11].Value = comprobantes[i].Comprobante.MetodoPago.ToString();

                        //NUMCTAPAGO (12)
                        //excelWorksheet.Cells[2, 12].Value = comprobante[i].Comprobante..ToString();

                        //FORMAPAGO (13)
                        excelWorksheet.Cells[2, 13].Value = comprobantes[i].Comprobante.FormaPago.ToString();

                        //MONEDA (14)
                        excelWorksheet.Cells[2, 14].Value = comprobantes[i].Comprobante.Moneda.ToString();

                        //TIPOCAMBIO (15)
                        if (comprobantes[i].Comprobante.Moneda.ToString() != "MXN")
                        {
                            excelWorksheet.Cells[2, 15].Value = 19.13;
                        }
                        else
                        {
                            excelWorksheet.Cells[2, 15].Value = 1;
                        }

                        //SUBTOTAL (16)
                        excelWorksheet.Cells[2, 16].Value = comprobantes[i].Comprobante.SubTotal.ToString();

                        //IMPUESTOSTRAS (17)
                        excelWorksheet.Cells[2, 17].Value = "0";

                        //IMPUESTOSTRASIVA (18)
                        excelWorksheet.Cells[2, 18].Value = "0";

                        //IMPUESTOSTRASIEPS (19)
                        excelWorksheet.Cells[2, 19].Value = "0";

                        //IMPUESTOSRETE (20)
                        excelWorksheet.Cells[2, 20].Value = "0";

                        //IMPIUESTOSRETIVA (21)
                        excelWorksheet.Cells[2, 21].Value = "0";

                        //IMPUESTOSRETIEPS (22)
                        excelWorksheet.Cells[2, 22].Value = "0";

                        //DESCUENTOS (23)
                        excelWorksheet.Cells[2, 23].Value = comprobantes[i].Comprobante.Descuento.ToString();

                        //TOTAL (24)
                        excelWorksheet.Cells[2, 24].Value = comprobantes[i].Comprobante.Total.ToString();

                        //CONCEPTOS (25)
                        excelWorksheet.Cells[2, 25].Value = getConeptosString(comprobantes[i].Comprobante.Conceptos);

                        //ESTADO (26)
                        excelWorksheet.Cells[2, 26].Value = "VIGENTE";

                        

                        excelPackage2.Save();
                        completed = true;
                        }
                    }
          
            }
            catch (Exception ex)
            {
                completed = false;
                throw new Exception(string.Format(BaseConstants.ERROR_ADD_DOCUMENT_CONTENT, ex));
            }

            return completed;
        }


        public string getConeptosString(CfdiConceptos conceptsList)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < conceptsList.Conceptos.Length; i++)
            {
                sb.Append(conceptsList.Conceptos[i].Descripcion);
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
