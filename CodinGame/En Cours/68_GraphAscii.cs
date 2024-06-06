using System;
using System.Collections.Generic;
using System.Text;

namespace CodinGame.En_Cours
{
    class _68_GraphAscii
    {
        public static char ScanChar(String s)
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                // use String.equals to compare strings
                if (AsciiArt.PrintChar(c).Equals(s))
                {
                    return c;
                }
            }
            return '?';
        }
    }
    class AsciiArt
    {
        public static String PrintChar(char s)
        {
            // return string value of param 
            return s.ToString();
        }
    }
}

