using Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class frmInicio : Form
    {
        Calculadora calculadora = new Calculadora();

        public frmInicio()
        {
            InitializeComponent();
        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            lblRes.Text = calculadora.Operar("+", txtOper1.Text, txtOper2.Text);
        }

        private void btMultiplicacion_Click(object sender, EventArgs e)
        {
            lblRes.Text = calculadora.Operar("*", txtOper1.Text, txtOper2.Text);
        }

        private void btDivision_Click(object sender, EventArgs e)
        {
            lblRes.Text = calculadora.Operar("/", txtOper1.Text, txtOper2.Text);
        }

        private void btResta_Click(object sender, EventArgs e)
        {
            lblRes.Text = calculadora.Operar("-", txtOper1.Text, txtOper2.Text);
        }

        //private void btSuma_Click(object sender, EventArgs e)
        //{
            //int num1 = int.Parse(txtOper1.Text);
            //int num2 = Convert.ToInt32(txtOper2.Text);
            //int res = num1 + num2;
            //lblRes.Text = res.ToString();

        //cfgnxcfgnxcvn
        //    xcvnxc
        //    vnxcvn
        //    xcvnxcvn


            //calculadora.Num1 = int.Parse(txtOper1.Text);
            //calculadora.Num2 = Convert.ToInt32(txtOper2.Text);0
            //int res = calculadora.Operar();
            //lblRes.Text = res.ToString();

            ////calculadora.Num1 = int.Parse(txtOper1.Text);
            ////calculadora.Num2 = Convert.ToInt32(txtOper2.Text); 
            ////int res = calculadora.Operar("+");
            ////lblRes.Text = res.ToString();

            //int res = calculadora.Operar("+",
            //                             int.Parse(txtOper1.Text),
            //                             Convert.ToInt32(txtOper2.Text));
            //lblRes.Text = res.ToString();

            //string res = calculadora.Operar("+",
            //                                txtOper1.Text,
            //                                txtOper2.Text);
            //lblRes.Text = res;

            //lblRes.Text = calculadora.Operar("+", txtOper1.Text, txtOper2.Text);
        //}
    }
}
