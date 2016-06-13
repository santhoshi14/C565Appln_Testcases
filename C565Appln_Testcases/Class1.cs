using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C565Appln_Testcases
{
    public class Class1
    {
        string myString;
        private int[] stack_ref = new int[100];

        //private int max_len=99, top_index=-1;
        //public StackClass()
        //{ // A constructor
        //    stack_ref = new int[100];
        //    max_len = 99;
        //    top_index = -1;
        //}
        public string push(int number, int top_index, int max_len)
        {
            string strResult = "";
            if (top_index == max_len)
            {
                strResult = "Error in push-stack is full";
                Console.WriteLine("Error in push-stack is full");
            }
            else
            {
                int topindex = ++top_index;
                stack_ref[topindex] = number;
                strResult = Convert.ToString(topindex);
                Console.WriteLine(topindex);
            }
            return strResult;
        }
        public string pop(int top_index)
        {
            string strpopResult;
            if (top_index == -1)
            {
                strpopResult = "Error in push-stack is empty";
                Console.WriteLine("Error in push-stack is empty");
            }
            else
            {
                int topindex = --top_index;
                strpopResult = Convert.ToString(topindex);

            }
            return strpopResult;
        }
        public int top()
        {
            int top_index = 0;
            stack_ref[top_index] = 10;
            return (stack_ref[top_index]);
        }
        public bool empty()
        {
            int top_index = -1;
            return (top_index == -1);
        }
    }
}
