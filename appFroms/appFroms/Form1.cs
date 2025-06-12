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

                //string user = txt_user.Text;
                //string pass = txt_pass.Text;

                //switch (user)
                //{
                //    case "Eduardo":
                //        MessageBox.Show("Bienvenido Eduardo");
                //        switch (pass)
                //        {
                //            case "1234":
                //                MessageBox.Show("exit");
                //                break;
                //            default:
                //                MessageBox.Show("error");
                //                break;
                //        }
                //        break;
                //    case "David":
                //        MessageBox.Show("Bienvenido David");
                //        break;
                //    default:
                //        MessageBox.Show("No existe");
                //        break;
                //}

                //string var = "";
                //for (int i = 0; i < 10; i++)
                //{
                //    var += i.ToString();

                //    if (i == 5)
                //    {
                //        break;
                //    }

                //    var += " - ";
                //}
                //MessageBox.Show(var.ToString());

                //string var = "";
                //int x = 0;

                ////while (x < 10)
                ////{
                ////    var += x.ToString() + "-";
                ////    x++;
                ////}
                //do
                //{
                //    var += x.ToString() + "-";
                //    x++;
                //} while (x > 10);

                //MessageBox.Show(var);



                //VECTORES
                int num = 0;
                int[] vector = new int[5];
                vector[0] = 10;
                vector[1] = 10;
                vector[2] = 10;
                //MessageBox.Show(vector.Length.ToString());


                //for (int i = 0; i < vector.Length; i++)
                //{
                //    vector[i] = i;
                //    MessageBox.Show(vector[i].ToString());
                //}

                //string[] vecstr = new string[10];
                //for (int i = 0; i < vecstr.Length; i++)
                //{
                //    vecstr[i] = "mi posicion es " + i;
                //}

                //for (int x = 0; x < vecstr.Length; x++)
                //{
                //    MessageBox.Show(vecstr[x]);
                //}


                //matrices

                int[] numVec = new int[5];
                int[,] numMat = new int[3, 5];

                numMat[0, 0] = 1;
                numMat[0, 1] = 2;
                numMat[0, 2] = 3;
                numMat[0, 3] = 4;
                numMat[0, 4] = 5;

                for (int a = 0; a < numMat.Length; a++)
                {
                    //MessageBox.Show(numMat.Length.ToString());
                    //MessageBox.Show(numMat[0, a].ToString());
                }

                //matriz ejercicio
                int[,] matriz = new int[5, 5];

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        matriz[i, j] = i + j;
                    }
                }


                //el matriz.GetLength(0) 0 para fila y columna 

                for (int fila = 0; fila < matriz.GetLength(0); fila++)
                {
                    for (int col = 0; col < matriz.GetLength(1); col++)
                    {
                        MessageBox.Show("Posicion: fila:" + fila + "columna" + col + " matriz: " + matriz[fila, col]);
                    }
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
