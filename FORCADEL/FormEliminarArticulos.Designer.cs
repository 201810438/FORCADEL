namespace FORCADEL
{
    partial class FormEliminarArticulos
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
            this.txtDescripcionArticulos = new System.Windows.Forms.TextBox();
            this.txtNombreArticulos = new System.Windows.Forms.TextBox();
            this.txtCodigoArticulos = new System.Windows.Forms.TextBox();
            this.txtIdArticulos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgModificarArticulos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminarArticulos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgModificarArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcionArticulos
            // 
            this.txtDescripcionArticulos.Location = new System.Drawing.Point(269, 193);
            this.txtDescripcionArticulos.Name = "txtDescripcionArticulos";
            this.txtDescripcionArticulos.Size = new System.Drawing.Size(457, 20);
            this.txtDescripcionArticulos.TabIndex = 77;
            // 
            // txtNombreArticulos
            // 
            this.txtNombreArticulos.Location = new System.Drawing.Point(261, 146);
            this.txtNombreArticulos.Name = "txtNombreArticulos";
            this.txtNombreArticulos.Size = new System.Drawing.Size(465, 20);
            this.txtNombreArticulos.TabIndex = 76;
            // 
            // txtCodigoArticulos
            // 
            this.txtCodigoArticulos.Location = new System.Drawing.Point(239, 107);
            this.txtCodigoArticulos.Name = "txtCodigoArticulos";
            this.txtCodigoArticulos.Size = new System.Drawing.Size(240, 20);
            this.txtCodigoArticulos.TabIndex = 75;
            // 
            // txtIdArticulos
            // 
            this.txtIdArticulos.Location = new System.Drawing.Point(196, 68);
            this.txtIdArticulos.Name = "txtIdArticulos";
            this.txtIdArticulos.Size = new System.Drawing.Size(205, 20);
            this.txtIdArticulos.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(74, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 16);
            this.label5.TabIndex = 73;
            this.label5.Text = "DESCRIPCION ARTICULO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(78, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 16);
            this.label4.TabIndex = 72;
            this.label4.Text = "NOMBRE DE ARTICULO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(78, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 71;
            this.label3.Text = "CODIGO ARTICULOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(78, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "ID ARTICULOS";
            // 
            // dgModificarArticulos
            // 
            this.dgModificarArticulos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgModificarArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgModificarArticulos.Location = new System.Drawing.Point(77, 271);
            this.dgModificarArticulos.Name = "dgModificarArticulos";
            this.dgModificarArticulos.Size = new System.Drawing.Size(649, 167);
            this.dgModificarArticulos.TabIndex = 69;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(605, 231);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 25);
            this.btnSalir.TabIndex = 68;
            this.btnSalir.Text = "SALIR ?";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.Location = new System.Drawing.Point(345, 225);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(171, 35);
            this.btnLimpiar.TabIndex = 67;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminarArticulos
            // 
            this.btnEliminarArticulos.BackColor = System.Drawing.Color.Blue;
            this.btnEliminarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArticulos.ForeColor = System.Drawing.Color.White;
            this.btnEliminarArticulos.Location = new System.Drawing.Point(77, 226);
            this.btnEliminarArticulos.Name = "btnEliminarArticulos";
            this.btnEliminarArticulos.Size = new System.Drawing.Size(152, 35);
            this.btnEliminarArticulos.TabIndex = 66;
            this.btnEliminarArticulos.Text = "ELIMINAR";
            this.btnEliminarArticulos.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "ELIMINAR ARTICULOS";
            // 
            // FormEliminarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDescripcionArticulos);
            this.Controls.Add(this.txtNombreArticulos);
            this.Controls.Add(this.txtCodigoArticulos);
            this.Controls.Add(this.txtIdArticulos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgModificarArticulos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminarArticulos);
            this.Controls.Add(this.label1);
            this.Name = "FormEliminarArticulos";
            this.Text = "FormEliminarArticulos";
            ((System.ComponentModel.ISupportInitialize)(this.dgModificarArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescripcionArticulos;
        private System.Windows.Forms.TextBox txtNombreArticulos;
        private System.Windows.Forms.TextBox txtCodigoArticulos;
        private System.Windows.Forms.TextBox txtIdArticulos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgModificarArticulos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminarArticulos;
        private System.Windows.Forms.Label label1;
    }
}