namespace Judith_s_Bakery.ControlUsuario
{
    partial class Page_Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_Empleados));
            this.lbUsuarios = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.lbHistorial = new System.Windows.Forms.Label();
            this.btnHistorial = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_usuarios = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.AutoSize = true;
            this.lbUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuarios.Location = new System.Drawing.Point(439, 611);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(96, 21);
            this.lbUsuarios.TabIndex = 3;
            this.lbUsuarios.Text = "Empleados";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(779, 27);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(56, 24);
            this.lbHora.TabIndex = 9;
            this.lbHora.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Empleados";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.HintForeColor = System.Drawing.Color.Gray;
            this.txtId.HintText = "Id";
            this.txtId.isPassword = false;
            this.txtId.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtId.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtId.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtId.LineThickness = 3;
            this.txtId.Location = new System.Drawing.Point(425, 397);
            this.txtId.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(286, 43);
            this.txtId.TabIndex = 11;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(67)))), ((int)(((byte)(45)))));
            this.btnSalida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalida.FlatAppearance.BorderSize = 0;
            this.btnSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.ForeColor = System.Drawing.Color.White;
            this.btnSalida.Location = new System.Drawing.Point(586, 448);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(125, 44);
            this.btnSalida.TabIndex = 12;
            this.btnSalida.Text = "Salida";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrada.FlatAppearance.BorderSize = 0;
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.ForeColor = System.Drawing.Color.White;
            this.btnEntrada.Location = new System.Drawing.Point(425, 448);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(125, 44);
            this.btnEntrada.TabIndex = 13;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // lbHistorial
            // 
            this.lbHistorial.AutoSize = true;
            this.lbHistorial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistorial.Location = new System.Drawing.Point(615, 611);
            this.lbHistorial.Name = "lbHistorial";
            this.lbHistorial.Size = new System.Drawing.Size(69, 21);
            this.lbHistorial.TabIndex = 15;
            this.lbHistorial.Text = "Historial";
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.Transparent;
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorial.Image")));
            this.btnHistorial.ImageActive = null;
            this.btnHistorial.Location = new System.Drawing.Point(600, 520);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(95, 88);
            this.btnHistorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHistorial.TabIndex = 14;
            this.btnHistorial.TabStop = false;
            this.btnHistorial.Zoom = 10;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            this.btnHistorial.MouseEnter += new System.EventHandler(this.btnHistorial_MouseEnter);
            this.btnHistorial.MouseLeave += new System.EventHandler(this.btnHistorial_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Judith_s_Bakery.Properties.Resources.multiple_users_silhouette;
            this.pictureBox2.Location = new System.Drawing.Point(425, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(286, 290);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // bt_usuarios
            // 
            this.bt_usuarios.BackColor = System.Drawing.Color.Transparent;
            this.bt_usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_usuarios.Image = ((System.Drawing.Image)(resources.GetObject("bt_usuarios.Image")));
            this.bt_usuarios.ImageActive = null;
            this.bt_usuarios.Location = new System.Drawing.Point(440, 520);
            this.bt_usuarios.Name = "bt_usuarios";
            this.bt_usuarios.Size = new System.Drawing.Size(95, 88);
            this.bt_usuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_usuarios.TabIndex = 2;
            this.bt_usuarios.TabStop = false;
            this.bt_usuarios.Zoom = 10;
            this.bt_usuarios.Click += new System.EventHandler(this.bt_usuarios_Click);
            this.bt_usuarios.MouseEnter += new System.EventHandler(this.bt_usuarios_MouseEnter);
            this.bt_usuarios.MouseLeave += new System.EventHandler(this.bt_usuarios_MouseLeave);
            // 
            // Page_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbHistorial);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbUsuarios);
            this.Controls.Add(this.bt_usuarios);
            this.Name = "Page_Empleados";
            this.Size = new System.Drawing.Size(1152, 689);
            this.Load += new System.EventHandler(this.Page_Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsuarios;
        private Bunifu.Framework.UI.BunifuImageButton bt_usuarios;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtId;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Label lbHistorial;
        private Bunifu.Framework.UI.BunifuImageButton btnHistorial;
    }
}
