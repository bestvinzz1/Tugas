using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("M    M  III   CCC  RRRR    OOOO ");
            Console.WriteLine("MM  MM   I   CC    R   R  O    O");
            Console.WriteLine("M MM M   I   C     RRRR   O    O");
            Console.WriteLine("M    M   I   CC    R R    O    O");
            Console.WriteLine("M    M  III   CCC  R  R    OOOO ");
            Console.WriteLine();
            Console.WriteLine("   PPPP      A     YY   YY   ");
            Console.WriteLine("   P   P    A A     YY YY    ");
            Console.WriteLine("   PPPP    A   A     YYY     ");
            Console.WriteLine("   P      AAAAAAA     Y      ");
            Console.WriteLine("   P     AA     AA    Y      ");
        
            //Penginputan

            string Id, Pass;
            int Coba = 0;
            Console.Write("\n\n++++++++++++++++++++++++++++++++++++++++");
            Console.Write("\n+");
            Console.Write("\n+    Masukan ID dan Password anda");
            for(int i = 0; i < 9; i++)
            {
                Console.SetCursorPosition(39, i+14); Console.Write("+");
            }
            Console.SetCursorPosition(39, 15); Console.Write("\n+      ID       :"); 
            Console.SetCursorPosition(39, 16); Console.Write("\n+      Password : ");
            Console.SetCursorPosition(39, 17); Console.Write("\n+");
            Console.SetCursorPosition(39, 18); Console.Write("\n+");
            Console.SetCursorPosition(39, 19); Console.Write("\n+");
            Console.SetCursorPosition(39, 20); Console.Write("\n+\n++++++++++++++++++++++++++++++++++++++++");
            do
            {
                try
                {
                    Console.SetCursorPosition(18, 16); Id = Convert.ToString(Console.ReadLine());
                    Console.SetCursorPosition(18, 17); Pass = Convert.ToString(Console.ReadLine());
                    if (Id == "Admin" && Pass == "Admin")
                    {
                        Console.SetCursorPosition(15, 19); throw new Exception("Id dan Password Salah");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (Id == "Admin" && Pass == "Admin");
 
 






            Console.ReadKey();
        }
    }
}
