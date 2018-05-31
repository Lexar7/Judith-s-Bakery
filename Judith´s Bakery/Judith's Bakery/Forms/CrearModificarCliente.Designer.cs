namespace Judith_s_Bakery.Forms
{
    partial class CrearModificarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearModificarCliente));
            this.txtDUI = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lb_numeroID = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.txtTelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDireccion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_crear = new System.Windows.Forms.Button();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtDUI
            // 
            this.txtDUI.BackColor = System.Drawing.Color.White;
            this.txtDUI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDUI.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDUI.ForeColor = System.Drawing.Color.Black;
            this.txtDUI.HintForeColor = System.Drawing.Color.DimGray;
            this.txtDUI.HintText = "DUI";
            this.txtDUI.isPassword = false;
            this.txtDUI.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtDUI.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDUI.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtDUI.LineThickness = 3;
            this.txtDUI.Location = new System.Drawing.Point(19, 220);
            this.txtDUI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(183, 33);
            this.txtDUI.TabIndex = 59;
            this.txtDUI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDUI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDUI_KeyPress);
            this.txtDUI.Leave += new System.EventHandler(this.txtDUI_Leave);
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
            this.txtEmail.Location = new System.Drawing.Point(19, 321);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(183, 33);
            this.txtEmail.TabIndex = 62;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lb_numeroID
            // 
            this.lb_numeroID.AutoSize = true;
            this.lb_numeroID.BackColor = System.Drawing.Color.Transparent;
            this.lb_numeroID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numeroID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(28)))));
            this.lb_numeroID.Location = new System.Drawing.Point(40, 19);
            this.lb_numeroID.Name = "lb_numeroID";
            this.lb_numeroID.Size = new System.Drawing.Size(33, 23);
            this.lb_numeroID.TabIndex = 66;
            this.lb_numeroID.Text = "ID:";
            this.lb_numeroID.Visible = false;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.BackColor = System.Drawing.Color.Transparent;
            this.lb_id.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(28)))));
            this.lb_id.Location = new System.Drawing.Point(6, 19);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(33, 23);
            this.lb_id.TabIndex = 65;
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
            this.txtTelefono.Location = new System.Drawing.Point(19, 167);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(183, 33);
            this.txtTelefono.TabIndex = 57;
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
            this.txtDireccion.Location = new System.Drawing.Point(19, 113);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(243, 33);
            this.txtDireccion.TabIndex = 56;
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
            this.txtNombre.Location = new System.Drawing.Point(19, 58);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(243, 33);
            this.txtNombre.TabIndex = 55;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress_1);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.Firebrick;
            this.bt_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.ForeColor = System.Drawing.Color.White;
            this.bt_cancelar.Location = new System.Drawing.Point(214, 382);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(159, 44);
            this.bt_cancelar.TabIndex = 64;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_crear
            // 
            this.bt_crear.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_crear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_crear.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_crear.ForeColor = System.Drawing.Color.White;
            this.bt_crear.Location = new System.Drawing.Point(21, 381);
            this.bt_crear.Name = "bt_crear";
            this.bt_crear.Size = new System.Drawing.Size(159, 44);
            this.bt_crear.TabIndex = 63;
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
            this.lb_titulo.Location = new System.Drawing.Point(78, 11);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(216, 36);
            this.lb_titulo.TabIndex = 54;
            this.lb_titulo.Text = "Nuevo Cliente";
            // 
            // bt_modificar
            // 
            this.bt_modificar.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_modificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_modificar.ForeColor = System.Drawing.Color.White;
            this.bt_modificar.Location = new System.Drawing.Point(21, 382);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(159, 44);
            this.bt_modificar.TabIndex = 67;
            this.bt_modificar.Text = "Actualizar";
            this.bt_modificar.UseVisualStyleBackColor = false;
            this.bt_modificar.Visible = false;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // cb_sexo
            // 
            this.cb_sexo.BackColor = System.Drawing.Color.White;
            this.cb_sexo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cb_sexo.Location = new System.Drawing.Point(19, 275);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(61, 29);
            this.cb_sexo.TabIndex = 68;
            this.cb_sexo.Text = "Sexo";
            // 
            // CrearModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 446);
            this.Controls.Add(this.cb_sexo);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lb_numeroID);
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
            this.Name = "CrearModificarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearModificarCliente";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CrearModificarCliente_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuMaterialTextbox txtDUI;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        public System.Windows.Forms.Label lb_numeroID;
        public System.Windows.Forms.Label lb_id;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefono;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtDireccion;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private System.Windows.Forms.Button bt_cancelar;
        public System.Windows.Forms.Button bt_crear;
        public System.Windows.Forms.Label lb_titulo;
        public System.Windows.Forms.Button bt_modificar;
        public System.Windows.Forms.ComboBox cb_sexo;
    }
}