using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Agregar Controladores de eventos TextChanged a los campos 
            tbnombre.TextChanged += Validarnombre;
            tbapellido.TextChanged += Validarapellido;
            tbedad.TextChanged += Validaredad;
            tbestatura.TextChanged += Validarestatura;
            tbtelefono.TextChanged += Validartelefono;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Obtener datos de los Texbox
            string nombres = tbnombre.Text;
            string apellidos = tbapellido.Text;
            string edad = tbedad.Text;
            string estatura = tbestatura.Text;
            string telefono = tbtelefono.Text;

            //Obtener el genero seleccionado
            string genero = "";
            if (rbHombre.Checked)
            {
                genero = "Hombre";
            }
            else if (rbMujer.Checked)
            {
                genero = "Mujer";
            }
            //Validar que los campos tengan el formato correcto 
            if (EsEnteroValido(edad)&& EsDecimalValido(estatura)&& EsEnteroValidoDe10Digitos(telefono)&& EsTextoValido(nombres)&& EsTextoValido(apellidos))
            {
                //Crear una cadena de los datos
                string datos = $"Nombres:{nombres}\r\nApellidos: {apellidos}\r\ntelefono: {telefono} \r\nestatura: {estatura} \r\nedad: {edad} años\r\ngenero: {genero}";

                //Guardar los datos en un archivo de texto 
                string rutaArchivo = "C:/Users/rodo1/PRO/IZI.txt";
                bool archivoExiste = File.Exists(rutaArchivo);
                if (archivoExiste== false)
                {
                    File.WriteAllText(rutaArchivo, datos);
                }
                else
                {
                    //verifica si el archivo ya existe
                    using(StreamWriter writer = new StreamWriter(rutaArchivo, true))
                    {
                        if (archivoExiste)
                        {
                            //si el archivo existe, añadir un separador antes del registro
                            writer.WriteLine();
                        }
                        writer.WriteLine(datos);
                    }
                }
                //mostrar un mensaje con los datos capturados 
                MessageBox.Show("Datos guardados con exito:\n\n" + datos, "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Por fabor, ingrese los datos validos en los campos .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            ////Crear una cadena de los datos
            //string datos = $"Nombres:{nombres}\r\nApellidos: {apellidos}\r\ntelefono: {telefono} \r\nestatura: {estatura} \r\nedad: {edad} años\r\ngenero: {genero}";

            ////Guardar los datos en un archivo de texto 
            //string rutaArchivo = "C:/Users/rodo1/PRO/IZI.txt";
            ////File.WriteAllText(rutaArchivo, datos);

            ////Verificar si el archivo existe 
            //bool archivoExiste = File.Exists(rutaArchivo);
            ////console.writeLine(ArchivoExiste);
            //if (archivoExiste == false)
            //{
            //    File.WriteAllText(rutaArchivo, datos);
            //}
            //else
            //{
            //    using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            //    {
            //        if (archivoExiste)
            //        {
            //            writer.WriteLine();
            //        }


            //        writer.WriteLine(datos);
            //    }
            //}

            ////mostrar mensajes con los datos capturados 
            //MessageBox.Show("Datos guardados con exito:\n\n" + datos, "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }
        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
        }
        private bool EsEnteroValidoDe10Digitos(string valor)
        {
            long resultado;
            return long.TryParse(valor, out resultado)&& valor.Length == 10;
        }
        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");//solo letras y espacios 
        }
        private void Validaredad(object senter, EventArgs e)
        {
            TextBox textBox =(TextBox) senter;
            if (!EsEnteroValido(textBox.Text))
            {
                MessageBox.Show("Por favor , ingrese una edad valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }
        private void Validarestatura(object senter, EventArgs e)
        {
            TextBox textBox = (TextBox)senter;
            if (!EsDecimalValido(textBox.Text))
            {
                MessageBox.Show("Por favor , ingrese una estatura valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }
        private void Validartelefono(object senter, EventArgs e)
        {
            TextBox textBox = (TextBox)senter;
            string inpunt = textBox.Text;
            //eliminar espacios en blanco y guiones si es necesario
            if (inpunt.Length > 10)
            {
                if (!EsEnteroValidoDe10Digitos(inpunt))
                {
                    MessageBox.Show("Por favor , ingrese un numero de telefono valida de 10 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear();
                }
            }
        }
   
            private void Validarnombre(object senter , EventArgs e)
            {
                TextBox textBox = (TextBox)senter;
                    if (!EsTextoValido(textBox.Text))
                {
                    MessageBox.Show("Por favor , ingrese un nombres validos (solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear();
                }
            }
        private void Validarapellido(object senter, EventArgs e)
        {
            TextBox textBox = (TextBox)senter;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor , ingrese un apellidos validos (solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }


        private void btborrar_Click_1(object sender, EventArgs e)
        {
            //Limpiar los controles despues de guardar 
            tbnombre.Clear();
            tbapellido.Clear();
            tbedad.Clear();
            tbestatura.Clear();
            tbtelefono.Clear();
            rbHombre.Checked = false;
            rbMujer.Checked = false;
        }
    }
}