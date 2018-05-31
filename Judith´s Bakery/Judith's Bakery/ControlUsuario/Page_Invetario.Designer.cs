namespace Judith_s_Bakery
{
    partial class Page_Invetario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_Invetario));
            this.label3 = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbProducto = new System.Windows.Forms.Label();
            this.lbMateria = new System.Windows.Forms.Label();
            this.btMateria = new Bunifu.Framework.UI.BunifuImageButton();
            this.btProducto = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCompra = new System.Windows.Forms.Label();
            this.btnCompra = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbVenta = new System.Windows.Forms.Label();
            this.btnVenta = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbPedidos = new System.Windows.Forms.Label();
            this.btnPedidos = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btMateria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Inventario";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(779, 27);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(56, 24);
            this.lbHora.TabIndex = 15;
            this.lbHora.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducto.Location = new System.Drawing.Point(414, 370);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(86, 42);
            this.lbProducto.TabIndex = 17;
            this.lbProducto.Text = "Producto \r\n    Final";
            // 
            // lbMateria
            // 
            this.lbMateria.AutoSize = true;
            this.lbMateria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMateria.Location = new System.Drawing.Point(630, 370);
            this.lbMateria.Name = "lbMateria";
            this.lbMateria.Size = new System.Drawing.Size(76, 42);
            this.lbMateria.TabIndex = 19;
            this.lbMateria.Text = "Materia \r\n  Prima";
            // 
            // btMateria
            // 
            this.btMateria.BackColor = System.Drawing.Color.Transparent;
            this.btMateria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMateria.Image = ((System.Drawing.Image)(resources.GetObject("btMateria.Image")));
            this.btMateria.ImageActive = null;
            this.btMateria.Location = new System.Drawing.Point(601, 237);
            this.btMateria.Name = "btMateria";
            this.btMateria.Size = new System.Drawing.Size(131, 130);
            this.btMateria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btMateria.TabIndex = 18;
            this.btMateria.TabStop = false;
            this.btMateria.Zoom = 10;
            this.btMateria.Click += new System.EventHandler(this.btMateria_Click);
            this.btMateria.MouseEnter += new System.EventHandler(this.bunifuImageButton1_MouseEnter);
            this.btMateria.MouseLeave += new System.EventHandler(this.btMateria_MouseLeave);
            // 
            // btProducto
            // 
            this.btProducto.BackColor = System.Drawing.Color.Transparent;
            this.btProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btProducto.Image = ((System.Drawing.Image)(resources.GetObject("btProducto.Image")));
            this.btProducto.ImageActive = null;
            this.btProducto.Location = new System.Drawing.Point(389, 237);
            this.btProducto.Name = "btProducto";
            this.btProducto.Size = new System.Drawing.Size(131, 130);
            this.btProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btProducto.TabIndex = 16;
            this.btProducto.TabStop = false;
            this.btProducto.Zoom = 10;
            this.btProducto.Click += new System.EventHandler(this.btProducto_Click);
            this.btProducto.MouseEnter += new System.EventHandler(this.bt_usuarios_MouseEnter);
            this.btProducto.MouseLeave += new System.EventHandler(this.bt_usuarios_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lbCompra
            // 
            this.lbCompra.AutoSize = true;
            this.lbCompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompra.Location = new System.Drawing.Point(355, 615);
            this.lbCompra.Name = "lbCompra";
            this.lbCompra.Size = new System.Drawing.Size(75, 21);
            this.lbCompra.TabIndex = 21;
            this.lbCompra.Text = "Compra";
            // 
            // btnCompra
            // 
            this.btnCompra.BackColor = System.Drawing.Color.Transparent;
            this.btnCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnCompra.Image")));
            this.btnCompra.ImageActive = null;
            this.btnCompra.Location = new System.Drawing.Point(327, 482);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(131, 130);
            this.btnCompra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCompra.TabIndex = 20;
            this.btnCompra.TabStop = false;
            this.btnCompra.Zoom = 10;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            this.btnCompra.MouseEnter += new System.EventHandler(this.btnCompra_MouseEnter);
            this.btnCompra.MouseLeave += new System.EventHandler(this.btnCompra_MouseLeave);
            // 
            // lbVenta
            // 
            this.lbVenta.AutoSize = true;
            this.lbVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVenta.Location = new System.Drawing.Point(538, 615);
            this.lbVenta.Name = "lbVenta";
            this.lbVenta.Size = new System.Drawing.Size(59, 21);
            this.lbVenta.TabIndex = 23;
            this.lbVenta.Text = "Venta";
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnVenta.Image")));
            this.btnVenta.ImageActive = null;
            this.btnVenta.Location = new System.Drawing.Point(501, 482);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(131, 130);
            this.btnVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVenta.TabIndex = 22;
            this.btnVenta.TabStop = false;
            this.btnVenta.Zoom = 10;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            this.btnVenta.MouseEnter += new System.EventHandler(this.btnVenta_MouseEnter);
            this.btnVenta.MouseLeave += new System.EventHandler(this.btnVenta_MouseLeave);
            // 
            // lbPedidos
            // 
            this.lbPedidos.AutoSize = true;
            this.lbPedidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPedidos.Location = new System.Drawing.Point(714, 615);
            this.lbPedidos.Name = "lbPedidos";
            this.lbPedidos.Size = new System.Drawing.Size(70, 21);
            this.lbPedidos.TabIndex = 25;
            this.lbPedidos.Text = "Pedidos";
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.Transparent;
            this.btnPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnPedidos.Image")));
            this.btnPedidos.ImageActive = null;
            this.btnPedidos.Location = new System.Drawing.Point(685, 482);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(131, 130);
            this.btnPedidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPedidos.TabIndex = 24;
            this.btnPedidos.TabStop = false;
            this.btnPedidos.Zoom = 10;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            this.btnPedidos.MouseEnter += new System.EventHandler(this.btnPedidos_MouseEnter);
            this.btnPedidos.MouseLeave += new System.EventHandler(this.btnPedidos_MouseLeave);
            // 
            // Page_Invetario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbPedidos);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.lbVenta);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.lbCompra);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.lbMateria);
            this.Controls.Add(this.btMateria);
            this.Controls.Add(this.lbProducto);
            this.Controls.Add(this.btProducto);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Name = "Page_Invetario";
            this.Size = new System.Drawing.Size(1152, 689);
            ((System.ComponentModel.ISupportInitialize)(this.btMateria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbProducto;
        private Bunifu.Framework.UI.BunifuImageButton btProducto;
        private System.Windows.Forms.Label lbMateria;
        private Bunifu.Framework.UI.BunifuImageButton btMateria;
        private System.Windows.Forms.Label lbCompra;
        private Bunifu.Framework.UI.BunifuImageButton btnCompra;
        private System.Windows.Forms.Label lbVenta;
        private Bunifu.Framework.UI.BunifuImageButton btnVenta;
        private System.Windows.Forms.Label lbPedidos;
        private Bunifu.Framework.UI.BunifuImageButton btnPedidos;
    }
}
