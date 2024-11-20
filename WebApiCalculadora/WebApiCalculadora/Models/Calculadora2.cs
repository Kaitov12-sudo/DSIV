namespace WebApiCalculadora.Models
{
    public class Calculadora2
    {
        public int Id { get; set; }
        public decimal Numero1 { get; set; }
        public string Operacion { get; set; } = string.Empty;

        public decimal Numero2 { get; set; }
        public decimal Resultado { get; set; }
        public DateTime Fecha { get; set; }
    }
}
