using System;
using System.Collections.Generic;

namespace BackEnd.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Carritos = new HashSet<Carrito>();
            Venta = new HashSet<Ventum>();
        }

        public int IdCliente { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Correo { get; set; }
        public string? Clave { get; set; }
        public bool? Reestablecer { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<Carrito> Carritos { get; set; }
        public virtual ICollection<Ventum> Venta { get; set; }
    }
}
