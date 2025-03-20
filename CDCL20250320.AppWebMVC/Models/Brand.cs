using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CDCL20250320.AppWebMVC.Models;

public partial class Brand
{
    public int BrandId { get; set; }
    [Required(ErrorMessage = "El nombre de la marca es obligatorio.")]
    [Display(Name = "Marca")]
    public string BrandName { get; set; } = null!;
    [Required(ErrorMessage = "Debe seleccionar un pais.")]
    [Display(Name = "Pais")]
    public string? Country { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
