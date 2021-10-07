using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Entity2
{
    public partial class Index : System.Web.UI.Page
    {
        private RefOperaciones refe;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SumarDelegado(object sender, EventArgs e)
        {
            int Num1 = Convert.ToInt32(txt_del_1.Text);
            int Num2 = Convert.ToInt32(txt_del_2.Text);
            refe = new RefOperaciones();
            refe.MostrarMensaje(" -------------- MENSAJE POR TERMINAL DEL DEBUG -------");
            lb_delegate.Text = "El resultado es: " + refe.EjemploDelegado(Num1, Num2).ToString();
        }

        protected void RestarAnonimo(object sender, EventArgs e)
        {
            int Num1 = Convert.ToInt32(txt_an_1.Text);
            int Num2 = Convert.ToInt32(txt_an_2.Text);
            refe = new RefOperaciones();
            lb_anonimo.Text = "El resultado es: " + refe.EjemploLambda(Num1, Num2).ToString();
        }
    }
}