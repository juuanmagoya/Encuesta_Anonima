using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Encuesta_Anonima
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string getComida() 
        {
            string Comida = "";
            Comida += CheckBox1.Checked ? " - " + CheckBox1.Text : "";
            Comida += CheckBox2.Checked ? " - " + CheckBox2.Text : "";
            Comida += CheckBox3.Checked ? " - " + CheckBox3.Text : "";

            return Comida;
        }
        public string getActividad()
        {
            string Actividad = "";
            Actividad += CheckBox4.Checked ? " - " + CheckBox4.Text : "";
            Actividad += CheckBox5.Checked ? " - " + CheckBox5.Text : "";
            Actividad += CheckBox6.Checked ? " - " + CheckBox6.Text : "";
            return Actividad;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedIndex >=0 && DropDownList1.SelectedIndex >=0 && RadioButtonList2.SelectedIndex >=0 &&  DropDownList2.SelectedIndex >=0)
            {
                Label5.Text = $"Comida Preferida : {getComida()} <br>" +
                              $"Lugar Preferido para Comer: {RadioButtonList1.SelectedItem.Text}<br>" +
                              $"Bebida Favorita : {DropDownList1.SelectedItem.Text}<br>" +
                              "Muchas Gracias por Completar la encuesta";
                Label9.Text = $"Actividad Favorita : {getActividad()}<br>" +
                              $"Lugar Favorito : {RadioButtonList2.SelectedItem.Text}<br>" +
                              $"Clima Favorito : {DropDownList2.SelectedItem.Text}<br>"+
                              "Muchas gracias por su opinión";
            }
        }


    }
}