//1 - Creat an Var or an Vector
//2 - Creat a loop to run into the vector
//3 - "Add" a new random value to each position in the vector
//4 - Orginaze the vector (Bubble sort)

using System.Globalization;
using System.Numerics;



int[] Valores = new int[100];
Random r = new Random();
//bool trade = false;

 for (int i = 0; i < Valores.Length; i++)
 {
     Valores[i] = r.Next(0, 1000);
 }
  Array.Sort(Valores);



// for (int i = 0; i < Valores.Length; i++)
// {
//     Console.Write(Valores[i] + " ");
// }
// do
// {
//     trade = false;
//     for (int i = 0; i < Valores.Length - 1; i++)
//     {
//         if (Valores[i] > Valores[i + 1])
//         {
//             int aux = Valores[i];
//             Valores[i] = Valores[i + 1];
//             Valores[i + 1] = aux;
//             trade = true;
//         }

//     }
//     Console.WriteLine("\n");

// } while (trade);

 for (int i = 0; i < Valores.Length; i++)
 {
     Console.Write(Valores[i] + " ");
 }