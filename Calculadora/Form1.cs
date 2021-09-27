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
        private void changeLabelContador(string BtnText) {

            if (resultado != ""){
                labelContador.Text = "";
            }
            contador += BtnText;
            labelContador.Text = contador;
        }
        

        private void changeLabelResult( string BtnOperador)
        {
            resultado = contador + " " + BtnOperador;
            labelResult.Text = resultado;
            contador = "";
        }



        /// METODOS BOTONES NUMERICOS
        private void btn_0(object sender, EventArgs e)
        {
            changeLabelContador(boton_0.Text);
        }

        private void btn_1(object sender, EventArgs e)
        {
            changeLabelContador(boton_1.Text);
        }

        private void btn_2(object sender, EventArgs e)
        {
            changeLabelContador(boton_2.Text);
        }

        private void btn_3(object sender, EventArgs e)
        {
            changeLabelContador(boton_3.Text);
        }

        private void btn_4(object sender, EventArgs e)
        {
            changeLabelContador(boton_4.Text);
        }

        private void btn_5(object sender, EventArgs e)
        {
            changeLabelContador(boton_5.Text);
        }

        private void btn_6(object sender, EventArgs e)
        {
            changeLabelContador(boton_6.Text);
        }

        private void btn_7(object sender, EventArgs e)
        {
            changeLabelContador(boton_7.Text);
        }

        private void btn_8(object sender, EventArgs e)
        {
            changeLabelContador(boton_8.Text);
        }

        private void btn_9(object sender, EventArgs e)
        {
            changeLabelContador(boton_9.Text);
        }


        /// METODOS BOTONES OPERADORES
        private void btn_suma(object sender, EventArgs e)
        {
            changeLabelResult(boton_suma.Text);
        }

        private void btn_resta(object sender, EventArgs e)
        {
            changeLabelResult(boton_resta.Text);
        }

        private void btn_multipli(object sender, EventArgs e)
        {
            changeLabelResult(boton_multi.Text);
        }

        private void btn_division(object sender, EventArgs e)
        {
            changeLabelResult(boton_division.Text);
        }

        private void btn_igual(object sender, EventArgs e)
        {

        }
    }

}
