using System;

namespace Ejercicio_2
{
	class Program
	{



        static int n ;

      
        static int[,] dp;

       
       static  int[,] v;

       
        static int minSteps(int i, int j, int[,] arr)
        {
      
            if (i == n - 1 && j == n - 1)
            {
                return 0;
            }

            if (i > n - 1 || j > n - 1)
            {
                return 9999999;
            }

         
            if (v[i, j] ==1)
            {
                return dp[i, j];
            }

            v[i, j] = 1;

         
            dp[i, j] = 1 + Math.Min(minSteps(i + arr[i, j], j, arr),
                                minSteps(i, j + arr[i, j], arr));

            return dp[i, j];
        }
        static void Main(string[] args)
		{

            n = int.Parse(Console.ReadLine());


            string[] input = new string[n];
            for(int a = 0; a < n; a++)
			{
                input[a] = Console.ReadLine();
				if (input[a].Length > n)
				{
                    Console.WriteLine("Error la longitud de la cadena debe ser igual a" + n);
                    return;
				}
			}

            int[,] arr= new int[n,n];
            
            for (int b = 0; b < n; b++)
			{
                for(int c=0;c< n; c++)
				{
					if (input[b][c].Equals( '*'))
					{
                        arr[b, c] = 1;
					}
					else
					{
                        arr[b, c] = 5;
                    }
				}
			}


            
            Console.Clear();
            for(int a = 0; a < n; a++)
			{
                for(int b = 0; b < n; b++)
				{
                    Console.Write(arr[a, b]);
				}
                Console.Write("\n");
			}

           
			

            dp = new int[n, n];
           v = new int[n, n];




            int ans = minSteps(0, 0, arr);






           // Console.WriteLine(ans);
            int N = int.Parse(Console.ReadLine());
            if (N >= ans + 1)
			{
                Console.WriteLine("YES");
			}
			else
			{
                Console.WriteLine("No");
                
			}
            Console.ReadLine();
        }
	}
}



  
