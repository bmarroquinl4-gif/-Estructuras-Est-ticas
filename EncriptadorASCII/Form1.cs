using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace EncriptadorASCII
{

    //Clase principal del proyecto 
    public partial class Form1 : Form
    {

        //es el metodo constructor
        public Form1()

        {

            //metodo que inicializa los componentes graficos
            InitializeComponent();
        }


        // evento que se crea cuando se hace clic al boton 
        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            // obtiene el texto que se escribe
            string cadena = txtCadena.Text;

            // Validar que no esté vacía
            if (string.IsNullOrWhiteSpace(cadena))


            {
                // da una adbertencia si no se ingresa una cadena 
                MessageBox.Show("Debe ingresar una cadena.");
                return;
            }

            string asciiOriginal = "";
            string asciiEncriptado = "";

            // bucle que recorre cada caracter dela cadena

            for (int i = 0; i < cadena.Length; i++)
            {
                // convierte a cadena a su codigo ascii
                int ascii = (int)cadena[i];

                //hace la encriptacion y le suma 3
                int encriptado = ascii + 3;

                asciiOriginal += ascii + " ";
                asciiEncriptado += encriptado + " ";
            }
            // muestra el resultado 

            lblResultado.Text =
                "ASCII: " + asciiOriginal + Environment.NewLine +
                "ASCII + 3: " + asciiEncriptado;
        }
    }
}