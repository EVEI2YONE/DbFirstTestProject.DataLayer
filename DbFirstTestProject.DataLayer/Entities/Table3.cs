using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DbFirstTestProject.DataLayer.Entities
{
    [PrimaryKey(nameof(Col1_PKFK), nameof(Col2_FK))]
    public class Table3
    {
        public Table3()
        {
            Table4 = new HashSet<Table4>();
        }

        public long Col1_PKFK { get; set; }
        public int Col2_FK { get; set; }
        public string Col3_Value { get; set; }
        public int? Col4_Extra { get; set; }
        public string? Col5_Extra { get; set; }

        public virtual Table1 Table1 { get; set; }
        public virtual Table2 Table2 { get; set; }
        public virtual ICollection<Table4> Table4 { get; set; }
    }
}
