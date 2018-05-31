namespace Judith_s_Bakery
{
    partial class Page_Clientes
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_Clientes));
            this.label3 = new System.Windows.Forms.Label();
            this.tb_buscar = new System.Windows.Forms.TextBox();
            this.TablaCliente = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lb_ayuda = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnVista = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.bt_eliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bt_modificar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bt_clientes = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_modificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Clientes";
            // 
            // tb_buscar
            // 
            this.tb_buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_buscar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_buscar.ForeColor = System.Drawing.Color.DarkGray;
            this.tb_buscar.Location = new System.Drawing.Point(224, 87);
            this.tb_buscar.Multiline = true;
            this.tb_buscar.Name = "tb_buscar";
            this.tb_buscar.Size = new System.Drawing.Size(561, 26);
            this.tb_buscar.TabIndex = 20;
            this.tb_buscar.Text = "Buscar Cliente";
            this.tb_buscar.Enter += new System.EventHandler(this.tb_buscar_Enter_1);
            this.tb_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_buscar_KeyPress);
            this.tb_buscar.Leave += new System.EventHandler(this.tb_buscar_Leave_1);
            // 
            // TablaCliente
            // 
            this.TablaCliente.AllowUserToAddRows = false;
            this.TablaCliente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TablaCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaCliente.BackgroundColor = System.Drawing.Color.White;
            this.TablaCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TablaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.TablaCliente.DoubleBuffered = true;
            this.TablaCliente.EnableHeadersVisualStyles = false;
            this.TablaCliente.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.TablaCliente.HeaderForeColor = System.Drawing.Color.White;
            this.TablaCliente.Location = new System.Drawing.Point(217, 129);
            this.TablaCliente.Name = "TablaCliente";
            this.TablaCliente.ReadOnly = true;
            this.TablaCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TablaCliente.RowHeadersVisible = false;
            this.TablaCliente.Size = new System.Drawing.Size(701, 419);
            this.TablaCliente.TabIndex = 24;
            this.TablaCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaCliente_CellClick);
            // 
            // lb_ayuda
            // 
            this.lb_ayuda.AutoSize = true;
            this.lb_ayuda.BackColor = System.Drawing.Color.Transparent;
            this.lb_ayuda.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ayuda.Location = new System.Drawing.Point(827, 562);
            this.lb_ayuda.Name = "lb_ayuda";
            this.lb_ayuda.Size = new System.Drawing.Size(127, 60);
            this.lb_ayuda.TabIndex = 36;
            this.lb_ayuda.Text = "Aqui puedes agregar, \r\nmodificar, eliminar o \r\nver los clientes \r\nexistentes! ";
            this.lb_ayuda.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(737, 575);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Ayuda");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnVista
            // 
            this.btnVista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVista.BackgroundImage")));
            this.btnVista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVista.FlatAppearance.BorderSize = 0;
            this.btnVista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVista.Location = new System.Drawing.Point(565, 562);
            this.btnVista.Name = "btnVista";
            this.btnVista.Size = new System.Drawing.Size(40, 39);
            this.btnVista.TabIndex = 34;
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
            this.btnExcel.Location = new System.Drawing.Point(565, 611);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(40, 39);
            this.btnExcel.TabIndex = 33;
            this.toolTip1.SetToolTip(this.btnExcel, "Formato Excel");
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.BackColor = System.Drawing.Color.Transparent;
            this.bt_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("bt_eliminar.Image")));
            this.bt_eliminar.ImageActive = null;
            this.bt_eliminar.Location = new System.Drawing.Point(456, 562);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(95, 88);
            this.bt_eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_eliminar.TabIndex = 29;
            this.bt_eliminar.TabStop = false;
            this.toolTip1.SetToolTip(this.bt_eliminar, "Eliminar Cliente");
            this.bt_eliminar.Zoom = 10;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_modificar
            // 
            this.bt_modificar.BackColor = System.Drawing.Color.Transparent;
            this.bt_modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_modificar.Image = ((System.Drawing.Image)(resources.GetObject("bt_modificar.Image")));
            this.bt_modificar.ImageActive = null;
            this.bt_modificar.Location = new System.Drawing.Point(355, 562);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(95, 88);
            this.bt_modificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_modificar.TabIndex = 28;
            this.bt_modificar.TabStop = false;
            this.toolTip1.SetToolTip(this.bt_modificar, "Modificar Cliente");
            this.bt_modificar.Zoom = 10;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // bt_clientes
            // 
            this.bt_clientes.BackColor = System.Drawing.Color.Transparent;
            this.bt_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_clientes.Image = ((System.Drawing.Image)(resources.GetObject("bt_clientes.Image")));
            this.bt_clientes.ImageActive = null;
            this.bt_clientes.Location = new System.Drawing.Point(254, 562);
            this.bt_clientes.Name = "bt_clientes";
            this.bt_clientes.Size = new System.Drawing.Size(95, 88);
            this.bt_clientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_clientes.TabIndex = 27;
            this.bt_clientes.TabStop = false;
            this.toolTip1.SetToolTip(this.bt_clientes, "Nuevo Cliente");
            this.bt_clientes.Zoom = 10;
            this.bt_clientes.Click += new System.EventHandler(this.bt_clientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(797, 78);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(46, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.toolTip1.SetToolTip(this.bunifuImageButton1, "Buscar");
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(779, 27);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(56, 24);
            this.lbHora.TabIndex = 37;
            this.lbHora.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(610, 626);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 19);
            this.label7.TabIndex = 60;
            this.label7.Text = "Exportar a Excel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(617, 575);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 59;
            this.label2.Text = "Mostrar Todo";
            // 
            // Page_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.lb_ayuda);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnVista);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_modificar);
            this.Controls.Add(this.bt_clientes);
            this.Controls.Add(this.TablaCliente);
            this.Controls.Add(this.tb_buscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuImageButton1);
            this.Name = "Page_Clientes";
            this.Size = new System.Drawing.Size(1152, 689);
            this.Load += new System.EventHandler(this.Page_Clientes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.TablaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_modificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tb_buscar;
        public Bunifu.Framework.UI.BunifuCustomDataGrid TablaCliente;
        private Bunifu.Framework.UI.BunifuImageButton bt_eliminar;
        private Bunifu.Framework.UI.BunifuImageButton bt_modificar;
        private Bunifu.Framework.UI.BunifuImageButton bt_clientes;
        private System.Windows.Forms.Button btnVista;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_ayuda;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
    }
}
