using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lgLeetCodePractice
{
    public class AddBinarySolver
    {
        public string AddBinary(string a, string b)
        {
            int i = 0;
            if (a.Length < b.Length)
                a = a.PadLeft(b.Length, '0');
            else
                b = b.PadLeft(a.Length, '0');

            a = new string(a.Reverse().ToArray());
            b = new string(b.Reverse().ToArray());
            var s = new StringBuilder();
            bool carry = false;
            while (i < a.Length)
            {
                if (carry)
                {
                    if (a[i] == '1' && b[i] == '1')
                    {
                        s.Insert(0,"1");
                        carry = true;
                    }
                    else if (a[i] == '1' || b[i] == '1')
                    {
                        s.Insert(0,"0");
                        carry = true;
                    }
                    else
                    {
                        s.Insert(0,"1");
                        carry = false;
                    }
                }
                else
                {
                    if (a[i] == '1' && b[i] == '1')
                    {
                        s.Insert(0,"0");
                        carry = true;
                    }
                    else if (a[i] == '1' || b[i] == '1')
                    {
                        s.Insert(0,"1");
                    }
                    else
                    {
                        s.Insert(0,"0");
                    }
                }
                i++;
            }

            if (carry)
            {
                s.Insert(0,"1");
            }

            return s.ToString();
        }
    }
}
