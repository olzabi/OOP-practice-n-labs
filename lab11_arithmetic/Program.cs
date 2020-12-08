using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace lab11_arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            // bracket balance?
                        
            // reads arithmetic expression from file
            StreamReader sr = new StreamReader(Console.ReadLine());
            string data = sr.ReadToEnd(); // info from file
            sr.Close();

            Stack st = new Stack();
            bool res = true;
            char[] arr = data.ToCharArray();

            foreach (var i in arr)
            {
                string it = i.ToString();
                
                if (it == "(") st.Push(it);
                else if (it == ")")
                {
                    if (st.Count == 0)
                    {
                        res = false;
                    } else
                    {
                        st.Pop();
                    }
                }
            }
            
            if (st.Count == 0)
            {
                if (res)
                {
                    Console.WriteLine("OK");
                }
            }
            else
            {
                Console.WriteLine("Smth not good");
                while (st.Count != 0)
                {
                    Console.Write("{0}", (string) st.Pop());
                }
                Console.WriteLine();
            }
        }
    }
}