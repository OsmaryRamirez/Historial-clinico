namespace Capa_presentacion
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btn_medico = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.panel_ayuda = new System.Windows.Forms.Panel();
            this.btn_backup = new System.Windows.Forms.Button();
            this.btn_cerrar_sesion = new System.Windows.Forms.Button();
            this.btn_historial_clinico = new System.Windows.Forms.Button();
            this.btn_datos_seguro = new System.Windows.Forms.Button();
            this.btn_pruebas_medicas = new System.Windows.Forms.Button();
            this.btn_detalle_record = new System.Windows.Forms.Button();
            this.btn_procedimientos = new System.Windows.Forms.Button();
            this.btn_recorr_clinico = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_historial_clinico = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_paciente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMuestra = new System.Windows.Forms.Panel();
            this.panel_ayuda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_historial_clinico.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_medico
            // 
            this.btn_medico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(157)))), ((int)(((byte)(239)))));
            this.btn_medico.FlatAppearance.BorderSize = 0;
            this.btn_medico.FlatAppearance.CheckedBackColor = System.Drawing.Color.PowderBlue;
            this.btn_medico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_medico.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_medico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(6)))), ((int)(((byte)(109)))));
            this.btn_medico.Image = ((System.Drawing.Image)(resources.GetObject("btn_medico.Image")));
            this.btn_medico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_medico.Location = new System.Drawing.Point(12, 97);
            this.btn_medico.Name = "btn_medico";
            this.btn_medico.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_medico.Size = new System.Drawing.Size(307, 64);
            this.btn_medico.TabIndex = 5;
            this.btn_medico.Text = "Medicos";
            this.btn_medico.UseVisualStyleBackColor = false;
            this.btn_medico.Click += new System.EventHandler(this.btn_medico_Click);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(157)))), ((int)(((byte)(239)))));
            this.btn_ayuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ayuda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(140)))), ((int)(((byte)(242)))));
            this.btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ayuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(6)))), ((int)(((byte)(109)))));
            this.btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_ayuda.Image")));
            this.btn_ayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ayuda.Location = new System.Drawing.Point(0, 703);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_ayuda.Size = new System.Drawing.Size(322, 70);
            this.btn_ayuda.TabIndex = 2;
            this.btn_ayuda.Text = "         Ayuda";
            this.btn_ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ayuda.UseVisualStyleBackColor = false;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // panel_ayuda
            // 
            this.panel_ayuda.AutoScroll = true;
            this.panel_ayuda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_ayuda.Controls.Add(this.btn_backup);
            this.panel_ayuda.Controls.Add(this.btn_cerrar_sesion);
            this.panel_ayuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ayuda.Location = new System.Drawing.Point(0, 773);
            this.panel_ayuda.Name = "panel_ayuda";
            this.panel_ayuda.Size = new System.Drawing.Size(322, 95);
            this.panel_ayuda.TabIndex = 3;
            // 
            // btn_backup
            // 
            this.btn_backup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(157)))), ((int)(((byte)(239)))));
            this.btn_backup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_backup.FlatAppearance.BorderSize = 0;
            this.btn_backup.FlatAppearance.CheckedBackColor = System.Drawing.Color.PowderBlue;
            this.btn_backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(6)))), ((int)(((byte)(109)))));
            this.btn_backup.Image = ((System.Drawing.Image)(resources.GetObject("btn_backup.Image")));
            this.btn_backup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_backup.Location = new System.Drawing.Point(0, 45);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_backup.Size = new System.Drawing.Size(322, 50);
            this.btn_backup.TabIndex = 1;
            this.btn_backup.Text = "      Backup";
            this.btn_backup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_backup.UseVisualStyleBackColor = false;
            // 
            // btn_cerrar_sesion
            // 
            this.btn_cerrar_sesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(157)))), ((int)(((byte)(239)))));
            this.btn_cerrar_sesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cerrar_sesion.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_sesion.FlatAppearance.CheckedBackColor = System.Drawing.Color.PowderBlue;
            this.btn_cerrar_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_sesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(6)))), ((int)(((byte)(109)))));
            this.btn_cerrar_sesion.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar_sesion.Image")));
            this.btn_cerrar_sesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar_sesion.Location = new System.Drawing.Point(0, 0);
            this.btn_cerrar_sesion.Name = "btn_cerrar_sesion";
            this.btn_cerrar_sesion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_cerrar_sesion.Size = new System.Drawing.Size(322, 45);
            this.btn_cerrar_sesion.TabIndex = 0;
            this.btn_cerrar_sesion.Text = "      Cerrar sesión ";
            this.btn_cerrar_sesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar_sesion.UseVisualStyleBackColor = false;
            // 
            // btn_historial_clinico
            // 
            this.btn_historial_clinico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(157)))), ((int)(((byte)(239)))));
            this.btn_historial_clinico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_historial_clinico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btn_historial_clinico.FlatAppearance.BorderSize = 0;
            this.btn_historial_clinico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_historial_clinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_historial_clinico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(6)))), ((int)(((byte)(109)))));
            this.btn_historial_clinico.Image = ((System.Drawing.Image)(resources.GetObject("btn_historial_clinico.Image")));
            this.btn_historial_clinico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_historial_clinico.Location = new System.Drawing.Point(0, 392);
            this.btn_historial_clinico.Name = "btn_historial_clinico";
            this.btn_historial_clinico.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_historial_clinico.Size = new System.Drawing.Size(322, 87);
            this.btn_historial_clinico.TabIndex = 0;
            this.btn_historial_clinico.Text = "         Historial Clinico";
            this.btn_historial_clinico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_historial_clinico.UseVisualStyleBackColor = false;
            this.btn_historial_clinico.Click += new System.EventHandler(this.btn_historial_clinico_Click);
            // 
            // btn_datos_seguro
            // 
            this.btn_datos_seguro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(157)))), ((int)(((byte)(239)))));
            this.btn_datos_seguro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_datos_seguro.FlatAppearance.BorderSize = 0;
            this.btn_datos_seguro.FlatAppearance.CheckedBackColor = System.Drawing.Color.PowderBlue;
            this.btn_datos_seguro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_datos_seguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datos_seguro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(6)))), ((int)(((byte)(109)))));
            this.btn_datos_seguro.Image = ((System.Drawing.Image)(resources.GetObject("btn_datos_seguro.Image")));
            this.btn_datos_seguro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_datos_seguro.Location = new System.Drawing.Point(0, 90);
            this.btn_datos_seguro.Name = "btn_datos_seguro";
            this.btn_datos_seguro.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_datos_seguro.Size = new System.Drawing.Size(322, 47);
            this.btn_datos_seguro.TabIndex = 5;
            this.btn_datos_seguro.Text = "       Datos del seguro";
            this.btn_datos_seguro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_datos_seguro.UseVisualStyleBackColor = false;
            this.btn_datos_seguro.Click += new System.EventHandler(this.btn_datos_seguro_Click_1);
            // 
            // btn_pruebas_medicas
            // 
            this.btn_pruebas_medicas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(157)))), ((int)(((byte)(239)))));
            this.btn_pruebas_medicas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_pruebas_medicas.FlatAppearance.BorderSize = 0;
            this.btn_pruebas_medicas.FlatAppearance.CheckedBackColor = System.Drawing.Color.PowderBlue;
            this.btn_pruebas_medicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pruebas_medicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pruebas_medicas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(6)))), ((int)(((byte)(109)))));
            this.btn_pruebas_medicas.Image = ((System.Drawing.Image)(resources.GetObject("btn_pruebas_medicas.Image")));
            this.btn_pruebas_medicas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pruebas_medicas.Location = new System.Drawing.Point(0, 137);
            this.btn_pruebas_medicas.Name = "btn_pruebas_medicas";
            this.btn_pruebas_medicas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_pruebas_medicas.Size = new System.Drawing.Size(322, 47);
            this.btn_pruebas_medicas.TabIndex = 4;
            this.btn_pruebas_medicas.Text = "       Pruebas medicas";
            this.btn_pruebas_medicas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pruebas_medicas.UseVisualStyleBackColor = false;
            // 
            // btn_detalle_record
            // 
            this.btn_detalle_record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(157)))), ((int)(((byte)(239)))));
            this.btn_detalle_record.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_detalle_record.FlatAppearance.BorderSize = 0;
            this.btn_detalle_record.FlatAppearance.CheckedBackColor = System.Drawing.Color.PowderBlue;
            this.btn_detalle_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_detalle_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detalle_record.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(6)))), ((int)(((byte)(109)))));
            this.btn_detalle_record.Image = ((System.Drawing.Image)(resources.GetObject("btn_detalle_record.Image")));
            this.btn_detalle_record.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_detalle_record.Location = new System.Drawing.Point(0, 184);
            this.btn_detalle_record.Name = "btn_detalle_record";
            this.btn_detalle_record.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_detalle_record.Size = new System.Drawing.Size(322, 47);
            this.btn_detalle_record.TabIndex = 2;
            this.btn_detalle_record.Text = "       Detalle record";
            this.btn_detalle_record.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_detalle_record.UseVisualStyleBackColor = false;
            // 
            // btn_procedimientos
            // 
            this.btn_procedimientos.BackColor = System.Drawing.Color.LightBlue;
            this.btn_procedimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_procedimientos.FlatAppearance.BorderSize = 0;
            this.btn_procedimientos.FlatAppearance.CheckedBackColor = System.Drawing.Color.PowderBlue;
            this.btn_procedimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_procedimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procedimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(6)))), ((int)(((byte)(109)))));
            this.btn_procedimientos.Image = ((System.Drawing.Image)(resources.GetObject("btn_procedimientos.Image")));
            this.btn_procedimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_procedimientos.Location = new System.Drawing.Point(0, 0);
            this.btn_procedimientos.Name = "btn_procedimientos";
            this.btn_procedimientos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_procedimientos.Size = new System.Drawing.Size(322, 47);
            this.btn_procedimientos.TabIndex = 1;
            this.btn_procedimientos.Text = "        Procedimientos realizados";
            this.btn_procedimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_procedimientos.UseVisualStyleBackColor = false;
            this.btn_procedimientos.Click += new System.EventHandler(this.btn_procedimientos_Click_1);
            // 
            // btn_recorr_clinico
            // 
            this.btn_recorr_clinico.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_recorr_clinico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_recorr_clinico.FlatAppearance.BorderSize = 0;
            this.btn_recorr_clinico.FlatAppearance.CheckedBackColor = System.Drawing.Color.PowderBlue;
            this.btn_recorr_clinico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recorr_clinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recorr_clinico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(6)))), ((int)(((byte)(109)))));
            this.btn_recorr_clinico.Image = ((System.Drawing.Image)(resources.GetObject("btn_recorr_clinico.Image")));
            this.btn_recorr_clinico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_recorr_clinico.Location = new System.Drawing.Point(0, 47);
            this.btn_recorr_clinico.Name = "btn_recorr_clinico";
            this.btn_recorr_clinico.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_recorr_clinico.Size = new System.Drawing.Size(322, 43);
            this.btn_recorr_clinico.TabIndex = 0;
            this.btn_recorr_clinico.Text = "        Record clinico";
            this.btn_recorr_clinico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_recorr_clinico.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(157)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.panel_ayuda);
            this.panel1.Controls.Add(this.btn_ayuda);
            this.panel1.Controls.Add(this.panel_historial_clinico);
            this.panel1.Controls.Add(this.btn_historial_clinico);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 883);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_historial_clinico
            // 
            this.panel_historial_clinico.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_historial_clinico.Controls.Add(this.btn_detalle_record);
            this.panel_historial_clinico.Controls.Add(this.btn_pruebas_medicas);
            this.panel_historial_clinico.Controls.Add(this.btn_datos_seguro);
            this.panel_historial_clinico.Controls.Add(this.btn_recorr_clinico);
            this.panel_historial_clinico.Controls.Add(this.btn_procedimientos);
            this.panel_historial_clinico.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_historial_clinico.Location = new System.Drawing.Point(0, 479);
            this.panel_historial_clinico.Name = "panel_historial_clinico";
            this.panel_historial_clinico.Size = new System.Drawing.Size(322, 224);
            this.panel_historial_clinico.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(157)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 392);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(3, 189);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(322, 1);
            this.panel5.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(0, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(322, 1);
            this.panel4.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(6)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(94, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre del usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 78);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(157)))), ((int)(((byte)(239)))));
            this.panel3.Controls.Add(this.btn_paciente);
            this.panel3.Controls.Add(this.btn_medico);
            this.panel3.Location = new System.Drawing.Point(3, 225);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 167);
            this.panel3.TabIndex = 7;
            // 
            // btn_paciente
            // 
            this.btn_paciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(157)))), ((int)(((byte)(239)))));
            this.btn_paciente.FlatAppearance.BorderSize = 0;
            this.btn_paciente.FlatAppearance.CheckedBackColor = System.Drawing.Color.PowderBlue;
            this.btn_paciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(6)))), ((int)(((byte)(109)))));
            this.btn_paciente.Image = ((System.Drawing.Image)(resources.GetObject("btn_paciente.Image")));
            this.btn_paciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_paciente.Location = new System.Drawing.Point(12, 30);
            this.btn_paciente.Name = "btn_paciente";
            this.btn_paciente.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_paciente.Size = new System.Drawing.Size(290, 61);
            this.btn_paciente.TabIndex = 7;
            this.btn_paciente.Text = "  Pacientes";
            this.btn_paciente.UseVisualStyleBackColor = false;
            this.btn_paciente.Click += new System.EventHandler(this.btn_paciente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(6)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(121, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Menú";
            // 
            // panelMuestra
            // 
            this.panelMuestra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMuestra.Location = new System.Drawing.Point(322, 0);
            this.panelMuestra.Name = "panelMuestra";
            this.panelMuestra.Size = new System.Drawing.Size(832, 883);
            this.panelMuestra.TabIndex = 7;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 883);
            this.Controls.Add(this.panelMuestra);
            this.Controls.Add(this.panel1);
            this.Name = "MenuPrincipal";
            this.Opacity = 0.95D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panel_ayuda.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_historial_clinico.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Panel panel_ayuda;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Button btn_cerrar_sesion;
        private System.Windows.Forms.Button btn_historial_clinico;
        private System.Windows.Forms.Button btn_datos_seguro;
        private System.Windows.Forms.Button btn_pruebas_medicas;
        private System.Windows.Forms.Button btn_detalle_record;
        private System.Windows.Forms.Button btn_procedimientos;
        private System.Windows.Forms.Button btn_recorr_clinico;
        private System.Windows.Forms.Button btn_medico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_historial_clinico;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_paciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelMuestra;
    }
}

