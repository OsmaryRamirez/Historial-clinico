using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocio;

namespace Capa_presentacion
{
    public partial class InicioSesion : Form
    {

        E_usuario objeuser = new E_usuario();
        N_usuario objnuser = new N_usuario();
        MenuPrincipal frm = new MenuPrincipal();

        public static string usuario;
        public static string contraseña;


        public InicioSesion()
        {
            InitializeComponent();
        }
        void lista()
        {
            DataTable dt = new DataTable();
            objeuser.usuario = txt_usuario.Text;
            objeuser.contraseña = txt_contraseña.Text;
            dt = objnuser.N_usuarios(objeuser);
            if (dt.Rows.Count > 0)
            {

                MessageBox.Show("BIENVENIDO  " + dt.Rows[0][4].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario = dt.Rows[0][2].ToString();
                contraseña = dt.Rows[0][3].ToString();

                frm.ShowDialog();
                InicioSesion login = new InicioSesion();
                login.ShowDialog();
                if (login.DialogResult == DialogResult.OK)
                    Application.Run(new MenuPrincipal());

                Close();


            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        private void btn_acceder_Click(object sender, EventArgs e)
        {
            lista();
        }
    }
}
