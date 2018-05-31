namespace Judith_s_Bakery.Report
{
    partial class ProveedoresReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveedoresReport));
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Proveedores11 = new Judith_s_Bakery.Report.Proveedores1();
            this.SuspendLayout();
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.CachedPageNumberPerDoc = 10;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = this.Proveedores11;
            this.crystalReportViewer2.Size = new System.Drawing.Size(609, 327);
            this.crystalReportViewer2.TabIndex = 0;
            this.crystalReportViewer2.Load += new System.EventHandler(this.crystalReportViewer2_Load);
            // 
            // ProveedoresReport
            // 
            this.ClientSize = new System.Drawing.Size(609, 327);
            this.Controls.Add(this.crystalReportViewer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProveedoresReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

       // private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        //private Proveedores Proveedores1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private Proveedores1 Proveedores11;
    }
}