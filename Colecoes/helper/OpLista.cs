using System.Collections.Generic;

namespace Colecoes.helper
{
    public class OpLista
    {
        public void ImprimirLista1(List<string> Lista1)
        {
                    for (int i = 0; i < Lista1.Count; i++)
        {
            System.Console.WriteLine($"Indice {i}, valor {Lista1[i]}");
        }

        }
    }
}