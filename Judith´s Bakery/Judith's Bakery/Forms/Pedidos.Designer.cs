namespace Judith_s_Bakery.Forms
{
    partial class Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbHora = new System.Windows.Forms.Label();
            this.txtDescuento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbTipoPago = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.tablaVenta = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTotal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnQuitar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVender = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_regresar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnHistorial = new Bunifu.Framework.UI.BunifuImageButton();
            this.lb_ayuda = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_regresar)).BeginInit();
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
            this.bunifuImageButton3.Location = new System.Drawing.Point(860, 17);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(23, 28);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton3.TabIndex = 22;
            this.bunifuImageButton3.TabStop = false;
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
            this.bunifuImageButton2.Location = new System.Drawing.Point(891, 9);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(25, 28);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 21;
            this.bunifuImageButton2.TabStop = false;
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
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pedidos";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.HintForeColor = System.Drawing.Color.DimGray;
            this.txtPrecio.HintText = "$ Precio";
            this.txtPrecio.isPassword = false;
            this.txtPrecio.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtPrecio.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrecio.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(54)))));
            this.txtPrecio.LineThickness = 3;
            this.txtPrecio.Location = new System.Drawing.Point(13, 110);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(124, 33);
            this.txtPrecio.TabIndex = 96;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(12, 62);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(56, 24);
            this.lbHora.TabIndex = 93;
            this.lbHora.Text = "Time";
            this.lbHora.Visible = false;
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
            this.txtDescuento.Location = new System.Drawing.Point(277, 110);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(124, 33);
            this.txtDescuento.TabIndex = 91;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
            // 
            // cbTipoPago
            // 
            this.cbTipoPago.BackColor = System.Drawing.Color.White;
            this.cbTipoPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoPago.FormattingEnabled = true;
            this.cbTipoPago.Location = new System.Drawing.Point(417, 113);
            this.cbTipoPago.Name = "cbTipoPago";
            this.cbTipoPago.Size = new System.Drawing.Size(166, 29);
            this.cbTipoPago.TabIndex = 92;
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
            this.txtCantidad.Location = new System.Drawing.Point(145, 110);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(124, 33);
            this.txtCantidad.TabIndex = 90;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // cbProducto
            // 
            this.cbProducto.BackColor = System.Drawing.Color.White;
            this.cbProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(254, 64);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(225, 29);
            this.cbProducto.TabIndex = 89;
            this.cbProducto.Text = "Producto";
            this.cbProducto.SelectedIndexChanged += new System.EventHandler(this.cbProducto_SelectedIndexChanged);
            // 
            // cbCliente
            // 
            this.cbCliente.BackColor = System.Drawing.Color.White;
            this.cbCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(12, 64);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(225, 29);
            this.cbCliente.TabIndex = 88;
            this.cbCliente.Text = "Cliente";
            // 
            // tablaVenta
            // 
            this.tablaVenta.AllowUserToAddRows = false;
            this.tablaVenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tablaVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaVenta.BackgroundColor = System.Drawing.Color.White;
            this.tablaVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
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
            this.tablaVenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaVenta.DoubleBuffered = true;
            this.tablaVenta.EnableHeadersVisualStyles = false;
            this.tablaVenta.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.tablaVenta.HeaderForeColor = System.Drawing.Color.White;
            this.tablaVenta.Location = new System.Drawing.Point(13, 193);
            this.tablaVenta.Name = "tablaVenta";
            this.tablaVenta.ReadOnly = true;
            this.tablaVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaVenta.RowHeadersVisible = false;
            this.tablaVenta.Size = new System.Drawing.Size(702, 312);
            this.tablaVenta.TabIndex = 97;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
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
            this.lbTotal.Location = new System.Drawing.Point(730, 202);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(186, 62);
            this.lbTotal.TabIndex = 104;
            this.lbTotal.Text = "TOTAL";
            this.lbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnQuitar.Location = new System.Drawing.Point(732, 387);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Normalcolor = System.Drawing.Color.Firebrick;
            this.btnQuitar.OnHovercolor = System.Drawing.Color.Maroon;
            this.btnQuitar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuitar.selected = false;
            this.btnQuitar.Size = new System.Drawing.Size(186, 44);
            this.btnQuitar.TabIndex = 102;
            this.btnQuitar.Text = " Quitar";
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitar.Textcolor = System.Drawing.Color.White;
            this.btnQuitar.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnVender
            // 
            this.btnVender.Activecolor = System.Drawing.Color.Green;
            this.btnVender.BackColor = System.Drawing.Color.LimeGreen;
            this.btnVender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVender.BorderRadius = 0;
            this.btnVender.ButtonText = " Pedido";
            this.btnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVender.DisabledColor = System.Drawing.Color.Gray;
            this.btnVender.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVender.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVender.Iconimage")));
            this.btnVender.Iconimage_right = null;
            this.btnVender.Iconimage_right_Selected = null;
            this.btnVender.Iconimage_Selected = null;
            this.btnVender.IconMarginLeft = 0;
            this.btnVender.IconMarginRight = 0;
            this.btnVender.IconRightVisible = true;
            this.btnVender.IconRightZoom = 0D;
            this.btnVender.IconVisible = true;
            this.btnVender.IconZoom = 70D;
            this.btnVender.IsTab = false;
            this.btnVender.Location = new System.Drawing.Point(732, 328);
            this.btnVender.Margin = new System.Windows.Forms.Padding(0);
            this.btnVender.Name = "btnVender";
            this.btnVender.Normalcolor = System.Drawing.Color.LimeGreen;
            this.btnVender.OnHovercolor = System.Drawing.Color.Green;
            this.btnVender.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVender.selected = false;
            this.btnVender.Size = new System.Drawing.Size(186, 44);
            this.btnVender.TabIndex = 101;
            this.btnVender.Text = " Pedido";
            this.btnVender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVender.Textcolor = System.Drawing.Color.White;
            this.btnVender.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
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
            this.btnAgregar.Location = new System.Drawing.Point(732, 270);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.btnAgregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregar.selected = false;
            this.btnAgregar.Size = new System.Drawing.Size(186, 44);
            this.btnAgregar.TabIndex = 100;
            this.btnAgregar.Text = " Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Textcolor = System.Drawing.Color.White;
            this.btnAgregar.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // bt_regresar
            // 
            this.bt_regresar.BackColor = System.Drawing.Color.Transparent;
            this.bt_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_regresar.Image = ((System.Drawing.Image)(resources.GetObject("bt_regresar.Image")));
            this.bt_regresar.ImageActive = null;
            this.bt_regresar.Location = new System.Drawing.Point(840, 438);
            this.bt_regresar.Name = "bt_regresar";
            this.bt_regresar.Size = new System.Drawing.Size(56, 53);
            this.bt_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_regresar.TabIndex = 103;
            this.bt_regresar.TabStop = false;
            this.toolTip1.SetToolTip(this.bt_regresar, "Regresar");
            this.bt_regresar.Zoom = 10;
            this.bt_regresar.Click += new System.EventHandler(this.bt_regresar_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.Transparent;
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorial.Image")));
            this.btnHistorial.ImageActive = null;
            this.btnHistorial.Location = new System.Drawing.Point(760, 438);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(56, 53);
            this.btnHistorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHistorial.TabIndex = 99;
            this.btnHistorial.TabStop = false;
            this.toolTip1.SetToolTip(this.btnHistorial, "Historial");
            this.btnHistorial.Zoom = 10;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // lb_ayuda
            // 
            this.lb_ayuda.AutoSize = true;
            this.lb_ayuda.BackColor = System.Drawing.Color.Transparent;
            this.lb_ayuda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ayuda.Location = new System.Drawing.Point(723, 61);
            this.lb_ayuda.Name = "lb_ayuda";
            this.lb_ayuda.Size = new System.Drawing.Size(140, 57);
            this.lb_ayuda.TabIndex = 95;
            this.lb_ayuda.Text = "Aqui pueden los \r\nclientes ordenar\r\nsus pedidos!";
            this.lb_ayuda.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(830, 107);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(83, 75);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 94;
            this.pictureBox3.TabStop = false;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(171, 161);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 105;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 106;
            this.label1.Text = "Fecha de Entrega: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(836, 494);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 109;
            this.label2.Text = "Regresar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(760, 494);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 19);
            this.label9.TabIndex = 108;
            this.label9.Text = "Historial";
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 517);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.bt_regresar);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.tablaVenta);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lb_ayuda);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.cbTipoPago);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbHora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pedidos_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_regresar)).EndInit();
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
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtPrecio;
        private System.Windows.Forms.Label lbHora;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtDescuento;
        public System.Windows.Forms.ComboBox cbTipoPago;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCantidad;
        public System.Windows.Forms.ComboBox cbProducto;
        public System.Windows.Forms.ComboBox cbCliente;
        public Bunifu.Framework.UI.BunifuCustomDataGrid tablaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private Bunifu.Framework.UI.BunifuMetroTextbox lbTotal;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuitar;
        private Bunifu.Framework.UI.BunifuFlatButton btnVender;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar;
        private Bunifu.Framework.UI.BunifuImageButton bt_regresar;
        private Bunifu.Framework.UI.BunifuImageButton btnHistorial;
        private System.Windows.Forms.Label lb_ayuda;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
    }
}