using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test {
    class Program {
        static void Main(string[] args) {
            string Id, Pass;
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
            Console.Write("\n\n++++++++++++++++++++++++++++++++++++++++");
            Console.Write("\n+");
            Console.Write("\n+  Masukan ID dan Password anda");
            Console.SetCursorPosition(39, 14); Console.Write("+");
            Console.SetCursorPosition(39, 15); Console.Write("+");
            Console.SetCursorPosition(39, 16); Console.Write("+");
            Console.SetCursorPosition(39, 17); Console.Write("+");
            Console.SetCursorPosition(39, 18); Console.Write("+");
            Console.SetCursorPosition(39, 15); Console.Write("\n+    ID       :"); 
            Console.SetCursorPosition(39, 16); Console.Write("\n+    Password : ");
            Console.SetCursorPosition(39, 17); Console.Write("\n+\n++++++++++++++++++++++++++++++++++++++++");
            Console.SetCursorPosition(15, 16); Id = Convert.ToString(Console.ReadLine());
            Console.SetCursorPosition(15, 17); Pass = Convert.ToString(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
