using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double lado, resultado;
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtLado.Clear();
            txtRespuesta.Clear();
            txtLado.ReadOnly = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           
            if (double.TryParse(txtLado.Text, out lado))
            {
                
                    if (lado >= 0)
                    {
                        resultado = lado * 4;
                        txtRespuesta.Text = resultado.ToString("N2");
                    }

                    else
                    {
                        txtRespuesta.Text = "Ingrese numeros positivos";
                    }
            }
            else
            {
                if (string.IsNullOrEmpty(txtLado.Text))
                {
                    txtRespuesta.Text = "Existe un campo vacio";
                }

                else
                {
                    txtRespuesta.Text = "Ingresa numeros y no letras";
                }
            }

            
            txtLado.ReadOnly = true;
        }
    }
}
