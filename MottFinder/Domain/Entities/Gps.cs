using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MottFinder.Domain.Entities
{
    [Table("TB_GPS")]
    public class Gps
    {
        [Key]
        [Column("ID_GPS")]
        public int Id { get; set; }

        [Column("NR_LATITUDE", TypeName = "VARCHAR2(50)")]
        public string Latitude { get; set; } = string.Empty;

        [Column("NR_LONGITUDE", TypeName = "VARCHAR2(50)")]
        public string Longitude { get; set; } = string.Empty;

        [Column("ID_MOTO")]
        public int IdMoto { get; set; }
    }
}
