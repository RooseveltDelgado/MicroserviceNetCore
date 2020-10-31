using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClientApi.Models
{

    // [Table("client")]
    public partial class Client
    {
        // [Key]
        // [Column(Order = 0)]
        public int Id { get; set; }

        // [Column("nombre", Order = 2, TypeName = "nvarchar(100)")]
        public string Nombre { get; set; }

        // [Column("apellidos", Order = 3, TypeName = "nvarchar(100)")]
        public string Apellidos { get; set; }

        // [Column("nro_documento", Order = 4, TypeName = "nvarchar(20)")]
        public string Documento { get; set; }

        // [Column("direccion", Order = 5, TypeName = "nvarchar(150)")]
        public string Direccion { get; set; }

        // [Column("telefono", Order = 6, TypeName = "nvarchar(12)")]
        public string Telefono { get; set; }

        // [Column("email", Order = 7, TypeName = "nvarchar(50)")]
        public string Email { get; set; }
    }
}