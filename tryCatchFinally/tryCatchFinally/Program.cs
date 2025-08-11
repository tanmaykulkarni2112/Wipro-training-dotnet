using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatchFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            try
            {
                int q = 10 / num;
            } catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                Console.WriteLine("The number is ",num);
            }
        }
    }
}
