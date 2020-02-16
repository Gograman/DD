using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalDispatcher
{
    public class DD
    {
        public void test(string text)
        {
            Console.WriteLine("I hate " + text);
            DD_DB DD_DB = new DD_DB();
         
            foreach (MSG m in DD_DB.MSG.ToList())
            {
                Console.WriteLine(m.Msg_Text);
            }

        }
       
    }
}
