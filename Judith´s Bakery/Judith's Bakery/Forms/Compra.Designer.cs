namespace Judith_s_Bakery.Forms
{
    partial class Compra
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_regresar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbHora = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtDescuento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPrecio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbTipoPago = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.lbTotal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tablaCompra = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.btnHistorial = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnComprar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuitar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lb_ayuda = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.bunifuImageButton3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 48);
            this.panel1.TabIndex = 10;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(857, 17);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(23, 28);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton3.TabIndex = 22;
            this.bunifuImageButton3.TabStop = false;
            this.toolTip1.SetToolTip(this.bunifuImageButton3, "Minimizar");
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(888, 9);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(25, 28);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 21;
            this.bunifuImageButton2.TabStop = false;
            this.toolTip1.SetToolTip(this.bunifuImageButton2, "Cerrar");
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Compra";
            // 
            // bt_regresar
            // 
            this.bt_regresar.BackColor = System.Drawing.Color.Transparent;
            this.bt_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_regresar.Image = ((System.Drawing.Image)(resources.GetObject("bt_regresar.Image")));
            this.bt_regresar.ImageActive = null;
            this.bt_regresar.Location = new System.Drawing.Point(841, 440);
            this.bt_regresar.Name = "bt_regresar";
            this.bt_regresar.Size = new System.Drawing.Size(56, 53);
            this.bt_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_regresar.TabIndex = 76;
            this.bt_regresar.TabStop = false;
            this.toolTip1.SetToolTip(this.bt_regresar, "Regresar");
            this.bt_regresar.Zoom = 10;
            this.bt_regresar.Click += new System.EventHandler(this.bt_regresar_Click);
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(12, 64);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(56, 24);
            this.lbHora.TabIndex = 75;
            this.lbHora.Text = "Time";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(750, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            // 
            // txtDescuento
            // 
            this.txtDescuento.BackColor = System.Drawing.Color.White;
            this.txtDescuento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescuento.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDescuento.ForeColor = System.Drawing.Color.Black;
            this.txtDescuento.HintForeColor = System.Drawing.Color.DimGray;
            this.txtDescuento.HintText = "Descuento %";
            this.txtDescuento.isPassword = false;
            this.txtDescuento.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtDescuento.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDescuento.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtDescuento.LineThickness = 3;
            this.txtDescuento.Location = new System.Drawing.Point(277, 156);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(124, 33);
            this.txtDescuento.TabIndex = 67;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.HintForeColor = System.Drawing.Color.DimGray;
            this.txtPrecio.HintText = "$ Precio";
            this.txtPrecio.isPassword = false;
            this.txtPrecio.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtPrecio.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrecio.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtPrecio.LineThickness = 3;
            this.txtPrecio.Location = new System.Drawing.Point(12, 156);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(124, 33);
            this.txtPrecio.TabIndex = 65;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // cbTipoPago
            // 
            this.cbTipoPago.BackColor = System.Drawing.Color.White;
            this.cbTipoPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoPago.FormattingEnabled = true;
            this.cbTipoPago.Location = new System.Drawing.Point(420, 158);
            this.cbTipoPago.Name = "cbTipoPago";
            this.cbTipoPago.Size = new System.Drawing.Size(166, 29);
            this.cbTipoPago.TabIndex = 68;
            this.cbTipoPago.Text = "Tipo De Pago";
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
            this.txtCantidad.Location = new System.Drawing.Point(145, 156);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(124, 33);
            this.txtCantidad.TabIndex = 66;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // cbProducto
            // 
            this.cbProducto.BackColor = System.Drawing.Color.White;
            this.cbProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(254, 106);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(225, 29);
            this.cbProducto.TabIndex = 64;
            this.cbProducto.Text = "Producto";
            // 
            // lbTotal
            // 
            this.lbTotal.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbTotal.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(156)))), ((int)(((byte)(28)))));
            this.lbTotal.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbTotal.BorderThickness = 3;
            this.lbTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbTotal.Enabled = false;
            this.lbTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Black;
            this.lbTotal.isPassword = false;
            this.lbTotal.Location = new System.Drawing.Point(733, 202);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(186, 62);
            this.lbTotal.TabIndex = 65;
            this.lbTotal.Text = "TOTAL";
            this.lbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tablaCompra
            // 
            this.tablaCompra.AllowUserToAddRows = false;
            this.tablaCompra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tablaCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaCompra.BackgroundColor = System.Drawing.Color.White;
            this.tablaCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Proveedor,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.Descuento,
            this.TipoPago,
            this.SubTotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaCompra.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaCompra.DoubleBuffered = true;
            this.tablaCompra.EnableHeadersVisualStyles = false;
            this.tablaCompra.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.tablaCompra.HeaderForeColor = System.Drawing.Color.White;
            this.tablaCompra.Location = new System.Drawing.Point(12, 200);
            this.tablaCompra.Name = "tablaCompra";
            this.tablaCompra.ReadOnly = true;
            this.tablaCompra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaCompra.RowHeadersVisible = false;
            this.tablaCompra.Size = new System.Drawing.Size(702, 305);
            this.tablaCompra.TabIndex = 80;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // TipoPago
            // 
            this.TipoPago.HeaderText = "Tipo Pago";
            this.TipoPago.Name = "TipoPago";
            this.TipoPago.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // cbProveedor
            // 
            this.cbProveedor.BackColor = System.Drawing.Color.White;
            this.cbProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(12, 106);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(225, 29);
            this.cbProveedor.TabIndex = 63;
            this.cbProveedor.Text = "Proveedor";
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.Transparent;
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorial.Image")));
            this.btnHistorial.ImageActive = null;
            this.btnHistorial.Location = new System.Drawing.Point(755, 440);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(56, 53);
            this.btnHistorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHistorial.TabIndex = 62;
            this.btnHistorial.TabStop = false;
            this.toolTip1.SetToolTip(this.btnHistorial, "Historial");
            this.btnHistorial.Zoom = 10;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnAgregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.BorderRadius = 0;
            this.btnAgregar.ButtonText = " Agregar";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Iconimage")));
            this.btnAgregar.Iconimage_right = null;
            this.btnAgregar.Iconimage_right_Selected = null;
            this.btnAgregar.Iconimage_Selected = null;
            this.btnAgregar.IconMarginLeft = 0;
            this.btnAgregar.IconMarginRight = 0;
            this.btnAgregar.IconRightVisible = true;
            this.btnAgregar.IconRightZoom = 0D;
            this.btnAgregar.IconVisible = true;
            this.btnAgregar.IconZoom = 70D;
            this.btnAgregar.IsTab = false;
            this.btnAgregar.Location = new System.Drawing.Point(733, 272);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.btnAgregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregar.selected = false;
            this.btnAgregar.Size = new System.Drawing.Size(186, 44);
            this.btnAgregar.TabIndex = 69;
            this.btnAgregar.Text = " Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Textcolor = System.Drawing.Color.White;
            this.btnAgregar.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar");
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Activecolor = System.Drawing.Color.Green;
            this.btnComprar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnComprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComprar.BorderRadius = 0;
            this.btnComprar.ButtonText = " Comprar";
            this.btnComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprar.DisabledColor = System.Drawing.Color.Gray;
            this.btnComprar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnComprar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnComprar.Iconimage")));
            this.btnComprar.Iconimage_right = null;
            this.btnComprar.Iconimage_right_Selected = null;
            this.btnComprar.Iconimage_Selected = null;
            this.btnComprar.IconMarginLeft = 0;
            this.btnComprar.IconMarginRight = 0;
            this.btnComprar.IconRightVisible = true;
            this.btnComprar.IconRightZoom = 0D;
            this.btnComprar.IconVisible = true;
            this.btnComprar.IconZoom = 70D;
            this.btnComprar.IsTab = false;
            this.btnComprar.Location = new System.Drawing.Point(733, 330);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(0);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Normalcolor = System.Drawing.Color.LimeGreen;
            this.btnComprar.OnHovercolor = System.Drawing.Color.Green;
            this.btnComprar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnComprar.selected = false;
            this.btnComprar.Size = new System.Drawing.Size(186, 44);
            this.btnComprar.TabIndex = 70;
            this.btnComprar.Text = " Comprar";
            this.btnComprar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprar.Textcolor = System.Drawing.Color.White;
            this.btnComprar.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnComprar, "Comprar");
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Activecolor = System.Drawing.Color.Maroon;
            this.btnQuitar.BackColor = System.Drawing.Color.Firebrick;
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitar.BorderRadius = 0;
            this.btnQuitar.ButtonText = " Quitar";
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuitar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuitar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Iconimage")));
            this.btnQuitar.Iconimage_right = null;
            this.btnQuitar.Iconimage_right_Selected = null;
            this.btnQuitar.Iconimage_Selected = null;
            this.btnQuitar.IconMarginLeft = 0;
            this.btnQuitar.IconMarginRight = 0;
            this.btnQuitar.IconRightVisible = true;
            this.btnQuitar.IconRightZoom = 0D;
            this.btnQuitar.IconVisible = true;
            this.btnQuitar.IconZoom = 70D;
            this.btnQuitar.IsTab = false;
            this.btnQuitar.Location = new System.Drawing.Point(733, 389);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Normalcolor = System.Drawing.Color.Firebrick;
            this.btnQuitar.OnHovercolor = System.Drawing.Color.Maroon;
            this.btnQuitar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuitar.selected = false;
            this.btnQuitar.Size = new System.Drawing.Size(186, 44);
            this.btnQuitar.TabIndex = 71;
            this.btnQuitar.Text = " Quitar";
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitar.Textcolor = System.Drawing.Color.White;
            this.btnQuitar.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnQuitar, "Quitar");
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(661, 114);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(83, 75);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Ayuda");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lb_ayuda
            // 
            this.lb_ayuda.AutoSize = true;
            this.lb_ayuda.BackColor = System.Drawing.Color.Transparent;
            this.lb_ayuda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ayuda.Location = new System.Drawing.Point(551, 68);
            this.lb_ayuda.Name = "lb_ayuda";
            this.lb_ayuda.Size = new System.Drawing.Size(180, 57);
            this.lb_ayuda.TabIndex = 28;
            this.lb_ayuda.Text = "Aqui puedes comprar\r\nproductos a tus \r\nproveedores!";
            this.lb_ayuda.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label1.Location = new System.Drawing.Point(756, 500);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 81;
            this.label1.Text = "Historial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label2.Location = new System.Drawing.Point(838, 500);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 82;
            this.label2.Text = "Regresar";
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 526);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lb_ayuda);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.bt_regresar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.tablaCompra);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.cbTipoPago);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.txtCantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Compra_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Compra_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton bt_regresar;
        private System.Windows.Forms.Label lbHora;
        public System.Windows.Forms.PictureBox pictureBox2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtDescuento;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtPrecio;
        public System.Windows.Forms.ComboBox cbTipoPago;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCantidad;
        public System.Windows.Forms.ComboBox cbProducto;
        private Bunifu.Framework.UI.BunifuMetroTextbox lbTotal;
        public Bunifu.Framework.UI.BunifuCustomDataGrid tablaCompra;
        public System.Windows.Forms.ComboBox cbProveedor;
        private Bunifu.Framework.UI.BunifuImageButton btnHistorial;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar;
        private Bunifu.Framework.UI.BunifuFlatButton btnComprar;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuitar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lb_ayuda;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}