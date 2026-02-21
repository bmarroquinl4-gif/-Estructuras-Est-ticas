// librerias necesarias 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaContactos
{
    public partial class Form1 : Form

    {
        // lista donde se guardan los contactos
        List<Contacto> listaContactos = new List<Contacto>();
        Contacto contactoActual = null;

        // metodo constructor
        public Form1()
        {
            InitializeComponent();
        }

        // agregar contacto
        private void btnAgregarContacto_Click(object sender, EventArgs e)
        {
            // se crea un objeto contacto
            Contacto nuevo = new Contacto();

            nuevo.Nombre = txtNombre.Text;
            nuevo.Apellido = txtApellido.Text;
            nuevo.Direccion = txtDireccion.Text;
            nuevo.Correo = txtCorreo.Text;


            // se asigna los valores 
            listaContactos.Add(nuevo);
            lstContactos.Items.Add(nuevo);

            //limpia los espacios despues de agregar 
            LimpiarCampos();
        }

        // modificar
        private void btnModificarContacto_Click(object sender, EventArgs e)
        {
            // revida que haya contacto seleccionado 
            if (contactoActual != null)
            {
                // actualiza datos
                contactoActual.Nombre = txtNombre.Text;
                contactoActual.Apellido = txtApellido.Text;
                contactoActual.Direccion = txtDireccion.Text;
                contactoActual.Correo = txtCorreo.Text;

                ActualizarLista();
                LimpiarCampos();
            }
        }

        // eliminar 
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //revisa si hay elemento seleccionado 
            if (lstContactos.SelectedItem != null)
            {
                Contacto c = (Contacto)lstContactos.SelectedItem;
                listaContactos.Remove(c);
                lstContactos.Items.Remove(c);

                LimpiarCampos();
            }
        }

        // Ver los contacots 
        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        // Busca por palabra 
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // obtiene la palabra buscada 
            string palabra = txtBuscar.Text.ToLower();

            // filtra contactos 

            var resultado = listaContactos
                .Where(c => c.PalabrasClave.Any(p => p.ToLower().Contains(palabra)))
                .ToList();

            lstContactos.Items.Clear();
            foreach (var c in resultado)
                lstContactos.Items.Add(c);
        }

        // Seleccionar contacto
        private void lstContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstContactos.SelectedItem != null)
            {
                // guarda el contacto seleccionado
                contactoActual = (Contacto)lstContactos.SelectedItem;

                txtNombre.Text = contactoActual.Nombre;
                txtApellido.Text = contactoActual.Apellido;
                txtDireccion.Text = contactoActual.Direccion;
                txtCorreo.Text = contactoActual.Correo;

                // muesta los telefonos 
                lstTelefonos.Items.Clear();
                foreach (var t in contactoActual.Telefonos)
                    lstTelefonos.Items.Add(t);

                // muesta las palabras 
                lstPalabras.Items.Clear();
                foreach (var p in contactoActual.PalabrasClave)
                    lstPalabras.Items.Add(p);
            }
        }

        // AGgregar 
        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            if (contactoActual != null && txtTelefono.Text != "")
            {
                contactoActual.Telefonos.Add(txtTelefono.Text);
                lstTelefonos.Items.Add(txtTelefono.Text);
                txtTelefono.Clear();
            }
        }

        // Eliminar
        private void btnEliminarTelefono_Click(object sender, EventArgs e)
        {
            if (contactoActual != null && lstTelefonos.SelectedItem != null)
            {
                contactoActual.Telefonos.Remove(lstTelefonos.SelectedItem.ToString());
                lstTelefonos.Items.Remove(lstTelefonos.SelectedItem);
            }
        }

        // Agregar palabra 
        private void btnAgregarPalabra_Click(object sender, EventArgs e)
        {
            if (contactoActual != null && txtPalabra.Text != "")
            {
                contactoActual.PalabrasClave.Add(txtPalabra.Text);
                lstPalabras.Items.Add(txtPalabra.Text);
                txtPalabra.Clear();
            }
        }

        // Eliminar palabra 
        private void btnEliminarPalabra_Click(object sender, EventArgs e)
        {
            if (contactoActual != null && lstPalabras.SelectedItem != null)
            {
                contactoActual.PalabrasClave.Remove(lstPalabras.SelectedItem.ToString());
                lstPalabras.Items.Remove(lstPalabras.SelectedItem);
            }
        }

        // limpiar 
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Metodo que limpia los campos 
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtPalabra.Clear();
            txtBuscar.Clear();

            lstTelefonos.Items.Clear();
            lstPalabras.Items.Clear();

            contactoActual = null;
        }

        // Actualizar lista 
        private void ActualizarLista()
        {
            lstContactos.Items.Clear();
            foreach (var c in listaContactos)
                lstContactos.Items.Add(c);
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }

        private void lstContactos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstContactos.SelectedItem == null) return;

    contactoActual = (Contacto)lstContactos.SelectedItem;

    txtNombre.Text = contactoActual.Nombre;
    txtApellido.Text = contactoActual.Apellido;
    txtDireccion.Text = contactoActual.Direccion;
    txtCorreo.Text = contactoActual.Correo;

    lstTelefonos.Items.Clear();
    foreach (var tel in contactoActual.Telefonos)
        lstTelefonos.Items.Add(tel);

    lstPalabras.Items.Clear();
    foreach (var p in contactoActual.PalabrasClave)
        lstPalabras.Items.Add(p);
        }
    }
}