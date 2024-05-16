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
    public partial class Registro_Paciente : Form
    {
        #region "Variables"
        int actualizado = 0;
        #endregion
        
    
        public Registro_Paciente()
        {
            InitializeComponent();
        }
        private void Listar_paciente(string valor)
        {
            try
            {
                dataGridView1.DataSource = N_pacientes.Listar_paciente(valor);
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error más amigable para los usuarios
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }



        private void Registro_Paciente_Load(object sender, EventArgs e)
        {
            this.Listar_paciente("%");
        }

        
        

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            actualizado = 1;
            if (txtnombre.Text == string.Empty)
            {
                MessageBox.Show("Este campo es obligatorio.", "Aviso importante",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                string respuesta = "";
                E_pacientes ePaciente = new E_pacientes();
                ePaciente.Codigo_pac = 0;
                ePaciente.ID_usuario = Convert.ToInt32(cmbusuario.SelectedValue);
                ePaciente.Nombre = txtnombre.Text.Trim();
                ePaciente.Apellido = txtapellido.Text.Trim();
                ePaciente.Cedula = txtcedula.Text.Trim();
                ePaciente.Fecha_nacimiento = txtnacimiento.Text.Trim();
                ePaciente.Telefono = txttelefono.Text.Trim();
                ePaciente.Correo = txtcorreo.Text.Trim();
                ePaciente.Edad = txtedad.Text.Trim();
                ePaciente.Sexo = txtsexo.Text.Trim();
                respuesta = N_pacientes.Guardar_pac(actualizado, ePaciente);
                  

                if (respuesta == "Ok")
                { 
                    this.Listar_paciente("%"); 
                    MessageBox.Show("Datos guardados correctamente", "Aviso del sistema",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtnombre.Text = "";
                    txtapellido.Text = "";
                    txtcedula.Text = "";
                    txtnacimiento.Text = "";
                    txttelefono.Text = "";
                    txtcorreo.Text = "";
                    txtedad.Text = "";
                    txtsexo.Text = "";

                }
                else
                {
                    MessageBox.Show(respuesta, "Aviso del sistema ",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                

                actualizado = 0;



            }
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Listar_paciente("%");
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == string.Empty)
            {
                MessageBox.Show("Los campos son obligatorios.", "Aviso importante",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta = "";
                E_pacientes ePaciente = new E_pacientes();

                // Obtén el ID del cliente seleccionado desde el DataGridView
                DataGridViewRow filaSeleccionada = dataGridView1.CurrentRow;
                if (filaSeleccionada != null)
                {
                    ePaciente.Codigo_pac = Convert.ToInt32(filaSeleccionada.Cells["Codigo_pac"].Value); // Ajusta el nombre de la columna según tu DataGridView
                }
                else
                {
                    MessageBox.Show("Selecciona un cliente para actualizar.", "Aviso importante",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Sal del método si no hay fila seleccionada
                }

                ePaciente.Nombre = txtnombre.Text.Trim();
                ePaciente.Apellido = txtapellido.Text.Trim();
                ePaciente.Cedula = txtcedula.Text.Trim();
                ePaciente.Fecha_nacimiento = txtnacimiento.Text.Trim();
                ePaciente.Telefono = txttelefono.Text.Trim();
                ePaciente.Correo = txtcorreo.Text.Trim();
                ePaciente.Edad = txtedad.Text.Trim();
                ePaciente.Sexo = txtsexo.Text.Trim() ;
                respuesta = N_pacientes.Guardar_pac(actualizado, ePaciente);
               

                if (respuesta == "Ok")
                {
                    MessageBox.Show("Datos guardados correctamente", "Aviso del sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    this.Listar_paciente("%");
                    txtnombre.Text = "";
                txtapellido.Text = "";
                txtcedula.Text = "";
                txtnacimiento.Text = "";
                txttelefono.Text = "";
                txtcorreo.Text = "";
                txtedad.Text = "";
                txtsexo.Text = "";

                }
                else
                {
                    MessageBox.Show(respuesta, "Aviso del sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
             
                actualizado = 0;
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice == -1 || dataGridView1.SelectedCells[1].Value.ToString() == "")
            {
                MessageBox.Show("Seleccione un registro valido");

            }
            else
            {
                
                txtnombre.Text = dataGridView1.SelectedCells[3].Value.ToString();
                txtapellido.Text = dataGridView1.SelectedCells[4].Value.ToString();
                txtcedula.Text = dataGridView1.SelectedCells[5].Value.ToString();
                txtnacimiento.Text = dataGridView1.SelectedCells[6].Value.ToString();
                txttelefono.Text = dataGridView1.SelectedCells[7].Value.ToString();
              txtcorreo.Text = dataGridView1.SelectedCells[8].Value.ToString();
                txtedad.Text = dataGridView1.SelectedCells[9].Value.ToString();
                txtsexo.Text = dataGridView1.SelectedCells[10].Value.ToString();


            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
} 
