﻿namespace Judith_s_Bakery
{
    partial class InicioSesion
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.tb_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tb_contraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_ingresar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.ForeColor = System.Drawing.Color.Black;
            this.tb_name.HintForeColor = System.Drawing.Color.Gray;
            this.tb_name.HintText = "Usuario";
            this.tb_name.isPassword = false;
            this.tb_name.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.tb_name.LineIdleColor = System.Drawing.Color.DarkGray;
            this.tb_name.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.tb_name.LineThickness = 3;
            this.tb_name.Location = new System.Drawing.Point(486, 93);
            this.tb_name.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(293, 43);
            this.tb_name.TabIndex = 5;
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tb_contraseña
            // 
            this.tb_contraseña.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_contraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_contraseña.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_contraseña.ForeColor = System.Drawing.Color.Gray;
            this.tb_contraseña.HintForeColor = System.Drawing.Color.Gray;
            this.tb_contraseña.HintText = "";
            this.tb_contraseña.isPassword = false;
            this.tb_contraseña.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.tb_contraseña.LineIdleColor = System.Drawing.Color.DarkGray;
            this.tb_contraseña.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.tb_contraseña.LineThickness = 4;
            this.tb_contraseña.Location = new System.Drawing.Point(486, 175);
            this.tb_contraseña.Margin = new System.Windows.Forms.Padding(5);
            this.tb_contraseña.Name = "tb_contraseña";
            this.tb_contraseña.Size = new System.Drawing.Size(293, 43);
            this.tb_contraseña.TabIndex = 6;
            this.tb_contraseña.Text = "Contraseña";
            this.tb_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_contraseña.Enter += new System.EventHandler(this.tb_contraseña_Enter);
            this.tb_contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_contraseña_KeyPress);
            this.tb_contraseña.Leave += new System.EventHandler(this.tb_contraseña_Leave);
            this.tb_contraseña.MouseEnter += new System.EventHandler(this.tb_contraseña_MouseEnter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Judith_s_Bakery.Properties.Resources._lock;
            this.pictureBox3.Location = new System.Drawing.Point(421, 173);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Judith_s_Bakery.Properties.Resources.user1;
            this.pictureBox2.Location = new System.Drawing.Point(421, 91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Judith_s_Bakery.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(67, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 458);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 34);
            this.label4.TabIndex = 2;
            this.label4.Text = "© Todos los derechos reservados a \r\n   Caceres\'s Car e Informatic Solutions.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nuestro objetivo es hacer \r\nde tu vehiculo algo unico!";
            // 
            // bt_ingresar
            // 
            this.bt_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.bt_ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ingresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ingresar.ForeColor = System.Drawing.Color.White;
            this.bt_ingresar.Location = new System.Drawing.Point(421, 312);
            this.bt_ingresar.Name = "bt_ingresar";
            this.bt_ingresar.Size = new System.Drawing.Size(181, 44);
            this.bt_ingresar.TabIndex = 8;
            this.bt_ingresar.Text = "Ingresar";
            this.bt_ingresar.UseVisualStyleBackColor = false;
            this.bt_ingresar.Click += new System.EventHandler(this.bt_ingresar_Click);
            this.bt_ingresar.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(64)))), ((int)(((byte)(58)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(619, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Inicio de Sesión";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "¿Olvidaste tu contraseña?";
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 3;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 458);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_ingresar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_contraseña);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_contraseña;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_ingresar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label5;
    }
}

