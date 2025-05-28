using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFroms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                //USO DE TRY CATCH con valor byte de 255
                //byte txt_texbox = Convert.ToByte(txt_nombre.Text);
                ////string txt_texbox = txt_nombre.Text;
                //lbl_texto.Text = txt_texbox.ToString();


                //USO DE CADENAD STRING
                //string bienvenida = " Bienvenido";
                //string texto = "hola " + txt_nombre.Text + bienvenida;
                //lbl_texto.Text = texto;





            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
