namespace Judith_s_Bakery.Forms
{
    partial class ModificarProductoFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarProductoFinal));
            this.cbActivo = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCantidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_crear = new System.Windows.Forms.Button();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lb_numeroID = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbActivo
            // 
            this.cbActivo.BackColor = System.Drawing.Color.White;
            this.cbActivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActivo.FormattingEnabled = true;
            this.cbActivo.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbActivo.Location = new System.Drawing.Point(225, 223);
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Size = new System.Drawing.Size(98, 29);
            this.cbActivo.TabIndex = 87;
            this.cbActivo.Text = "Estado";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.HintForeColor = System.Drawing.Color.DimGray;
            this.txtPrecio.HintText = "Precio";
            this.txtPrecio.isPassword = false;
            this.txtPrecio.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtPrecio.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrecio.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtPrecio.LineThickness = 3;
            this.txtPrecio.Location = new System.Drawing.Point(36, 170);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(183, 33);
            this.txtPrecio.TabIndex = 85;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
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
            this.txtCantidad.Location = new System.Drawing.Point(36, 119);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(183, 33);
            this.txtCantidad.TabIndex = 84;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
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
            this.txtNombre.Location = new System.Drawing.Point(36, 68);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(243, 33);
            this.txtNombre.TabIndex = 83;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.Firebrick;
            this.bt_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.ForeColor = System.Drawing.Color.White;
            this.bt_cancelar.Location = new System.Drawing.Point(216, 278);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(159, 44);
            this.bt_cancelar.TabIndex = 89;
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
            this.bt_crear.Location = new System.Drawing.Point(23, 277);
            this.bt_crear.Name = "bt_crear";
            this.bt_crear.Size = new System.Drawing.Size(159, 44);
            this.bt_crear.TabIndex = 88;
            this.bt_crear.Text = "Modificar";
            this.bt_crear.UseVisualStyleBackColor = false;
            this.bt_crear.Click += new System.EventHandler(this.bt_crear_Click);
            // 
            // bt_modificar
            // 
            this.bt_modificar.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_modificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_modificar.ForeColor = System.Drawing.Color.White;
            this.bt_modificar.Location = new System.Drawing.Point(23, 278);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(159, 44);
            this.bt_modificar.TabIndex = 90;
            this.bt_modificar.Text = "Actualizar";
            this.bt_modificar.UseVisualStyleBackColor = false;
            this.bt_modificar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(28)))));
            this.label1.Location = new System.Drawing.Point(84, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 28);
            this.label1.TabIndex = 93;
            this.label1.Text = "Modificar Producto ";
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.White;
            this.cbCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(36, 223);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(109, 29);
            this.cbCategoria.TabIndex = 86;
            this.cbCategoria.Text = "Categoria";
            // 
            // lb_numeroID
            // 
            this.lb_numeroID.AutoSize = true;
            this.lb_numeroID.BackColor = System.Drawing.Color.Transparent;
            this.lb_numeroID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numeroID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(28)))));
            this.lb_numeroID.Location = new System.Drawing.Point(27, 24);
            this.lb_numeroID.Name = "lb_numeroID";
            this.lb_numeroID.Size = new System.Drawing.Size(28, 23);
            this.lb_numeroID.TabIndex = 96;
            this.lb_numeroID.Text = "ID";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.BackColor = System.Drawing.Color.Transparent;
            this.lb_id.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(28)))));
            this.lb_id.Location = new System.Drawing.Point(2, 24);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(33, 23);
            this.lb_id.TabIndex = 95;
            this.lb_id.Text = "ID:";
            // 
            // ModificarProductoFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(400, 340);
            this.Controls.Add(this.lb_numeroID);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbActivo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_crear);
            this.Controls.Add(this.bt_modificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ModificarProductoFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearProductoFinal";
            this.Load += new System.EventHandler(this.ModificarProductoFinal_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ModificarProductoFinal_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbActivo;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtPrecio;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCantidad;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private System.Windows.Forms.Button bt_cancelar;
        public System.Windows.Forms.Button bt_crear;
        public System.Windows.Forms.Button bt_modificar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbCategoria;
        public System.Windows.Forms.Label lb_numeroID;
        public System.Windows.Forms.Label lb_id;
    }
}