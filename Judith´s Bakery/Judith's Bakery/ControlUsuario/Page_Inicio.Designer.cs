namespace Judith_s_Bakery
{
    partial class Page_Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_Inicio));
            this.lbUsuarios = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_usuarios = new Bunifu.Framework.UI.BunifuImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.AutoSize = true;
            this.lbUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuarios.Location = new System.Drawing.Point(514, 505);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(96, 21);
            this.lbUsuarios.TabIndex = 1;
            this.lbUsuarios.Text = "Empleados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inicio";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(350, 30);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(56, 24);
            this.lbHora.TabIndex = 6;
            this.lbHora.Text = "Time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // bt_usuarios
            // 
            this.bt_usuarios.BackColor = System.Drawing.Color.Transparent;
            this.bt_usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_usuarios.Image = ((System.Drawing.Image)(resources.GetObject("bt_usuarios.Image")));
            this.bt_usuarios.ImageActive = null;
            this.bt_usuarios.Location = new System.Drawing.Point(515, 414);
            this.bt_usuarios.Name = "bt_usuarios";
            this.bt_usuarios.Size = new System.Drawing.Size(95, 88);
            this.bt_usuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_usuarios.TabIndex = 0;
            this.bt_usuarios.TabStop = false;
            this.bt_usuarios.Zoom = 10;
            this.bt_usuarios.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            this.bt_usuarios.MouseEnter += new System.EventHandler(this.bunifuImageButton1_MouseEnter);
            this.bt_usuarios.MouseLeave += new System.EventHandler(this.bunifuImageButton1_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Page_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbUsuarios);
            this.Controls.Add(this.bt_usuarios);
            this.Name = "Page_Inicio";
            this.Size = new System.Drawing.Size(622, 543);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bt_usuarios;
        private System.Windows.Forms.Label lbUsuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer timer1;
    }
}
