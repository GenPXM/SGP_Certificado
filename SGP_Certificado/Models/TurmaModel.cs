namespace SGP_Certificado.Models
{
    public class TurmaModel
    {
        public int Id { get; set; }
        public string Nome_Curso { get; set; }
        public string Nome_Professor { get; set; }
        public string Cidade { get; set; }
        public DateTime Horario_Inicio { get; set; }
        public DateTime Horario_Fim { get; set; }
        public string Empresa { get; set; }

    }
}
