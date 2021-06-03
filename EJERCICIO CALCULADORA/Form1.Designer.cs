
namespace EJERCICIO_CALCULADORA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtDividir = new System.Windows.Forms.RadioButton();
            this.rbtMultiplicar = new System.Windows.Forms.RadioButton();
            this.rbtSumar = new System.Windows.Forms.RadioButton();
            this.rbtRestar = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(107, 37);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 20);
            this.txtN1.TabIndex = 3;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(107, 73);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 20);
            this.txtN2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtRestar);
            this.groupBox1.Controls.Add(this.rbtSumar);
            this.groupBox1.Controls.Add(this.rbtMultiplicar);
            this.groupBox1.Controls.Add(this.rbtDividir);
            this.groupBox1.Location = new System.Drawing.Point(12, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 122);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // rbtDividir
            // 
            this.rbtDividir.AutoSize = true;
            this.rbtDividir.Location = new System.Drawing.Point(18, 19);
            this.rbtDividir.Name = "rbtDividir";
            this.rbtDividir.Size = new System.Drawing.Size(54, 17);
            this.rbtDividir.TabIndex = 0;
            this.rbtDividir.TabStop = true;
            this.rbtDividir.Text = "Dividir";
            this.rbtDividir.UseVisualStyleBackColor = true;
            // 
            // rbtMultiplicar
            // 
            this.rbtMultiplicar.AutoSize = true;
            this.rbtMultiplicar.Location = new System.Drawing.Point(18, 42);
            this.rbtMultiplicar.Name = "rbtMultiplicar";
            this.rbtMultiplicar.Size = new System.Drawing.Size(72, 17);
            this.rbtMultiplicar.TabIndex = 1;
            this.rbtMultiplicar.TabStop = true;
            this.rbtMultiplicar.Text = "Multiplicar";
            this.rbtMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rbtSumar
            // 
            this.rbtSumar.AutoSize = true;
            this.rbtSumar.Location = new System.Drawing.Point(18, 65);
            this.rbtSumar.Name = "rbtSumar";
            this.rbtSumar.Size = new System.Drawing.Size(55, 17);
            this.rbtSumar.TabIndex = 2;
            this.rbtSumar.TabStop = true;
            this.rbtSumar.Text = "Sumar";
            this.rbtSumar.UseVisualStyleBackColor = true;
            // 
            // rbtRestar
            // 
            this.rbtRestar.AutoSize = true;
            this.rbtRestar.Location = new System.Drawing.Point(18, 88);
            this.rbtRestar.Name = "rbtRestar";
            this.rbtRestar.Size = new System.Drawing.Size(56, 17);
            this.rbtRestar.TabIndex = 3;
            this.rbtRestar.TabStop = true;
            this.rbtRestar.Text = "Restar";
            this.rbtRestar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(180, 195);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(180, 241);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(107, 304);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(107, 115);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(297, 339);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtRestar;
        private System.Windows.Forms.RadioButton rbtSumar;
        private System.Windows.Forms.RadioButton rbtMultiplicar;
        private System.Windows.Forms.RadioButton rbtDividir;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTotal;
    }
}

