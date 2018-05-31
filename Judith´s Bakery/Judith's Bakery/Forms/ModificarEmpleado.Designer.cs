namespace Judith_s_Bakery.Forms
{
    partial class ModificarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarEmpleado));
            this.btnImagen = new System.Windows.Forms.Button();
            this.cb_activo = new System.Windows.Forms.ComboBox();
            this.txtSueldo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNIT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDUI = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lb_numeroID = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.tb_contraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDireccion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_cargo = new System.Windows.Forms.ComboBox();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblCorrecto = new System.Windows.Forms.Label();
            this.lblFormato = new System.Windows.Forms.Label();
            this.lbCorrecto2 = new System.Windows.Forms.Label();
            this.lbFormato2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImagen
            // 
            this.btnImagen.BackColor = System.Drawing.SystemColors.Control;
            this.btnImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagen.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagen.ForeColor = System.Drawing.Color.Black;
            this.btnImagen.Location = new System.Drawing.Point(516, 201);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(163, 44);
            this.btnImagen.TabIndex = 59;
            this.btnImagen.Text = "Cargar Imagen";
            this.btnImagen.UseVisualStyleBackColor = false;
            this.btnImagen.Visible = false;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // cb_activo
            // 
            this.cb_activo.BackColor = System.Drawing.Color.White;
            this.cb_activo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_activo.FormattingEnabled = true;
            this.cb_activo.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cb_activo.Location = new System.Drawing.Point(516, 384);
            this.cb_activo.Name = "cb_activo";
            this.cb_activo.Size = new System.Drawing.Size(97, 29);
            this.cb_activo.TabIndex = 55;
            this.cb_activo.Text = "Estado";
            // 
            // txtSueldo
            // 
            this.txtSueldo.BackColor = System.Drawing.Color.White;
            this.txtSueldo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSueldo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSueldo.ForeColor = System.Drawing.Color.Black;
            this.txtSueldo.HintForeColor = System.Drawing.Color.DimGray;
            this.txtSueldo.HintText = "Sueldo";
            this.txtSueldo.isPassword = false;
            this.txtSueldo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtSueldo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSueldo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtSueldo.LineThickness = 3;
            this.txtSueldo.Location = new System.Drawing.Point(265, 219);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(218, 33);
            this.txtSueldo.TabIndex = 47;
            this.txtSueldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldo_KeyPress);
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
            this.txtNIT.Location = new System.Drawing.Point(21, 219);
            this.txtNIT.Margin = new System.Windows.Forms.Padding(4);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(213, 33);
            this.txtNIT.TabIndex = 46;
            this.txtNIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNIT.Enter += new System.EventHandler(this.txtNIT_Enter);
            this.txtNIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIT_KeyPress);
            this.txtNIT.Leave += new System.EventHandler(this.txtNIT_Leave);
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
            this.txtDUI.Location = new System.Drawing.Point(265, 134);
            this.txtDUI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(218, 33);
            this.txtDUI.TabIndex = 45;
            this.txtDUI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDUI.Enter += new System.EventHandler(this.txtDUI_Enter);
            this.txtDUI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDUI_KeyPress);
            this.txtDUI.Leave += new System.EventHandler(this.txtDUI_Leave);
            // 
            // cb_sexo
            // 
            this.cb_sexo.BackColor = System.Drawing.Color.White;
            this.cb_sexo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cb_sexo.Location = new System.Drawing.Point(516, 310);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(61, 29);
            this.cb_sexo.TabIndex = 48;
            this.cb_sexo.Text = "Sexo";
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
            this.txtEmail.Location = new System.Drawing.Point(19, 306);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(215, 33);
            this.txtEmail.TabIndex = 43;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lb_numeroID
            // 
            this.lb_numeroID.AutoSize = true;
            this.lb_numeroID.BackColor = System.Drawing.Color.Transparent;
            this.lb_numeroID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numeroID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(28)))));
            this.lb_numeroID.Location = new System.Drawing.Point(40, 21);
            this.lb_numeroID.Name = "lb_numeroID";
            this.lb_numeroID.Size = new System.Drawing.Size(33, 23);
            this.lb_numeroID.TabIndex = 51;
            this.lb_numeroID.Text = "ID:";
            this.lb_numeroID.Visible = false;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.BackColor = System.Drawing.Color.Transparent;
            this.lb_id.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(28)))));
            this.lb_id.Location = new System.Drawing.Point(15, 21);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(33, 23);
            this.lb_id.TabIndex = 49;
            this.lb_id.Text = "ID:";
            this.lb_id.Visible = false;
            // 
            // tb_contraseña
            // 
            this.tb_contraseña.BackColor = System.Drawing.Color.White;
            this.tb_contraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_contraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_contraseña.ForeColor = System.Drawing.Color.DimGray;
            this.tb_contraseña.HintForeColor = System.Drawing.Color.DimGray;
            this.tb_contraseña.HintText = "";
            this.tb_contraseña.isPassword = false;
            this.tb_contraseña.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.tb_contraseña.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_contraseña.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.tb_contraseña.LineThickness = 3;
            this.tb_contraseña.Location = new System.Drawing.Point(265, 380);
            this.tb_contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.tb_contraseña.Name = "tb_contraseña";
            this.tb_contraseña.Size = new System.Drawing.Size(218, 33);
            this.tb_contraseña.TabIndex = 52;
            this.tb_contraseña.Text = "Contraseña";
            this.tb_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_contraseña.Enter += new System.EventHandler(this.tb_contraseña_Enter);
            this.tb_contraseña.Leave += new System.EventHandler(this.tb_contraseña_Leave);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.HintForeColor = System.Drawing.Color.DimGray;
            this.txtUser.HintText = "Usuario";
            this.txtUser.isPassword = false;
            this.txtUser.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtUser.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUser.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtUser.LineThickness = 3;
            this.txtUser.Location = new System.Drawing.Point(19, 380);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(215, 33);
            this.txtUser.TabIndex = 50;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtTelefono.Location = new System.Drawing.Point(21, 134);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(213, 33);
            this.txtTelefono.TabIndex = 44;
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
            this.txtDireccion.Location = new System.Drawing.Point(265, 58);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(218, 33);
            this.txtDireccion.TabIndex = 42;
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
            this.txtNombre.Location = new System.Drawing.Point(21, 58);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 33);
            this.txtNombre.TabIndex = 41;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(369, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 44);
            this.button1.TabIndex = 57;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_cargo
            // 
            this.cb_cargo.BackColor = System.Drawing.Color.White;
            this.cb_cargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cargo.FormattingEnabled = true;
            this.cb_cargo.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cb_cargo.Location = new System.Drawing.Point(265, 310);
            this.cb_cargo.Name = "cb_cargo";
            this.cb_cargo.Size = new System.Drawing.Size(218, 29);
            this.cb_cargo.TabIndex = 53;
            this.cb_cargo.Text = "Cargo";
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lb_titulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(28)))));
            this.lb_titulo.Location = new System.Drawing.Point(203, 8);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(300, 36);
            this.lb_titulo.TabIndex = 40;
            this.lb_titulo.Text = "Modificar Empleado";
            // 
            // bt_modificar
            // 
            this.bt_modificar.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_modificar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_modificar.ForeColor = System.Drawing.Color.White;
            this.bt_modificar.Location = new System.Drawing.Point(155, 460);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(159, 44);
            this.bt_modificar.TabIndex = 54;
            this.bt_modificar.Text = "Actualizar";
            this.bt_modificar.UseVisualStyleBackColor = false;
            this.bt_modificar.Visible = false;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(516, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblCorrecto
            // 
            this.lblCorrecto.AutoSize = true;
            this.lblCorrecto.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lblCorrecto.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCorrecto.Location = new System.Drawing.Point(266, 191);
            this.lblCorrecto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorrecto.Name = "lblCorrecto";
            this.lblCorrecto.Size = new System.Drawing.Size(138, 19);
            this.lblCorrecto.TabIndex = 82;
            this.lblCorrecto.Text = "Formato a mostrar:";
            this.lblCorrecto.Visible = false;
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lblFormato.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblFormato.Location = new System.Drawing.Point(266, 171);
            this.lblFormato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(237, 19);
            this.lblFormato.TabIndex = 81;
            this.lblFormato.Text = "Formato correcto a ingresar para";
            this.lblFormato.Visible = false;
            // 
            // lbCorrecto2
            // 
            this.lbCorrecto2.AutoSize = true;
            this.lbCorrecto2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lbCorrecto2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbCorrecto2.Location = new System.Drawing.Point(17, 276);
            this.lbCorrecto2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCorrecto2.Name = "lbCorrecto2";
            this.lbCorrecto2.Size = new System.Drawing.Size(138, 19);
            this.lbCorrecto2.TabIndex = 84;
            this.lbCorrecto2.Text = "Formato a mostrar:";
            this.lbCorrecto2.Visible = false;
            // 
            // lbFormato2
            // 
            this.lbFormato2.AutoSize = true;
            this.lbFormato2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lbFormato2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbFormato2.Location = new System.Drawing.Point(17, 256);
            this.lbFormato2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFormato2.Name = "lbFormato2";
            this.lbFormato2.Size = new System.Drawing.Size(237, 19);
            this.lbFormato2.TabIndex = 83;
            this.lbFormato2.Text = "Formato correcto a ingresar para";
            this.lbFormato2.Visible = false;
            // 
            // ModificarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(696, 516);
            this.Controls.Add(this.lbCorrecto2);
            this.Controls.Add(this.lbFormato2);
            this.Controls.Add(this.lblCorrecto);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.pictureBox1);
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
            this.Controls.Add(this.cb_cargo);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.bt_modificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ModificarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarEmpleado";
            this.Load += new System.EventHandler(this.ModificarEmpleado_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ModificarEmpleado_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnImagen;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox cb_activo;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtSueldo;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNIT;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtDUI;
        public System.Windows.Forms.ComboBox cb_sexo;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        public System.Windows.Forms.Label lb_numeroID;
        public System.Windows.Forms.Label lb_id;
        public Bunifu.Framework.UI.BunifuMaterialTextbox tb_contraseña;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtUser;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefono;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtDireccion;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox cb_cargo;
        public System.Windows.Forms.Label lb_titulo;
        public System.Windows.Forms.Button bt_modificar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblCorrecto;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.Label lbCorrecto2;
        private System.Windows.Forms.Label lbFormato2;
    }
}