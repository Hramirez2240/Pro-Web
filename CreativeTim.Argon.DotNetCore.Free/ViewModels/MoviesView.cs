using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using GestionDeVehiculos.Models;
using System.ComponentModel.DataAnnotations;

namespace GestionDeVehiculos.ViewModels
{
    public class MoviesView
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
       
        public string Url { get; set; }
        public string Sipnosis { get; set; }

        public IFormFile  Foto { get; set; }


        

        public string FotoPath { get; set; }
    }
}
