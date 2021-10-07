using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;

namespace Entity2
{
    public class RefOperaciones
    {
        public int EjemploDelegado(int Num1, int Num2)
        {
            Operaciones op = new Operaciones();
            op.WriteError = MostrarMensaje;
            op.TituloMsg = MostrarLinea;
            return op.Sumar(Num1, Num2);
        }

        public int EjemploAnonimo(int Num1, int Num2)
        {
            Operaciones op = new Operaciones();
            op.WriteError = delegate (string mensaje)
            {
                Debug.WriteLine("Mensaje a través de un método anónimo: " + mensaje);
            };

            return op.Restar(Num1, Num2);
        }

        public int EjemploLambda(int Num1, int Num2)
        {
            Operaciones op = new Operaciones();
            /*op.WriteError = delegate (string mensaje)
            {
                Debug.WriteLine("Mensaje a través de un método anónimo: " + mensaje);
            };*/

            op.WriteError = mensaje => Debug.WriteLine("Mensaje a través de una Lambda Expression: " + mensaje);

            return op.Restar(Num1, Num2);
        }

        public int EjemploAction(int Num1, int Num2)
        {
            Operaciones op = new Operaciones();
            Action<string> EjAction;
            EjAction = MostrarMensaje;
            return op.Multiplicar(Num1, Num2, EjAction);
        }

        public string EjemploFunc(int Num1,int Num2)
        {
            Operaciones op = new Operaciones();
            Func<int, int, string> EjFunc;
            EjFunc = SumaFunc;
            return op.SumaFuncOp(Num1,Num2,EjFunc);
        }

        public string SumaFunc(int Num1,int Num2)
        {
            int Suma = Num1 + Num2;
            return "La suma de los números es " + Suma;
        }


        public void MostrarMensaje(string mensaje)
        {
            Debug.WriteLine(mensaje);
        }

        public void MostrarLinea()
        {
            Debug.WriteLine("--------------- ERROR ---------------");
        }

        

        public bool Test()
        {
            return true;
        }
    }
}