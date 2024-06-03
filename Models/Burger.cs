using System.ComponentModel.DataAnnotations;

namespace NicolasCasamenSolucion.Models
{
    public class Burger
    {
        [Key]
        public int BurgerId { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }

        [VerificarRango]
        public decimal Precio { get; set; }

        public List<Promo>? Promo { get; set; }
    }

    public class VerificarRango : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if ((decimal)value < 1 || (decimal)value > 20)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
