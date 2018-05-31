namespace Judith_s_Bakery.Forms
{
    partial class CrearModificarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearModificarProveedor));
            this.txtServicio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNIT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFax = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lb_id = new System.Windows.Forms.Label();
            this.txtTelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDireccion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_crear = new System.Windows.Forms.Button();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.txtNumRegistro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lb_numeroID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtServicio
            // 
            this.txtServicio.BackColor = System.Drawing.Color.White;
            this.txtServicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServicio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtServicio.ForeColor = System.Drawing.Color.Black;
            this.txtServicio.HintForeColor = System.Drawing.Color.DimGray;
            this.txtServicio.HintText = "Servicio";
            this.txtServicio.isPassword = false;
            this.txtServicio.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtServicio.LineIdleColor = System.Drawing.Color.Gray;
            this.txtServicio.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtServicio.LineThickness = 3;
            this.txtServicio.Location = new System.Drawing.Point(15, 260);
            this.txtServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(183, 33);
            this.txtServicio.TabIndex = 44;
            this.txtServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNIT
            // 
            this.txtNIT.BackColor = System.Drawing.Color.White;
            this.txtNIT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNIT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNIT.ForeColor = System.Drawing.Color.Black;
            this.txtNIT.HintForeColor = System.Drawing.Color.DimGray;
            this.txtNIT.HintText = "NIT";
            this.txtNIT.isPassword = false;
            this.txtNIT.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtNIT.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNIT.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtNIT.LineThickness = 3;
            this.txtNIT.Location = new System.Drawing.Point(15, 209);
            this.txtNIT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(183, 33);
            this.txtNIT.TabIndex = 43;
            this.txtNIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNIT.Leave += new System.EventHandler(this.txtNIT_Leave);
            // 
            // txtFax
            // 
            this.txtFax.BackColor = System.Drawing.Color.White;
            this.txtFax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFax.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFax.ForeColor = System.Drawing.Color.Black;
            this.txtFax.HintForeColor = System.Drawing.Color.DimGray;
            this.txtFax.HintText = "FAX";
            this.txtFax.isPassword = false;
            this.txtFax.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtFax.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFax.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtFax.LineThickness = 3;
            this.txtFax.Location = new System.Drawing.Point(213, 157);
            this.txtFax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(183, 33);
            this.txtFax.TabIndex = 42;
            this.txtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFax_KeyPress);
            this.txtFax.Leave += new System.EventHandler(this.txtFax_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HintForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.HintText = "Email";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(15, 361);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(183, 33);
            this.txtEmail.TabIndex = 46;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.BackColor = System.Drawing.Color.Transparent;
            this.lb_id.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(28)))));
            this.lb_id.Location = new System.Drawing.Point(9, 18);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(33, 23);
            this.lb_id.TabIndex = 49;
            this.lb_id.Text = "ID:";
            this.lb_id.Visible = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.HintForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.HintText = "Teléfono";
            this.txtTelefono.isPassword = false;
            this.txtTelefono.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtTelefono.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTelefono.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtTelefono.LineThickness = 3;
            this.txtTelefono.Location = new System.Drawing.Point(15, 157);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(183, 33);
            this.txtTelefono.TabIndex = 41;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.HintForeColor = System.Drawing.Color.DimGray;
            this.txtDireccion.HintText = "Dirección";
            this.txtDireccion.isPassword = false;
            this.txtDireccion.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtDireccion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDireccion.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtDireccion.LineThickness = 3;
            this.txtDireccion.Location = new System.Drawing.Point(15, 106);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(243, 33);
            this.txtDireccion.TabIndex = 40;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.HintForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.HintText = "Nombre";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtNombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtNombre.LineThickness = 3;
            this.txtNombre.Location = new System.Drawing.Point(15, 55);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(243, 33);
            this.txtNombre.TabIndex = 39;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.Firebrick;
            this.bt_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.ForeColor = System.Drawing.Color.White;
            this.bt_cancelar.Location = new System.Drawing.Point(220, 418);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(159, 44);
            this.bt_cancelar.TabIndex = 48;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_crear
            // 
            this.bt_crear.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_crear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_crear.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_crear.ForeColor = System.Drawing.Color.White;
            this.bt_crear.Location = new System.Drawing.Point(27, 417);
            this.bt_crear.Name = "bt_crear";
            this.bt_crear.Size = new System.Drawing.Size(159, 44);
            this.bt_crear.TabIndex = 47;
            this.bt_crear.Text = "Crear";
            this.bt_crear.UseVisualStyleBackColor = false;
            this.bt_crear.Click += new System.EventHandler(this.bt_crear_Click);
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lb_titulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(28)))));
            this.lb_titulo.Location = new System.Drawing.Point(73, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(260, 36);
            this.lb_titulo.TabIndex = 38;
            this.lb_titulo.Text = "Nuevo Proveedor";
            // 
            // bt_modificar
            // 
            this.bt_modificar.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_modificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_modificar.ForeColor = System.Drawing.Color.White;
            this.bt_modificar.Location = new System.Drawing.Point(27, 418);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(159, 44);
            this.bt_modificar.TabIndex = 53;
            this.bt_modificar.Text = "Actualizar";
            this.bt_modificar.UseVisualStyleBackColor = false;
            this.bt_modificar.Visible = false;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // txtNumRegistro
            // 
            this.txtNumRegistro.BackColor = System.Drawing.Color.White;
            this.txtNumRegistro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumRegistro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNumRegistro.ForeColor = System.Drawing.Color.Black;
            this.txtNumRegistro.HintForeColor = System.Drawing.Color.DimGray;
            this.txtNumRegistro.HintText = "Número de registro";
            this.txtNumRegistro.isPassword = false;
            this.txtNumRegistro.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtNumRegistro.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNumRegistro.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtNumRegistro.LineThickness = 3;
            this.txtNumRegistro.Location = new System.Drawing.Point(15, 311);
            this.txtNumRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumRegistro.Name = "txtNumRegistro";
            this.txtNumRegistro.Size = new System.Drawing.Size(183, 33);
            this.txtNumRegistro.TabIndex = 45;
            this.txtNumRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumRegistro_KeyPress);
            // 
            // lb_numeroID
            // 
            this.lb_numeroID.AutoSize = true;
            this.lb_numeroID.BackColor = System.Drawing.Color.Transparent;
            this.lb_numeroID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numeroID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(28)))));
            this.lb_numeroID.Location = new System.Drawing.Point(39, 19);
            this.lb_numeroID.Name = "lb_numeroID";
            this.lb_numeroID.Size = new System.Drawing.Size(33, 23);
            this.lb_numeroID.TabIndex = 54;
            this.lb_numeroID.Text = "ID:";
            this.lb_numeroID.Visible = false;
            // 
            // CrearModificarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(408, 481);
            this.Controls.Add(this.lb_numeroID);
            this.Controls.Add(this.txtNumRegistro);
            this.Controls.Add(this.txtServicio);
            this.Controls.Add(this.txtNIT);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_crear);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.bt_modificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CrearModificarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearModificarProveedor";
            this.Load += new System.EventHandler(this.CrearModificarProveedor_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CrearModificarProveedor_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuMaterialTextbox txtServicio;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNIT;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtFax;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        public System.Windows.Forms.Label lb_id;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefono;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtDireccion;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private System.Windows.Forms.Button bt_cancelar;
        public System.Windows.Forms.Button bt_crear;
        public System.Windows.Forms.Label lb_titulo;
        public System.Windows.Forms.Button bt_modificar;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNumRegistro;
        public System.Windows.Forms.Label lb_numeroID;
    }
}