﻿using System;
using System.Collections.Generic;

namespace BackEnd.Models
{
    public partial class Producto
    {
        public Producto()
        {
            Carritos = new HashSet<Carrito>();
            DetalleVenta = new HashSet<DetalleVentum>();
        }

        public int IdProducto { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int? IdMarca { get; set; }
        public int? IdCategoria { get; set; }
        public decimal? Precio { get; set; }
        public int? Stock { get; set; }
        public string? RutaImagen { get; set; }
        public string? NombreImagen { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual Categorium? IdCategoriaNavigation { get; set; }
        public virtual Marca? IdMarcaNavigation { get; set; }
        public virtual ICollection<Carrito> Carritos { get; set; }
        public virtual ICollection<DetalleVentum> DetalleVenta { get; set; }
    }
}
