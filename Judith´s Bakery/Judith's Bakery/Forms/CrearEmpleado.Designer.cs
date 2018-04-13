namespace Judith_s_Bakery.Forms
{
    partial class CrearEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearEmpleado));
            this.lb_titulo = new System.Windows.Forms.Label();
            this.cb_cargo = new System.Windows.Forms.ComboBox();
            this.bt_ingresar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDireccion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tb_contraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tb_fecha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_numeroID = new System.Windows.Forms.Label();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.txtDUI = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNIT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSueldo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cb_activo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lb_titulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lb_titulo.Location = new System.Drawing.Point(91, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(259, 36);
            this.lb_titulo.TabIndex = 0;
            this.lb_titulo.Text = "Nuevo Empleado";
            // 
            // cb_cargo
            // 
            this.cb_cargo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_cargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cargo.FormattingEnabled = true;
            this.cb_cargo.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cb_cargo.Location = new System.Drawing.Point(16, 405);
            this.cb_cargo.Name = "cb_cargo";
            this.cb_cargo.Size = new System.Drawing.Size(183, 29);
            this.cb_cargo.TabIndex = 34;
            this.cb_cargo.Text = "Cargo";
            // 
            // bt_ingresar
            // 
            this.bt_ingresar.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ingresar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ingresar.ForeColor = System.Drawing.Color.White;
            this.bt_ingresar.Location = new System.Drawing.Point(27, 451);
            this.bt_ingresar.Name = "bt_ingresar";
            this.bt_ingresar.Size = new System.Drawing.Size(159, 44);
            this.bt_ingresar.TabIndex = 36;
            this.bt_ingresar.Text = "Crear";
            this.bt_ingresar.UseVisualStyleBackColor = false;
            this.bt_ingresar.Click += new System.EventHandler(this.bt_ingresar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(220, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 44);
            this.button1.TabIndex = 37;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.HintForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.HintText = "Nombre";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.txtNombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.OrangeRed;
            this.txtNombre.LineThickness = 3;
            this.txtNombre.Location = new System.Drawing.Point(16, 55);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(243, 33);
            this.txtNombre.TabIndex = 24;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.HintForeColor = System.Drawing.Color.DimGray;
            this.txtDireccion.HintText = "Dirección";
            this.txtDireccion.isPassword = false;
            this.txtDireccion.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.txtDireccion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDireccion.LineMouseHoverColor = System.Drawing.Color.OrangeRed;
            this.txtDireccion.LineThickness = 3;
            this.txtDireccion.Location = new System.Drawing.Point(16, 106);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(243, 33);
            this.txtDireccion.TabIndex = 25;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.HintForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.HintText = "Teléfono";
            this.txtTelefono.isPassword = false;
            this.txtTelefono.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.txtTelefono.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTelefono.LineMouseHoverColor = System.Drawing.Color.OrangeRed;
            this.txtTelefono.LineThickness = 3;
            this.txtTelefono.Location = new System.Drawing.Point(217, 161);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(172, 33);
            this.txtTelefono.TabIndex = 27;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefono.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox4_OnValueChanged);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.HintForeColor = System.Drawing.Color.DimGray;
            this.txtUser.HintText = "Usuario";
            this.txtUser.isPassword = false;
            this.txtUser.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.txtUser.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUser.LineMouseHoverColor = System.Drawing.Color.OrangeRed;
            this.txtUser.LineThickness = 3;
            this.txtUser.Location = new System.Drawing.Point(16, 310);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(183, 33);
            this.txtUser.TabIndex = 32;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tb_contraseña
            // 
            this.tb_contraseña.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_contraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_contraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_contraseña.ForeColor = System.Drawing.Color.DimGray;
            this.tb_contraseña.HintForeColor = System.Drawing.Color.DimGray;
            this.tb_contraseña.HintText = "";
            this.tb_contraseña.isPassword = false;
            this.tb_contraseña.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.tb_contraseña.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_contraseña.LineMouseHoverColor = System.Drawing.Color.OrangeRed;
            this.tb_contraseña.LineThickness = 3;
            this.tb_contraseña.Location = new System.Drawing.Point(16, 359);
            this.tb_contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.tb_contraseña.Name = "tb_contraseña";
            this.tb_contraseña.Size = new System.Drawing.Size(183, 33);
            this.tb_contraseña.TabIndex = 33;
            this.tb_contraseña.Text = "Contraseña";
            this.tb_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_contraseña.Enter += new System.EventHandler(this.tb_contraseña_Enter);
            this.tb_contraseña.Leave += new System.EventHandler(this.tb_contraseña_Leave);
            // 
            // tb_fecha
            // 
            this.tb_fecha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_fecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_fecha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_fecha.ForeColor = System.Drawing.Color.Black;
            this.tb_fecha.HintForeColor = System.Drawing.Color.DimGray;
            this.tb_fecha.HintText = "";
            this.tb_fecha.isPassword = false;
            this.tb_fecha.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.tb_fecha.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_fecha.LineMouseHoverColor = System.Drawing.Color.OrangeRed;
            this.tb_fecha.LineThickness = 3;
            this.tb_fecha.Location = new System.Drawing.Point(15, 405);
            this.tb_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.tb_fecha.Name = "tb_fecha";
            this.tb_fecha.Size = new System.Drawing.Size(183, 33);
            this.tb_fecha.TabIndex = 31;
            this.tb_fecha.Text = "Usuario";
            this.tb_fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_fecha.Visible = false;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.BackColor = System.Drawing.Color.Transparent;
            this.lb_id.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.ForeColor = System.Drawing.Color.OrangeRed;
            this.lb_id.Location = new System.Drawing.Point(10, 18);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(33, 23);
            this.lb_id.TabIndex = 32;
            this.lb_id.Text = "ID:";
            this.lb_id.Visible = false;
            // 
            // lb_numeroID
            // 
            this.lb_numeroID.AutoSize = true;
            this.lb_numeroID.BackColor = System.Drawing.Color.Transparent;
            this.lb_numeroID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numeroID.ForeColor = System.Drawing.Color.OrangeRed;
            this.lb_numeroID.Location = new System.Drawing.Point(35, 18);
            this.lb_numeroID.Name = "lb_numeroID";
            this.lb_numeroID.Size = new System.Drawing.Size(33, 23);
            this.lb_numeroID.TabIndex = 33;
            this.lb_numeroID.Text = "ID:";
            this.lb_numeroID.Visible = false;
            // 
            // bt_modificar
            // 
            this.bt_modificar.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_modificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_modificar.ForeColor = System.Drawing.Color.White;
            this.bt_modificar.Location = new System.Drawing.Point(27, 451);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(159, 44);
            this.bt_modificar.TabIndex = 34;
            this.bt_modificar.Text = "Actualizar";
            this.bt_modificar.UseVisualStyleBackColor = false;
            this.bt_modificar.Visible = false;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HintForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.HintText = "Email";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.txtEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.OrangeRed;
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(16, 161);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(183, 33);
            this.txtEmail.TabIndex = 26;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cb_sexo
            // 
            this.cb_sexo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_sexo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cb_sexo.Location = new System.Drawing.Point(217, 262);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(61, 29);
            this.cb_sexo.TabIndex = 31;
            this.cb_sexo.Text = "Sexo";
            // 
            // txtDUI
            // 
            this.txtDUI.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDUI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDUI.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDUI.ForeColor = System.Drawing.Color.Black;
            this.txtDUI.HintForeColor = System.Drawing.Color.DimGray;
            this.txtDUI.HintText = "DUI";
            this.txtDUI.isPassword = false;
            this.txtDUI.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.txtDUI.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDUI.LineMouseHoverColor = System.Drawing.Color.OrangeRed;
            this.txtDUI.LineThickness = 3;
            this.txtDUI.Location = new System.Drawing.Point(14, 213);
            this.txtDUI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(183, 33);
            this.txtDUI.TabIndex = 28;
            this.txtDUI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNIT
            // 
            this.txtNIT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNIT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNIT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNIT.ForeColor = System.Drawing.Color.Black;
            this.txtNIT.HintForeColor = System.Drawing.Color.DimGray;
            this.txtNIT.HintText = "NIT";
            this.txtNIT.isPassword = false;
            this.txtNIT.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.txtNIT.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNIT.LineMouseHoverColor = System.Drawing.Color.OrangeRed;
            this.txtNIT.LineThickness = 3;
            this.txtNIT.Location = new System.Drawing.Point(217, 213);
            this.txtNIT.Margin = new System.Windows.Forms.Padding(4);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(172, 33);
            this.txtNIT.TabIndex = 29;
            this.txtNIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSueldo
            // 
            this.txtSueldo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSueldo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSueldo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSueldo.ForeColor = System.Drawing.Color.Black;
            this.txtSueldo.HintForeColor = System.Drawing.Color.DimGray;
            this.txtSueldo.HintText = "Sueldo";
            this.txtSueldo.isPassword = false;
            this.txtSueldo.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.txtSueldo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSueldo.LineMouseHoverColor = System.Drawing.Color.OrangeRed;
            this.txtSueldo.LineThickness = 3;
            this.txtSueldo.Location = new System.Drawing.Point(16, 262);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(183, 33);
            this.txtSueldo.TabIndex = 30;
            this.txtSueldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cb_activo
            // 
            this.cb_activo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_activo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_activo.FormattingEnabled = true;
            this.cb_activo.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cb_activo.Location = new System.Drawing.Point(217, 405);
            this.cb_activo.Name = "cb_activo";
            this.cb_activo.Size = new System.Drawing.Size(79, 29);
            this.cb_activo.TabIndex = 35;
            this.cb_activo.Text = "Activo";
            // 
            // CrearEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(402, 518);
            this.Controls.Add(this.cb_activo);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtNIT);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.cb_sexo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lb_numeroID);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.tb_contraseña);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_ingresar);
            this.Controls.Add(this.cb_cargo);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.tb_fecha);
            this.Controls.Add(this.bt_modificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_fecha;
        public System.Windows.Forms.Label lb_id;
        public System.Windows.Forms.ComboBox cb_cargo;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtDireccion;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefono;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtUser;
        public Bunifu.Framework.UI.BunifuMaterialTextbox tb_contraseña;
        public System.Windows.Forms.Label lb_titulo;
        public System.Windows.Forms.Label lb_numeroID;
        public System.Windows.Forms.Button bt_ingresar;
        public System.Windows.Forms.Button bt_modificar;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        public System.Windows.Forms.ComboBox cb_sexo;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtDUI;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNIT;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtSueldo;
        public System.Windows.Forms.ComboBox cb_activo;
    }
}