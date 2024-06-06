using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodinGame.A_Tester
{
    class _53_StreamPrinter
    {
        public void Print(TextReader reader)
        {
            //int code = reader.Read();
            //while (code != -1)
            //{
            //    Console.Write((char)code);
            //    code = reader.Read();
            //}
            //reader.Close();

            try
            {
                int code = reader.Read();
                while (code != -1)
                {
                    Console.Write((char)code);
                    code = reader.Read();
                }
            }
            finally
            {
                reader.Close();
            }
        }

    }
}
