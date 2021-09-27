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
        string acumulador = "";

        int primerNumero = 0;
        int segundoNumero = 0;
        string operador = "";


        /// METODOS GLOBALES
       
        /// 1) Metodo que permite plasmar el valor del boton en el primer label.
        private void changeLabelContador(string BtnText) {
            if (acumulador != ""){ /// Si ya hemos escrito algo previamente, nos borrara el contenido y escribira lo nuevo.
                labelContador.Text = "";
            }
            contador += BtnText;
            labelContador.Text = contador;
        }
        
        /// 2) Metodo que permite plasmar el contenido del "labelContador", en el "labelResultado" junto al signo elegido.
        private void changeLabelResult( string BtnOperador)
        {
            if (acumulador == "")
            {
                /// Si valida aca, es porque hemos puesto el primer numero
                acumulador = contador + " " + BtnOperador;

                /// Convertimos el primer valor en numero y lo almacenamos (para realizar operacion)
                primerNumero = System.Convert.ToInt32(contador);

                /// Mostramos en pantalla.
                labelResult.Text = acumulador;
                contador = "";
            }
            else
            {
                /// Si valida aca, es porque hemos puesto el segundo numero
                acumulador = acumulador + " " + contador + " " + BtnOperador;

                /// Convertimos el 2do numero a numero.
                segundoNumero = System.Convert.ToInt32(contador);

                /// Mostramos en pantalla.
                labelResult.Text = acumulador;
            }
        }

        /// 3) Metodo que realiza la operacion en cuesiton.
        private string calculateOperation ( string Operator)
        {
            string resultado = "";
            switch (Operator)
            {
                case "➕":
                    resultado = System.Convert.ToString(primerNumero + segundoNumero);
                    break;
                case "➖":
                    resultado = System.Convert.ToString(primerNumero - segundoNumero);
                    break;

                case "✖":
                    resultado = System.Convert.ToString(primerNumero * segundoNumero);
                    break;

                case "➗":
                    resultado = System.Convert.ToString(primerNumero / segundoNumero);
                    break;

                default:
                    break;
            }

            return resultado;
        }


        /// TODOS LOS METODOS DE ABAJO, SON DE LOS BOTONES QUE EJECUTAN LOS METODOS GLOBALES DE ARRIBA.

        /// METODOS BOTONES OPERADORES
        private void btn_igual(object sender, EventArgs e)
        {
            changeLabelResult(boton_igual.Text);
            labelContador.Text = calculateOperation(operador);
        }

        private void btn_suma(object sender, EventArgs e)
        {
            changeLabelResult(boton_suma.Text);
            operador = boton_suma.Text;
        }

        private void btn_resta(object sender, EventArgs e)
        {
            changeLabelResult(boton_resta.Text);
            operador = boton_resta.Text;
        }

        private void btn_multipli(object sender, EventArgs e)
        {
            changeLabelResult(boton_multi.Text);
            operador = boton_multi.Text;
        }

        private void btn_division(object sender, EventArgs e)
        {
            changeLabelResult(boton_division.Text);
            operador = boton_division.Text;
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

    }
}
