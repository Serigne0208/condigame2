using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodinGame.A_Tester
{
    class _54_UniverseFormula
    {
        public static string Find()
        {
            string filePatch = null;

            DirectoryInfo di = new DirectoryInfo("/tmp/documents");
            if (di.Exists)
            {
                FileInfo[] files = di.GetFiles("universe-formula", SearchOption.AllDirectories);
                try
                {
                    filePatch = files[0].FullName;
                }
                catch
                {

                }
            }

            return filePatch;

        }
    }
}
