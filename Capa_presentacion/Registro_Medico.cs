using Capa_Entidad;
using Capa_Negocio;
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
    
    //Se utiliza para guardar el codigo seleccionado
 
    public partial class Registro_Medico : Form
    {
        public Registro_Medico()
        {
            InitializeComponent();
        }
        private void ListarMedicos(string valor)
        {
            try
            {
                dataGridView1.DataSource =N_medico.ListarMedicos(valor);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }
        }
        private void BuscarMedicos(string valor)
        {
            try
            {
                dataGridView1.DataSource = N_medico.BuscarMedicos(valor);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.BuscarMedicos(txt_buscar.Text.Trim());

        }

        private void Registro_Medico_Load(object sender, EventArgs e)
        {
            this.ListarMedicos("%");
            dataGridView1.Enabled = true;

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
            
                string respuesta = "";
                E_medico medico = new E_medico();
            medico.Nombre = txt_nombre_medico.Text.Trim();
            medico.Apellido = txt_apellido_medico.Text.Trim();
            medico.Cedula= txt_cedula_medico.Text.Trim();
            medico.correo= txt_correo_medico.Text.Trim();
            medico.Telefono = txt_telefono_medico.Text.Trim();
            medico.Especialidad = txt_especialidad_medico.Text.Trim();
           

                if (respuesta == "Ok")
                {
                    MessageBox.Show("Datos guardados correctamente.", "Aviso del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ListarMedicos("%");
                
                }
                else
                {
                    MessageBox.Show(respuesta, "Aviso del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }

