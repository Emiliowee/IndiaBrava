using System.ComponentModel.DataAnnotations;

public class Producto
{
    [Key]
    public int IDProducto { get; set; }
    
    [Required(ErrorMessage = "El nombre es requerido")]
    public string? Nombre { get; set; }
    
    public string? UnidadMedida { get; set; }
    
    [Required(ErrorMessage = "El contenido neto es requerido")]
    public decimal ContenidoNeto { get; set; }
    
    [Required(ErrorMessage = "El precio es requerido")]
    public decimal Precio { get; set; }
    
    [Required(ErrorMessage = "El stock es requerido")]
    public int Stock { get; set; }
    
    public string? Imagen { get; set; }
}
