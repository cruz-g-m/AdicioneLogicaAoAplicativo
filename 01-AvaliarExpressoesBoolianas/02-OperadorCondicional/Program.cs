/*
Suponha que você precise determinar rapidamente se a compra de um cliente está
 qualificada para um desconto promocional. Se o valor da venda for maior que 
 1.000, a compra receberá um desconto de 100 dólares. Se o valor for de 1.000 
 ou menos, a venda receberá um desconto de apenas 50 dólares.

Embora seja certamente possível usar a construção de ramificação if ... elseif ... 
else para expressar essa regra de negócios, podemos escolher o operador condicional 
para executar o desconto promocional. O operador condicional usa um formato 
compacto que economiza algumas linhas de código e, possivelmente, torna a intenção 
do código mais clara.

O que é o operador condicional?
O operador condicional?:, normalmente conhecido como o operador condicional ternário, 
avalia uma expressão booliana e retorna o resultado da avaliação de uma de duas 
expressões, dependendo se a expressão booliana é avaliada como verdadeira ou falsa.

Usaremos o operador condicional para abordar o cenário nesta unidade. Exibiremos uma 
mensagem para o cliente com o desconto promocional que ele obteve, com base em ter 
gasto mais de US$ 1.000 em sua compra ou não.
*/

int saleAmount = 1001;

//int discount = saleAmount > 1000 ? 100 : 50;


//Usar o operador condicional embutido
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");