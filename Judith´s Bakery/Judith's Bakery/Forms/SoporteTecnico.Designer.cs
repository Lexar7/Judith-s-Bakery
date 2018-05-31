namespace Judith_s_Bakery.Forms
{
    partial class SoporteTecnico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoporteTecnico));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtEmisor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnEnivar = new System.Windows.Forms.Button();
            this.rtbMensaje = new System.Windows.Forms.RichTextBox();
            this.txtContraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAsunto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtRutaArchivo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAdjuntar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "Escribele a los desarrolladores el \r\nproblema que tienes";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(64)))), ((int)(((byte)(58)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(276, 384);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(149, 38);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmisor
            // 
            this.txtEmisor.BackColor = System.Drawing.Color.White;
            this.txtEmisor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmisor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmisor.ForeColor = System.Drawing.Color.Black;
            this.txtEmisor.HintForeColor = System.Drawing.Color.Gray;
            this.txtEmisor.HintText = "Escribe tu correo";
            this.txtEmisor.isPassword = false;
            this.txtEmisor.LineFocusedColor = System.Drawing.Color.Orange;
            this.txtEmisor.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtEmisor.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.txtEmisor.LineThickness = 3;
            this.txtEmisor.Location = new System.Drawing.Point(28, 82);
            this.txtEmisor.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmisor.Name = "txtEmisor";
            this.txtEmisor.Size = new System.Drawing.Size(278, 33);
            this.txtEmisor.TabIndex = 7;
            this.txtEmisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnEnivar
            // 
            this.btnEnivar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEnivar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnivar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnivar.ForeColor = System.Drawing.Color.White;
            this.btnEnivar.Location = new System.Drawing.Point(79, 384);
            this.btnEnivar.Name = "btnEnivar";
            this.btnEnivar.Size = new System.Drawing.Size(149, 38);
            this.btnEnivar.TabIndex = 13;
            this.btnEnivar.Text = "Enviar";
            this.toolTip1.SetToolTip(this.btnEnivar, "Enviar");
            this.btnEnivar.UseVisualStyleBackColor = false;
            this.btnEnivar.Click += new System.EventHandler(this.btnEnivar_Click);
            // 
            // rtbMensaje
            // 
            this.rtbMensaje.BackColor = System.Drawing.Color.White;
            this.rtbMensaje.Location = new System.Drawing.Point(28, 243);
            this.rtbMensaje.Name = "rtbMensaje";
            this.rtbMensaje.Size = new System.Drawing.Size(448, 125);
            this.rtbMensaje.TabIndex = 12;
            this.rtbMensaje.Text = "";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.White;
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.Gray;
            this.txtContraseña.HintForeColor = System.Drawing.Color.Gray;
            this.txtContraseña.HintText = "";
            this.txtContraseña.isPassword = false;
            this.txtContraseña.LineFocusedColor = System.Drawing.Color.Orange;
            this.txtContraseña.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtContraseña.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.txtContraseña.LineThickness = 3;
            this.txtContraseña.Location = new System.Drawing.Point(317, 82);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(159, 33);
            this.txtContraseña.TabIndex = 8;
            this.txtContraseña.Text = "Contraseña de tu correo";
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContraseña.Enter += new System.EventHandler(this.tb_contraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.tb_contraseña_Leave);
            // 
            // txtAsunto
            // 
            this.txtAsunto.BackColor = System.Drawing.Color.White;
            this.txtAsunto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAsunto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAsunto.ForeColor = System.Drawing.Color.Black;
            this.txtAsunto.HintForeColor = System.Drawing.Color.Gray;
            this.txtAsunto.HintText = "Asunto";
            this.txtAsunto.isPassword = false;
            this.txtAsunto.LineFocusedColor = System.Drawing.Color.Orange;
            this.txtAsunto.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtAsunto.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.txtAsunto.LineThickness = 3;
            this.txtAsunto.Location = new System.Drawing.Point(28, 133);
            this.txtAsunto.Margin = new System.Windows.Forms.Padding(4);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(278, 33);
            this.txtAsunto.TabIndex = 9;
            this.txtAsunto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.BackColor = System.Drawing.Color.White;
            this.txtRutaArchivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRutaArchivo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRutaArchivo.ForeColor = System.Drawing.Color.Black;
            this.txtRutaArchivo.HintForeColor = System.Drawing.Color.Gray;
            this.txtRutaArchivo.HintText = "Adjuntar archivo";
            this.txtRutaArchivo.isPassword = false;
            this.txtRutaArchivo.LineFocusedColor = System.Drawing.Color.Orange;
            this.txtRutaArchivo.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtRutaArchivo.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.txtRutaArchivo.LineThickness = 3;
            this.txtRutaArchivo.Location = new System.Drawing.Point(28, 183);
            this.txtRutaArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(278, 33);
            this.txtRutaArchivo.TabIndex = 10;
            this.txtRutaArchivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.BackColor = System.Drawing.Color.LightGray;
            this.btnAdjuntar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdjuntar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjuntar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjuntar.ForeColor = System.Drawing.Color.White;
            this.btnAdjuntar.Location = new System.Drawing.Point(317, 185);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(42, 33);
            this.btnAdjuntar.TabIndex = 11;
            this.btnAdjuntar.Text = "...";
            this.toolTip1.SetToolTip(this.btnAdjuntar, "Adjuntar");
            this.btnAdjuntar.UseVisualStyleBackColor = false;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SoporteTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(502, 442);
            this.Controls.Add(this.btnAdjuntar);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.rtbMensaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtEmisor);
            this.Controls.Add(this.btnEnivar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "SoporteTecnico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoporteTecnico";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SoporteTecnico_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmisor;
        private System.Windows.Forms.Button btnEnivar;
        private System.Windows.Forms.RichTextBox rtbMensaje;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContraseña;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAsunto;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRutaArchivo;
        private System.Windows.Forms.Button btnAdjuntar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}