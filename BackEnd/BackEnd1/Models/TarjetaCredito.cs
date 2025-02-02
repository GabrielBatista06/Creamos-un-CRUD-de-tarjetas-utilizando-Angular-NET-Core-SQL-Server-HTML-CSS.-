﻿using System.ComponentModel.DataAnnotations;

namespace BackEnd1.Models
{
    public class TarjetaCredito
    {
        public int Id { get; set; }

        [Required]
        public string Titular { get; set; }
        [Required]
        public string NumeroTarjeta { get; set; }
        [Required]
        public string FechaExp { get; set; }
        [Required]
        public string CVV { get; set; }
        
    }
}
