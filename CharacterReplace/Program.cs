using System;

namespace CharacterReplace
{
    class Program
    {
        public static void Main(string[] args)
        {                                                                       
            Console.WriteLine("Enter String : ");
            string original = Console.ReadLine();
            Console.WriteLine("Enter String to be replace string");
            string replaces = Console.ReadLine();
            Console.WriteLine("Enter Replace string");
            string replacestring = Console.ReadLine();
            int r = replace(original.ToCharArray(), replaces,replacestring.ToCharArray());
            Console.WriteLine(r);
            Console.ReadKey();
        }
        public static int replace(char[] og,string replace,char[] replacestring) {
            bool success = false;
            int successcount = 0;
            int oocuurencelength = 0;
            int j = 0;

            for (int i = 0; i < og.Length; i++)
            {
                if (og[i] == replace[oocuurencelength])
                {
                    oocuurencelength++; 
                    if (oocuurencelength - 1 == replace.Length - 1)
                    {
                        oocuurencelength = oocuurencelength - 1;
                        j = i;
                        while (oocuurencelength >= 0)
                        {
                            og[j] = replacestring[oocuurencelength];
                            oocuurencelength--;
                            j--;
                        }

                        success = true;
                    }
                }
                else { oocuurencelength = 0; }
                if (success == true) {
                    successcount++;
                    oocuurencelength = 0;
                    j = 0;
                    success = false;
                }
            
            }
            Console.WriteLine(new String(og));
            return successcount;
        }


    }

}
