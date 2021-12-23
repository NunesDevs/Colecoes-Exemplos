namespace Colecoes.helper
{
    public class OpArrays
    {
        
        public void OrdenarBubbleSort(ref int[] array){
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if(array[j] > array[j + 1]){
                        temp = array[j + 1];
                        array[j+1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        
        public void ImprimirArray(int[] array){
            var linha = string.Join(", " , array);
            System.Console.WriteLine(linha);
        }
        public void Ordenar1(ref int[] array1){
            Array.Sort(array1);
        }
        public void ImprimirArray1(int[] array1){
            var linha = string.Join(", " , array1);
            System.Console.WriteLine(linha);
        }

        public void Copiar(ref int[] array2, ref int[] arraycopia){
            Array.Copy(array2, arraycopia, array2.Length);
        }
        public void ImprimirArray2(int[] array2){
            var linha = string.Join(", " , array2);
            System.Console.WriteLine(linha);
        }
        public void Ordenar2(ref int[] array2){
            Array.Sort(array2);
        }

        public bool Existe(int[] array3, int valor){
            return Array.Exists(array3, elemento => elemento == valor);
        }
        public void ImprimirArray3(int[] array3){
            var linha = string.Join(", " , array3);
            System.Console.WriteLine(linha);
        }

    }
}