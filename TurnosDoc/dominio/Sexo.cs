﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Sexo
    {
        public int Id { get; set; }
        public string Sexualidad { get; set; }
        public override string ToString()
        {
            return Sexualidad;
        }
    }
}
