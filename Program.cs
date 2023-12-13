using System.Net.NetworkInformation;
using ExemploExplorando.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Anderson";
// p1.Sobrenome = "Oliveira";
// p1.Idade = 33;
// p1.Apresentar();

Pessoa p1 = new Pessoa(nome:"Anderson", sobrenome:"Oliveira");
Pessoa p2 = new Pessoa(nome:"Luiz", sobrenome:"Oliveira");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
