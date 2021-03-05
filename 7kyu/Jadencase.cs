using System;

namespace kata
{
    public class Jadencase
    {
        public string Jadencase_7kyu(string phrase)
        {
            string scrm = null;
            string[] jadString = phrase.Split(' ');
            int lenArray = jadString.Length;

            for (int x = 0; lenArray > x; x++)
            {
                scrm = String.Concat(scrm, jadString[x].Substring(0, 1).ToUpper(), jadString[x].Substring(1), " ");
            }

            scrm = scrm.TrimEnd();

            return scrm;
        }
    }
}
