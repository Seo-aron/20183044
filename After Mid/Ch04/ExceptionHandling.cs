using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class ExceptionHandling
    {
        public static void Main()
        {
            try
            {
                int a = Int32.Parse(Console.ReadLine());
                int b = Int32.Parse(Console.ReadLine());

                if (a > b)
                    Console.WriteLine("{0}값이 더 큽니다.", a);
                else
                    Console.WriteLine("{0}값이 더 작습니다.", a);
            }
            catch (Exception e)
            {
                Console.WriteLine("예외상황이 발생했습니다. 에러메시지는 {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("프로그램 작성일자 {0}", DateTime.Now);
            }
        }
    }
} 
