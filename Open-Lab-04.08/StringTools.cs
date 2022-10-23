using System;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            int c = 0;
            
            for(int i = 0; i < strings.Length; i++)
            {
                
                if (strings[i].Length == 4)
                {
                    
                    c++;
                    
                }
            }


            int sus = 0;
            string[] styri = new string[c];

            for(int j = 0; j < strings.Length; j++)
            {

                if(strings[j].Length == 4)
                {

                    styri[sus] = strings[j];
                    sus++;

                }
            }s

            return styri;
        }
    }
}
