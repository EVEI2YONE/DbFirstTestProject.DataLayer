using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DbFirstTestProject.DataLayer.Entities
{
    [PrimaryKey(nameof(Col1_PK))]
    public class Table2
    {
        public Table2()
        {
            Table4 = new HashSet<Table4>();
        }

        public int Col1_PK { get; set; }
        public long Col2_FK { get; set; }
        public string? Col3_Value { get; set; }
        public string? Col4_Extra { get; set; }
        public int Col5_Extra { get; set; }

        public virtual Table1 Table1 { get; set; }
        public virtual ICollection<Table3> Table3 { get; set; }
        public virtual ICollection<Table4> Table4 { get; set; }
    }
}
