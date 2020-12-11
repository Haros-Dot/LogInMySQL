using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInMySQL
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Usuario = txtusuario.Text;
            usuario.Password = txtpassword.Text;
            usuario.Conpassword = txtconpassword.Text;
            usuario.Nombre = txtnombre.Text;

            try
            {

                Control control = new Control();
                string respuesta = control.ctrlRegistro(usuario);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario registrado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            FormLogin fL = new FormLogin();
            fL.Visible = true;
            this.Visible = false;
        }
    }
}
