using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using ALMACEN; 

namespace ALMACEN.Models
{
    public partial class Verdura
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Color { get; set; }
        public int? Precio { get; set; }

        ALMACENContext bd = new ALMACENContext();

        public List<Verdura> Readall()
        {
            return this.bd.Verduras.Select(p => new Verdura()
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Color = p.Color,
                Precio = p.Precio

            }).ToList();

        }

    }
}
