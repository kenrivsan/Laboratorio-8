﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoArchivosJson
{
    class clsNotas
    {
        string nombre;
        List<int>notas;
        public string Nombre { get => nombre; set => nombre = value; }
        public List<int> Notas { get => notas; set => notas = value; }
    }
}
