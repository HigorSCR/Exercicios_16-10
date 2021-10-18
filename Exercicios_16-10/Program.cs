using System;

namespace Exercicios_16_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double peso;
            double altura;
            double imc;
            bool validacao = true;
            double salario_usuario;
            double salario_minimo;
            double quantidade_salario_minimo;
            double volume;
            double raio;
            double nota1, nota2, nota3, nota4;
            double resultado;

            Program program = new Program();

            Console.WriteLine("*******Sejam Bem vindos*******");
            do
            {
                Console.WriteLine("Qual opção deseja acessar?");
                Console.WriteLine("(1) Calculadora de IMC;");
                Console.WriteLine("(2) Calcule o número de salários mínimos você ganha;");
                Console.WriteLine("(3) Calcule o volume de um esfera;");
                Console.WriteLine("(4) Calcule média escolar:");
                Console.WriteLine("(5) Calcule a quantidade de animais informados:");
                Console.WriteLine("(6) Sair");

                Console.WriteLine("Digite sua opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    // Caso IMC
                    case 1:
                        Console.WriteLine("Qual é o seu peso? ");
                        peso = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Qual é a sua altura? ");
                        altura = Convert.ToDouble(Console.ReadLine());

                        imc = peso / (altura * altura);

                        Console.WriteLine("Seu IMC é: " + imc);

                        if (imc < 20)
                        {
                            Console.WriteLine("Abaixo do peso");
                        }
                        else if (imc >= 25)
                        {
                            Console.WriteLine("Acima do Peso");
                        }
                        else
                        {
                            Console.WriteLine("Peso Ideal");
                        }
                        break;


                    // Caso Salário

                    case 2:

                        Console.WriteLine("Qual é o valor do seu salário? ");
                        salario_usuario = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Qual é o valor do salário minimo atualmente? ");
                        salario_minimo = Convert.ToDouble(Console.ReadLine());

                        quantidade_salario_minimo = (salario_usuario / salario_minimo);
                        Console.WriteLine("Você ganha: " + quantidade_salario_minimo + " salários mínimos");

                        break;

                    // Caso calculo de volume
                    case 3:

                        Console.WriteLine("Informe o valor do raio:  ");
                        raio = Convert.ToDouble(Console.ReadLine());

                        volume = 3 * (3.14 * Math.Pow(raio, 3)) / 4;

                        Console.WriteLine("O Valor do volume é " + volume);

                        break;

                    // Caso calculo de média
                    case 4:

                        Console.WriteLine("Informe sua Primeira nota:  ");
                        nota1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe sua Segunda nota:  ");
                        nota2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe sua Terceira nota:  ");
                        nota3 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.resultado_case4(nota1, nota2, nota3);
                        Console.WriteLine("Sua média é " + resultado);

                        if (resultado >= 7)
                        {
                            Console.WriteLine("Aprovado!");

                        }
                        else if (resultado < 7)
                        {
                            Console.WriteLine("Informe sua nota de exame: ");
                            nota4 = Convert.ToDouble(Console.ReadLine());

                            resultado = program.resultado2_case4(resultado, nota4);
                            Console.WriteLine("Sua média é " + resultado);

                            if ((resultado >= 5))
                            {
                                Console.WriteLine("Aprovado!");
                            }
                            else
                            {
                                Console.WriteLine("Reprovadissimo!");
                            }
                        }
                        break;

                    case 5:
                        {
                            Animais a1 = new Animais();
                            Animais a2 = new Animais();
                            Animais a3 = new Animais();
                            Animais a4 = new Animais();
                            Animais a5 = new Animais();
                            int contCachorro = 0, contGato = 0, contPeixe = 0;


                            Console.WriteLine("Informe o nome do 1º animal: ");
                            a1.Nome = Console.ReadLine();
                            Console.WriteLine("Informe o Tipo do 1º animal (Cachorro, Gato ou Peixe):  ");
                            a1.Tipo = Console.ReadLine();
                            if (a1.Tipo == "Cachorro") contCachorro++;
                            if (a1.Tipo == "Gato") contGato++;
                            if (a1.Tipo == "Peixe") contPeixe++;

                            Console.WriteLine("Informe o nome do 2º animal: ");
                            a2.Nome = Console.ReadLine();
                            Console.WriteLine("Informe o Tipo do 2º animal (Cachorro, Gato ou Peixe):  ");
                            a2.Tipo = Console.ReadLine();
                            if (a2.Tipo == "Cachorro") contCachorro++;
                            if (a2.Tipo == "Gato") contGato++;
                            if (a2.Tipo == "Peixe") contPeixe++;

                            Console.WriteLine("Informe o nome do 3º animal: ");
                            a3.Nome = Console.ReadLine();
                            Console.WriteLine("Informe o Tipo do 3º animal (Cachorro, Gato ou Peixe):  ");
                            a3.Tipo = Console.ReadLine();
                            if (a3.Tipo == "Cachorro") contCachorro++;
                            if (a3.Tipo == "Gato") contGato++;
                            if (a3.Tipo == "Peixe") contPeixe++;

                            Console.WriteLine("Informe o nome do 4º animal: ");
                            a4.Nome = Console.ReadLine();
                            Console.WriteLine("Informe o Tipo do 4º animal (Cachorro, Gato ou Peixe):  ");
                            a4.Tipo = Console.ReadLine();
                            if (a4.Tipo == "Cachorro") contCachorro++;
                            if (a4.Tipo == "Gato") contGato++;
                            if (a4.Tipo == "Peixe") contPeixe++;

                            Console.WriteLine("Informe o nome do 5º animal: ");
                            a5.Nome = Console.ReadLine();
                            Console.WriteLine("Informe o Tipo do 5º animal (Cachorro, Gato ou Peixe):  ");
                            a5.Tipo = Console.ReadLine();
                            if (a5.Tipo == "Cachorro") contCachorro++;
                            if (a5.Tipo == "Gato") contGato++;
                            if (a5.Tipo == "Peixe") contPeixe++;

                            Console.WriteLine("Quantidade de animais: ");
                            Console.WriteLine("Cachorros: "+contCachorro);
                            Console.WriteLine("Gatos: " + contGato);
                            Console.WriteLine("Peixes: " + contPeixe );
                        }
                        break;
                }
                    Console.WriteLine("Aperte ENTER para continuar");
                    Console.ReadLine();
                    Console.Clear();

                } while (validacao);
        }
        public double resultado_case4(double nota1, double nota2, double nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }
        public double resultado2_case4(double resultado, double nota4)
        {
            return (resultado + nota4) / 2;
        }
    }
}
