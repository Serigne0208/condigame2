using CodinGame.A_Tester;
using CodinGame.En_Cours;
using CodinGame.Fini;
using System;
using System.Collections.Generic;
using System.IO;

namespace CodinGame
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (Console.ReadLine())
            {
                case "PI":

                    var rands = new _38_CalculerPi.Point[100000];
                    Random random = new Random();

                    for (int i = 0; i < rands.Length; i++)
                    {
                        _38_CalculerPi.Point p = new _38_CalculerPi.Point();
                        p.x = random.NextDouble(); //x
                        p.y = random.NextDouble(); //y
                        rands[i] = p;
                    }

                    double Test = _38_CalculerPi.Approx(rands);

                    Console.WriteLine(Test);
                    break;

                case "Billet":
                    long s = 1;

                    Change change = _39_Billet.OptimalChange(s);

                    Console.WriteLine("monnaie " + s);

                    Console.WriteLine("Coin(s) 2€: " + change.coin2);
                    Console.WriteLine("Bill(s) 5€: " + change.bill5);
                    Console.WriteLine("Bill(s) 10€: " + change.bill10);

                    long result = change.coin2 * 2 + change.bill5 * 5 + change.bill10 * 10;
                    Console.WriteLine("\nChange given = " + result);

                    break;

                case "Carton":
                    int[] boxesA = { 90, 190 };
                    int[] boxesB = { 130, 160 };
                    int[] boxesC = { 160 };
                    string[] deplacement = _57_Cartons.Solve(boxesA, boxesB, boxesC);

                    foreach (string d in deplacement)
                        Console.WriteLine(d);

                    break;

                case "formula":


                    Console.Write(_54_UniverseFormula.Find());

                    break;

                case "intervalle":
                    int[] array = { 0, 1, 2, 3, 4, 5, 3 };
                    Console.WriteLine(_40_Intervalle.Calc(array, 0, 1)); //1
                    Console.WriteLine(_40_Intervalle.Calc(array, 0, 5)); //15
                    Console.WriteLine(_40_Intervalle.Calc(array, 0, 0)); //0
                    Console.WriteLine(_40_Intervalle.Calc(array, 0, 6)); //18

                    break;

                case "Danse":

                    Console.WriteLine(_41_Nouvelle_Danse.GetPositionAt(3)); //-4
                    Console.WriteLine(_41_Nouvelle_Danse.GetPositionAt(100000)); //-5
                    Console.WriteLine(_41_Nouvelle_Danse.GetPositionAt(2147483647)); //1

                    break;

                case "Pierre":

                    List<int> stones = new List<int>(new int[] { 1, 1 });
                    Console.WriteLine(_55_StoneMagic.Magic(stones));//1

                    stones = new List<int>(new int[] { 1, 1, 5 });
                    Console.WriteLine(_55_StoneMagic.Magic(stones));//2

                    stones = new List<int>(new int[] { 1, 1, 2, 3, 3, 3, 5, 6, 6, 6, 6, 6, 6, 6, 6, 9 });
                    Console.WriteLine(_55_StoneMagic.Magic(stones));//2
                    break;

                case "Encode":
                    string plainText = "aabaa";
                    Console.WriteLine(_56_Occurence.Encode(plainText)); // 2a1b2a

                    plainText = "aaaabcccaaa";
                    Console.WriteLine(_56_Occurence.Encode(plainText)); //4a1b3c3a

                    break;

                case "Solde":
                    int[] prices = { 100, 400, 200 };
                    Console.WriteLine(_42_Solde.CalculateTotalPrice(prices, 20));

                    break;

                case "Filter":
                    var strings = new List<string>();
                    var filteredStrings = new _43_Filter().filter(strings);

                    strings.Add("Gurt");
                    strings.Add("Lobster");
                    strings.Add("Litch");
                    strings.Add("Doe");

                    foreach (var str in filteredStrings)
                    {
                        Console.WriteLine(str);
                    }

                    break;

                case "Paire":

                    Console.WriteLine(_44_NombrePaire.Count(4));
                    Console.WriteLine(_44_NombrePaire.Count(10000));
                    break;

                case "IsTwin":

                    Console.WriteLine(_46_IsTwin.isTwin("Hello", "world")); //Faux 372 392
                    Console.WriteLine(_46_IsTwin.isTwin("acb", "bca")); // Vrai
                    Console.WriteLine(_46_IsTwin.isTwin("Lookout", "Outloook")); //Vrai
                    break;

                case "Fizz":
                    Dictionary<int, string> map = new Dictionary<int, string>();

                    map[3] = "FIZZ";
                    map[4] = "BUZZ";

                    Console.WriteLine(_48_FizzBuzz.FizzBuzz(5, map)); //5
                    Console.WriteLine(_48_FizzBuzz.FizzBuzz(3, map)); //FIZZ
                    Console.WriteLine(_48_FizzBuzz.FizzBuzz(8, map)); //BUZZ
                    Console.WriteLine(_48_FizzBuzz.FizzBuzz(12, map)); //FIZZBUZZ

                    break;

                case "data":
                    int[] data = { 7, 3, 6, 4, 3, 3, 4, 9 }; // 7 3 6 4 9
                    int[] q = _59_SansDoublons.FilterDuplicate(data);

                    foreach (int doublon in q)
                    {
                        Console.WriteLine(doublon);
                    }

                    break;

                case "matrix":
                    int[,] M = new int[6, 5]{{0, 1, 1, 0, 1},
                    {1, 1, 0, 1, 0},
                    {0, 1, 1, 1, 0},
                    {1, 1, 1, 1, 0},
                    {1, 1, 1, 1, 1},
                    {0, 0, 0, 0, 0}};

                    Console.WriteLine(_63_Matrix.FindLargestSquare(M));

                    break;

                case "stack":
                    _66_MyStack stack = new _66_MyStack(10000);

                    Console.WriteLine("Memory Use (approx.):" + (GC.GetTotalMemory(true) / 1024) + " KBytes");

                    for (int i = 0; i < 10000; i++) //fill the stack
                        stack.Push("a large, large, large, large, string " + i);

                    for (int i = 0; i < 10000; i++) //empty the stack
                        stack.Pop();

                    Console.WriteLine("Memory Use (approx.):" + (GC.GetTotalMemory(true) / 1024) + " KBytes");

                    break;

                case "counter":
                    Console.WriteLine(_64_Counter.Increment());

                    break;
                case "max":
                    int[] numbers = { 1, -28, 88, 200, 7 };
                    int resultat = _47_AlgoMax.FindLargest(numbers);

                    Console.WriteLine(resultat);

                    break;

                case "stream":
                    TextReader example = new StringReader("Hello");
                    new _53_StreamPrinter().Print(example);

                    break;

                case "identifiant":
                    Console.WriteLine(_52_IdentifiantNumerique.ComputeChekDigit("39847"));

                    break;

                case "closes":
                    int[] ints = { -9, 8, 2, -5, 7 };
                    Console.WriteLine(_58_ClosesToZero.ClosestToZero(ints));

                    break;

                case "scanAscii":
                    string art = AsciiArt.PrintChar('J');
                    string art1 = AsciiArt.PrintChar('B');
                    Console.WriteLine(_68_GraphAscii.ScanChar(art));
                    Console.WriteLine(_68_GraphAscii.ScanChar(art1));

                    break;

                case "Tennis":
                    string[] wins = { "P1" };
                    Console.WriteLine(_60_Tennis.ComputeGameState("P1", "P2", wins)); // P1 15 - P2 0

                    wins = new string[] { "P2","P2" };
                    Console.WriteLine(_60_Tennis.ComputeGameState("P1", "P2", wins)); // P1 0 - P2 30

                    wins = new string[] { "P1", "P1","P1" };
                    Console.WriteLine(_60_Tennis.ComputeGameState("P1", "P2", wins)); // P1 40 - P2 0

                    wins = new string[] { "P2", "P2", "P2","P2" };
                    Console.WriteLine(_60_Tennis.ComputeGameState("P1", "P2", wins)); // P2 WINS

                    wins = new string[] { "P1", "P2", "P1", "P2", "P2"};
                    Console.WriteLine(_60_Tennis.ComputeGameState("P2", "P2", wins)); //  P1 30 - P2 40

                    break;

                case "Reshape":
                    Console.WriteLine(_49_Reshape.reshape(3, "abc de fghij"));
                    Console.WriteLine(_49_Reshape.reshape(2, "1 23 456"));
                    break;

                case "Macaron":

                    string[] macarons = { "PEAR", "PEACH", "PEACH" };

                    Console.WriteLine(_62_Macaron.ComputeTotalPrice(5, macarons));

                    break;

                case "SommeChiffre":
                    Console.WriteLine(_71_SommeNombre.ComputeJoinPoint(483, 480));

                    break;
                case "LogicGates":

                    var inputcas1 = new Input()
                    {
                        n = 2,
                        m = 3,
                        inputName = ["A", "B"],
                        inputSignal = ["__---___---___---___---___", "____---___---___---___---_"],
                        outputName = ["C", "D", "E"],
                        type = ["AND", "OR", "XOR"],
                        inputName1 = ["A"],
                        inputName2 = ["B"]
                    };

                   

                    for (int i = 0; i < inputcas1.m; i++)
                    {
                        Console.WriteLine(LogicGates.GenrationChaine(i, inputcas1));
                    }
                    
                    break;
                case "Golf":
                   

                     CodeGolf.ChoiseMountain();

                    break;


            }
        }
    }
}


