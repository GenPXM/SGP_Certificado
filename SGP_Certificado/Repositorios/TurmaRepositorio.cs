using SGP_Certificado.Models;

namespace SGP_Certificado.Repositoios
{
    public interface TurmaRepositorio
    {
        Task<List<TurmaModel>> BuscarTodasAsTurmas();
        Task<TurmaModel> BuscarPorId(int id);
        Task<TurmaModel> CadastrarTurma(TurmaModel turma);
        Task<TurmaModel> Atualizar(TurmaModel turma, int id);
        Task<bool> Apagar(int id);
    }
}
