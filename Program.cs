using System;
using System.Collections.Generic;
using System.IO;

namespace Aula2705
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Exec 02

            //int a;
            //while (true)
            //{

            //    Console.WriteLine("Insira um número");
            //    try
            //    {

            //        a = Convert.ToInt32(Console.ReadLine());

            //        Console.WriteLine("Deu Certo!!!!");
            //        break;

            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Número gigantesco");
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Apenas números");
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("*ERRO*");
            //    }

            //}




            ////Exec 03
            ///

            //double n1;
            //double n2;
            //double n3;
            //double resultado;

            //while (true)
            //{
            //    Console.WriteLine("Insira 3 números entre 0 e 10");
            //    try
            //    {

            //        n1 = Convert.ToDouble(Console.ReadLine());
            //        n2 = Convert.ToDouble(Console.ReadLine());
            //        n3 = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine();
            //        resultado = (n1 + n2 + n3) / 3;
            //        Console.WriteLine("A média é: " + resultado);

            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Número gigantesco");

            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Apenas números");

            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("*ERRO*");

            //    }

            //}



            //////Exec 04

            //int[] vetor = new int[5];

            //while (true)
            //{

            //    Console.WriteLine("Insira 5 números");



            //    try
            //    {

            //        for (int i = 0; i < vetor.Length; i++)
            //        {
            //            vetor[i] = Convert.ToInt32(Console.ReadLine());
            //        }
            //        Array.Sort(vetor);
            //        Console.WriteLine("O maior número é: " + vetor[4]);
            //        Console.WriteLine();
            //        Console.WriteLine("O menor número é: " + vetor[0]);
            //        Console.ReadKey();

            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Número gigantesco");

            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Apenas números");

            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("*ERRO*");

            //    }

            //}



            //if (nota > 10)
            //{
            //    throw OverFlowException;
            //}
            //OverflowException kilo = new OverflowException();
            //throw kilo;




            ////////////////////////////////////////////////////////////////////////////////////////





            //// Exec 01

            ////criando a lista
            //List<string> listaDeString = new List<string>();
            ////pedir dados
            //string entrada = Program.CR();
            //listaDeString.Add(entrada);
            //entrada = CR();
            //listaDeString.Add(entrada);
            ////mostrar na tela
            //Console.WriteLine("____________________________");
            //for (int i = 0; i < listaDeString.Count; i++)
            //{
            //    Console.WriteLine(listaDeString[i]);
            //}
            //Console.WriteLine("____________________________");

            //foreach(var item in listaDeString)
            //{
            //    Console.WriteLine(item);
            //}



            //////Exec 02
            /////

            ////cria s lista
            //List<double> notas = new List<double>();
            ////pede dados
            //for (int i = 0; i < 3; i++)
            //{
            //    var nota = CRD();
            //    notas.Add(nota);
            //}
            ////mostra
            //double resultado = 0;
            //foreach (var item in notas)
            //{
            //    resultado += item;
            //}
            //Console.WriteLine("Média: " + (resultado/3));


            ////Exec 03
            ///

            //List<int> valores = new List<int>();

            //Console.WriteLine("Insira 3 valores");

            //for (int i = 0; i < 3; i++)
            //{
            //    var valor = CRI();
            //    valores.Add(valor);
            //}
            //Console.WriteLine("_______________________");

            //for (int i = 0; i < 3; i++)
            //{
            //    if (valores[0] == valores[1] && valores[0] == valores[2])
            //    {
            //        Console.WriteLine("São todos iguais");
            //        break;
            //    }

            //    if (valores[0] > valores[1] && valores[0] > valores[2])
            //    {
            //        Console.WriteLine("Maior é: " + valores[0]);
            //    }

            //    else if (valores[1] > valores[0] && valores[1] > valores[2])
            //    {
            //        Console.WriteLine("Maior é: " + valores[1]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Maior é: " + valores[2]);
            //    }
            //    break;
            //}


            /////Exec 04

            ////VER

            //List<double> numeros = new List<double>();

            //Console.WriteLine("Insira quantos números desejar\nQuando desejar parar digite 0");

            //while (true)
            //{
            //    var numero = CRD();
            //    numeros.Add(numero);

            //    if (numero == 0)
            //    {
            //        numeros[numeros.Count-1] = 1;
            //        double resultado = 1;
            //        foreach (var item in numeros)
            //        {

            //            resultado *= item;
            //        }
            //        Console.WriteLine("Multiplicação dos números: " + resultado);
            //        break;
            //    }
            //}



            ////Exec 05

            //List<double> num = new List<double>();

            //while (true)
            //{
            //    double numero = CRD();
            //    num.Add(numero);

            //    foreach (var item in num)
            //    {
            //        if (item > numero)
            //        {
            //            Console.WriteLine("Número pequeno demais\nDigite um novo número");
            //            break;

            //        }
            //    }


            //}



            ////Exec 06

            //List<string> login = new List<string>();
            //List<string> senha = new List<string>();

            //login.Add("Admin");
            //senha.Add("@proway");

            //while (true)
            //{
            //    Console.WriteLine("Digite seu login");
            //    string log = CR();
            //    Console.WriteLine("Digite sua senha");
            //    string sen = CR();


            //    foreach (var item in login)
            //    {
            //        foreach (var item2 in senha)
            //        {
            //            if (log == item && sen == item2)
            //            {
            //                Console.WriteLine("Login realizado com sucesso");

            //                if (log == "Admin")
            //                {
            //                    Console.WriteLine("1 - Criar Conta\n2 - Deletar User\n3 - LogOut");
            //                    string escolha = "";
            //                    escolha = CR();
            //                    switch (escolha)
            //                    {
            //                        case "1":
            //                            Console.WriteLine("Digite seu login");
            //                            log = CR();
            //                            login.Add(log);
            //                            Console.WriteLine("Digite sua senha");
            //                            sen = CR();
            //                            senha.Add(sen);
            //                            break;
            //                        case "2":
            //                            Console.WriteLine("Lista de logins: ");
            //                            foreach (var item3 in login)
            //                            {
            //                                Console.WriteLine(item3);
            //                            }
            //                            Console.WriteLine("Qual login deseja deletar?");
            //                            string escolhe = CR();
            //                            escolhe = "";
            //                            break;
            //                        case "3":
            //                            break;
            //                    }


            //                }

            //            }
            //            else
            //            {
            //                Console.WriteLine("Login incorreto");
            //            }
            //        }
            //    }



            //////SOLUÇÃO DO PROFESSOR

            //List<string> logins = new List<string>();
            //List<string> senhas = new List<string>();
            //// preenche as lista com letras de 'a' a 'e'
            //for (int i = 97; i < 102; i++) // preenche com letras
            //{
            //    char letra = Convert.ToChar(i);
            //    logins.Add(letra.ToString());
            //    letra = Convert.ToChar(i - 32);
            //    senhas.Add(Convert.ToString(letra));
            //}
            //// mostra as listas
            ////foreach (var item in logins)
            ////{
            ////    Console.Write(item + "  ");
            ////}
            ////Console.WriteLine();
            ////foreach (var item in senhas)
            ////{
            ////    Console.Write(item + "  ");
            ////}

            //while (true)
            //{
            //    Console.WriteLine("Insira o login ou sair ou ver");
            //    string tempL = CR(); // CR() == Console.ReadLine
            //    if (tempL == "sair")
            //    {
            //        break;
            //    }
            //    else if (tempL == "ver")
            //    {
            //        MostraLista(logins);
            //        MostraLista(senhas);
            //    }
            //    else if (tempL == "Admin")
            //    {
            //        Console.WriteLine("Senha do Admin");
            //        string tempS = CR();
            //        if (tempS == "@Senac")
            //        {
            //            int a = 0;
            //            while (a == 0)
            //            {
            //                Console.WriteLine("\t\t***Menu Do Admin***");
            //                Console.WriteLine("1 - Criar Conta");
            //                Console.WriteLine("2 - Deletar Conta");
            //                Console.WriteLine("3 - LogOut");
            //                int escolha = CRI();// CRI() == Convert.ToInt32(Console.ReadLine());
            //                switch (escolha)
            //                {
            //                    case 1:
            //                        Console.WriteLine("Qual o login desta conta?");
            //                        string entrada = CR();
            //                        if (BuscaEmLista(logins, entrada) == -1)
            //                        {
            //                            logins.Add(entrada);
            //                            Console.WriteLine("Qual a senha deste login?");
            //                            entrada = CR();
            //                            senhas.Add(entrada);
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("Login ja existente");
            //                        }
            //                        break;
            //                    case 2:
            //                        int cont = 0;
            //                        foreach (var item in logins)
            //                        {
            //                            cont++;
            //                            Console.WriteLine(cont + " -> " + item);
            //                        }
            //                        Console.WriteLine("\nQual deseja remover?");
            //                        cont = CRI();
            //                        logins.RemoveAt(cont);
            //                        senhas.RemoveAt(cont);

            //                        break;
            //                    case 3:
            //                        a = 1;
            //                        Console.WriteLine("Log Out efetuado");
            //                        break;
            //                    default:
            //                        Console.WriteLine("Opção inválida");
            //                        break;
            //                }

            //                Console.WriteLine("Pressione enter para progredir");
            //                Console.ReadLine();
            //                Console.Clear();
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Senha incorreta");
            //        }
            //    }
            //    else
            //    {
            //        int indice = BuscaEmLista(logins, tempL);
            //        if (indice != -1)
            //        {
            //            Console.WriteLine("Qual a senha?");
            //            string tempS = CR();
            //            if (senhas[indice] == tempS)
            //            {
            //                Console.WriteLine("Login efetuado");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Senha incorreta");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Login não encontrado");
            //        }
            //    }

            //    Console.WriteLine("Pressione enter para progredir");
            //    Console.ReadLine();
            //    Console.Clear();
            //}



            /////Exec 01.02

            //List<string> nomes = new List<string>();


            //while (true)
            //{
            //    Console.WriteLine("Inserir nomes:\nPara parar digite 'exit'");
            //    string nome = CR();
            //    nomes.Add(nome);
            //    Console.Clear();

            //    if (nome == "exit")
            //    {
            //        nomes[nomes.Count - 1] = "";
            //        foreach (var item in nomes)
            //        {
            //            Console.WriteLine(item);

            //        }
            //        break;
            //    }


            //}



            /////Exec 02.02
            ///

            //List<double> notas = new List<double>();
            //double nota = 0;
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Digite as notas:\nDigite '00' para sair");
            //        nota = CRD();
            //        notas.Add(nota);

            //        if (nota == 00)
            //        {
            //            double resultado = 0;
            //            foreach (var item in notas)
            //            {
            //                resultado += item;

            //            }
            //            Console.WriteLine("A média desse aluno é: " + resultado / (notas.Count - 1));
            //            break;
            //        }




            //    }
            //    catch (Exception)
            //    {

            //        Console.WriteLine("Opção inválida");
            //    }


            //}







            /////Exec 03.02

            //List<double> numeros = new List<double>();
            //double num = 0;
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Inserir números:\nPara sair digite '00'");
            //        num = CRD();
            //        if (num == 0)
            //        {
            //            break;
            //        }

            //        numeros.Add(num);
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Digite apenas números");

            //    }
            //}


            //numeros.Sort();
            //Console.WriteLine("O maior número é: " + numeros[numeros.Count - 1]);
            //Console.WriteLine("O menos número é: " + numeros[1]);








            ///Exec 04.02


            //List<string> nomes = new List<string>();
            //List<int> ano = new List<int>();
            //string nome = "";
            //int anoNasc;
            //while (true)
            //{

            //    do
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("Para sair digite 'parar'\nInsira o nome:");
            //        nome = CR();
            //    } while (nome == "");





            //    if (nome == "parar")
            //    {

            //        break;


            //    }
            //    try
            //    {
            //        Console.WriteLine("Insira o ano de nascimento");
            //        anoNasc = CRI();
            //        Console.Clear();
            //        nomes.Add(nome);
            //        ano.Add(anoNasc);
            //    }


            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Apenas números");
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Digite uma informação válida");
            //    }


            //}

            //for (int i = 0; i < ano.Count; i++)

            //{

            //    // Laço que volta organizando

            //    for (int j = i; j > 0; j--)

            //    {

            //        if (ano[j - 1] > ano[j])

            //        {
            //            string temp = nomes[j];

            //            nomes[j] = nomes[j - 1];

            //            nomes[j - 1] = temp;
            //            //
            //            int temp2 = ano[j];

            //            ano[j] = ano[j - 1];

            //            ano[j - 1] = temp2;

            //        }

            //    }

            //}
            //for (int i = 0; i < nomes.Count; i++)
            //{
            //    Console.WriteLine(nomes[i] + " | " + ano[i]);

            //}





            //////Exec 05.02
            ///





            //List<string> placas = new List<string>();
            //List<double> hora = new List<double>();
            //double hrEntrada = 0, hrSaida = 0;
            //Console.WriteLine("Estacionamento Virtual");
            //Console.WriteLine();
            //int escolha = 0; ;
            //string placa;
            //while (true)
            //{
            //    try
            //    {

            //        Console.WriteLine("\t\t***MENU***");
            //        Console.WriteLine("1 - Entrando");
            //        Console.WriteLine("2 - Saindo");
            //        Console.WriteLine("3 - Encerrar");
            //        Console.WriteLine();
            //        escolha = CRI();


            //        if (escolha == 1)
            //        {
            //            //try
            //            //{
            //            do
            //            {
            //                Console.WriteLine("Qual a placa?");
            //                placa = CR();
            //            } while (placa == "");


            //            placas.Add(placa);
            //            Console.WriteLine("Qual a hora de entrada?");
            //            hrEntrada = CRD();
            //            hora.Add(hrEntrada);
            //            //}
            //            //catch (Exception)
            //            //{

            //            //    Console.WriteLine("Informação inválida");

            //            //}



            //        }
            //        else if (escolha == 2)
            //        {
            //            Console.WriteLine("Qual a placa saindo?");
            //            placa = CR();

            //            if (BuscaEmPlacas(placas, placa) != -1)
            //            {

            //                Console.WriteLine("Qual a hora de saída?");
            //                hrSaida = CRD();
            //                Console.WriteLine();
            //                Console.WriteLine("Valor a pagar:");
            //                double valor = (hrSaida - hrEntrada) * 4;
            //                Console.WriteLine(valor);


            //            }
            //            //else
            //            //{
            //            //    Console.WriteLine("Placa não encontrada");
            //            //}


            //        }
            //        else if (escolha == 3)
            //        {
            //            Console.WriteLine("Até logo!!!!!!");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Opção inválida");
            //        }







            //    }

            //    catch (Exception e)
            //    {

            //        Console.WriteLine("Aconteceu um erro inesperado.");
            //        Console.WriteLine("Verifique se todos os dados inseridos estão corretos");
            //        string caminhoerro = @"C:\Users\marcus.pinto\Desktop\erro.txt";
            //        StreamWriter erro;
            //        erro = File.CreateText(caminhoerro);
            //        erro.WriteLine("Erro detectado");
            //        erro.WriteLine("Data do erro:" + DateTime.Now);
            //        erro.WriteLine("Detalhes: " + e.ToString());
            //        erro.WriteLine("Detalhes simplificados: " + e.Message);
            //        erro.WriteLine("Erro finalizado!");
            //        erro.Close();

            //    }
            //    //catch (Exception)
            //    //{
            //    //    Console.WriteLine("Informação inválida");

            //    //}





            //}


            ///////////////////////////////////////////////////////////////////////////////////
            ////////// Depuração


            /////Exec 01

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Insira 1 número");
            //        Console.WriteLine();
            //        int x = CRI();

            //        Console.WriteLine(Exec01(x));
            //        break;
            //    }
            //    catch (OverflowException)
            //    {

            //        Console.WriteLine("Número muito grande");
            //    }
            //    catch (FormatException)
            //    {

            //        Console.WriteLine("Insira um número válido");
            //    }
            //}





            /////Exec 02



            //Console.WriteLine("Insira um numero ou sair");
            //string entrada = Console.ReadLine();

            //Exec02();




            /////Exec 03

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Insira 2 números");
            //        Console.WriteLine();
            //        int x = 0;
            //        int y = 0;
            //        x = Convert.ToInt32(Console.ReadLine());
            //        y = Convert.ToInt32(Console.ReadLine());


            //        Console.WriteLine(Exec03(x, y));
            //        break;
            //    }
            //    catch (OverflowException)
            //    {

            //        Console.WriteLine("Número muito grande");
            //    }
            //    catch (FormatException)
            //    {

            //        Console.WriteLine("Digite um número válido");
            //    }
            //}


            ////Exec 04
            //while (true)
            //{


            //    try
            //    {
            //        Console.WriteLine("Insira 2 números");
            //        Console.WriteLine();
            //        int x = 0;
            //        int y = 0;
            //        x = CRI();
            //        y = CRI();

            //        Exec04(x, y);
            //        break;
            //    }
            //    catch (OverflowException)
            //    {

            //        Console.WriteLine("Número muito grande");
            //    }
            //    catch (FormatException)
            //    {

            //        Console.WriteLine("Digite um número válido");
            //    }

            //}


            ///////Exec 05

            //List<double> num = new List<double>();

            //Console.WriteLine("Insira quantos números quiser números");
            //Console.WriteLine("Digite '00' quando quiser sair");
            //Console.WriteLine();
            //double numeros = 0;

            //while (true)
            //{
            //    try
            //    {
            //        numeros = CRD();
            //        num.Add(numeros);


            //        if (numeros == 00)
            //        {
            //            Console.WriteLine("O maior número da lista é: " + Exec05(num));
            //            break;
            //        }
            //    }
            //    catch (FormatException)
            //    {

            //        Console.WriteLine("Digite um número válido");
            //    }



            //}



            /////Exec 06


            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Insira 1 número");
            //        Console.WriteLine();
            //        int x = CRI();

            //        Console.WriteLine(Exec06(x));
            //        break;
            //    }
            //    catch (OverflowException)
            //    {

            //        Console.WriteLine("Número muito grande");
            //    }
            //    catch (FormatException)
            //    {

            //        Console.WriteLine("Digite um número válido");
            //    }


            //}




            ////////////////////////////////////////////////////

            string[] nomes = new string[4];
            string[] cpf = new string[4];
            int[] idade = new int[4];
            int escolha;
            while (true)
            {
                try
                {
                   
                    
                    for (int i = 0; i < nomes.Length; i++)
                    {
                        Console.WriteLine("_____________/____________");
                        Console.WriteLine("Aluno: " + (i + 1));
                        Console.WriteLine("Nome: " + nomes[i]);
                        Console.WriteLine("CPF: " + cpf[i]);
                        Console.WriteLine("Idade: " + idade[i]);
                    }
                    do
                    {
                        Console.WriteLine("Qual aluno deseja preencher?");
                        escolha = Convert.ToInt32(Console.ReadLine())/*-1*/;
                    } while (escolha <= 0 || escolha > 4);
                    

            

                    //escolha--;
                    Console.WriteLine("Insira o nome");
                    string nomeTemp = CR();
                    Console.WriteLine();
                    Console.WriteLine("Insira o cpf");
                    string cpfTemp = CR();
                    Console.WriteLine();
                    Console.WriteLine("Insira a idade");
                    idade[escolha - 1] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    nomes[escolha - 1] = nomeTemp;
                    cpf[escolha - 1] = cpfTemp;

                    do
                    {
                        Console.WriteLine("Deseja sair?\n1 - sim | 2 - não");
                        escolha = Convert.ToInt32(Console.ReadLine());
                    } while (escolha !=1 && escolha != 2);
                   
                    
                    if (escolha == 1)
                    {
                        break;
                    }

                }
                catch (OverflowException)
                {

                    Console.WriteLine("Número muito grande");
                    CR();
                    Console.Clear();
                }
                catch (FormatException)
                {

                    Console.WriteLine("*********Insira um dado válido*******");
                    CR();
                    Console.Clear();
                }
                catch (IndexOutOfRangeException)
                {

                    Console.WriteLine("Digite uma posição válida");
                    CR();
                    Console.Clear();
                }


            }









        }


        public static int Exec06(int numero)
        {
            if (numero > 0 && numero < 10)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }



        public static double Exec05(List<double> lista)
        {
            double maior = 0;
            foreach (var item in lista)
            {
                if (item > maior)
                {
                    maior = item;
                }
            }
            return maior;
        }



        public static void Exec04(int numero1, int numero2)
        {
            if (numero2 < numero1)
            {
                Console.WriteLine(numero1 + numero2);
            }
            else
            {
                Console.WriteLine("Não computável");
            }
        }




        public static bool Exec03(int numero1, int numero2)
        {
            if (numero1 > numero2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public static void Exec02()
        {
            while (true)
            {
                Console.WriteLine("Insira um numero ou sair");
                string entrada = Console.ReadLine();
                if (entrada == "sair")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(entrada);
                }
            }
        }


        public static int Exec01(int numero)
        {
            if (numero > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }




        public static string CR()
        {
            return Console.ReadLine();
        }
        public static int CRI()
        {
            return Convert.ToInt32(CR());
        }
        public static double CRD()
        {
            return Convert.ToDouble(CR());
        }

        public static int BuscaEmLista(List<string> elementos, string verificador)
        {
            for (int i = 0; i < elementos.Count; i++)
            {
                if (elementos[i] == verificador)
                {
                    return i;
                }

            }
            return -1;
        }

        public static void MostraLista(List<string> elementos)
        {
            foreach (var item in elementos)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
        }


        public static int BuscaEmPlacas(List<string> elementos, string verificador)
        {
            for (int i = 0; i < elementos.Count; i++)
            {
                if (elementos[i] == verificador)
                {
                    return i;
                }

            }
            return -1;
        }















    }
}

