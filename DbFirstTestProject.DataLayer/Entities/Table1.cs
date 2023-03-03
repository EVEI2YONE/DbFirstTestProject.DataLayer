using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DbFirstTestProject.DataLayer.Entities
{
    [PrimaryKey(nameof(Col1_PK))]
    public class Table1
    {
        public Table1()
        {
            Table2 = new HashSet<Table2>();
            Table3 = new HashSet<Table3>();
            Table4 = new HashSet<Table4>();
        }

        public long Col1_PK { get; set; }
        public string Col2 { get; set; }
        public int? Col3 { get; set; }
        public string Col4 { get; set; }

        public virtual ICollection<Table2> Table2 { get; set; }
        public virtual ICollection<Table3> Table3 { get; set; }
        public virtual ICollection<Table4> Table4 { get; set; }
    }
}
