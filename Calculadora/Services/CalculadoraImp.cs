using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        private List<string> listaHistorico;
        public CalculadoraImp()
        {
            listaHistorico = [];
        }
        public int Somar(int num1, int num2)
        {
            int res = num1 + num2;
            listaHistorico.Insert(0, "Res: "+ res);
            return res;
        }
        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2 ;
        }
        public int Dividir(int num1, int num2)
        {
            return num1/num2;
        }
        public List<string> Historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}