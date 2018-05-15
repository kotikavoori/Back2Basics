using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{


    using System;

    public class TextInput
    {
        StringBuilder sb = new StringBuilder();
        //static string s = String.Empty;
       static char[] arr = new char[10];

       
        int i = 0;
        public virtual void Add(char c )
        {
            
            //i ++;
            arr[i] = c;
            //s.Insert(s.Length, c.ToString());
        }

       public string GetValue()
        {
            return new string(arr);
        }
    }

    public class NumericInput : TextInput
    {
        public NumericInput()
        {
        }

        public override void Add(char c)
        {
            if (!(Convert.ToInt32(c) > 65 && (Convert.ToInt32(c) < 122)))
            {
                base.Add(c);
            }  
        }
    }

    public class UserInput
    {
        public void main(string[] args)
        {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());
            Console.ReadKey();
        }
    }
    
}
