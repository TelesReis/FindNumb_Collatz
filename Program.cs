using System.Collections.Generic;
using System.Collections;
using System;

namespace ConsoleApplicationVSCode
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<Int64, Int64?> numeroContagem = new Dictionary<Int64, Int64?>();
            int m = 1000000, nInicial = 0;
            Int64? count, max = 0;
            Console.WriteLine("Iniciando a execução");
            for (int i = 2; i < m; i++) {
                Int64 t = i;
                count = 0;
                if (t % 2 != 0) {                
                do {

                    if (t % 2 == 0) {
                        t = t / 2;

                    }
                    else {
                        t = 3 * t + 1;
                    }
                    count++;
                    
                    if (numeroContagem.ContainsKey(t)) {
                        //Console.WriteLine("aproveitado");
                        count += numeroContagem[t];
                        break;
                    }
                } while (t != 1);
                numeroContagem.Add(i, count);
                }
                if (count  > max) {
                    max = count;
                    nInicial = i;
                }

            }
            // foreach (KeyValuePair<Int32, int?> author in numeroContagem)  
            // {  
            //     Console.WriteLine("Key: {0}, Value: {1}",  
            //     author.Key, author.Value);  
            // }     
            Console.WriteLine(nInicial);
        }
    }
}