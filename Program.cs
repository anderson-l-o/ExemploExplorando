using System.Globalization;
using System.Net.NetworkInformation;
using ExemploExplorando.Models;



//if ternário

int numero = 20;
bool ehPar = false;

ehPar = numero % 2 == 0;
Console.WriteLine($"o número {numero} é " + (ehPar ? "par": "ímpar"));

// if (numero % 2==0)
// {
    
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é impar");
// }











// Pessoa p1 = new Pessoa("Anderson", "Oliveira");

// (string nome, string sobrenome) = p1;
// Console.WriteLine($"{nome} {sobrenome}");


// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, LinhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso){
//     //Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
//     foreach(string linha in LinhasArquivo){
//         Console.WriteLine(linha);
//     }
// }
// else{
//     Console.WriteLine("Não foi possível ler o arquivo");
// }



// (int, string, string, decimal)tupla = (1,"Anderson","Oliveira", 1.67M);
// ValueTuple<int, string, string, decimal> outroExemploTupla = (1,"Anderson","Oliveira", 1.67M);
// var outroExemploTuplaCreate = Tuple.Create(1,"Anderson","Oliveira", 1.67M);

// Console.WriteLine($"Id:{tupla.Item1}");
// Console.WriteLine($"Nome:{tupla.Item2}");
// Console.WriteLine($"Sobrenome:{tupla.Item3}");
// Console.WriteLine($"Altura:{tupla.Item4}");




// string dataString = "2023-04-32 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, 
//                         "yyyy-MM-dd HH:mm", 
//                         CultureInfo.InvariantCulture, 
//                         DateTimeStyles.None, out DateTime data);
// if(sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
    
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }


// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("C8"));

// double porcetagem = .3421;

// Console.WriteLine(porcetagem.ToString("P"));

// int numero = 123456;

// Console.WriteLine(numero.ToString("##-##-##"));


// string numero1 =   "10";
// string numeor2 = "20";

// string resultado = numero1 + numeor2;

// Console.WriteLine(resultado);

// Pessoa p1 = new Pessoa();
// p1.Nome = "Anderson";
// p1.Sobrenome = "Oliveira";
// p1.Idade = 33;
// p1.Apresentar();

// Pessoa p1 = new Pessoa(nome:"Anderson", sobrenome:"Oliveira");
// Pessoa p2 = new Pessoa(nome:"Luiz", sobrenome:"Oliveira");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();
