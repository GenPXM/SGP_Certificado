using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using SGP_Certificado.Models;
using SGP_Certificado.Repositoios;
using Microsoft.AspNetCore.Mvc.Routing;

namespace SGP_Certificado.Controller
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase    
    {
        private readonly TurmaRepositorio  _turmarepositorio;
        public TurmaController(TurmaRepositorio turmarepositorio)
        {
            _turmarepositorio = turmarepositorio;
        }
        [HttpGet]
        public async Task<ActionResult<List<TurmaModel>>> BuscarAsTurmas()
        {
            List<TurmaModel> turmas = await _turmarepositorio.BuscarTodasAsTurmas();
            return Ok(turmas);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<TurmaModel>> BuscarPorId(int  id)
        {
            TurmaModel turma = await _turmarepositorio.BuscarPorId(id);
            return Ok(turma);
        }
        [HttpPost]
        public async Task<ActionResult<TurmaModel>> Cadastrar_Turma([FromBody] TurmaModel turmaModel)
        {
            TurmaModel turma = await _turmarepositorio.CadastrarTurma(turmaModel);
           return Ok(turma);

        }
        [HttpPut("{id}")]
        public async Task<ActionResult<TurmaModel>> Atualizar([FromBody] TurmaModel turmaModel, int id)
        {
            turmaModel.Id = id;
            TurmaModel turma = await _turmarepositorio.Atualizar(turmaModel,(id));
            return Ok(turma);

        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<TurmaModel>> Apagar(int id)

        {
            bool apagado = await _turmarepositorio.Apagar(id);
            return Ok(apagado);

        }
    }
    

    
}
