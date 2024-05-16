using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            PersonalizarDiseñoMenu();
            //llamanos al metodo.

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void PersonalizarDiseñoMenu()
        {
            panel_historial_clinico.Visible = false;
            panel_ayuda.Visible = false;
            //para que el boton o menu se despliegue.
        }

        private void OcultarMenu()//personalizar menu,para poder ocultarlo
        {
            if (panel_ayuda.Visible == true)
                panel_ayuda.Visible = false;

            if (panel_historial_clinico.Visible == true)
                panel_historial_clinico.Visible = false;
        }
        private void MostrarMenu(Panel Menu)
        {
            if (Menu.Visible == false)
            {
                OcultarMenu();
                Menu.Visible = true;
            }
            else
                Menu.Visible = false;


        }



        private void btn_historial_clinico_Click(object sender, EventArgs e)
        {
            MostrarMenu(panel_historial_clinico);
        }

        private void btn_recorr_clinico_Click(object sender, EventArgs e)
        {
            
            OcultarMenu();
        }

        private void btn_procedimientos_Click(object sender, EventArgs e)
        {
            openhijoform(new Registro_Procedimientos_Realizados());
            OcultarMenu();
        }

        private void btn_pruebas_medicas_Click(object sender, EventArgs e)
        {
            openhijoform(new Registro_Pruebas_Medica());
            OcultarMenu();
        }

        private void btn_detalle_record_Click(object sender, EventArgs e)
        {
            OcultarMenu();
        }

        private void btn_datos_seguro_Click(object sender, EventArgs e)
        {
            OcultarMenu();
        }

       

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {

            OcultarMenu();
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            OcultarMenu();
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {

            MostrarMenu(panel_ayuda);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_datos_seguro_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_paciente_Click(object sender, EventArgs e)
        {

            openhijoform(new Registro_Paciente());
        }
        private Form activeForm = null;
        private void openhijoform(Form hijoform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = hijoform;
            hijoform.TopLevel = false;
            hijoform.Dock = DockStyle.Fill;
            panelMuestra.Controls.Add(hijoform);
            panelMuestra.Tag = hijoform;
            hijoform.BringToFront();
            hijoform.Show();


        }

        private void btn_medico_Click(object sender, EventArgs e)
        {
            openhijoform(new Registro_Medico());
        }

        private void btn_procedimientos_Click_1(object sender, EventArgs e)
        {

        }
    }
}


