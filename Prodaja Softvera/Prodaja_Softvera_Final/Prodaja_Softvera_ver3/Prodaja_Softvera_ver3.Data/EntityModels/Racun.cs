﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Prodaja_Softvera_ver3.Data.EntityModels
{
    public class Racun
    {
        public int RacunID { get; set; }
        public DateTime Datum { get; set; }
        public double Cijena { get; set; }
        public int Kolicina { get; set; }

    }
}
