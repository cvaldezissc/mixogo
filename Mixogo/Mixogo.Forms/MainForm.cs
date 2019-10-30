using System;
using System.Windows.Forms;
using System.IO;
using Mixogo.ClassesLibraries.Helpers;
using Mixogo.ClassesLibraries.Constants;
 

namespace Mixogo.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string ContainerFolder { get; set; }
        public string[] XMLFilesPaths { get; set; }
        public string DestinationExcelFilePath { get; set; }
        public XLSReportHelper ExcelHelper { get; set; }

        //Step 1: Select the Folder where there are XML files
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ChooseFolder();

        }

        public void ChooseFolder()
        {
            var fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                ContainerFolder = fd.SelectedPath;
                textBox1.Text = ContainerFolder;

                XMLFilesPaths = Directory.GetFiles(ContainerFolder, BaseConstants.XML_EXTENSION_POSFIX);
                foreach (var item in XMLFilesPaths)
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        //step 3: Add content to the Excel file
        private void BtnExport_Click(object sender, EventArgs e)
        {
            ExcelHelper = new XLSReportHelper();
            if(ExcelHelper.AddDocumentContent(DestinationExcelFilePath, XMLFilesPaths))
            {
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("There was an error");
            }
            
            


        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            ExcelHelper = new XLSReportHelper();
            ExcelHelper.ConfigureDocumentTemplate(DestinationExcelFilePath);
        }


        //Step 2: Creates the document
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog
            {
                Title = BaseConstants.SFD_TITLE,
                Filter = BaseConstants.EXCEL_FILES_FILTER_SFD,
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                DestinationExcelFilePath = sfd.FileName;
                ExcelHelper = new XLSReportHelper();
                ExcelHelper.ConfigureDocumentTemplate(DestinationExcelFilePath);
            }

        }
    }
}
