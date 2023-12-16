namespace EmprestimoFilmes.Models
{
    public class EmprestimosModel
    {
        public int Id { get; set; }
        public string NomeFilmeEmprestimo { get; set; }
        public string NomeCliente { get; set; }
        public float Preco { get; set; }
        public DateTime DataEmprestimo { get; set; } = DateTime.Now;
    }
}
