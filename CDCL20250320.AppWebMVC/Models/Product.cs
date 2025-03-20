using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CDCL20250320.AppWebMVC.Models;

public partial class Product
{
    public int ProductId { get; set; }
    [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
    [Display(Name = "Nombre del producto")]
    public string ProductName { get; set; } = null!;
    [Required(ErrorMessage = "La descripción es obligatorio.")]
    [Display(Name = "Descripción")]
    public string? Description { get; set; }
    [Required(ErrorMessage = "El precio es obligatorio.")]
    [Display(Name = "Precio")]
    public decimal Price { get; set; }
    [Required(ErrorMessage = "Debe seleccionar una bodega.")]
    [Display(Name = "Bodega")]
    public int? WarehouseId { get; set; }
    [Required(ErrorMessage = "Debe seleccionar una marca.")]
    [Display(Name = "Marca")]
    public int? BrandId { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}
