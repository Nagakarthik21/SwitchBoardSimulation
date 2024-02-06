using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Switchboard
{
    class Helper
    {
        public static int Input()
        {
            int n;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                {
                    throw new Exception();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please Enter Number");
                n = Input();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please Enter smaller Number");
                n = Input();
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter Positive Number");
                n = Input();
            }
            return n;
        }
    }
}
