using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MexicanWaveProject
{
    public class Kata
    {
        public List<string> Wave(string str)
        {

            var waving = new List<string>();
            if (string.IsNullOrEmpty(str))
            {
                return waving;
            }
            return LetStrWave(str, waving);
        }

        private static List<string> LetStrWave(string str, List<string> waving)
        {
            for (int i = 0; i < str.Length; i++)
            {
                waving.Add(str.Remove(i, 1).Insert(i, str.Substring(i, 1).ToUpper()));
            }
            waving.RemoveAll(x => x.Equals(str));
            return waving;
        }
    }
}
