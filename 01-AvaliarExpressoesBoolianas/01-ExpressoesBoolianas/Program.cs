/*
Avaliando igualdade e desigualdade
Muitas vezes, será conveniente que você verifique se dois valores 
são iguais ou não. Você pode usar o operador de igualdade == entre 
dois valores para avaliar a igualdade. Se os dois valores em ambos 
 lados do operador de igualdade forem equivalentes, a expressão 
 retornará true. Caso contrário, retornará false.

Outras vezes, talvez você deseje verificar se os dois valores não são 
iguais. Você usa o operador de desigualdade != entre dois valores para 
avaliar a igualdade.

Talvez você se pergunte por que precisa de operadores de igualdade e 
desigualdade. O motivo ficará mais claro à medida que você aprender a 
criar instruções de ramificação e começar a escrever código do mundo real. 
Dois operadores que executam tarefas opostas permitem que você seja mais 
expressivo e compacto.
*/

Console.WriteLine("");

//Usar o operador de igualdade
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

Console.WriteLine("");

/*
Vamos melhorar a verificação anterior de igualdade encadeando esses dois 
métodos em ambos os valores na listagem de código a seguir:
*/
string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

//Usar o operador de desigualdade
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

Console.WriteLine("");

string myValue2 = "a";
Console.WriteLine(myValue2 != "a");

/*
Avaliar comparações
Ao trabalhar com tipos de dados numéricos, você desejará determinar se um valor é 
maior, menor ou igual a outro valor. Use os operadores a seguir para executar esses 
tipos de comparações.

Maior que >
Menor que <
Maior que ou igual a >=
Menor ou igual a <=

*/

Console.WriteLine("");

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

Console.WriteLine("");

//Usar uma expressão de invocação de método
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

/*
O que é negação lógica?
O termo "negação lógica" refere-se ao operador !. Algumas pessoas simplesmente chamam 
isso de "operador de negação". A adição do operador ! antes de uma expressão condicional, 
tal como uma chamada de método, verifica se a expressão é falsa.

E, de uma maneira que esperamos que ajude você a ver as conexões entre essas ideias, 
as duas linhas de código a seguir fazem a mesma coisa. A segunda linha é mais compacta.
*/

Console.WriteLine("");

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));

Console.WriteLine("");

//Usar o operador de negação lógica

Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));


Console.WriteLine("");
