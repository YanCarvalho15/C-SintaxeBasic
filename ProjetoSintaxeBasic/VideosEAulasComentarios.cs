// See https://aka.ms/new-console-template for more information
using System.Buffers;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello World!");
Console.WriteLine("Olá Mundo");
// tag ("comentário");

//var decimal tipo01DeVarial = "010101";
// var +atribuição+class = "Value";

//const string NumeroPi = "3.14";
Console.WriteLine("NumeroPi");

//Comentarios
Console.Write("Oi");
Console.Write("TudoBem?");
//Linha juntas

int idade = 17;
Console.WriteLine("Yan"+ idade + "Anos");
//Exemplo de informasção atribuida a um valor e determinada classe

Console.WriteLine(@"eae suave?
   tudobem?");
// Quando o comentario esta digitalizada diferente,pode ser utilizar "@" que possibilita a digitalização correta dele


//                          Operadores 


int valorUm = 10;
int valorDois = 5;

Console.WriteLine(valorUm + valorDois);
Console.WriteLine(valorUm - valorDois);
Console.WriteLine(valorUm * valorDois);
Console.WriteLine(valorUm / valorDois);
Console.WriteLine(valorUm % valorDois);

// Cada simbolo aritmetricos sao dado uma função ao "int"(var) como:
// + (soma) - (subtrai) *(multiplica) / (divide) %(Porcentagem)

float total;

total=(5+4)*9;
Console.WriteLine(total);

// Procedencia matematica = oque tiver dentro dos  parentes sera efetuado primeiro,sem o "( )" ia resolver
//num padão errado Ex: 5+4*9=40

float valorTUm =10;

Console.WriteLine(valorTUm += 1); // valor = valor +  1 (11) < base 
Console.WriteLine(valorTUm -= 2); // 11-2 = 9
Console.WriteLine(valorTUm *= 3); // 9x3= 27
Console.WriteLine(valorTUm /= 4); // 27 / 4 = 6,75
Console.WriteLine(valorTUm %= 5); // 6,75< 5% = 1,75

// com adição (Encremento) no  "valorMais++;" ele +1 ficando = 21.  Obs: Quanto mais  adição mais +1

float valorMais = 20;

valorMais++;
valorMais++;
Console.WriteLine(valorMais);

//Com a adição (Decremento) no "valorMais--;" ele -1 ficando 19.

//                                 Estrutura de Controle 

//if (condição)

int idadeMinima= 16;
int idadeDeClaudi= 15;

if (idadeDeClaudi >= idadeMinima)   //como a idade de Claudi e maior do que idade minima da variavel "int" permitira a demonstrção de tal comentarios
{
   Console.WriteLine("Acesso concedido");
}
else      //Se não ou falso
{
   Console.WriteLine("Acesso Negado");
}

//ternário

int idadeCris = 30;
int idadeArtur = 20;

Console.WriteLine(idadeCris > idadeArtur ? "Cris" : "Artur"); //Se for maior,repodera Cris e virce versa

//Switch / comando de seleção / Quando muitas opçoes 
int numeroDoMes = 4;   // selecionei a case,se for erada aparecerar a mensagem do default
string mes = " ";
switch (numeroDoMes)
{
   case 1:
   mes= "janeiro";
   break;

   case 2:
   mes="fevereiro";
   break;

   case 3:
   mes ="março";
   break;

   default:                      // se for selecionado a  int errada,aparecerar a mensagem do default
   mes = "mes invalido";
   break;                        //break; sera inserido a cada case concluida ou default no switch
}
Console.WriteLine(mes);

//Essa estrutura pode fazer com os simbolos aritmetricos 

// Estrutura de reptição 

//while   (el pergunta e depois faz)

int inicilização = 0;        // pergunta,se o falor igual 0,aparecera mensagem repetidamente do console
while (inicilização <= 3)  // enquanto ao contrario parecerar na ordem 
{
   Console.WriteLine("instrução de laço" + inicilização);   // ctrl + c para parar dotnet run
   inicilização++;
}

// Do while 

int inicialDo = 3;

do // faça      (faça e depois pergunta)
{
   Console.WriteLine("instrução inicial"+ inicialDo);
   inicialDo++;
} while (inicialDo <= 3);

// a diferença e que while e embaixo,faz e  depois pergunta

// for estrutura de repetição maus usadas quando for fazer algoritomo

for (int inicio = 0; inicio <= 10; inicio++)
{
   Console.WriteLine("inicio" + inicio);
}
// fala a lista de 0 a 10 , como tem ++ começa por 1

//                                           Arrays
                //Para armazenarmos um conjunto de elementos de um mesmo tipo de dado,Lista de numero,nomes...
                
int[ ] arrayinteiros = new int[4];      //  = new int [4] (tamanho)
arrayinteiros [0] = 32; // começa pelo 0,1,2,3,4...

// outra forma 

int[] arrayComValores = new int [4] { 23, 44, 55, 100 }; //{ conteudo da arrays vem aqui} = cada numero dentro e uma posição { 0 , 1 , 2, 3}
arrayComValores[3] = 200;   //Mudei o valor do 100 para = 200
Console.WriteLine(arrayComValores [3]); // dentro [] sera a posição ou indice que eu quero mostra seguinte a ordem

//Outra formas, existem varias formas de declarar um array

int[] numeros = { 10, 20, 30,};
Console.WriteLine(numeros[0]);

// declarar uma array de String.Lembrando que a String é um tipo de dado cujo valor é texto.

String[] nomes = { "Yan", "Isabel", "Everton" };
Console.WriteLine(nomes[2]);
Console.WriteLine(nomes[0]);

//Se  quiser mostrar todos é  fazer mais Console.WriteLine( nome[valor]); mais  tem outra forma:

 for (int itemDoArray = 0; itemDoArray < nomes.Length; itemDoArray++)
 {
   Console.WriteLine(nomes[itemDoArray]);
 }

 //                              Funções e bibliotecas      (Ajuda a moldenizar  e capsula as tarefas em uma unica estrutura)

static void imprimirTexto()
{
   Console.WriteLine("Fala Cria");
}

imprimirTexto();    // Estou chamando a função sem return e  sem parâmetro
 // "algum que é void" (não da retorno) oque da retorno é return
 
 //Com parâmetro
 static void imprimirNome(string nome)
 {
   Console.WriteLine(nome);
 }

 imprimirNome("Salgadinho");  //Chamei ela vou colocar o valor(nome)

 //Bibliotecas são coleçoes de funçoes  e metodos, comunidades escrevem essas bibliotecas externas ou internas
 //Posso conseguir no Github,Microsft,Nuggt.. 

 //using System.IO: não necessario, sopara versoes mais antigas

 Random dado =  new Random();
int lados = dado.Next(1, 7); // vou sortear de 1 a 7,mais o ultimo numero e excluido então se fosse colocar  1 a 10 precisaria colocar (1, 11);
Console.WriteLine(lados);    // utilizados muitos em jogos 

float numero = 81;
Console.WriteLine(Math.Sqrt(numero)); //Sqrt calcula a (Raiz Quadrada) Raiz de 81= 9

//Caminho do Arquivo 

String caminhoDoArquivo = @"C:\Users\Usuario\Documents\C# Senai Treino e isso mesmo\C#SintaxeBasic\ProjetoSintaxeBasic\obj\arquivo.txt";

// Instancia objeto do tipo StreamWriter com o caminho do arquivo como argumento
var stream = new StreamWriter(caminhoDoArquivo);

//Escreve linhas no Arquivo

stream.WriteLine("linha 1...");
stream.WriteLine("linha 2...");
stream.WriteLine("linha 3...");

// fecha o objeto atual e o fluxo adjacente
stream.Close();

using (var reader = new StreamReader(caminhoDoArquivo))
{
   // Le linha por linha até o final do arquivo
   var linha = " ";
   while ((linha = reader.ReadLine()) != null)
   {
        Console.WriteLine(linha);
   }
}

