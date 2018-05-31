namespace Judith_s_Bakery
{
    partial class Page_Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_Proveedor));
            this.label3 = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tb_buscar = new System.Windows.Forms.TextBox();
            this.TablaProveedor = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnExcel = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bt_eliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bt_modificar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bt_usuarios = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnVista = new System.Windows.Forms.Button();
            this.lb_ayuda = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_modificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Proveedores";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(779, 27);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(56, 24);
            this.lbHora.TabIndex = 16;
            this.lbHora.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tb_buscar
            // 
            this.tb_buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_buscar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_buscar.ForeColor = System.Drawing.Color.DarkGray;
            this.tb_buscar.Location = new System.Drawing.Point(192, 90);
            this.tb_buscar.Multiline = true;
            this.tb_buscar.Name = "tb_buscar";
            this.tb_buscar.Size = new System.Drawing.Size(582, 31);
            this.tb_buscar.TabIndex = 21;
            this.tb_buscar.Text = "Buscar Proveedor";
            this.tb_buscar.Enter += new System.EventHandler(this.tb_buscar_Enter);
            this.tb_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_buscar_KeyPress);
            this.tb_buscar.Leave += new System.EventHandler(this.tb_buscar_Leave);
            // 
            // TablaProveedor
            // 
            this.TablaProveedor.AllowUserToAddRows = false;
            this.TablaProveedor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TablaProveedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaProveedor.BackgroundColor = System.Drawing.Color.White;
            this.TablaProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaProveedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TablaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaProveedor.DefaultCellStyle = dataGridViewCellStyle3;
            this.TablaProveedor.DoubleBuffered = true;
            this.TablaProveedor.EnableHeadersVisualStyles = false;
            this.TablaProveedor.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.TablaProveedor.HeaderForeColor = System.Drawing.Color.White;
            this.TablaProveedor.Location = new System.Drawing.Point(176, 140);
            this.TablaProveedor.Name = "TablaProveedor";
            this.TablaProveedor.ReadOnly = true;
            this.TablaProveedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TablaProveedor.RowHeadersVisible = false;
            this.TablaProveedor.Size = new System.Drawing.Size(783, 380);
            this.TablaProveedor.TabIndex = 23;
            this.TablaProveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaProveedor_CellClick);
            this.TablaProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaProveedor_CellContentClick);
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Location = new System.Drawing.Point(572, 595);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(40, 39);
            this.btnExcel.TabIndex = 30;
            this.toolTip1.SetToolTip(this.btnExcel, "Formato Excel");
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(753, 558);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Ayuda");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.BackColor = System.Drawing.Color.Transparent;
            this.bt_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("bt_eliminar.Image")));
            this.bt_eliminar.ImageActive = null;
            this.bt_eliminar.Location = new System.Drawing.Point(449, 546);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(95, 88);
            this.bt_eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_eliminar.TabIndex = 26;
            this.bt_eliminar.TabStop = false;
            this.toolTip1.SetToolTip(this.bt_eliminar, "Eliminar");
            this.bt_eliminar.Zoom = 10;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_modificar
            // 
            this.bt_modificar.BackColor = System.Drawing.Color.Transparent;
            this.bt_modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_modificar.Image = ((System.Drawing.Image)(resources.GetObject("bt_modificar.Image")));
            this.bt_modificar.ImageActive = null;
            this.bt_modificar.Location = new System.Drawing.Point(348, 546);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(95, 88);
            this.bt_modificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_modificar.TabIndex = 25;
            this.bt_modificar.TabStop = false;
            this.toolTip1.SetToolTip(this.bt_modificar, "Modificar");
            this.bt_modificar.Zoom = 10;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // bt_usuarios
            // 
            this.bt_usuarios.BackColor = System.Drawing.Color.Transparent;
            this.bt_usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_usuarios.Image = ((System.Drawing.Image)(resources.GetObject("bt_usuarios.Image")));
            this.bt_usuarios.ImageActive = null;
            this.bt_usuarios.Location = new System.Drawing.Point(247, 546);
            this.bt_usuarios.Name = "bt_usuarios";
            this.bt_usuarios.Size = new System.Drawing.Size(95, 88);
            this.bt_usuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_usuarios.TabIndex = 24;
            this.bt_usuarios.TabStop = false;
            this.toolTip1.SetToolTip(this.bt_usuarios, "Nuevo");
            this.bt_usuarios.Zoom = 10;
            this.bt_usuarios.Click += new System.EventHandler(this.bt_usuarios_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(789, 85);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(46, 39);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 22;
            this.bunifuImageButton1.TabStop = false;
            this.toolTip1.SetToolTip(this.bunifuImageButton1, "Buscar Proveedor");
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btnVista
            // 
            this.btnVista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVista.BackgroundImage")));
            this.btnVista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVista.FlatAppearance.BorderSize = 0;
            this.btnVista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVista.Location = new System.Drawing.Point(572, 546);
            this.btnVista.Name = "btnVista";
            this.btnVista.Size = new System.Drawing.Size(40, 39);
            this.btnVista.TabIndex = 32;
            this.toolTip1.SetToolTip(this.btnVista, "Mostrar Proveedores");
            this.btnVista.UseVisualStyleBackColor = true;
            this.btnVista.Click += new System.EventHandler(this.btnVista_Click);
            // 
            // lb_ayuda
            // 
            this.lb_ayuda.AutoSize = true;
            this.lb_ayuda.BackColor = System.Drawing.Color.Transparent;
            this.lb_ayuda.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ayuda.Location = new System.Drawing.Point(853, 546);
            this.lb_ayuda.Name = "lb_ayuda";
            this.lb_ayuda.Size = new System.Drawing.Size(127, 60);
            this.lb_ayuda.TabIndex = 31;
            this.lb_ayuda.Text = "Aqui puedes agregar, \r\nmodificar, eliminar o \r\nver los proveedores\r\nexistentes! ";
            this.lb_ayuda.Visible = false;
            this.lb_ayuda.Click += new System.EventHandler(this.lb_ayuda_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(617, 605);
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
            this.label2.Location = new System.Drawing.Point(617, 558);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 59;
            this.label2.Text = "Mostrar Todo";
            // 
            // Page_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVista);
            this.Controls.Add(this.lb_ayuda);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_modificar);
            this.Controls.Add(this.bt_usuarios);
            this.Controls.Add(this.TablaProveedor);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.tb_buscar);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Name = "Page_Proveedor";
            this.Size = new System.Drawing.Size(1152, 689);
            this.Load += new System.EventHandler(this.Page_Clientes_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Page_Proveedor_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.TablaProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_modificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public System.Windows.Forms.TextBox tb_buscar;
        public Bunifu.Framework.UI.BunifuCustomDataGrid TablaProveedor;
        private Bunifu.Framework.UI.BunifuImageButton bt_eliminar;
        private Bunifu.Framework.UI.BunifuImageButton bt_modificar;
        private Bunifu.Framework.UI.BunifuImageButton bt_usuarios;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lb_ayuda;
        private System.Windows.Forms.Button btnVista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
    }
}
