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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string password = txtpassword.Text;

            try
            {
                Control ctrl = new Control();
                String respuesta = ctrl.ctrlLogin(usuario, password);
                if(respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FormPrincipal frm = new FormPrincipal();
                    frm.Visible = true;
                    this.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            FormRegistro f1 = new FormRegistro();
            f1.Visible = true;
            this.Visible = false;
        }
    }
}
