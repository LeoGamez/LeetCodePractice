using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lgLeetCodePractice
{
    public class SearchParentheses
    {

        public bool IsValid(string s)
        {
            List<char> open = new List<char>() { '(', '[', '{' };
            List<char> closed = new List<char>() { ')', ']', '}' };
            List<int> indexes = new List<int>();
            if (s.Length <= 1) return false;

            for (int i = 0; i < s.Length; i++)
            {
                int l = open.IndexOf(s[i]);
                int r = -1;
                if (l == -1 && !(indexes.Contains(i)))
                {
                    return false;
                }
                if (l >= 0 && i == s.Length - 1)
                {
                    return false;
                }

                for (int j = i + 1; j < s.Length; j++)
                {
                    r = closed.IndexOf(s[j]);
                    if (l != r && j >= s.Length - 1)
                    {
                        return false;
                    }

                    if (l == r && (j - i) % 2 == 0)
                    {
                        return false;
                    }
                    else if (l == r)
                    {
                        if (j - i == 1)
                        {
                            i++;
                        }
                        indexes.Add(i);
                        indexes.Add(j);
                        break;
                    }
                }
            }

            return true;
        }

        public bool IsValidB(string s)
        {
            List<char> open = new List<char>() { '(', '[', '{' };
            List<char> closed = new List<char>() { ')', ']', '}' };
            if (s.Length <= 1) return false;

            int sum = 0;
            List<int> pending=new();
            for (int i = 0; i < s.Length; i++)
            {
                int o = open.IndexOf(s[i]);
                int c = closed.IndexOf(s[i]);
                if (o >= 0)
                {
                    pending.Add(o);
                    sum += 1;
                }
                else if (c >= 0)
                {
                    if (pending.Count==0 || c != pending[pending.Count-1])
                    {
                        return false;
                    }
                    else
                    {
                        pending.RemoveAt(pending.Count-1);
                    }
                    sum += -1;
                }
                
            }

            return sum == 0;
        }
    }
}
