
namespace XaviFormas
{
    partial class Form1
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
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.listFormas = new System.Windows.Forms.ListBox();
            this.btnVerDiagrama = new System.Windows.Forms.Button();
            this.btnCalcularArea = new System.Windows.Forms.Button();
            this.btnEliminarForma = new System.Windows.Forms.Button();
            this.btnFormaAleatoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCirculo
            // 
            this.btnCirculo.Location = new System.Drawing.Point(119, 67);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(118, 23);
            this.btnCirculo.TabIndex = 0;
            this.btnCirculo.Text = "Circulo";
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(119, 121);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(118, 23);
            this.btnTriangulo.TabIndex = 1;
            this.btnTriangulo.Text = "Triangulo";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Location = new System.Drawing.Point(119, 176);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(118, 23);
            this.btnRectangulo.TabIndex = 2;
            this.btnRectangulo.Text = "Rectangulo";
            this.btnRectangulo.UseVisualStyleBackColor = true;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // listFormas
            // 
            this.listFormas.FormattingEnabled = true;
            this.listFormas.ItemHeight = 16;
            this.listFormas.Location = new System.Drawing.Point(303, 50);
            this.listFormas.Name = "listFormas";
            this.listFormas.Size = new System.Drawing.Size(316, 372);
            this.listFormas.TabIndex = 3;
            // 
            // btnVerDiagrama
            // 
            this.btnVerDiagrama.Location = new System.Drawing.Point(119, 229);
            this.btnVerDiagrama.Name = "btnVerDiagrama";
            this.btnVerDiagrama.Size = new System.Drawing.Size(118, 23);
            this.btnVerDiagrama.TabIndex = 4;
            this.btnVerDiagrama.Text = "Ver diagrama";
            this.btnVerDiagrama.UseVisualStyleBackColor = true;
            this.btnVerDiagrama.Click += new System.EventHandler(this.btnVerDiagrama_Click);
            // 
            // btnCalcularArea
            // 
            this.btnCalcularArea.Location = new System.Drawing.Point(119, 279);
            this.btnCalcularArea.Name = "btnCalcularArea";
            this.btnCalcularArea.Size = new System.Drawing.Size(118, 23);
            this.btnCalcularArea.TabIndex = 5;
            this.btnCalcularArea.Text = "Calcular area";
            this.btnCalcularArea.UseVisualStyleBackColor = true;
            this.btnCalcularArea.Click += new System.EventHandler(this.btnCalcularArea_Click);
            // 
            // btnEliminarForma
            // 
            this.btnEliminarForma.Location = new System.Drawing.Point(119, 329);
            this.btnEliminarForma.Name = "btnEliminarForma";
            this.btnEliminarForma.Size = new System.Drawing.Size(118, 23);
            this.btnEliminarForma.TabIndex = 6;
            this.btnEliminarForma.Text = "Eliminar forma";
            this.btnEliminarForma.UseVisualStyleBackColor = true;
            this.btnEliminarForma.Click += new System.EventHandler(this.btnEliminarForma_Click);
            // 
            // btnFormaAleatoria
            // 
            this.btnFormaAleatoria.Location = new System.Drawing.Point(119, 380);
            this.btnFormaAleatoria.Name = "btnFormaAleatoria";
            this.btnFormaAleatoria.Size = new System.Drawing.Size(118, 23);
            this.btnFormaAleatoria.TabIndex = 7;
            this.btnFormaAleatoria.Text = "Forma aleatoria";
            this.btnFormaAleatoria.UseVisualStyleBackColor = true;
            this.btnFormaAleatoria.Click += new System.EventHandler(this.btnFormaAleatoria_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFormaAleatoria);
            this.Controls.Add(this.btnEliminarForma);
            this.Controls.Add(this.btnCalcularArea);
            this.Controls.Add(this.btnVerDiagrama);
            this.Controls.Add(this.listFormas);
            this.Controls.Add(this.btnRectangulo);
            this.Controls.Add(this.btnTriangulo);
            this.Controls.Add(this.btnCirculo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.ListBox listFormas;
        private System.Windows.Forms.Button btnVerDiagrama;
        private System.Windows.Forms.Button btnCalcularArea;
        private System.Windows.Forms.Button btnEliminarForma;
        private System.Windows.Forms.Button btnFormaAleatoria;
    }
}

