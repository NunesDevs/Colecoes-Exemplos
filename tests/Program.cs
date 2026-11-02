using Colecoes.helper;
using System;
var helper = new OpArrays();
void Check(bool condition) { if (!condition) throw new Exception("Falha de regressão"); }
int[] values = {3,-5,0,3,1}; helper.OrdenarBubbleSort(ref values);
Check(string.Join(",",values)=="-5,0,1,3,3");
int[] empty={}; helper.OrdenarBubbleSort(ref empty); Check(empty.Length==0);
int[] copy=new int[values.Length]; helper.Copiar(ref values,ref copy); copy[0]=99;
Check(values[0]==-5); Check(helper.Existe(values,3)); Check(!helper.Existe(values,99));
Console.WriteLine("Coleções: ordenação, vazios, cópia e busca aprovados.");
