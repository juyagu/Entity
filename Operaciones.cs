using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity2
{
    public delegate void MensajeError(string mensaje);
    public delegate void MostrarTituloMensaje();
    public delegate bool TestLoco();
    public class Operaciones
    {
        public MensajeError WriteError;
        public MostrarTituloMensaje TituloMsg;
        public int Sumar(int Num1, int Num2)
        {
            int Suma = Num1 + Num2;
            if(Suma < 0)
            {
                //throw new Exception("La suma dio negativo");
                TituloMsg();
                WriteError("La suma dio negativo");

            }
            return Suma;
        }

        public int Restar(int Num1, int Num2)
        {
            int Resta = Num1 - Num2;
            if (Resta < 0)
            {
                WriteError("La resta dio negativo");

            }
            return Resta;
        }

        public int Multiplicar(int Num1,int Num2, Action<string> EjemploAction)
        {
            int Multi = Num1 * Num2;
            if(Multi == 100)
            {
                EjemploAction("La multiplicación me devolvió 100 y me da ansiedad");
            }
            return Multi;
        }

        public string SumaFuncOp(int Num1, int Num2, Func<int,int,string> EjemploFunc)
        {
            string resultado = EjemploFunc(Num1, Num2);
            return resultado;
        }

    }
}