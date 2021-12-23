using System.Collections;
using System.Collections.Generic;
using Colecoes.helper;
using System;

Inicio:
Console.WriteLine("############################################\n# Atividades sobre orientação a obj com C# #\n############################################\nMenu:\n  - Array \n  - Matriz \n  - Ordenar \n  - Sort \n  - Copiar \n  - Existe \n  - Lista \n  - Remover\n  - Adicionar \n  - Fila\n  - Pilha \n  - Dicionario \n  - Consulta \n  - Sair: Encerra programa.");


switch (Console.ReadLine()){
    case "Array":
        int[] arrayInteiros = new int[3];
            arrayInteiros[0] = 10;
            arrayInteiros[1] = 20;
            arrayInteiros[2] = 30;
            System.Console.WriteLine("Utilizando for: ");
        
        for (int i = 0; i < arrayInteiros.Length; i++)
        {
            System.Console.WriteLine(arrayInteiros[i]);
        }

            System.Console.WriteLine("Utilizando foreach:");
        
        foreach (int item in arrayInteiros)
        {
            System.Console.WriteLine(item);
        }
    goto Inicio;

    case "Matriz":
        int[,] matriz = new int[4,2]{
            {
                8,8
            },
            {
                10,20
            },
            {
                50,100
            },
            {
                90,200
            }
        };

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int f = 0; f < matriz.GetLength(1); f++)
            {
                System.Console.WriteLine(matriz[i,f]);
            }
        }
    goto Inicio;

    case "Ordenar":
        int[] array = new int[6] {6,3,8,100,23,9};
        OpArrays op = new OpArrays();
        System.Console.WriteLine("Escolha: \n 1 - Ordenado\n 2 - Original");
            var opc = int.Parse(Console.ReadLine());
        
        if (opc == 2)
        {
            System.Console.WriteLine("Array padrão, sem utilizar ordenador de lista.");
            op.ImprimirArray(array);
        } else if (opc == 1)
        {
            System.Console.WriteLine("Array ordenado.");
            op.OrdenarBubbleSort(ref array);
            op.ImprimirArray(array);
        } else 
        {
            System.Console.WriteLine("Invalido.");
        }
    goto Inicio;

    case "Sort":
        int[] array1 = new int[6] {6,3,8,100,23,9};
        OpArrays op1 = new OpArrays();
        System.Console.WriteLine("Escolha: \n 1 - Ordenado\n 2 - Original");
            var opc1 = int.Parse(Console.ReadLine());
        
        if  (opc1 == 2)
        {
            System.Console.WriteLine("Array padrão, sem utilizar ordenador de lista.");
            op1.ImprimirArray1(array1);
        } else if (opc1 == 1)
        {
            System.Console.WriteLine("Array ordenado.");
            op1.Ordenar1(ref array1);
            op1.ImprimirArray1(array1);
        } else 
        {
            System.Console.WriteLine("Invalido.");
        }
    goto Inicio;

    case "Copiar":
        int[] array2 = new int[6] {6,3,8,100,23,9};
        int[] arraycopia = new int[10];
        OpArrays op2 = new OpArrays();
        System.Console.WriteLine("Escolha: \n 1 - Ordenado\n 2 - Original\n 3 - Copiar");
            var opc2 = int.Parse(Console.ReadLine());
        
        if (opc2 == 2)
        {
            System.Console.WriteLine("Array padrão, sem utilizar ordenador de lista.");
            op2.ImprimirArray2(array2);
        } else if (opc2 == 1)
        {
            System.Console.WriteLine("Array ordenado.");
            op2.Ordenar2(ref array2);
            op2.ImprimirArray2(array2);
        } else if (opc2 == 3)
        {
            op2.ImprimirArray2(arraycopia);
            op2.Copiar(ref array2, ref arraycopia);
            System.Console.WriteLine("Array copiado");
            op2.ImprimirArray2(arraycopia);
        } else
        {
            System.Console.WriteLine("Invalido.");
        }
    goto Inicio;

    case "Existe":
        int[] array3 = new int[20] {6,3,8,100,23,9,12,33,45,17,66,54,31,67,53,234,56,432,45,567};
        System.Console.WriteLine("Qual valor procura?");
            var valorProcurado = int.Parse(Console.ReadLine());
        OpArrays op3 = new OpArrays();
        bool existe = op3.Existe(array3, valorProcurado);
        
        if (existe)
        {
            System.Console.WriteLine("Valor encontrado: " , valorProcurado);
        } else 
        {
            System.Console.WriteLine("Não encontrado");
        }

    goto Inicio;

    case "Lista":
        OpLista OpL1 = new OpLista(); 
        List<string> Lista1 = new List<string>();
        System.Console.WriteLine("Primeiro valor:");
            string p = Console.ReadLine();
        System.Console.WriteLine("Segundo valor: ");
            string s = Console.ReadLine();
        System.Console.WriteLine("Terceiro valor: ");
            string t = Console.ReadLine();    
        
        Lista1.Add(p);
        Lista1.Add(s);
        Lista1.Add(t);

        System.Console.WriteLine($"Qantidade de elementos na lista: {Lista1.Count}" );

        System.Console.WriteLine("Lendo elementos...");
    
        OpL1.ImprimirLista1(Lista1);
    goto Inicio;

    case "Remover":
        OpLista OpL2 = new OpLista(); 
        List<string> Lista2 = new List<string>();
        System.Console.WriteLine("Primeiro valor:");
            string p1 = Console.ReadLine();
        System.Console.WriteLine("Segundo valor: ");
            string s1 = Console.ReadLine();
        System.Console.WriteLine("Terceiro valor: ");
            string t1 = Console.ReadLine();    
        
        Lista2.Add(p1);
        Lista2.Add(s1);
        Lista2.Add(t1);

        System.Console.WriteLine($"Qantidade de elementos na lista: {Lista2.Count}" );

        System.Console.WriteLine("Lendo elementos... ");
    
        OpL2.ImprimirLista1(Lista2);
        System.Console.WriteLine("Deseja remover elemento? S ou enter para continuar");
        var rm = Console.ReadLine();
        if (rm == "S")
        {
            System.Console.WriteLine("Digite o item de sua lista a ser removido.");
                var r = Console.ReadLine();
        Lista2.Remove(r);
        }
        System.Console.WriteLine("Encerrando.");
    goto Inicio;

    case "Adicionar":
        OpLista OpL3 = new OpLista(); 
        List<string> Lista3 = new List<string>();
        System.Console.WriteLine("Primeiro valor:");
            string p2 = Console.ReadLine();
        System.Console.WriteLine("Segundo valor: ");
            string s2 = Console.ReadLine();
        System.Console.WriteLine("Terceiro valor: ");
            string t2 = Console.ReadLine();    
        
        Lista3.Add(p2);
        Lista3.Add(s2);
        Lista3.Add(t2);

        System.Console.WriteLine("Digite outros dois valores:");
            System.Console.WriteLine("Primeiro");
                var ne1 = Console.ReadLine();
            System.Console.WriteLine("Segundo");
                var ne2 = Console.ReadLine();

        string[] novosElementos = new string[2] {ne1 , ne2};

        System.Console.WriteLine($"Quantidade de elementos na lista: {Lista3.Count}" );

        System.Console.WriteLine("Lendo elementos...");
    
        OpL3.ImprimirLista1(Lista3);

        System.Console.WriteLine("Deseja adicionar os outros dois valores? S para sim enter para encerrar.");
            var esc = Console.ReadLine();
        
        if (esc == "S")
        {
            Lista3.AddRange(novosElementos);
            OpL3.ImprimirLista1(Lista3);
        }
        System.Console.WriteLine("Encerrando.");
    goto Inicio;
    
    case "Fila":
        Queue<string> fila1 = new Queue<string>();

        System.Console.WriteLine("Entre com um item para a fila:");
            var el1 = Console.ReadLine();
        System.Console.WriteLine("Entre com mais um item para a fila:");
            var el2 = Console.ReadLine();

        System.Console.WriteLine("Entre com mais um item para a fila:");
            var el3 = Console.ReadLine();

        System.Console.WriteLine("Entre com mais um item para a fila:");
            var el4 = Console.ReadLine();

        fila1.Enqueue(el1);
        fila1.Enqueue(el2);
        fila1.Enqueue(el3);
        fila1.Enqueue(el4);

        System.Console.WriteLine($"Itens na fila: {fila1.Count()}");
        while (fila1.Count > 0)
        {
            System.Console.WriteLine($"Item de sua fila: {fila1.Peek()}");
            System.Console.WriteLine($"{fila1.Dequeue()} Pronto.");
        }
        System.Console.WriteLine($"Itens na fila: {fila1.Count}");
    goto Inicio;

    case "Pilha":
        Stack<string> pilha1 = new Stack<string>();

        System.Console.WriteLine("Entre com o primeiro item da pilha.");
            var pl1 = Console.ReadLine();

        System.Console.WriteLine("Entre com o segundo item da pilha.");
            var pl2 = Console.ReadLine();

        System.Console.WriteLine("Entre com o terceiro item da pilha.");
            var pl3 = Console.ReadLine();

        System.Console.WriteLine("Entre com o quarto item da pilha.");
            var pl4 = Console.ReadLine();

        System.Console.WriteLine("Entre com o quinto item da pilha.");
            var pl5 = Console.ReadLine();

        
        pilha1.Push(pl1);
        pilha1.Push(pl2);
        pilha1.Push(pl3);
        pilha1.Push(pl4);
        pilha1.Push(pl5);

        System.Console.WriteLine($"Itens na pilha: {pilha1.Count}");

        while (pilha1.Count > 0)
        {
            System.Console.WriteLine($"Proximo item: {pilha1.Peek()}");
            System.Console.WriteLine($"Pronto {pilha1.Pop()}");    
        }
            System.Console.WriteLine($"Itens na pilha: {pilha1.Count}");
    goto Inicio;

    case "Dicionario":
        Dictionary<string, string> dicionarioItem = new Dictionary<string, string>();

        System.Console.WriteLine("Digite uma chave.");
            var key1 = Console.ReadLine();
                System.Console.WriteLine("Digite o conteudo dela.");
                    var conteudo1 = Console.ReadLine();

        System.Console.WriteLine("Digite uma chave.");    
            var key2 = Console.ReadLine();
                System.Console.WriteLine("Digite o conteudo dela.");
                    var conteudo2 = Console.ReadLine();
        
        System.Console.WriteLine("Digite uma chave.");
            var key3 = Console.ReadLine();
                System.Console.WriteLine("Digite o conteudo dela.");
                    var conteudo3 = Console.ReadLine();
        
        System.Console.WriteLine("Digite uma chave.");
            var key4 = Console.ReadLine();
                System.Console.WriteLine("Digite o conteudo dela.");
                    var conteudo4 = Console.ReadLine();
        
        System.Console.WriteLine("Digite uma chave.");
            var key5 = Console.ReadLine();
                System.Console.WriteLine("Digite o conteudo dela.");
                    var conteudo5 = Console.ReadLine();

        dicionarioItem.Add(key1, conteudo1);
        dicionarioItem.Add(key2, conteudo2);
        dicionarioItem.Add(key3, conteudo3);
        dicionarioItem.Add(key4, conteudo4);
        dicionarioItem.Add(key5, conteudo5);
        
        menu:
        System.Console.WriteLine(" 1 - Indice\n 2 - Acessar valor\n 3 - Atualizar valor\n 4 - Remover valor");
        var option = int.Parse(Console.ReadLine());

        if (option == 1)
        {
            foreach (KeyValuePair<string, string> item in dicionarioItem)
            {
                System.Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
                
            } goto menu;
        } else if (option == 2)
        {
            System.Console.WriteLine("Entre com a chave: ");
            string valorProcur = Console.ReadLine();
            System.Console.WriteLine(dicionarioItem[valorProcur]);
            goto menu;
        } else if (option == 3)
        {
            System.Console.WriteLine("Entre com a chave: ");
                string valorProcura = Console.ReadLine();
            System.Console.WriteLine("Valor original: ");
            System.Console.WriteLine(dicionarioItem[valorProcura]);
            
            System.Console.WriteLine("Qua valor deseja colocar no lugar? ");
                string novoValor = Console.ReadLine();
            dicionarioItem[valorProcura] = novoValor;
            System.Console.WriteLine("Valor atualizado: ");
            System.Console.WriteLine(dicionarioItem[valorProcura]);
            goto menu;
        } else if (option == 4)
        {
            foreach (KeyValuePair<string, string> item in dicionarioItem)
            {
                System.Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
                
            } 

            System.Console.WriteLine("Qual valor deseja remover? ");
                string valorRemove = Console.ReadLine();

            System.Console.WriteLine($"Removendo o valor {valorRemove}");
            dicionarioItem.Remove(valorRemove);
            System.Console.WriteLine("Nova lista: ");
            foreach (KeyValuePair<string, string> item in dicionarioItem)
            {
                System.Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
                
            } goto menu;
        } else 
        {
            System.Console.WriteLine("Invalido.");
        }
    goto Inicio;

    case "Consulta":
        System.Console.WriteLine("Criando um array, entre com 5 valores.");

        System.Console.WriteLine("Valor 1:");
            var a = int.Parse(Console.ReadLine());
            
        System.Console.WriteLine("Valor 2:");
            var b = int.Parse(Console.ReadLine());
            
        System.Console.WriteLine("Valor 3:");
            var c = int.Parse(Console.ReadLine());
            
        System.Console.WriteLine("Valor 4:");
            var d = int.Parse(Console.ReadLine());
            
        System.Console.WriteLine("Valor 5:");
            var e = int.Parse(Console.ReadLine());
            

        int[] arrayNumeros = new int[5] {a, b, c, d, e};


        System.Console.WriteLine("Consulta numeros pares.");
        consumenu:
        System.Console.WriteLine(" 1 - Obter valores\n 2 - Ordenar\n 3 - Valores minimos, máximos e médios");
        var consu = int.Parse(Console.ReadLine());
        if (consu == 1)
        {
            var numerosPares = 
                from num in arrayNumeros
                where num % 2 == 0
                select num;

                System.Console.WriteLine("Numeros pares:" + string.Join(", ", numerosPares));
                goto consumenu;
        } else if (consu == 2)
        {
                var numerosParesMetodos = arrayNumeros.Where( x => x % 2 == 0).OrderBy(x => x).ToList();
                System.Console.WriteLine("Numeros ordenados: " + string.Join(", ", numerosParesMetodos));
                goto consumenu;
        } else if (consu == 3)
        {
            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();

            System.Console.WriteLine($"Minimo: {minimo}\nMáximo: {maximo}\nMédio: {medio}");
        } else {
            System.Console.WriteLine("Invalido");
        }
    goto Inicio;

    case "Sair":
        System.Console.WriteLine("Obrigado por testar meu código!!");
        Environment.Exit(0);
    goto Inicio;

    default:

    System.Console.WriteLine("Menu invalido, tente novamente.");

    goto Inicio;
}
