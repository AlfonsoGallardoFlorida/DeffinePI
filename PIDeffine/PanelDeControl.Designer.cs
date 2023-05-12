
namespace PIDeffine
{
    partial class PanelDeControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbCerrar = new System.Windows.Forms.PictureBox();
            this.pcbMaximizar = new System.Windows.Forms.PictureBox();
            this.pcbMinimizar = new System.Windows.Forms.PictureBox();
            this.pcbVolver = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pcbCerrar);
            this.panel1.Controls.Add(this.pcbMaximizar);
            this.panel1.Controls.Add(this.pcbMinimizar);
            this.panel1.Controls.Add(this.pcbVolver);
            this.panel1.Location = new System.Drawing.Point(3, -13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 55);
            this.panel1.TabIndex = 24;
            // 
            // pcbCerrar
            // 
            this.pcbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbCerrar.Image = global::PIDeffine.Properties.Resources.closewindowapplication_cerca_ventan_2874;
            this.pcbCerrar.Location = new System.Drawing.Point(953, 17);
            this.pcbCerrar.Name = "pcbCerrar";
            this.pcbCerrar.Size = new System.Drawing.Size(41, 35);
            this.pcbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCerrar.TabIndex = 24;
            this.pcbCerrar.TabStop = false;
            // 
            // pcbMaximizar
            // 
            this.pcbMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbMaximizar.Image = global::PIDeffine.Properties.Resources.maximizethewindow_theapplication_maximizar_2873;
            this.pcbMaximizar.Location = new System.Drawing.Point(906, 17);
            this.pcbMaximizar.Name = "pcbMaximizar";
            this.pcbMaximizar.Size = new System.Drawing.Size(41, 35);
            this.pcbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMaximizar.TabIndex = 25;
            this.pcbMaximizar.TabStop = false;
            // 
            // pcbMinimizar
            // 
            this.pcbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbMinimizar.Image = global::PIDeffine.Properties.Resources.minimize_thewindow_theapplication_2872;
            this.pcbMinimizar.Location = new System.Drawing.Point(863, 17);
            this.pcbMinimizar.Name = "pcbMinimizar";
            this.pcbMinimizar.Size = new System.Drawing.Size(37, 35);
            this.pcbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMinimizar.TabIndex = 0;
            this.pcbMinimizar.TabStop = false;
            // 
            // pcbVolver
            // 
            this.pcbVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbVolver.Image = global::PIDeffine.Properties.Resources.image_removebg_preview__13_;
            this.pcbVolver.Location = new System.Drawing.Point(17, 17);
            this.pcbVolver.Name = "pcbVolver";
            this.pcbVolver.Size = new System.Drawing.Size(38, 35);
            this.pcbVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbVolver.TabIndex = 26;
            this.pcbVolver.TabStop = false;
            // 
            // PanelDeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "PanelDeControl";
            this.Size = new System.Drawing.Size(1041, 55);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVolver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbCerrar;
        private System.Windows.Forms.PictureBox pcbMaximizar;
        private System.Windows.Forms.PictureBox pcbMinimizar;
        private System.Windows.Forms.PictureBox pcbVolver;
    }
}
