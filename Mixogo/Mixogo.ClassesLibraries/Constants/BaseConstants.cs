using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mixogo.ClassesLibraries.Constants
{
    public static class BaseConstants
    {
        public static readonly string SHEET1_DEFAULT_NAME = "Resumen";
        public static readonly string INVOICE_VERSION_TO_READ = "v3.3";
        public static readonly string XML_EXTENSION_POSFIX = "*.xml";
        public static readonly string EXCEL_FILES_FILTER_SFD = "Excel 2003 File|*.xls|Excel 2007,2010,2013,2016,2019 File|*.xlsx";
        public static readonly string SFD_TITLE = "Guardar archivo de Excel como...";
        public static readonly string SFD_DEFAULT_EXT = "XLSX";

        public static readonly string ERROR_ADD_DOCUMENT_CONTENT = "Error in XLSReportHelper.AddDocumentContent: {0}";
        public static readonly string ERROR_CONFIGURE_DOC_TEMPLATE = "Error in XLSReportHelper.ConfigureDocumentTemplate: {0}";
        public static List<string> GetExcelFormatColumnTitles()
        {
            return new List<string>()
            {/*
                "No.",
                "Fecha",	
                "TipoDocumento",	
                "RFC Receptor",
                "Receptor",
                "RFC Emisor",	
                "Emisor",	
                "Serie",	
                "Moneda",
                "tipoCambio",	
                "SubTotal",
                "ivaTrasladado",	
                "Descuento",	
                "Total",
                "Estado"
                */
                "COUNT",
                "FECHA",
                "TIPO",
                "RFC_REC",
                "RECEPTOR",
                "RFC_EMI",
                "EMISOR",
                "SERIE",
                "FOLIO",
                "UUID",
                "METODOPAGO",
                "NUMCTAPAGO",
                "FORMAPAGO",
                "MONEDA",
                "TIPOCAMBIO",
                "SUBTOTAL",
                "IMPUESTOSTRAS",
                "IMPUESTOSTRASIVA",
                "IMPUESTOSTRASIEPS",
                "IMPUESTOSRETE",
                "IMPUESTOSRETIVA",
                "IMPUESTOSRETIEPS",
                "DESCUENTOS",
                "TOTAL",
                "CONCEPTOS",
                "ESTADO"
            };
        }



    }
}
