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

        float primerNumero = 0;
        float segundoNumero = 0;
        string operador = "";
        string resultado = "";


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

            /// Se valida aca, cuando ingresamos el primer numero de la primera operacion
            if (acumulador == "")
            {
                /// Si valida aca, es porque hemos puesto el primer numero
                acumulador = contador + " " + BtnOperador;

                /// Convertimos el primer valor en numero flotante
                /// y lo almacenamos (para realizar operacion)
                primerNumero = System.Convert.ToSingle(contador);
                
                /// Mostramos en pantalla.
                labelResult.Text = acumulador;
                contador = ""; /// Permite escribir nuevamente un numero de 0.
            }

            /// En caso de que hayamos hehco una operacion y queramos continuar
            else if (acumulador != "" && resultado != "")
            {
              labelResult.Text = resultado + " " + BtnOperador;
            }


            /// Se valida aca, cuando ingresamos el segundo numero de la primera operacion
            else
            {
                acumulador = acumulador + " " + contador + " " + BtnOperador;

                /// Convertimos el 2do numero a numero flotante.
                segundoNumero = System.Convert.ToSingle(contador);

                /// Mostramos en pantalla.
                labelResult.Text = acumulador;
                contador = ""; /// Permite escribir nuevamente un numero de 0.
            }
        }

        /// 3) Metodo que realiza la operacion en cuesiton.
        private void calculateOperation ( string Operator, float numero1, float numero2)
        {
            switch (Operator)
            {
                case "➕":
                    resultado = System.Convert.ToString(numero1 + numero2);
                    break;
                case "➖":
                    resultado = System.Convert.ToString( numero1 - numero2);
                    break;

                case "✖":
                    resultado = System.Convert.ToString(numero1 * numero2);
                    break;

                case "➗":
                    resultado = System.Convert.ToString(numero1 / numero2);
                    break;

                default:
                    break;
            }
        }

        /// 3) Dicho boton, ejecuta el METODO GLOBAL "changeLabelResult" para realizar toda
        /// la operacion en cuestion.
        private void btn_igual(object sender, EventArgs e)
        {

            try
            {
                /// Si no escribimos nada, no se ejecuta el igual.
                if (primerNumero == 0 && operador == "")
                {
                    throw new Exception("Ingrese 2 numeros y operador.");
                }

                /// Caso de que hayamos escrito un numero y un operador, SI.
                changeLabelResult(boton_igual.Text);
                if (resultado == "")
                { /// Se ejecuta cuando obtenemos un primer resultado.
                    calculateOperation(
                        operador,
                        primerNumero,
                        segundoNumero
                    );
                }
                else
                { /// Se ejecuta cuando sumamos un valor al resultado ya obtenido.
                    labelResult.Text = resultado + " " + operador + " " + contador + " " + boton_igual.Text;
                    calculateOperation(
                        operador,
                        System.Convert.ToSingle(resultado),
                        System.Convert.ToSingle(contador)
                    );
                }
                contador = ""; /// Permite escribir nuevamente un numero de 0.
                labelContador.Text = resultado;

            }
              catch (Exception error)
            {
                 labelResult.Text = error.Message.ToString();
            }
        }


        /// 2) Los siguientes 4 metodos, utilizan un METODO GLOBAL "changeLabelResult"
        /// el cual, plasma dentro del "labelResult", el contenido del "labelContador"
        /// sumado del signo de operacion.
        /// Tambien determina el valor del "operador", que nos servira para ejecutar 
        /// la operacion en si.
        private void btn_suma(object sender, EventArgs e)
        {
           if (labelContador.Text != "0") ///Evitamos poder poner primero un operador.
           {
              changeLabelResult(boton_suma.Text);
              operador = boton_suma.Text;
           }
        }

        private void btn_resta(object sender, EventArgs e)
        {
            if (labelContador.Text != "0") ///Evitamos poder poner primero un operador.
            {
              changeLabelResult(boton_resta.Text);
              operador = boton_resta.Text;
            }
        }

        private void btn_multipli(object sender, EventArgs e)
        {
            if (labelContador.Text != "0") ///Evitamos poder poner primero un operador.
            {
                changeLabelResult(boton_multi.Text);
                operador = boton_multi.Text;
            }
        }

        private void btn_division(object sender, EventArgs e)
        {
            if (labelContador.Text != "0") ///Evitamos poder poner primero un operador.
            {
                changeLabelResult(boton_division.Text);
                operador = boton_division.Text;
            }
        }


        /// 1) Cada boton numerico, utilizara un METODO GLOBAL "changeLabelContador" 
        /// el cual servira para plasmar su valor numerico en el labelContador.
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
            
        private void btn_coma(object sender, EventArgs e)
        {
            ///Si el contador, NO posee una "," (Debido a que ya pusimos una antes)
            /// no pondra otra coma mas.
            if (!contador.Contains(","))
            {
                changeLabelContador(boton_coma.Text);
            }
        }

        private void btn_delete(object sender, EventArgs e )
        {
            if (contador.Length != 0)
            {
                contador = contador.Remove(contador.Length - 1);
                labelContador.Text = contador;
            }
            if (labelContador.Text == "")
            {
                labelContador.Text = "0";
            }
        }
       
        private void btn_clear(object sender, EventArgs e)
        {
            contador = "";
            acumulador = "";

            primerNumero = 0;
            segundoNumero = 0;

            operador = "";
            resultado = "";
            labelContador.Text = "0";
            labelResult.Text = "";
        }

        private void btn_negacion(object sender, EventArgs e)
        {
            if (labelContador.Text != "0") //Si nuestro label esta en "0". no pondra signo -
            {
                if (!contador.Contains("-")) //Si nuestro contador NO posee el "-", permite agregarselo                         ////if (!contador.Contains("-")) 
                {
                    contador = "-" + contador;
                }
                else
                {// caso contrario, se lo quita.
                    contador = contador.Replace("-", "");
                }
                labelContador.Text = contador;
            }
        }
    }
}
