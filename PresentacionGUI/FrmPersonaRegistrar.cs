using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
namespace PresentacionGUI
{
    public partial class FrmPersonaRegistrar : Form
    {
        Persona persona;
        public FrmPersonaRegistrar()
        {
            InitializeComponent();
             
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PersonaService personaService = new PersonaService();
            string mensaje = personaService.Guarda(persona);
            MessageBox.Show(mensaje, "Mensaje al guardar" , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCalcularpulsacion_Click(object sender, EventArgs e)
        {
            persona = new Persona();
            persona.Identificacion = txtIdentificacion.Text;
            persona.Nombre = txtNombre.Text;
            persona.Sexo = cmbSexo.Text;
            persona.Edad = int.Parse(txtEdad.Text);
            persona.CalcularPulsacion();
            txtPulsacion.Text = persona.Pulsacion.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtPulsacion.Text = "";
        }
    }
}
