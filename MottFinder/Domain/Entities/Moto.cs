using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MottFinder.Domain.Entities
{
    [Table("TB_MOTO")]
    public class Moto
    {
        [Key]
        [Column("ID_MOTO")]
        public int Id { get; set; }

        [Column("NM_MODELO", TypeName = "VARCHAR2(100)")]
        public string Modelo { get; set; } = string.Empty;

        [Column("DS_LOCALIZACAO", TypeName = "VARCHAR2(100)")]
        public string Localizacao { get; set; } = string.Empty;

        [Column("ST_MOTO", TypeName = "VARCHAR2(20)")]
        public string Status { get; set; } = "Pronto";
    }
}
