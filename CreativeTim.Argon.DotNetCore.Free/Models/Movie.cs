using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GestionDeVehiculos.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Url { get; set; }
        public string Sipnosis { get; set; }
        public string Foto { get; set; }
    }
}
