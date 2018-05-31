namespace Judith_s_Bakery.Forms
{
    partial class CrearProductoFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearProductoFinal));
            this.cb_activo = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPrecio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_ingresar = new System.Windows.Forms.Button();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_ayuda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_activo
            // 
            this.cb_activo.BackColor = System.Drawing.Color.White;
            this.cb_activo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_activo.FormattingEnabled = true;
            this.cb_activo.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cb_activo.Location = new System.Drawing.Point(218, 231);
            this.cb_activo.Name = "cb_activo";
            this.cb_activo.Size = new System.Drawing.Size(79, 29);
            this.cb_activo.TabIndex = 52;
            this.cb_activo.Text = "Estado";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCantidad.ForeColor = System.Drawing.Color.Black;
            this.txtCantidad.HintForeColor = System.Drawing.Color.DimGray;
            this.txtCantidad.HintText = "Cantidad";
            this.txtCantidad.isPassword = false;
            this.txtCantidad.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtCantidad.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCantidad.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtCantidad.LineThickness = 3;
            this.txtCantidad.Location = new System.Drawing.Point(9, 177);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(183, 33);
            this.txtCantidad.TabIndex = 42;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.HintForeColor = System.Drawing.Color.DimGray;
            this.txtPrecio.HintText = "Precio Unitario";
            this.txtPrecio.isPassword = false;
            this.txtPrecio.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtPrecio.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrecio.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtPrecio.LineThickness = 3;
            this.txtPrecio.Location = new System.Drawing.Point(9, 121);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(213, 33);
            this.txtPrecio.TabIndex = 40;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.HintForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.HintText = "Nombre Producto";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtNombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtNombre.LineThickness = 3;
            this.txtNombre.Location = new System.Drawing.Point(9, 72);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 33);
            this.txtNombre.TabIndex = 39;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(225, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 44);
            this.button1.TabIndex = 54;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_ingresar
            // 
            this.bt_ingresar.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ingresar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ingresar.ForeColor = System.Drawing.Color.White;
            this.bt_ingresar.Location = new System.Drawing.Point(32, 280);
            this.bt_ingresar.Name = "bt_ingresar";
            this.bt_ingresar.Size = new System.Drawing.Size(159, 44);
            this.bt_ingresar.TabIndex = 53;
            this.bt_ingresar.Text = "Crear";
            this.bt_ingresar.UseVisualStyleBackColor = false;
            this.bt_ingresar.Click += new System.EventHandler(this.bt_ingresar_Click);
            // 
            // cb_categoria
            // 
            this.cb_categoria.BackColor = System.Drawing.Color.White;
            this.cb_categoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cb_categoria.Location = new System.Drawing.Point(9, 231);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(183, 29);
            this.cb_categoria.TabIndex = 51;
            this.cb_categoria.Text = "Categoria";
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lb_titulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(28)))));
            this.lb_titulo.Location = new System.Drawing.Point(90, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(242, 36);
            this.lb_titulo.TabIndex = 38;
            this.lb_titulo.Text = "Nuevo Producto";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(323, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lb_ayuda
            // 
            this.lb_ayuda.AutoSize = true;
            this.lb_ayuda.BackColor = System.Drawing.Color.Transparent;
            this.lb_ayuda.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ayuda.Location = new System.Drawing.Point(229, 72);
            this.lb_ayuda.Name = "lb_ayuda";
            this.lb_ayuda.Size = new System.Drawing.Size(168, 15);
            this.lb_ayuda.TabIndex = 56;
            this.lb_ayuda.Text = "La cantidad del producto sera";
            this.lb_ayuda.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "cambiada por medio de";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 15);
            this.label2.TabIndex = 58;
            this.label2.Text = "compra y venta o Materia Prima.";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(28)))));
            this.label3.Location = new System.Drawing.Point(9, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 23);
            this.label3.TabIndex = 59;
            this.label3.Text = "ID:";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(28)))));
            this.lbId.Location = new System.Drawing.Point(39, 19);
            this.lbId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(33, 23);
            this.lbId.TabIndex = 60;
            this.lbId.Text = "ID:";
            // 
            // CrearProductoFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(423, 338);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_ayuda);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cb_activo);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_ingresar);
            this.Controls.Add(this.cb_categoria);
            this.Controls.Add(this.lb_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CrearProductoFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearProductoFinal";
            this.Load += new System.EventHandler(this.CrearProductoFinal_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CrearProductoFinal_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cb_activo;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCantidad;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtPrecio;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button bt_ingresar;
        public System.Windows.Forms.ComboBox cb_categoria;
        public System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_ayuda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbId;
    }
}