namespace Judith_s_Bakery.Forms
{
    partial class ModificarMateriaPrima
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
            this.lb_numeroID = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbActivo = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCantidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_crear = new System.Windows.Forms.Button();
            this.cbMedida = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_numeroID
            // 
            this.lb_numeroID.AutoSize = true;
            this.lb_numeroID.BackColor = System.Drawing.Color.Transparent;
            this.lb_numeroID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numeroID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(28)))));
            this.lb_numeroID.Location = new System.Drawing.Point(34, 41);
            this.lb_numeroID.Name = "lb_numeroID";
            this.lb_numeroID.Size = new System.Drawing.Size(28, 23);
            this.lb_numeroID.TabIndex = 106;
            this.lb_numeroID.Text = "ID";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.BackColor = System.Drawing.Color.Transparent;
            this.lb_id.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(28)))));
            this.lb_id.Location = new System.Drawing.Point(4, 41);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(33, 23);
            this.lb_id.TabIndex = 105;
            this.lb_id.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(28)))));
            this.label1.Location = new System.Drawing.Point(86, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 28);
            this.label1.TabIndex = 104;
            this.label1.Text = "Modificar Materia Prima ";
            // 
            // cbActivo
            // 
            this.cbActivo.BackColor = System.Drawing.Color.White;
            this.cbActivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActivo.FormattingEnabled = true;
            this.cbActivo.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbActivo.Location = new System.Drawing.Point(226, 240);
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Size = new System.Drawing.Size(98, 29);
            this.cbActivo.TabIndex = 101;
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
            this.txtPrecio.Location = new System.Drawing.Point(38, 187);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(183, 33);
            this.txtPrecio.TabIndex = 99;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCantidad.ForeColor = System.Drawing.Color.Black;
            this.txtCantidad.HintForeColor = System.Drawing.Color.DimGray;
            this.txtCantidad.HintText = "Cantidad";
            this.txtCantidad.isPassword = false;
            this.txtCantidad.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtCantidad.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCantidad.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtCantidad.LineThickness = 3;
            this.txtCantidad.Location = new System.Drawing.Point(38, 136);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(183, 33);
            this.txtCantidad.TabIndex = 98;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtNombre.Location = new System.Drawing.Point(38, 85);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(243, 33);
            this.txtNombre.TabIndex = 97;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.Firebrick;
            this.bt_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.ForeColor = System.Drawing.Color.White;
            this.bt_cancelar.Location = new System.Drawing.Point(218, 295);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(159, 44);
            this.bt_cancelar.TabIndex = 103;
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
            this.bt_crear.Location = new System.Drawing.Point(25, 294);
            this.bt_crear.Name = "bt_crear";
            this.bt_crear.Size = new System.Drawing.Size(159, 44);
            this.bt_crear.TabIndex = 102;
            this.bt_crear.Text = "Modificar";
            this.bt_crear.UseVisualStyleBackColor = false;
            this.bt_crear.Click += new System.EventHandler(this.bt_crear_Click);
            // 
            // cbMedida
            // 
            this.cbMedida.BackColor = System.Drawing.Color.White;
            this.cbMedida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedida.FormattingEnabled = true;
            this.cbMedida.Location = new System.Drawing.Point(38, 240);
            this.cbMedida.Name = "cbMedida";
            this.cbMedida.Size = new System.Drawing.Size(98, 29);
            this.cbMedida.TabIndex = 107;
            this.cbMedida.Text = "MEDIDA";
            // 
            // ModificarMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 365);
            this.Controls.Add(this.cbMedida);
            this.Controls.Add(this.lb_numeroID);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbActivo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_crear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModificarMateriaPrima";
            this.Text = "ModificarMateriaPrima";
            this.Load += new System.EventHandler(this.ModificarMateriaPrima_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ModificarMateriaPrima_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_numeroID;
        public System.Windows.Forms.Label lb_id;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbActivo;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtPrecio;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCantidad;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private System.Windows.Forms.Button bt_cancelar;
        public System.Windows.Forms.Button bt_crear;
        public System.Windows.Forms.ComboBox cbMedida;
    }
}