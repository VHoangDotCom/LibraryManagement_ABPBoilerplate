using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.MyCore.DataExport.Dto
{
    public class ExcelGroupData<Data, GroupRow>
        where Data : class
        where GroupRow : class
    {
        public IList<Data> DataRow { get; set; }
        public GroupRow DataGroupRow { get; set; }
        public Data SumRow { get; set; }
    }
}
