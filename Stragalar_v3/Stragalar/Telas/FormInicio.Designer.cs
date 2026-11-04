namespace Stragalar.Telas
{
    partial class FormInicio
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblBemVindo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.lblBemVindo.Text = "Bem-vindo ao STRAGALAR\n\nSelecione uma opção no menu lateral.";
            this.lblBemVindo.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblBemVindo.Location = new System.Drawing.Point(40, 40);
            this.lblBemVindo.Size = new System.Drawing.Size(600, 100);
            this.Controls.Add(this.lblBemVindo);
            this.ResumeLayout(false);
        }
    }
}
