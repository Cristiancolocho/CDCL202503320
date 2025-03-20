using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CDCL20250320.AppWebMVC.Models;

public partial class Warehouse
{
    public int WarehouseId { get; set; }
    [Required(ErrorMessage = "El nombre de la bodega es obligatorio.")]
    [Display(Name = "Bodega")]
    public string WarehouseName { get; set; } = null!;
    [Required(ErrorMessage = "Debe insertar una nota.")]
    [Display(Name = "Notas")]
    public string? Notes { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
