using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DbFirstTestProject.DataLayer.Entities
{
    [PrimaryKey(nameof(Col1_T1PKFK), nameof(Col2_T2PKFK), 
        nameof(Col3_T3PKFK_PKFK), nameof(Col4_T3PKFK_FK))]
    public class Table4
    {
        public long Col1_T1PKFK { get; set; }
        public int Col2_T2PKFK { get; set; }
        public long Col3_T3PKFK_PKFK { get; set; }
        public int Col4_T3PKFK_FK { get; set; }
        public string? Col5_Value { get; set; }
        public int? Col6_Extra { get; set; }
        public string? Col7_Extra { get; set; }

        public virtual Table1 Table1 { get; set; }
        public virtual Table2 Table2 { get; set; }
        public virtual Table3 Table3 { get; set; }
    }
}
