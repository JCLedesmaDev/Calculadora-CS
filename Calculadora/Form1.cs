using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form {
        public Form1(){
            InitializeComponent();
        }

        /// VARIABLES GLOBALES
        string contador = "";
        string resultado = "";

        /// METODO GLOBAL
        private void changeLabelResult (string BtnText) {
            resultado += BtnText;
            labelContador.Text = resultado;
        }

        /// METODO BOTONES
        private void btn_0(object sender, EventArgs e)
        {
            changeLabelResult(boton_0.Text);
        }

        private void btn_1(object sender, EventArgs e)
        {
            changeLabelResult(boton_1.Text);
        }

        private void btn_2(object sender, EventArgs e)
        {
            changeLabelResult(boton_2.Text);
        }

        private void btn_3(object sender, EventArgs e)
        {
            changeLabelResult(boton_3.Text);
        }

        private void btn_4(object sender, EventArgs e)
        {
            changeLabelResult(boton_4.Text);
        }

        private void btn_5(object sender, EventArgs e)
        {
            changeLabelResult(boton_5.Text);
        }

        private void btn_6(object sender, EventArgs e)
        {
            changeLabelResult(boton_6.Text);
        }

        private void btn_7(object sender, EventArgs e)
        {
            changeLabelResult(boton_7.Text);
        }

        private void btn_8(object sender, EventArgs e)
        {
            changeLabelResult(boton_8.Text);
        }

        private void btn_9(object sender, EventArgs e)
        {
            changeLabelResult(boton_9.Text);
        }
    }

}
