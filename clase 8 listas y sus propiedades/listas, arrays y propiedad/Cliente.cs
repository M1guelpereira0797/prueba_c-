﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas__arrays_y_propiedad
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public long ID { get; set; }
        public short Edad { get; set; }

        public Cliente(string nombre, string descripcion, long iD, short edad)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.ID = iD;
            this.Edad = edad;
        }
        public override bool Equals ( object? obj)

        {
            Cliente cliente = (Cliente)obj;
            return this.ID.Equals(cliente.ID);
        }
    }
}
