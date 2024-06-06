using System;
using System.Collections.Generic;
using System.Linq;

namespace CodinGame.Fini
{
    public class _93_PanelCount
    {
        public static List<int> CountOccurence(List<string> listP, List<string> lstString, List<string> conditions)
        {
            List<string> dic = new List<string>();
            List<int> output = new List<int>();
            int count = lstString.Count;

            foreach (var item in conditions)
            {

                var test = new List<Table>();
                foreach (var v in lstString)
                {
                    for (int i = 0; i < listP.Count; i++)
                    {
                        test.Add(new Table { Type = listP[i], Value = v.Split(' ')[i + 1] });
                    }
                    int cpt = 0;
                    if (item.Contains("AND"))
                    {
                        for (int i = 0; i < item.Split("AND").Count(); i++)
                        {
                            string cond1 = item.Split("AND")[i].Split("=")[0].Trim();
                            string cond2 = item.Split("AND")[i].Split("=")[1].Trim();
                            if (test.Any(m => m.Type == cond1 && m.Value == cond2))
                            {
                                cpt++;
                            }
                        }
                        test.Clear();
                        if (cpt == item.Split("AND").Count())
                            dic.Add("");
                    }
                    else
                    {
                        string cond1 = item.Split("=")[0].Trim();
                        string cond2 = item.Split("=")[1].Trim();
                        if (test.Any(m => m.Type == cond1 && m.Value == cond2))
                        {
                            cpt++;
                        }
                        test.Clear();
                        if (cpt == item.Split("=").Count() / 2)
                            dic.Add("");
                    }

                }

                output.Add(dic.Count);
                dic.Clear();

            }

            return output;
        }
    }
    public class Table
    {

        public string Type { get; set; }
        public string Value { get; set; }
    }

}
