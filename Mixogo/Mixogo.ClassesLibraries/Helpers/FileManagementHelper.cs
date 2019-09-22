using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Mixogo.ClassesLibraries.Helpers
{
    public class FileManagementHelper
    {

        public string GetFileContent(string filePath)
        {
            return File.ReadAllText(filePath);
        }

    }
}
