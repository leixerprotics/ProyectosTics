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

                //if (user == "Eduardo")
                //{
                //    MessageBox.Show("Bienvenido ");
                //    if (Convert.ToInt64(pass) < 100)
                //    {
                //        MessageBox.Show("ES < 100");
                //    }
                //    else if(Convert.ToInt64(pass) > 100)
                //    {
                //        MessageBox.Show("ES > 100");
                //        //MessageBox.Show("no llega");
                //    }
                //    else
                //    {
                //        MessageBox.Show("ES 100");
                //        //MessageBox.Show("no llega");
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Incorrecto session");
                //}

                string user = txt_user.Text;
                string pass = txt_pass.Text;

                switch (user)
                {
                    case "Eduardo":
                        MessageBox.Show("Bienvenido Eduardo");
                        break;
                    
                    case "David":
                        MessageBox.Show("Bienvenido David");
                        break;

                    default:
                        MessageBox.Show("No existe");
                        break;
                }
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
