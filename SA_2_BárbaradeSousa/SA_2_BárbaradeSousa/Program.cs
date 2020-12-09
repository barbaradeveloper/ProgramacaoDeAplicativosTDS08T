using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace SA_2_BárbaradeSousa
{
    class Program
    {
        static void Main(string[] args)
        {

            // Menu principal 

            List<Receitas> receitas = new List<Receitas>(); // Criando uma lista para armazenar as receitas 
            List<Ingredientes> ingredientes = new List<Ingredientes>(); // Criando uma lista para armazenar os ingredientes

        MenuPrincipal:
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("                  GESTÃO DE RECEITAS CULINÁRIAS                ");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Selecione uma das opções do menu: ");
            Console.WriteLine();
            Console.WriteLine("1 - Registrar receita");
            Console.WriteLine("2 - Ver receitas Registradas ");
            Console.WriteLine("3 - Editar Receita ");
            Console.WriteLine("4 - Eliminar Receita ");
            Console.WriteLine("5 - Sair do Programa");
            Console.WriteLine("---------------------------------------------------------------");

            int opcaoMenu = int.Parse(Console.ReadLine());

            Console.Clear(); // Limpa tela          



            // Escolha 
            switch (opcaoMenu)
            {
                case 1:

                RegistrarReceita:

                    Console.WriteLine("                    REGISTRAR RECEITA                   ");
                    Console.WriteLine("********************************************************");
                    Console.WriteLine();

                    Console.Write("Informe o nome da Receita: ");
                    string nome_da_receita = Console.ReadLine();
                    Console.Write("Informe o tempo de preparação em minutos: ");
                    int tempo_de_preparacao = int.Parse(Console.ReadLine());
                    Console.Write("Informe o valor estimado da receita: ");
                    double valor_receita = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();
                    Console.WriteLine("              Grau de Dificuldade             ");
                    Console.WriteLine("______________________________________________");
                    Console.WriteLine();
                    Console.WriteLine("Informe o grau de dificuldade: ");
                    Console.WriteLine();
                    Console.WriteLine("Digite 1 para Fácil");
                    Console.WriteLine("Digite 2 para Médio");
                    Console.WriteLine("Digite 3 para Difícil");
                    int grau_de_dificuldade = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Informe o número de pessoas: ");
                    int numero_de_pessoas = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("                   Categoria                 ");
                    Console.WriteLine("_____________________________________________");
                    Console.WriteLine();
                    Console.Write("Informe a categoria da receita: ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Digite 1 para Carne");
                    Console.WriteLine("Digite 2 para Peixes");
                    Console.WriteLine("Digite 3 para Mariscos");
                    Console.WriteLine("Digite 4 para Sobremesa");
                    Console.WriteLine("Digite 5 para Lanche");
                    Console.WriteLine("Digite 6 para Pastelaria");
                    Console.WriteLine("Digite 7 para Almoço");
                    Console.WriteLine("Digite 8 para Outra Categoria");
                    int categoria = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                Ingredientes:
                    Console.WriteLine("           Ingredientes         ");
                    Console.WriteLine("_______________________________ ");
                    Console.WriteLine();
                    Console.Write("Informe o nome do ingrediente: ");
                    string nome_ingrediente = Console.ReadLine();
                    Console.Write("Informe a unidade de medida (Kg, G, Ml, L ): ");
                    string unidade_de_medida = Console.ReadLine();
                    Console.Write("Informe a quantidade necessária do ingrediente: ");
                    int quantidade_ingrediente = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    // Adicionando ingredientes na lista ingredientes 
                    ingredientes.Add(new Ingredientes(nome_ingrediente, quantidade_ingrediente, unidade_de_medida));

                    Console.WriteLine("Deseja adicionar outro ingrediente? Digite 1 para sim ou 2 para não: ");
                    int adicionarOutroIngrediente = int.Parse(Console.ReadLine());

                    if (adicionarOutroIngrediente == 1)
                    {
                        goto Ingredientes;
                    }
                    else
                    {
                        goto MododePreparo;
                    }

                MododePreparo:
                    Console.WriteLine();
                    Console.WriteLine("           Modo de Preparo             ");
                    Console.WriteLine("_______________________________________");
                    Console.WriteLine();
                    Console.Write("Informe a descrição da preparação da receita: ");
                    string descricao_de_preparacao = Console.ReadLine();


                    // Adicionando as receitas na lista receitas

                    receitas.Add(new Receitas(nome_da_receita, tempo_de_preparacao, valor_receita, grau_de_dificuldade,
                        numero_de_pessoas, categoria, descricao_de_preparacao));
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("___________________________________________________________");
                    Console.WriteLine("************** RECEITA REGISTRADA COM SUCESSO *************");
                    Console.WriteLine("___________________________________________________________");
                    Console.WriteLine();
                    Console.Write("Deseja registrar outra receita? Digite 1 para sim ou 2 para não: ");
                    int registrarOutraReceita = int.Parse(Console.ReadLine());
                    Console.Clear(); // Limpa tela
                    Console.WriteLine();


                    if (registrarOutraReceita == 1)
                    {
                        goto RegistrarReceita;
                    }
                    else
                    {
                        Console.Clear();
                        goto MenuPrincipal;
                    }
            
                   
                case 2:

                ReceitasRegistradas:
                    Console.Clear();
                    Console.WriteLine("                         VER RECEITAS REGISTRADAS                       ");
                    Console.WriteLine("************************************************************************");
                    Console.WriteLine("");
                    Console.WriteLine("Selecione uma das opções do menu: ");
                    Console.WriteLine();
                    Console.WriteLine("1 - Ver todas as receitas");
                    Console.WriteLine("2 - Ver receitas por dificuldade");
                    Console.WriteLine("3 - Ver receitas por categoria");
                    Console.WriteLine("4 - Ver receitas por tempo de preparação");
                    Console.WriteLine("5 - Voltar ao Menu Principal");
                    int verReceitas = int.Parse(Console.ReadLine());

                    switch (verReceitas)
                    {
                        case 1:

                            Console.Clear();
                            Console.WriteLine("            Todas as receitas registradas          ");
                            Console.WriteLine("___________________________________________________");
                            foreach (Receitas todasReceitas in receitas)
                            {
                                Console.WriteLine(todasReceitas);
                            }
                            Console.WriteLine("Digite 1 para voltar ao menu 'VER RECEITAS REGISTRADAS' ou 2 para voltar ao Menu principal");
                            int voltar = int.Parse(Console.ReadLine());

                            if (voltar == 1)
                            {
                                goto ReceitasRegistradas;
                            }
                            else
                            {
                                goto MenuPrincipal;
                            }


                        case 2:
                            {
                            ReceitasPorDificuldade:
                                Console.Clear();
                                Console.WriteLine("Selecione uma opção: ");
                                Console.WriteLine();
                                Console.WriteLine("1 - Ver receitas de Grau de dificuldade Fácil");
                                Console.WriteLine("2 - Ver receitas de Grau de dificuldade Médio");
                                Console.WriteLine("3 - Ver receitas de Grau de dificuldade Difícil");
                                int dificuldadeReceita = int.Parse(Console.ReadLine());
                                if (dificuldadeReceita == 1)
                                {
                                    Console.Clear();
                                    List<Receitas> receitas2 = receitas.FindAll(x => x.Grau_De_Dificuldade == 1);
                                    foreach (Receitas receitasPorDificuldade in receitas2)
                                    {
                                        Console.WriteLine(receitasPorDificuldade);
                                    }

                                    Console.WriteLine();
                                    Console.WriteLine("Deseja ver receitas por outro grau de dificuldade? Digite 1 para sim ou 2 para não: ");
                                    int outraDificuldadeReceita = int.Parse(Console.ReadLine());
                                    if (outraDificuldadeReceita == 1)
                                    {
                                        goto ReceitasPorDificuldade;
                                    }
                                    else
                                    {
                                        goto ReceitasRegistradas;
                                    }
                                }
                                else if (dificuldadeReceita == 2)
                                {
                                    Console.Clear();
                                    List<Receitas> receitas2 = receitas.FindAll(x => x.Grau_De_Dificuldade == 2);
                                    foreach (Receitas receitasPorDificuldade in receitas2)
                                    {
                                        Console.WriteLine(receitasPorDificuldade);
                                    }

                                    Console.WriteLine();
                                    Console.WriteLine("Deseja ver receitas por outro grau de dificuldade? Digite 1 para sim ou 2 para não: ");
                                    int outraDificuldadeReceita = int.Parse(Console.ReadLine());
                                    if (outraDificuldadeReceita == 1)
                                    {
                                        goto ReceitasPorDificuldade;
                                    }
                                    else
                                    {
                                        goto ReceitasRegistradas;
                                    }
                                }
                                else if (dificuldadeReceita == 3)
                                {
                                    Console.Clear();
                                    List<Receitas> receitas2 = receitas.FindAll(x => x.Grau_De_Dificuldade == 3);
                                    foreach (Receitas receitasPorDificuldade in receitas2)
                                    {
                                        Console.WriteLine(receitasPorDificuldade);
                                    }

                                    Console.WriteLine();
                                    Console.WriteLine("Deseja ver receitas por outro grau de dificuldade? Digite 1 para sim ou 2 para não: ");
                                    int outraDificuldadeReceita = int.Parse(Console.ReadLine());
                                    if (outraDificuldadeReceita == 1)
                                    {
                                        goto ReceitasPorDificuldade;
                                    }
                                    else
                                    {
                                        goto ReceitasRegistradas;
                                    }
                                }
                            }
                            break;
                        case 3:

                        // Ver receitas por categoria
                        ReceitasPorCategoria:
                            Console.Clear();
                            Console.WriteLine("Qual categoria você deseja consultar? ");
                            Console.WriteLine();
                            Console.WriteLine("Digite 1 para Carne");
                            Console.WriteLine("Digite 2 para Peixes");
                            Console.WriteLine("Digite 3 para Mariscos");
                            Console.WriteLine("Digite 4 para Sobremesa");
                            Console.WriteLine("Digite 5 para Lanche");
                            Console.WriteLine("Digite 6 para Pastelaria");
                            Console.WriteLine("Digite 7 para Almoço");
                            Console.WriteLine("Digite 8 para Outra categoria");
                            int consultarCategoria = int.Parse(Console.ReadLine());

                            if (consultarCategoria == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("                    Categoria Carne                   ");
                                Console.WriteLine("******************************************************");
                                Console.WriteLine();
                                List<Receitas> receitas3 = receitas.FindAll(x => x.Categoria == 1);
                                foreach (Receitas receitasPorCategoria in receitas3)
                                {
                                    Console.WriteLine(receitasPorCategoria);
                                }

                                Console.WriteLine();
                                Console.WriteLine("Deseja ver receitas por outra categoria? Digite 1 para sim ou 2 para não: ");
                                int outraCategoriaReceita = int.Parse(Console.ReadLine());
                                if (outraCategoriaReceita == 1)
                                {
                                    goto ReceitasPorCategoria;
                                }
                                else
                                {
                                    goto ReceitasRegistradas;
                                }
                            }
                            else if (consultarCategoria == 2)
                            {
                                Console.Clear();
                                List<Receitas> receitas3 = receitas.FindAll(x => x.Categoria == 2);
                                foreach (Receitas receitasPorCategoria in receitas3)
                                {
                                    Console.WriteLine(receitasPorCategoria);
                                }

                                Console.WriteLine();
                                Console.WriteLine("Deseja ver receitas por outra categoria? Digite 1 para sim ou 2 para não: ");
                                int outraCategoriaReceita = int.Parse(Console.ReadLine());
                                if (outraCategoriaReceita == 1)
                                {
                                    goto ReceitasPorCategoria;
                                }
                                else
                                {
                                    goto ReceitasRegistradas;
                                }
                            }
                            else if (consultarCategoria == 3)
                            {
                                Console.Clear();
                                List<Receitas> receitas3 = receitas.FindAll(x => x.Categoria == 3);
                                foreach (Receitas receitasPorCategoria in receitas3)
                                {
                                    Console.WriteLine(receitasPorCategoria);
                                }

                                Console.WriteLine();
                                Console.WriteLine("Deseja ver receitas por outra categoria? Digite 1 para sim ou 2 para não: ");
                                int outraCategoriaReceita = int.Parse(Console.ReadLine());
                                if (outraCategoriaReceita == 1)
                                {
                                    goto ReceitasPorCategoria;
                                }
                                else
                                {
                                    goto ReceitasRegistradas;
                                }
                            }
                            else if (consultarCategoria == 4)
                            {
                                Console.Clear();
                                List<Receitas> receitas3 = receitas.FindAll(x => x.Categoria == 4);
                                foreach (Receitas receitasPorCategoria in receitas3)
                                {
                                    Console.WriteLine(receitasPorCategoria);
                                }

                                Console.WriteLine();
                                Console.WriteLine("Deseja ver receitas por outra categoria? Digite 1 para sim ou 2 para não: ");
                                int outraCategoriaReceita = int.Parse(Console.ReadLine());
                                if (outraCategoriaReceita == 1)
                                {
                                    goto ReceitasPorCategoria;
                                }
                                else
                                {
                                    goto ReceitasRegistradas;
                                }
                            }
                            else if (consultarCategoria == 5)
                            {
                                Console.Clear();
                                List<Receitas> receitas3 = receitas.FindAll(x => x.Categoria == 5);
                                foreach (Receitas receitasPorCategoria in receitas3)
                                {
                                    Console.WriteLine(receitasPorCategoria);
                                }

                                Console.WriteLine();
                                Console.WriteLine("Deseja ver receitas por outra categoria? Digite 1 para sim ou 2 para não: ");
                                int outraCategoriaReceita = int.Parse(Console.ReadLine());
                                if (outraCategoriaReceita == 1)
                                {
                                    goto ReceitasPorCategoria;
                                }
                                else
                                {
                                    goto ReceitasRegistradas;
                                }
                            }
                            else if (consultarCategoria == 6)
                            {
                                Console.Clear();
                                List<Receitas> receitas3 = receitas.FindAll(x => x.Categoria == 6);
                                foreach (Receitas receitasPorCategoria in receitas3)
                                {
                                    Console.WriteLine(receitasPorCategoria);
                                }

                                Console.WriteLine();
                                Console.WriteLine("Deseja ver receitas por outra categoria? Digite 1 para sim ou 2 para não: ");
                                int outraCategoriaReceita = int.Parse(Console.ReadLine());
                                if (outraCategoriaReceita == 1)
                                {
                                    goto ReceitasPorCategoria;
                                }
                                else
                                {
                                    goto ReceitasRegistradas;
                                }
                            }
                            else if (consultarCategoria == 7)
                            {
                                Console.Clear();
                                List<Receitas> receitas3 = receitas.FindAll(x => x.Categoria == 7);
                                foreach (Receitas receitasPorCategoria in receitas3)
                                {
                                    Console.WriteLine(receitasPorCategoria);
                                }

                                Console.WriteLine();
                                Console.WriteLine("Deseja ver receitas por outra categoria? Digite 1 para sim ou 2 para não: ");
                                int outraCategoriaReceita = int.Parse(Console.ReadLine());
                                if (outraCategoriaReceita == 1)
                                {
                                    goto ReceitasPorCategoria;
                                }
                                else
                                {
                                    goto ReceitasRegistradas;
                                }
                            }
                            else if (consultarCategoria == 8)
                            {
                                Console.Clear();
                                List<Receitas> receitas3 = receitas.FindAll(x => x.Categoria == 8);
                                foreach (Receitas receitasPorCategoria in receitas3)
                                {
                                    Console.WriteLine(receitasPorCategoria);
                                }

                                Console.WriteLine();
                                Console.WriteLine("Deseja ver receitas por outra categoria? Digite 1 para sim ou 2 para não: ");
                                int outraCategoriaReceita = int.Parse(Console.ReadLine());
                                if (outraCategoriaReceita == 1)
                                {
                                    goto ReceitasPorCategoria;
                                }
                                else
                                {
                                    goto ReceitasRegistradas;
                                }
                            }

                            break;
                        case 4:

                        ReceitasPorTempoDePreparo:
                            Console.Clear();
                            Console.WriteLine("Qual opção você deseja consultar? ");
                            Console.WriteLine();
                            Console.WriteLine("Digite 1 para receitas de até 30 minutos");
                            Console.WriteLine("Digite 2 para receitas que levam  mais de 30 e menos de 60 minutos");
                            Console.WriteLine("Digite 3 para receitas que levam mais de 60 e menos que 120 minutos");
                            Console.WriteLine("Digite 4 para receitas que levam mais de 120 minutos");
                            int consultarTempoDePreparo = int.Parse(Console.ReadLine());
                            if (consultarTempoDePreparo == 1)
                            {
                                Console.Clear();
                                List<Receitas> receitas4 = receitas.FindAll(x => x.Tempo_De_Preparacao <= 30);
                                foreach (Receitas receitasPorTempoDePreparo in receitas4)
                                {
                                    Console.WriteLine(receitasPorTempoDePreparo);
                                }

                                Console.WriteLine();
                                Console.WriteLine("Deseja ver receitas por outro tempo de preparo? Digite 1 para sim ou 2 para não: ");
                                int outraTempoPreparoReceita = int.Parse(Console.ReadLine());
                                if (outraTempoPreparoReceita == 1)
                                {
                                    goto ReceitasPorTempoDePreparo;
                                }
                                else
                                {
                                    goto ReceitasRegistradas;
                                }
                            }
                            else if (consultarTempoDePreparo == 2)
                            {
                                Console.Clear();
                                List<Receitas> receitas4 = receitas.FindAll(x => x.Tempo_De_Preparacao > 30 && x.Tempo_De_Preparacao
                                <= 60);
                                foreach (Receitas receitasPorTempoDePreparo in receitas4)
                                {
                                    Console.WriteLine(receitasPorTempoDePreparo);
                                }

                                Console.WriteLine();
                                Console.WriteLine("Deseja ver receitas por outro tempo de preparo? Digite 1 para sim ou 2 para não: ");
                                int outraTempoPreparoReceita = int.Parse(Console.ReadLine());
                                if (outraTempoPreparoReceita == 1)
                                {
                                    goto ReceitasPorTempoDePreparo;
                                }
                                else
                                {
                                    goto ReceitasRegistradas;
                                }
                            }
                            else if (consultarTempoDePreparo == 3)
                            {
                                Console.Clear();
                                List<Receitas> receitas4 = receitas.FindAll(x => x.Tempo_De_Preparacao > 60 && x.Tempo_De_Preparacao <= 120);
                                foreach (Receitas receitasPorTempoDePreparo in receitas4)
                                {
                                    Console.WriteLine(receitasPorTempoDePreparo);
                                }

                                Console.WriteLine();
                                Console.WriteLine("Deseja ver receitas por outro tempo de preparo? Digite 1 para sim ou 2 para não: ");
                                int outraTempoPreparoReceita = int.Parse(Console.ReadLine());
                                if (outraTempoPreparoReceita == 1)
                                {
                                    goto ReceitasPorTempoDePreparo;
                                }
                                else
                                {
                                    goto ReceitasRegistradas;
                                }
                            }
                            else if (consultarTempoDePreparo == 4)
                            {
                                Console.Clear();
                                List<Receitas> receitas4 = receitas.FindAll(x => x.Tempo_De_Preparacao > 120);
                                foreach (Receitas receitasPorTempoDePreparo in receitas4)
                                {
                                    Console.WriteLine(receitasPorTempoDePreparo);
                                }

                                Console.WriteLine();
                                Console.WriteLine("Deseja ver receitas por outro tempo de preparo? Digite 1 para sim ou 2 para não: ");
                                int outraTempoPreparoReceita = int.Parse(Console.ReadLine());
                                if (outraTempoPreparoReceita == 1)
                                {
                                    goto ReceitasPorTempoDePreparo;
                                }
                                else
                                {
                                    goto ReceitasRegistradas;
                                }
                            }

                            break;

                        case 5:

                            goto MenuPrincipal;

                    }

                    break;

                case 3:
                EditarReceita:
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("                       EDITAR RECEITA                         ");
                    Console.WriteLine("**************************************************************");
                    Console.WriteLine();
                    Console.Write("Informe o nome da receita que deseja editar: ");
                    string editarReceita = Console.ReadLine();

                    var editar = receitas.Find(x => x.Nome_Da_Receita == editarReceita);

                    Console.WriteLine();
                    Console.WriteLine("O que deseja editar? ");
                    Console.WriteLine();
                    Console.WriteLine("Digite 1 para Nome da receita");
                    Console.WriteLine("Digite 2 para Tempo de Preparação");
                    Console.WriteLine("Digite 3 para Grau de Dificuldade");
                    Console.WriteLine("Digite 4 para Número de Pessoas");
                    Console.WriteLine("Digite 5 para Categoria");
                    Console.WriteLine("Digite 6 para Modo de Preparo");
                    int desejaEditar = int.Parse(Console.ReadLine());

                    switch (desejaEditar)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("                Editar Nome            ");
                            Console.WriteLine("***************************************");
                            Console.WriteLine();
                            Console.Write("Informe o novo nome: ");
                            editar.Nome_Da_Receita = Console.ReadLine();
                            Console.WriteLine();

                            Console.Clear();
                            Console.WriteLine("************************************************");
                            Console.WriteLine("          RECEITA EDITADA COM SUCESSO       ");
                            Console.WriteLine();
                            Console.WriteLine("Digite 1 para voltar ao Menu Principal: ");
                            int voltarMenu = int.Parse(Console.ReadLine());
                            if (voltarMenu == 1)
                            {
                                goto MenuPrincipal;
                            }
                            else
                            {
                                goto EditarReceita;
                            }


                        case 2:
                            Console.Clear();
                            Console.WriteLine("                Editar Tempo de Preparação            ");
                            Console.WriteLine("******************************************************");
                            Console.WriteLine();
                            Console.WriteLine("Informe o novo tempo de preparação em minutos: ");
                            editar.Tempo_De_Preparacao = int.Parse(Console.ReadLine());

                            Console.WriteLine();
                            Console.Clear();
                            Console.WriteLine("************************************************");
                            Console.WriteLine("          RECEITA EDITADA COM SUCESSO       ");
                            Console.WriteLine();
                            Console.WriteLine("Digite 1 para voltar ao Menu Principal: ");
                            int voltarMenu2 = int.Parse(Console.ReadLine());
                            if (voltarMenu2 == 1)
                            {
                                goto MenuPrincipal;
                            }
                            else
                            {
                                goto EditarReceita;
                            }



                        case 3:
                            Console.Clear();
                            Console.WriteLine("                Editar grau de Dificuldade            ");
                            Console.WriteLine("******************************************************");
                            Console.WriteLine();
                            Console.WriteLine("Informe o novo grau de dificuldade: ");
                            Console.WriteLine();
                            Console.WriteLine("Digite 1 para Fácil");
                            Console.WriteLine("Digite 2 para Médio");
                            Console.WriteLine("Digite 3 para Difícil");
                            editar.Grau_De_Dificuldade = int.Parse(Console.ReadLine());

                            Console.WriteLine();
                            Console.Clear();
                            Console.WriteLine("************************************************");
                            Console.WriteLine("          RECEITA EDITADA COM SUCESSO       ");
                            Console.WriteLine();
                            Console.WriteLine("Digite 1 para voltar ao Menu Principal: ");
                            int voltarMenu3 = int.Parse(Console.ReadLine());
                            if (voltarMenu3 == 1)
                            {
                                goto MenuPrincipal;
                            }
                            else
                            {
                                goto EditarReceita;
                            }

                        case 4:
                            Console.Clear();
                            Console.WriteLine("                Editar número de pessoas           ");
                            Console.WriteLine("***************************************************");
                            Console.WriteLine();
                            Console.Write("Informe o novo número de pessoas: ");
                            editar.Numero_De_Pessoas = int.Parse(Console.ReadLine());

                            Console.WriteLine();
                            Console.Clear();
                            Console.WriteLine("************************************************");
                            Console.WriteLine("          RECEITA EDITADA COM SUCESSO       ");
                            Console.WriteLine();
                            Console.WriteLine("Digite 1 para voltar ao Menu Principal: ");
                            int voltarMenu4 = int.Parse(Console.ReadLine());
                            if (voltarMenu4 == 1)
                            {
                                goto MenuPrincipal;
                            }
                            else
                            {
                                goto EditarReceita;
                            }




                        case 5:
                            Console.Clear();
                            Console.WriteLine("                Editar categoria            ");
                            Console.WriteLine("*********************************************");
                            Console.WriteLine();
                            Console.WriteLine("Informe a nova categoria: ");
                            Console.WriteLine();
                            Console.WriteLine("Digite 1 para Carne");
                            Console.WriteLine("Digite 2 para Peixes");
                            Console.WriteLine("Digite 3 para Mariscos");
                            Console.WriteLine("Digite 4 para Sobremesa");
                            Console.WriteLine("Digite 5 para Lanche");
                            Console.WriteLine("Digite 6 para Pastelaria");
                            Console.WriteLine("Digite 7 para Almoço");
                            Console.WriteLine("Digite 8 para Outra categoria");

                            editar.Categoria = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.Clear();
                            Console.WriteLine("************************************************");
                            Console.WriteLine("          RECEITA EDITADA COM SUCESSO       ");
                            Console.WriteLine();
                            Console.WriteLine("Digite 1 para voltar ao Menu Principal: ");

                            int voltarMenu5 = int.Parse(Console.ReadLine());
                            if (voltarMenu5 == 1)
                            {
                                goto MenuPrincipal;
                            }
                            else
                            {
                                goto EditarReceita;
                            }


                        case 6:
                            Console.Clear();
                            Console.WriteLine("                Editar modo de preparo            ");
                            Console.WriteLine("**************************************************");
                            Console.WriteLine();
                            Console.Write("Informe o novo modo de preparo: ");
                            editar.Descricao_De_Preparacao = Console.ReadLine();

                            Console.WriteLine();
                            Console.Clear();
                            Console.WriteLine("************************************************");
                            Console.WriteLine("          RECEITA EDITADA COM SUCESSO       ");
                            Console.WriteLine();
                            Console.WriteLine("Digite 1 para voltar ao Menu Principal: ");

                            int voltarMenu6 = int.Parse(Console.ReadLine());
                            if (voltarMenu6 == 1)
                            {
                                goto MenuPrincipal;
                            }
                            else
                            {
                                goto EditarReceita;
                            }

                    }
                    break;

                case 4:

                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("                       ELIMINAR RECEITA                        ");
                    Console.WriteLine("***************************************************************");
                    Console.WriteLine();
                    Console.Write("Informe o nome da receita que deseja eliminar: ");
                    string eliminarReceita = Console.ReadLine();

                    var eliminar = receitas.RemoveAll(x => x.Nome_Da_Receita == eliminarReceita);
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("************************************************");
                    Console.WriteLine("          RECEITA ELIMINADA COM SUCESSO       ");
                    Console.WriteLine();
                    Console.WriteLine("Digite 1 para voltar ao Menu Principal: ");

                    int voltarMenu7 = int.Parse(Console.ReadLine());
                    if (voltarMenu7 == 1)
                    {
                        goto MenuPrincipal;
                    }
                    else
                    {
                        goto EditarReceita;
                    }

                case 5:
                    Console.Clear();
                    break;
            }
        }
    }
}