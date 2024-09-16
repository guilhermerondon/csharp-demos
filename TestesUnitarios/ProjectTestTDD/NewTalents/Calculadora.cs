using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {

        private List<string> listahistorico;
        private string data;

        public Calculadora(string data)
        {   
            listahistorico = new List<string>();
            this.data = data;
        }

        public int somar(int num1, int num2)
        {   
            int resultado = num1 + num2;

            listahistorico.Insert(0, "Res: "  + resultado + " data " + data);
            return resultado;
        }

        public int subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;

            listahistorico.Insert(0, "Res: "  + resultado + " data " + data);
            return resultado;
        }

        public int multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            listahistorico.Insert(0, "Res: "  + resultado + " data " + data);
            return resultado;
        }

        public int dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            listahistorico.Insert(0, "Res: "  + resultado + " data " + data);
            return resultado;
        }

        public List<string> historico()
        {
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }
    }
}