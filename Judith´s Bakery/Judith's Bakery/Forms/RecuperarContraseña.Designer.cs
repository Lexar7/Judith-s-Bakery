namespace Judith_s_Bakery.Forms
{
    partial class RecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarContraseña));
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.txtCorreo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperar.ForeColor = System.Drawing.Color.White;
            this.btnRecuperar.Location = new System.Drawing.Point(28, 145);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(149, 38);
            this.btnRecuperar.TabIndex = 2;
            this.btnRecuperar.Text = "Enviar";
            this.btnRecuperar.UseVisualStyleBackColor = false;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtCorreo.HintForeColor = System.Drawing.Color.Gray;
            this.txtCorreo.HintText = "Escribe tu correo";
            this.txtCorreo.isPassword = false;
            this.txtCorreo.LineFocusedColor = System.Drawing.Color.Orange;
            this.txtCorreo.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtCorreo.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.txtCorreo.LineThickness = 3;
            this.txtCorreo.Location = new System.Drawing.Point(28, 81);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(346, 33);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(64)))), ((int)(((byte)(58)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(225, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enviar correo para recuperación \r\nde contraseña";
            // 
            // RecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 209);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.btnRecuperar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "RecuperarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecuperarContraseña";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RecuperarContraseña_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRecuperar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCorreo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}