using System;
using System.Collections.Generic;
using System.Numerics;
public static class KataSumOfK
{
    public static int? chooseBestSum(int t, int k, List<int> ls)
    {
      
            // Validaciones iniciales: si no hay suficientes pueblos o k es inválido
            if (ls == null || ls.Count < k || k < 1)
            {
                return null; // O regresa -1 según lo requiera tu plataforma específica
            }

            // Obtenemos todas las combinaciones posibles de tamaño k
            var combinations = GetCombinations(ls, k);

            // Calculamos la suma de cada combinación
            var sums = combinations.Select(c => c.Sum());

            // Filtramos las sumas que no pasen el límite 't'
            var validSums = sums.Where(s => s <= t);

            // Si no hay ninguna suma válida, devolvemos null (o -1)
            if (!validSums.Any())
            {
                return null; // Cambiar a -1 si el validador te pide un entero estricto
            }

            // Devolvemos la suma máxima encontrada
            return validSums.Max();
        }

        // Método auxiliar recursivo para generar las combinaciones sin alterar la lista original
        private static IEnumerable<IEnumerable<int>> GetCombinations(List<int> list, int length)
        {
            if (length == 1)
                return list.Select(el => new[] { el });

            return GetCombinations(list, length - 1)
                .SelectMany((c, i) => list.Skip(i + 1)
                                          .Select(el => c.Concat(new[] { el })));
        }
    }


/*
 
 using System;
using System.Collections.Generic;

public class SumOfParts
{
    public static int ChooseBestSum(int t, int k, List<int> ls)
    {
        // Validaciones iniciales
        if (ls == null || ls.Count < k || k < 1)
        {
            return -1; 
        }

        // Convertimos la lista a un array para un acceso más rápido en memoria
        int[] distances = ls.ToArray();
        
        // Esta variable guardará la mejor suma encontrada (-1 si no hay ninguna válida)
        int bestSum = -1;

        // Iniciamos la búsqueda recursiva
        FindMaxSum(distances, t, k, 0, 0, 0, ref bestSum);

        return bestSum;
    }

    // Método recursivo (Backtracking)
    private static void FindMaxSum(int[] distances, int maxLimit, int townsToVisit, int currentIndex, int currentTownCount, int currentSum, ref int bestSum)
    {
        // CASO BASE 1: Si ya visitamos los 'k' pueblos requeridos
        if (currentTownCount == townsToVisit)
        {
            // Si la suma actual es menor o igual al límite y es mayor que la mejor que teníamos
            if (currentSum <= maxLimit && currentSum > bestSum)
            {
                bestSum = currentSum;
            }
            return;
        }

        // CASO BASE 2: Si ya revisamos todos los pueblos del array o nos pasamos del límite
        if (currentIndex >= distances.Length || currentSum > maxLimit)
        {
            return;
        }

        // OPCIÓN 1: Incluir el pueblo actual en el viaje
        FindMaxSum(distances, maxLimit, townsToVisit, currentIndex + 1, currentTownCount + 1, currentSum + distances[currentIndex], ref bestSum);

        // OPCIÓN 2: Ignorar el pueblo actual y pasar al siguiente
        FindMaxSum(distances, maxLimit, townsToVisit, currentIndex + 1, currentTownCount, currentSum, ref bestSum);
    }
}
 
 
 */

//if (ls == null)
//    return null;

//int[] combinations = new int[k];
//int[] combinations2 = new int[k];
//int flag = 0;
//int total = 0;
//int[] resultat = new int[k];
//List<int> bigger = new List<int>();

//for (int i = 0; i < k; i++)
//{
//    combinations[i] = ls[i];
//    if (i == k)
//    {
//        for (int j = 0; j < combinations.Length; j++)
//        {
//            resultat[j] = combinations[j];
//            total += resultat[j];
//        }               
//    }

//}
//bigger.Add(total);

//for (int i = k; i < ls.Count; i++)
//{
//    //total -= combinations[i - 1];
//    combinations[i - 1] = 0;
//     combinations[i] = ls[i];
//    total += combinations[i];
//    bigger.Add(total);
//    total -= combinations[i];

//}

//for (int i = 0; i < ls.Count; i++)
//{
//    combinations[i] = ls[i];
//    for (int j = i + 1; j < ls.Count; j++)
//    {
//        if (flag == k)
//        {
//            break;
//        }
//        combinations[j] = ls[j];
//        flag++;
//    }



//    combinations[flag] = ls[i];
//    flag++;
//    if (flag == k)
//    {
//        flag = 0;
//        for (int j = 0; j < k; j++)
//        {
//            resultat[j] = combinations[j];
//            total += resultat[j];
//        }
//        combinations = new int[k];
//        if (total <= t)
//        {
//            bigger.Add(total);
//            //for (int z = 0; z < resultat.Length; z++)
//            //{
//            //     bigger.Add(resultat[z]);
//            //}
//        }

//    }
//}



//return bigger.Max(); 
//}
//}