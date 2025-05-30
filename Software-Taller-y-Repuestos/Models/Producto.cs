using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Software_Taller_y_Repuestos.Models;

public partial class Producto
{
    public int ProductoId { get; set; }
    public string Nombre { get; set; } = null!;
    public string Codigo { get; set; } = null!;
    public string? CategoriaNombre { get; set; }
    public int CategoriaId { get; set; }
    public string? Descripcion { get; set; }
    public int Cantidad { get; set; }
    [Column(TypeName = "decimal(18,2)")]
    public decimal PrecioCompra { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal PrecioVenta { get; set; }
    public string? Marca { get; set; }
    public string? Imagen { get; set; }
    [Required]
    public bool Activo { get; set; } = true;
    public virtual Categoria? Categoria { get; set; } = null!;
    public virtual ICollection<DetalleFactura> DetallesFacturas { get; set; } = new List<DetalleFactura>();
    public virtual ICollection<ModelosAuto> Modelos { get; set; } = new List<ModelosAuto>();
}
