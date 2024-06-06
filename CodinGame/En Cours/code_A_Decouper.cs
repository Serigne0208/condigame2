//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Metrics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CodinGame.En_Cours
//{
//    internal class code_A_Decouper
//    {
        
												  
												  
//	// calcule la sommme des multiplication 

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;



//namespace SommeFacteur
//    {
//        class Program
//        {

//            /*int somme = 0;
//                for(int i=0; i<n; i++)
//                {
//                    if(i%3==0 || i%5==0 || i%7==0 )
//                    {
//                        somme += i;
//                    }
//                }
//                return somme;

//                */



//            public static int ComputeMultiplesSum(int n)
//            {
//                List<int> multiplesDe3 = new List<int>();
//                List<int> multiplesDe5 = new List<int>();
//                List<int> multiplesDe7 = new List<int>();

//                for (int i = 3; i <= n; i += 3)
//                {
//                    multiplesDe3.Add(i);
//                }

//                for (int i = 5; i <= n; i += 5)
//                {
//                    multiplesDe5.Add(i);
//                }

//                for (int i = 7; i <= n; i += 7)
//                {
//                    multiplesDe5.Add(i);
//                }

//                multiplesDe3.AddRange(multiplesDe5);
//                multiplesDe7.AddRange(multiplesDe3);

//                int somme = 0;
//                foreach (int m3 in multiplesDe7)
//                {
//                    somme += m3;
//                }
//                return somme;

//                //return default(int);
//            }
//            static void Main(string[] args)
//            {
//                int n = int.Parse(Console.ReadLine());
//                var stdtoutWriter = Console.Out;
//                Console.SetOut(Console.Error);
//                int res = ComputeMultiplesSum(n);
//                Console.SetOut(stdtoutWriter);
//                Console.WriteLine(res);
//                Console.WriteLine("appuyer sur une touche");
//                Console.ReadKey();

//            }
//        }
//    }

//    // expresion boleeen
//    namespace BooleenSimple
//    {
//        class Program
//        {


//            /// Tests that one of the arguments, or their sum, equals 1.
//            public static bool Test(int i, int j)
//            {
//                if (i == 1 || j == 1)
//                {
//                    return true;
//                }
//                else if ((i + j) == 1)
//                {
//                    return true;
//                }
//                else
//                {
//                    return false;
//                }

//            }
//            public static void Main(string[] args)
//            {
//                Console.WriteLine(Program.Test(4, 3));
//                Console.WriteLine("appuyer sur une touche");
//                Console.ReadKey();
//            }

//            private static void Test()
//            {
//                throw new NotImplementedException();
//            }
//        }
//    }


//    //  Argorithme find
//    class Program
//    {
//        /// Finds the largest number in the <c>numbers</c> array.
//        public static int FindLargest(int[] numbers)
//        {
//            var max = numbers[0];

//            for (var i = 1; i < numbers.Length; i++)
//            {
//                if (max < numbers[i])
//                    max = numbers[i];
//            }

//            return max;
//        }

//        static void Main(string[] args)
//        {
//            int[] numbers = { 1, 1000, 4, 25 };
//            Console.WriteLine(Program.FindLargest(numbers));
//            Console.WriteLine("appuyer sur une touche");
//            Console.ReadKey();
//        }
//    }

//    /// combinaison
//    class Program
//    {
//        public static int Count(int n)
//        {
//            return n*(n-1)/2;
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine(Program.Count(1000));
//            Console.WriteLine("appuyer sur une touche");
//            Console.ReadKey();
//        }
//    }

//    /// parcours noeud
//    namespace NoeudTerminal
//    {
//        class Program
//        {
//            public static int FindNetworkEndpoint(int starNodeId, int[] fromIds, int[] toIds)
//            {
//                bool chemin = true;

//                var dejapasse = new List<int>();
//                //dejapasse.Add(starNodeId);

//                if (!fromIds.Contains(starNodeId))
//                {
//                    return starNodeId;
//                }

//                while (chemin)
//                {
//                    for (int i = 0; i<fromIds.Length; i++)
//                    {
//                        if (starNodeId==fromIds[i])
//                        {
//                            starNodeId=toIds[i];
//                            // dejapasse.Add(starNodeId);
//                        }

//                    }
//                    // verifier condition s'il y'a boucle encore sue le derniere noeud
//                    if (!fromIds.Contains(starNodeId) || !dejapasse.Contains(starNodeId))
//                    {
//                        chemin=false;
//                    }

//                }

//                return starNodeId;
//            }


//        }
	
	
	
	
	
	
	
	
//	//billet
	
//	using System;

//// Do not modify Change
//class Change
//        {
//            public long coin2 = 0;
//            public long bill5 = 0;
//            public long bill10 = 0;
//        }

//        class Solution
//        {

//            // Do not modify this method​​​​​​‌​​​‌​‌‌​‌‌‌​‌‌​‌‌‌‌​‌‌‌‌ signature
//            public static Change OptimalChange(long s)
//            {

//                Change change = new Change();
//                if (s == 1 || s == 3)
//                {
//                    return null;
//                }
//                if (s % 2 == 0)
//                {
//                    change.bill10 = s / 10;
//                    change.bill5 = (s - change.bill10 * 10) / 5;

//                    if (s % 10 <= 5)
//                    {
//                        change.coin2 = (s - (change.bill10 * 10 + change.bill5 * 5)) / 2;
//                    }
//                    else
//                    {
//                        change.coin2 = (s - (change.bill10 * 10 + change.bill5 * 5)) / 2;
//                    }
//                }

//                else
//                {
//                    if (s % 10 >= 5)
//                    {
//                        change.bill10 = s / 10;
//                        change.bill5 = (s - change.bill10 * 10) / 5;
//                        change.coin2 = (s - (change.bill10 * 10 + change.bill5 * 5)) / 2;
//                    }
//                    else
//                    {
//                        change.bill10 = s/10 -1;
//                        change.bill5 = (s - change.bill10 * 10) / 5 -1;
//                        change.coin2 = (s - (change.bill10 * 10 + change.bill5 * 5)) / 2;
//                    }
//                }
//                Console.WriteLine("billet10 =" + change.bill10.ToString());
//                Console.WriteLine("billet5 =" + change.bill5.ToString());
//                Console.WriteLine("billet2 =" + change.coin2.ToString());
//                return change;
//            }
//        }

//        long s = 10; // Change this value to perform other tests
//        Change m = Solution.OptimalChange(s);

//        Console.WriteLine("Coin(s)  2€: " + m.coin2);
//Console.WriteLine("Bill(s)  5€: " + m.bill5);
//Console.WriteLine("Bill(s) 10€: " + m.bill10);

//long result = m.coin2 * 2 + m.bill5 * 5 + m.bill10 * 10;
//        Console.WriteLine("\nChange given = " + result);

//// pi

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Appi
//        {
//            struct Point
//            {
//                public double x;
//                public double y;
//            }

//            class Program
//            {
//                static double Pi_Estimation(Point[] p)
//                {
//                    double result;
//                    int Numbre = 0;
//                    for (int i = 0; i < p.Length; i++)
//                    {
//                        if ((p[i].x * p[i].x + p[i].y * p[i].y) <= 1)
//                        {
//                            Numbre += 1;
//                        }

//                    }
//                    Console.WriteLine("Hello you");
//                    result = Numbre / (double)p.Length;
//                    return result * 4;

//                }
//                static void Main(string[] args)
//                {
//                }
//            }
//        }

//        Mettez à jour le code en appliquant les règles suivantes : Si une exception est levée par s.Execute() alors
//    appeler c.Rollback() et propager l'exception, sinon appeler c.Commit() Dans tous les cas, c.Close() doit
//être appelée avant de quitter la méthode Run(Service s, Connection c)
    
// using System;
// using System.IO;

// public class Answer
//        {
//            /// Executes the service with the given connection.
//            public void Run(Service s, Connection c)
//            {
//                s.SetConnection(c);
//                try
//                {
//                    s.Execute();
//                    c.Commit();
//                }
//                catch (Exception e)
//                {
//                    c.Rollback();
//                    throw new Exception(e.Message);
//                }
//                finally
//                {
//                    c.Close();
//                }
//            }
//        }

//        /// Definition of a service
//        public interface Service
//        {
//            void Execute();
//            void SetConnection(Connection c);
//        }

//        /// Definition of a connection
//        public interface Connection
//        {
//            void Commit();
//            void Rollback();
//            void Close();

//using System;
//using System.Collections.Generic;
//using System.Text;




//namespace uTESTs1_7_COMBO
//        {
//            class Jointure
//            {
//                public static int ComputeJoinPoint(int s1, int s2)
//                {
//                    // Write your code here
//                    // To debug: console.error('Debug messages...');
//                    Console.WriteLine("--- --- --- " + s1 + " " + s2 + " --- --- ---");

//                    while (s1 < 20000000 && s2 < 20000000 && s1 != s2)
//                    {
//                        if (s1 < s2)
//                            s1 += machine(s1);
//                        if (s1 > s2)
//                            s2 += machine(s2);
//                    }

//                    if (s1 == s2)
//                        return s1;
//                    else
//                        return 0;
//                }

//                public static int machine(int s3)
//                {
//                    int answer = 0;
//                    while (s3 >= 1)
//                    {
//                        answer += (s3 % 10);
//                        s3 = s3 / 10;
//                    }
//                    return answer;
//                }
//            }
//        }


//        public static int ComputeJoinPoint(int s1, int s2)
//        {
//            // Write your code here
//            // To debug: Console.Error.WriteLine("Debug messages...");

//            int result = 0;
//            string st_1;
//            string st_2;

//            while (s1 != s2)
//            {
//                st_1 = s1.ToString();
//                st_2 = s2.ToString();

//                if (s1 < s2)
//                {
//                    foreach (var item in st_1)
//                    {
//                        s1 = s1 + int.Parse(item.ToString());
//                    }
//                }
//                else
//                {
//                    foreach (var item in st_2)
//                    {
//                        s2 = s2 + int.Parse(item.ToString());
//                    }
//                }
//            }

//            result = s1;

//            return result;
//        }
	
	
//	//doublon
//using System;
//using System.Linq;
//using System.IO;
//using System.Text;
//using System.Collections;
//using System.Collections.Generic;

//class Solution
//        {
//            public static int[] Doublons(int[] data)
//            {
//                // Write your code here
//                // To debug: Console.Error.WriteLine("Debug messages...");

//                IList<int> temp = new List<int>();
//                for (int i = 0; i < data.Length; i++)
//                {
//                    if (temp.Contains(data[i]) == false)
//                    {
//                        temp.Add(data[i]);
//                    }
//                }
//                int[] answer = new int[temp.Count];
//                for (int j = 0; j < temp.Count; j++)
//                {
//                    answer[j] = temp[j];
//                }
//                return answer;
//            }
//        }
//        /* Ignore and do not change the code below */
//        #region
//        static void Main(string[] args)
//        {
//            string[] inputs;
//            int n = int.Parse(Console.ReadLine());
//            int[] data = new int[n];
//            inputs = Console.ReadLine().Split(' ');
//            for (int i = 0; i < n; i++)
//            {
//                data[i] = int.Parse(inputs[i]);
//            }
//            var stdtoutWriter = Console.Out;
//            Console.SetOut(Console.Error);
//            int[] filtered = FilterDuplicates(data);
//            Console.SetOut(stdtoutWriter);
//            for (int i = 0; i < filtered.GetLength(0); i++)
//            {
//                Console.WriteLine(filtered[i]);
//            }
//        }

//        //dupplication

//        public static int[] FilterDuplicates(int[] data)
//        {
//            // Write your code here
//            // To debug: Console.Error.WriteLine("Debug messages...");
//            IList<int> temp = new List<int>();
//            Array.Sort(data);
//            for (int i = 0; i < data.Length-1; i++)
//            {
//                if (data[i] == data[i+1])
//                {
//                    temp.Add(data[i]);
//                }
//            }
//            int[] answer = new int[temp.Count];
//            for (int j = 0; j < temp.Count; j++)
//            {
//                answer[j] = temp[j];
//            }
//            return answer;
//        }
	
//	using System;
//using System.Linq;
//using System.IO;
//using System.Text;
//using System.Collections;
//using System.Collections.Generic;

//class Solution
//        {

//            public static int[] FilterDuplicates(int[] data)
//            {
//                // Write your code here
//                // To debug: Console.Error.WriteLine("Debug messages...");
//                IList<int> temp = new List<int>();
//                Array.Sort(data);
//                for (int i = 0; i < data.Length-1; i++)
//                {
//                    if (data[i] == data[i+1])
//                    {
//                        temp.Add(data[i]);
//                    }
//                }
//                int[] answer = new int[temp.Count];
//                for (int j = 0; j < temp.Count; j++)
//                {
//                    answer[j] = temp[j];
//                }
//                var final = new HashSet<int>(answer).ToList();
//                return final.ToArray();
//            }

//            /* Ignore and do not change the code below */
//            #region
//            static void Main(string[] args)
//            {
//                string[] inputs;
//                int n = int.Parse(Console.ReadLine());
//                int[] data = new int[n];
//                inputs = Console.ReadLine().Split(' ');
//                for (int i = 0; i < n; i++)
//                {
//                    data[i] = int.Parse(inputs[i]);
//                }
//                var stdtoutWriter = Console.Out;
//                Console.SetOut(Console.Error);
//                int[] filtered = FilterDuplicates(data);
//                Console.SetOut(stdtoutWriter);
//                for (int i = 0; i < filtered.GetLength(0); i++)
//                {
//                    Console.WriteLine(filtered[i]);
//                }
//            }
//            #endregion
//        }
	
//	/* le plus petit intervalle positif entre deux elements du tableau numbers */
	
//using System.Collections.Generic

//class SmallestInterval
//        {
//            public static int FindSmallestInterval(int[] numbers)
//            {
//                int answer = 0.
//                Array.Sort(numbers);
//                for (int i = 0.I<numbers.Length -1), i++)
//		  {
//                    if (i==0 || (numbers[i+1] - numbers[i]< answer))
//                        answer=(numbers[i+1] - numbers[i]);
//                }
//                return answer;
//            }
//        }
//    }
//}
