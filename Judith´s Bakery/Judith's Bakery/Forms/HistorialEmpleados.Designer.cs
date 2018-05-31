namespace Judith_s_Bakery.Forms
{
    partial class HistorialEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialEmpleados));
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.tablaHistorial = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbEmpleado = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bt_regresar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnVista = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaHistorial)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpleado.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleado.ForeColor = System.Drawing.Color.DarkGray;
            this.txtEmpleado.Location = new System.Drawing.Point(13, 65);
            this.txtEmpleado.Multiline = true;
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(361, 26);
            this.txtEmpleado.TabIndex = 50;
            this.txtEmpleado.Text = "Buscar Empleado";
            this.txtEmpleado.Enter += new System.EventHandler(this.txtEmpleado_Enter);
            this.txtEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpleado_KeyPress);
            this.txtEmpleado.Leave += new System.EventHandler(this.txtEmpleado_Leave);
            // 
            // tablaHistorial
            // 
            this.tablaHistorial.AllowUserToAddRows = false;
            this.tablaHistorial.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tablaHistorial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaHistorial.BackgroundColor = System.Drawing.Color.White;
            this.tablaHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaHistorial.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaHistorial.DoubleBuffered = true;
            this.tablaHistorial.EnableHeadersVisualStyles = false;
            this.tablaHistorial.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.tablaHistorial.HeaderForeColor = System.Drawing.Color.White;
            this.tablaHistorial.Location = new System.Drawing.Point(13, 133);
            this.tablaHistorial.Name = "tablaHistorial";
            this.tablaHistorial.ReadOnly = true;
            this.tablaHistorial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaHistorial.RowHeadersVisible = false;
            this.tablaHistorial.Size = new System.Drawing.Size(916, 405);
            this.tablaHistorial.TabIndex = 54;
            this.tablaHistorial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaHistorial_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.bunifuImageButton3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 48);
            this.panel1.TabIndex = 60;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(873, 20);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(23, 28);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton3.TabIndex = 22;
            this.bunifuImageButton3.TabStop = false;
            this.toolTip1.SetToolTip(this.bunifuImageButton3, "Minimizar");
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(904, 12);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(25, 28);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 21;
            this.bunifuImageButton2.TabStop = false;
            this.toolTip1.SetToolTip(this.bunifuImageButton2, "Cerrar");
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Historial de empleados";
            // 
            // rbEmpleado
            // 
            this.rbEmpleado.AutoSize = true;
            this.rbEmpleado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmpleado.Location = new System.Drawing.Point(13, 104);
            this.rbEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.rbEmpleado.Name = "rbEmpleado";
            this.rbEmpleado.Size = new System.Drawing.Size(82, 24);
            this.rbEmpleado.TabIndex = 63;
            this.rbEmpleado.TabStop = true;
            this.rbEmpleado.Text = "Activos";
            this.rbEmpleado.UseVisualStyleBackColor = true;
            this.rbEmpleado.CheckedChanged += new System.EventHandler(this.rbEmpleado_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(111, 104);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 24);
            this.radioButton1.TabIndex = 64;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Inactivos";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(440, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 32);
            this.button1.TabIndex = 65;
            this.button1.Text = "Activar Empleado";
            this.toolTip1.SetToolTip(this.button1, "Activar Empleado");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // bt_regresar
            // 
            this.bt_regresar.BackColor = System.Drawing.Color.Transparent;
            this.bt_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_regresar.Image = ((System.Drawing.Image)(resources.GetObject("bt_regresar.Image")));
            this.bt_regresar.ImageActive = null;
            this.bt_regresar.Location = new System.Drawing.Point(832, 56);
            this.bt_regresar.Name = "bt_regresar";
            this.bt_regresar.Size = new System.Drawing.Size(49, 46);
            this.bt_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_regresar.TabIndex = 59;
            this.bt_regresar.TabStop = false;
            this.toolTip1.SetToolTip(this.bt_regresar, "Regresar");
            this.bt_regresar.Zoom = 10;
            this.bt_regresar.Click += new System.EventHandler(this.bt_regresar_Click);
            // 
            // btnVista
            // 
            this.btnVista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVista.BackgroundImage")));
            this.btnVista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVista.FlatAppearance.BorderSize = 0;
            this.btnVista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVista.Location = new System.Drawing.Point(603, 54);
            this.btnVista.Name = "btnVista";
            this.btnVista.Size = new System.Drawing.Size(49, 47);
            this.btnVista.TabIndex = 57;
            this.toolTip1.SetToolTip(this.btnVista, "Ver Todo");
            this.btnVista.UseVisualStyleBackColor = true;
            this.btnVista.Click += new System.EventHandler(this.btnVista_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Location = new System.Drawing.Point(728, 54);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(43, 46);
            this.btnExcel.TabIndex = 55;
            this.toolTip1.SetToolTip(this.btnExcel, "Formato Excel");
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageActive = null;
            this.btnBuscar.Location = new System.Drawing.Point(387, 56);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(46, 45);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 52;
            this.btnBuscar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.Zoom = 10;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(594, 104);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 19);
            this.label9.TabIndex = 67;
            this.label9.Text = "Ver Todo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(691, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 19);
            this.label7.TabIndex = 66;
            this.label7.Text = "Exportar a Excel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(826, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 68;
            this.label2.Text = "Regresar";
            // 
            // HistorialEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rbEmpleado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.bt_regresar);
            this.Controls.Add(this.btnVista);
            this.Controls.Add(this.tablaHistorial);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "HistorialEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistorialEmpleados";
            this.Load += new System.EventHandler(this.HistorialEmpleados_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HistorialEmpleados_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.tablaHistorial)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtEmpleado;
        private Bunifu.Framework.UI.BunifuImageButton bt_regresar;
        private System.Windows.Forms.Button btnVista;
        public Bunifu.Framework.UI.BunifuCustomDataGrid tablaHistorial;
        private System.Windows.Forms.Button btnExcel;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbEmpleado;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
    }
}