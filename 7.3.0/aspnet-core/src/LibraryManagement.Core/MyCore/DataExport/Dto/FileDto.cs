using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.MyCore.DataExport.Dto
{
    public class FileDto
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public double FileSize { get; set; }
        public string ServerPath { get; set; }
    }


    public class FileBase64Dto
    {
        public string FileName { get; set; }
        public string Base64 { get; set; }
        public string FileType { get; set; }
    }
}
