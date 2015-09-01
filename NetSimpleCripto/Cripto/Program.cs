using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Cripto {
    class Program {
        public static String  Cripto(String cript) {
            cript = cript.ToUpper();
            String temp = "";
            foreach (char c in cript) {
                temp+=(Convert.ToInt32(c) - 64) < 10 ? "0"+ Convert.ToString(Convert.ToInt32(c) - 64) : Convert.ToString(Convert.ToInt32(c) - 64);
            }
            return temp;
        }
        public static String Descripto(String descript) {
            descript = descript.ToUpper();
            String temp = "";
            for (int i=0; i < descript.Length-1;i=i+2 ) { 
                temp += Convert.ToChar((Convert.ToInt32(descript.Substring(i, 2)) +64 ));
        }
            return temp;
        }
        static void Main(string[] args) {
            if (args.Length < 2) {
                Console.WriteLine(@"Digite -c XXXX para criptografar
Digite -d XXXX para descriptografar");
            }
            else {
                if ((args[0] == "-c") && (args[1] != null)) {
                    Console.WriteLine(Cripto(args[1]));
                }
                if ((args[0] == "-d") && (args[1] != null)) {
                    Console.WriteLine(Descripto(args[1]));
                }
            }
        }
    }
}
