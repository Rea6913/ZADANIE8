using System.Text;
using System;

namespace PadawansTask8
{
    public static class WordsManipulation
    {
        public static void RemoveDuplicateWords(ref string text)
        {

            if (text == null)
                throw new ArgumentNullException();
            if (text.Length == 0)
                throw new ArgumentException();

        string razd = ".,!? -:;";
            string slova = "";
            string otv = "";
            string slovo_now = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (razd.Contains(text[i].ToString()))
                {
                    if (!slova.Contains(' ' + slovo_now + ' '))
                    {
                        slova += ' ' + slovo_now + ' ';
                        otv += slovo_now + text[i];
                    }
                    else
                        otv += text[i];
                    slovo_now = "";
                }
                else
                    slovo_now += text[i];
            }
            text = otv;
        }
    }
}
     

