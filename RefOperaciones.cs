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