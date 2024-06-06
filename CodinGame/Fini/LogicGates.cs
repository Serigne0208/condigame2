using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CodinGame.Fini
{
    public class Input
    {
        public int n;
        public int m;
        public string[] inputName;
        public string[] inputSignal;
        public string[] outputName;
        public string[] type;
        public string[] inputName1;
        public string[] inputName2;
    }
    public class Input2
    {
        public int n;
        public int m;
        public string[] inputSignal;
        public string[] output;
    }
    public class LogicGates
    {
        public static string GenrationChaine(int element, Input input)
        {
            string chaine = input.outputName[element] + " ";
            Dictionary<string, string> LstchaineInput = new Dictionary<string, string>();
            int le = input.inputSignal[0].Length;

            for (int i = 0; i < input.inputSignal.Count(); i++)
            {
                input.inputSignal[i] = input.inputSignal[i].Replace("-", "1");
                input.inputSignal[i] = input.inputSignal[i].Replace("_", "0");
                LstchaineInput.Add(input.inputName[i], input.inputSignal[i]);
            }

            if (input.type[element] == "AND")
            {
                for (int i = 0; i < le; i++)
                {
                    chaine += LstchaineInput.Where(m => m.Key == input.inputName1[element]).Select(m => m.Value).First().Substring(i, 1) == "1" &&
                        LstchaineInput.Where(m => m.Key == input.inputName2[element]).Select(m => m.Value).First().Substring(i, 1) == "1";
                }
            }
            else if (input.type[element] == "OR")
            {
                for (int i = 0; i < le; i++)
                {
                    chaine += LstchaineInput.Where(m => m.Key == input.inputName1[element]).Select(m => m.Value).First().Substring(i, 1) == "1" ||
                        LstchaineInput.Where(m => m.Key == input.inputName2[element]).Select(m => m.Value).First().Substring(i, 1) == "1";
                }
            }
            else if (input.type[element] == "XOR")
            {
                for (int i = 0; i < le; i++)
                {
                    chaine += LstchaineInput.Where(m => m.Key == input.inputName1[element]).Select(m => m.Value).First().Substring(i, 1) == "1" ^
                        LstchaineInput.Where(m => m.Key == input.inputName2[element]).Select(m => m.Value).First().Substring(i, 1) == "1";
                }
            }
            else if (input.type[element] == "NAND")
            {
                for (int i = 0; i < le; i++)
                {
                    chaine += !(LstchaineInput.Where(m => m.Key == input.inputName1[element]).Select(m => m.Value).First().Substring(i, 1) == "1" &&
                        LstchaineInput.Where(m => m.Key == input.inputName2[element]).Select(m => m.Value).First().Substring(i, 1) == "1");
                }
            }
            else if (input.type[element] == "NOR")
            {
                for (int i = 0; i < le; i++)
                {
                    chaine += !(LstchaineInput.Where(m => m.Key == input.inputName1[element]).Select(m => m.Value).First().Substring(i, 1) == "1" ||
                        LstchaineInput.Where(m => m.Key == input.inputName2[element]).Select(m => m.Value).First().Substring(i, 1) == "1");
                }
            }
            else if (input.type[element] == "NXOR")
            {
                for (int i = 0; i < le; i++)
                {

                    chaine += !(LstchaineInput.Where(m => m.Key == input.inputName1[element]).Select(m => m.Value).First().Substring(i, 1) == "1" ^
                        LstchaineInput.Where(m => m.Key == input.inputName2[element]).Select(m => m.Value).First().Substring(i, 1) == "1");

                }
            }

            chaine = chaine.Replace("True", "-"); // True 1
            chaine = chaine.Replace("False", "_"); // False 0


            return chaine;
        }
        public static string Solution2(int element, Input input)
        {
            string chaine = input.outputName[element] + " ";
            var inSignals = new Dictionary<string, string>();
            int le = input.inputSignal[0].Length;

            for (int i = 0; i < input.inputSignal.Count(); i++)
            {
                input.inputSignal[i] = input.inputSignal[i].Replace("-", "1");
                input.inputSignal[i] = input.inputSignal[i].Replace("_", "0");
                inSignals.Add(input.inputName[i], input.inputSignal[i]);
            }

            for (int i = 0; i < le; i++)
            {
                chaine += IsOn(inSignals.Where(m => m.Key == input.inputName1[element]).Select(m => m.Value).First().Substring(i, 1) == "1", inSignals.Where(m => m.Key == input.inputName2[element]).Select(m => m.Value).First().Substring(i, 1) == "1", input.type[element]);
            }

            chaine = chaine.Replace("True", "-"); // True 1
            chaine = chaine.Replace("False", "_"); // False 0

            return chaine;
        }

        private static bool IsOn(bool a, bool b, string type)
        => type switch
        {
            "AND" => a && b,
            "OR" => a || b,
            "XOR" => a ^ b,
            "NAND" => !(a && b),
            "NOR" => !(a || b),
            "NXOR" => !(a ^ b),
            _ => false,
        };

    }

}
