using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ClassModels
{
    class ListaOperacionesModel
    {

        // TODO - Agregar boton para que cambie el .visible() de nuestro dataGrid

        public DataTable DTOperaciones { get; set; } = new DataTable();
        public int ultimo_id {get;set;} = 0;
 
        /* Creacion de Tabla */
        public ListaOperacionesModel()
        {
            DTOperaciones.TableName = "Lista operaciones";
            DTOperaciones.Columns.Add("Id");
            DTOperaciones.Columns.Add("operacion");

            verifyFileDTOperaciones()
        }

        /* Verificamos la existencia de nuestro archivo .xml */
        public void verifyFileDTOperaciones()
        {

            if(System.IO.File.Exists("ListaOperaciones.xml"))
            {
                // Lo lee
                DTOperaciones.ReadXml("ListaOperaciones.xml");

                // Obtiene el Id mas grande y lo almacena.
                ultimo_id = getLastId(DTOperaciones, ultimo_id)
            }
        }

        public int getLastId (DataTable table, int id )
        {
            int numberId = 0 ;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if( Convert.ToInt32( table.Rows[i]["Id"])>id)
                {
                    numberId = Convert.ToInt32(table.Rows[i]["Id"]);
                }
            }
            return numberId;
        }




        ///////////////////////////////////////////////////////


        ///Calcula la operacion en cuestion
        public string calculateOperation(OperacionModel operacion)
        {

            /*switch (Operator)
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
            }*/

            return "";
        }


        /// Obtiene Lista de Operaciones.
        public void getListOperations()
        {

        }

        /// Seleccionar operaicon en particular
    }
}
