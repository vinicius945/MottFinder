using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MottFinder.Domain.Entities
{
    [Table("TB_CAMERA")]
    public class Camera
    {
        [Key]
        [Column("ID_CAMERA")]
        public int Id { get; set; }

        [Column("DS_POSICAO", TypeName = "VARCHAR2(100)")]
        public string Posicao { get; set; } = string.Empty;

        [Column("ID_MOTO")]
        public int IdMoto { get; set; }

    }
}
