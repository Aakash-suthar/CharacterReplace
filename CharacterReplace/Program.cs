using System;
using System.Text;

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
            Console.WriteLine("Success Count : " + r);
            Console.ReadKey();
        }

        public static int replace(char[] og, string replace, char[] replacestring)
        {
            StringBuilder outputstring = new StringBuilder();
            bool success = false;
            int lengthofnewstring = replacestring.Length-1;
            int successcount = 0;
            int j;
            int oocuurencelength = 0;

                for (int i = 0; i < og.Length; i++)
                {
                    if (og[i] == replace[oocuurencelength])
                    {
                        oocuurencelength++;
                        if (oocuurencelength - 1 == replace.Length - 1)
                        {
                            j = 0;
                            while (lengthofnewstring >= 0) {
                                outputstring.Append(replacestring[j]);
                                lengthofnewstring--;
                                oocuurencelength = 0;
                                j++;
                            }
                            lengthofnewstring = replacestring.Length - 1;
                            success = true;
                        }

                    }
                    else
                    {
                        if (oocuurencelength > 0)
                        {
                            j = i;
                            while (oocuurencelength >= 0)
                            {
                                outputstring.Append(og[j]);
                                j--;
                                oocuurencelength--;
                            }
                        }
                        else
                        {
                            outputstring.Append(og[i]);
                        }
                        oocuurencelength = 0;

                    }
                    if (i == og.Length - 1) {
                        j = i+1 - oocuurencelength;
                        while (oocuurencelength > 0)
                        {
                            outputstring.Append(og[j]);
                            j++;
                            oocuurencelength--;
                        }
                    }
                    if (success == true)
                    {
                        successcount++;
                        oocuurencelength = 0;
                        success = false;
                    }
                }

            Console.WriteLine("New String : " + outputstring);
            return successcount;
        }
    }

}
