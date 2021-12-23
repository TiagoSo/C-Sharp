                                                                Conceitos Básicos
|----------------------------------------------
|  <<<Como é a estrutura geral do codigo?>>>  |
|----------------------------------------------

using System;

namespace Applicação
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá mundo");
           
        }
    }



}                 

|----------------------------------------------
|     <<<Como posso fazer comentários?>>>     |
|----------------------------------------------                                            
1- Linha // 
Várias- /*
texto
texto
*/

|--------------------------------------------
|       <<<Operadores Aritmétricos>>>       |
|--------------------------------------------

                Adição:+ 
                Subtração:-
                Multiplicação:*
                Divisão:/
                Resto:%

|---------------------------------------------
|              <<<Constantes>>>              |
|---------------------------------------------
const double PI = 3.14;
/*The value of const PI cannot be changed during program execution.
For example, an assignment statement later in the program will cause an error:*/
const double PI = 3.14;
PI = 8; //ERRO

|--------------------------------------------
|         <<<Declarando Variaveis>>>        |
|--------------------------------------------
        Tipos de dados e Declarações:

        Para inteiros = int*/
        Para textos =  String*/
        Para Numeros Fracionados = double*/

Exemplo:

namespace Applicação
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2;
            int num_2=4;
            Console.WriteLine(num);
            Console.WriteLine(num_2);
            
            int soma = (num+num_2);

            Console.WriteLine("A soma dos valores é{0}", soma);//Indica que dentro do {0} o programa escreve, a soma
            
            double num_4 = 10.5;
            int num_5 = 20;
            double media=((num_4+num_5)/2);
            Console.WriteLine("A média É {0}",media);
        }
    }



}


|---------------------------------------------
|      <<<Operadores de atribuição>>>        |
|---------------------------------------------
                x(operador aritmétrico)=(Numero)

Exemplos:

int x = 42;
x += 2; //equivalente a x=x+2
x -= 6; //equivalente a x=x-6

<A mesma sintaxe abreviada se aplica aos operadores de multiplicação, divisão e módulo>
x *= 8; // equivalent to x = x * 8
x /= 5; // equivalent to x = x / 5
x %= 2; // equivalent to x = x % 2

/*O operador de incremento é usado para aumentar o valor de um inteiro em um, e é um operato C # comumente usado*/
x++; ​//equivalent to x = x + 1
x-- // x=x-1

/*What is the output of this code?
int x = 6;
x++;
Console.WriteLine(x);*/
//R: x=7

//O operador de incremento tem duas formas, prefixo e postfix
++x; //prefix
x++; //postfix

/*Prefixo incrementa o valor e, a seguir, prossegue com a expressão.
Postfix avalia a expressão e então executa o incremento.*/

//Prefixo Exemplo:                               Postfix Exemplo 
int x = 3;                                       int x1 = 3;
int y = ++x;                                     int y1 = x1++;
//x é 4 e y=4                                    x é 4 e y=3


|---------------------------------------------
|   <<<Convertendo os valores da string>>>   |
|---------------------------------------------
Converte o valor especificado em sua representação de string equivalente.
Existem diversos, cada uma com funções diferentes