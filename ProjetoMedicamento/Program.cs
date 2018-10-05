using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMedicamento
{
    class Program
    {
        #region OBJETOS STATICOS
        static Lote minhaListaLote;
        static Medicamento minhaListaMedicamento;
        static Medicamentos minhaListaMedicamentos;
        static Lote lotParc;
        static Medicamento medicParc;
        #endregion  

        static void Main(string[] args)
        {
            string opc;
            #region INSTANCIAS DOS OBJETOS
            minhaListaLote = new Lote();
            minhaListaMedicamento = new Medicamento();
            minhaListaMedicamentos = new Medicamentos();
            #endregion

            do
            {
                Console.Clear();

                Console.WriteLine("+=================================================================+");
                Console.WriteLine("| 0. Finalizar processo                                           |");                                        
                Console.WriteLine("| 1. Cadastrar medicamento                                        |");
                Console.WriteLine("| 2. Consultar medicamento (sintético: Informar dados)            |");
                Console.WriteLine("| 3. Consultar medicamento (analítico: Informar dados + Lotes)    |");
                Console.WriteLine("| 4. Comprar medicamento (Cadastrar lote)                         |");
                Console.WriteLine("| 5. Vender medicamento (Abater do lote mais antigo)              |");
                Console.WriteLine("| 6. Listar medicamentos (Informar dados sintéticos)              |");
                Console.WriteLine("+=================================================================+");
                opc = Console.ReadLine();

                Console.Clear();

                #region OPCAO 1
                if (opc == "1")
                {
                    Console.Clear();
                    //Entrada

                    //Variaveis
                    Int32 id;
                    Int32 idLote;
                    Int32 qtdeLote;
                    String nome;
                    String laboratorio;
                    DateTime vencLote;

                    Console.WriteLine("Informe qual é o ID do medicamento");
                    id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe qual é o nome do medicamento");
                    nome = Console.ReadLine();

                    Console.WriteLine("Informe qual é o nome do laboratório");
                    laboratorio = Console.ReadLine();

                    minhaListaMedicamentos.adicionar(new Medicamento(id, nome, laboratorio));

                    Console.WriteLine("Medicamento adicionado com sucesso!");

                    Console.ReadKey();
                }//OPC 1
                #endregion
                else if (opc == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Informe qual é o ID do medicamento que você gostaria de pesquisar.");
                    Int32 id = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();
                    Medicamento medicamento = minhaListaMedicamentos.pesquisar(new Medicamento(id, "1", "1"));

                    if (minhaListaMedicamentos.Existe == true)
                    {
                        Console.WriteLine("Medicamento encontrado.");
                    }
                    else
                    {
                        Console.WriteLine("Medicamento não existe na lista.");
                    }
                    minhaListaMedicamentos.Existe = false;
                    Console.WriteLine("");
                    Console.WriteLine(medicamento.toString());
                    Console.ReadKey();
                }//OPC 2
                else if (opc == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Informe qual é o ID do medicamento que você gostaria de pesquisar.");
                    Int32 id = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();
                    Medicamento medicamento = minhaListaMedicamentos.pesquisar(new Medicamento(id, "1", "1"));
                    foreach (Lote lot in minhaListaMedicamento.Lotes)
                    {
                        if (lot.Id.Equals(id))
                        {
                            lotParc = lot;
                        }
                    }

                    if (minhaListaMedicamentos.Existe == true)
                    {
                        Console.WriteLine("Medicamento encontrado.");
                    }
                    else
                    {
                        Console.WriteLine("Medicamento não existe na lista.");
                    }

                    minhaListaMedicamentos.Existe = false;
                    Console.WriteLine("");
                    Console.WriteLine(medicamento.toString() +" "+lotParc.toString());
                    Console.ReadKey();
                    /*
                    Console.Clear();
                    foreach (Lote lot in minhaListaMedicamento.Lotes)
                    {
                        lotParc = lot;
                        foreach (Medicamento medic in minhaListaMedicamentos.ListaMedicamentos)
                        {
                            medicParc = medic;
                        }
                        Console.WriteLine(medicParc.toString() + " " + lot.toString());
                    }*/
                    Console.ReadKey();
                }//OPC 3
                else if (opc == "4")
                {
                    Console.Clear();
                    Int32 id;
                    Int32 qtde;
                    DateTime venc = System.DateTime.MaxValue;

                    Console.WriteLine("Informe qual é o ID do Lote");
                    id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe qual é a quantidade e medicamentos do lote");
                    qtde = Convert.ToInt32(Console.ReadLine());

                    minhaListaMedicamento.comprar(new Lote(id, qtde, venc));

                    Console.Clear();
                    Console.WriteLine("Medicamento comprado sucesso.");
                    Console.ReadKey();
                }//OPC 4
                else if (opc == "5")
                {
                    Console.Clear();
                    Console.WriteLine("Informe qual é a quantidade a ser vendida ?");
                    Int32 qtde = Convert.ToInt32(Console.ReadLine());

                    if(minhaListaMedicamento.vender(qtde))
                    {
                        Console.WriteLine("Medicamento vendido com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Erro ao vender o medicamento. Por favor tente novamente.");
                    }
                    Console.ReadKey();
                }//OPC 5
                else if (opc == "6")
                {
                    Console.Clear();

                    foreach (Medicamento medic in minhaListaMedicamentos.ListaMedicamentos)
                    {
                        Console.WriteLine(medic.toString());
                    }
                    Console.ReadKey();
                }//OPC 6
            }//DO
            while (opc != "0");
        }//MAIN
    }//CLASS
}//NAMESPACE
