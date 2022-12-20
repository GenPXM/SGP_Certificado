using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SGP_Certificado.Data;
using SGP_Certificado.Models;
using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEntityFrameworkSqlServer();
builder.Services.AddDbContext<ApplicationDbContext>();
    
        
builder.Services.AddScoped<TurmaModel>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

//public class UserRepository
//{
   // public static List<TurmaModel> Turmas { get; set; }
   // public static void Add(TurmaModel turma)
    //{
      //  if (Turmas == null)
          //  Turmas = new List<TurmaModel>(); 
      //  Turmas.Add(turma);  
    //}
   // public static TurmaModel GetBy(string nome_professor)
   // {
  //      return Turmas.FirstOrDefault(p => p.Nome_Curso == nome_professor);
   // }
    //public static void Remove(TurmaModel turma)
    //{
     //   Turmas.Remove(turma);
   // }
//}

    

