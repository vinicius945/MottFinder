using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotFinder.Application.Dtos
{
    public class MotoDto
    {
        public string Modelo { get; set; } = string.Empty;
        public string Localizacao { get; set; } = string.Empty;
        public string Status { get; set; } = "Pronto";
    }
}
