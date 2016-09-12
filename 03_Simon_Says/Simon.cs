using System;

namespace _03_Simon_Says
{
    internal class Simon
    {
        internal string Echo(string v)
        {
            return v;
        }

        internal string Shout(string v)
        {
            string u = v.ToUpper();
            return u;
        }

        internal object Repeat(string v1, int v2 = 2)
        {
            
            string ud = v1;

            for (int i = 0; i < v2-1; i++)
            {
                 ud = ud + " ";
                 ud = ud + v1;
            }
            return ud;
        }

        internal string StartOfWord(string v1, int v2)
        {
            string ud = "";

            for (int i = 0; i < v2; i++)
            {
                ud = ud + v1[i];
            }
            return ud;
        }

        internal string FirstWord(string v)
        {
            string ud = "";
            for (int i = 0; i < i+1; i++)
            {
                if (char.IsWhiteSpace(v[i]))
                {
                    break;
                }
                else
                {
                    ud = ud + v[i];
                }
                }
            return ud;
            }

        internal string Titleize(string v)
        {
            char[] array = v.ToCharArray();
            // Handle the first letter in the string.
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            // Scan through the letters, checking for spaces.
            // ... Uppercase the lowercase letters following spaces.
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
            throw new NotImplementedException();
        }
    }

       

      
    }
