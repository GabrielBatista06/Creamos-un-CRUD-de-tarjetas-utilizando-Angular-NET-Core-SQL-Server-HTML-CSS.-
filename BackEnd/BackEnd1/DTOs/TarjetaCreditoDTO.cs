﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd1.DTOs
{
    public class TarjetaCreditoDTO
    {
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
