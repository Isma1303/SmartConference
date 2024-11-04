namespace SmartConference.Components
{
    partial class Widget
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            labelPrecioProducto = new Label();
            labelNombreProducto = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(labelPrecioProducto);
            panel1.Controls.Add(labelNombreProducto);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 170);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.Hamburger;
            pictureBox1.Location = new Point(201, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            
            // 
            // labelPrecioProducto
            // 
            labelPrecioProducto.AutoSize = true;
            labelPrecioProducto.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrecioProducto.Location = new Point(3, 131);
            labelPrecioProducto.Name = "labelPrecioProducto";
            labelPrecioProducto.Size = new Size(75, 25);
            labelPrecioProducto.TabIndex = 1;
            labelPrecioProducto.Text = "Q20.00";
            // 
            // labelNombreProducto
            // 
            labelNombreProducto.AutoSize = true;
            labelNombreProducto.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombreProducto.Location = new Point(3, 6);
            labelNombreProducto.Name = "labelNombreProducto";
            labelNombreProducto.Size = new Size(132, 25);
            labelNombreProducto.TabIndex = 0;
            labelNombreProducto.Text = "Hamburguesa";
            // 
            // Widget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Widget";
            Size = new Size(330, 176);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelPrecioProducto;
        private Label labelNombreProducto;
        private PictureBox pictureBox1;
    }
}
