namespace FORCADEL
{
    partial class FormModificarArticulos
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificarArticulos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgModificarArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcionArticulos
            // 
            this.txtDescripcionArticulos.Location = new System.Drawing.Point(221, 191);
            this.txtDescripcionArticulos.Name = "txtDescripcionArticulos";
            this.txtDescripcionArticulos.Size = new System.Drawing.Size(457, 20);
            this.txtDescripcionArticulos.TabIndex = 63;
            // 
            // txtNombreArticulos
            // 
            this.txtNombreArticulos.Location = new System.Drawing.Point(213, 144);
            this.txtNombreArticulos.Name = "txtNombreArticulos";
            this.txtNombreArticulos.Size = new System.Drawing.Size(465, 20);
            this.txtNombreArticulos.TabIndex = 62;
            // 
            // txtCodigoArticulos
            // 
            this.txtCodigoArticulos.Location = new System.Drawing.Point(191, 105);
            this.txtCodigoArticulos.Name = "txtCodigoArticulos";
            this.txtCodigoArticulos.Size = new System.Drawing.Size(240, 20);
            this.txtCodigoArticulos.TabIndex = 61;
            // 
            // txtIdArticulos
            // 
            this.txtIdArticulos.Location = new System.Drawing.Point(148, 66);
            this.txtIdArticulos.Name = "txtIdArticulos";
            this.txtIdArticulos.Size = new System.Drawing.Size(205, 20);
            this.txtIdArticulos.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "DESCRIPCION ARTICULO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(30, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 16);
            this.label4.TabIndex = 58;
            this.label4.Text = "NOMBRE DE ARTICULO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "CODIGO ARTICULOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "ID ARTICULOS";
            // 
            // dgModificarArticulos
            // 
            this.dgModificarArticulos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgModificarArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgModificarArticulos.Location = new System.Drawing.Point(29, 269);
            this.dgModificarArticulos.Name = "dgModificarArticulos";
            this.dgModificarArticulos.Size = new System.Drawing.Size(649, 167);
            this.dgModificarArticulos.TabIndex = 55;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(557, 229);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 25);
            this.btnSalir.TabIndex = 54;
            this.btnSalir.Text = "SALIR ?";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.Location = new System.Drawing.Point(370, 227);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(171, 35);
            this.btnLimpiar.TabIndex = 53;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Blue;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(201, 227);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(152, 35);
            this.btnGuardar.TabIndex = 52;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "MODIFICAR ARTICULOS";
            // 
            // btnModificarArticulos
            // 
            this.btnModificarArticulos.BackColor = System.Drawing.Color.Black;
            this.btnModificarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarArticulos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificarArticulos.Location = new System.Drawing.Point(29, 228);
            this.btnModificarArticulos.Name = "btnModificarArticulos";
            this.btnModificarArticulos.Size = new System.Drawing.Size(152, 35);
            this.btnModificarArticulos.TabIndex = 64;
            this.btnModificarArticulos.Text = "MODIFICAR";
            this.btnModificarArticulos.UseVisualStyleBackColor = false;
            // 
            // FormModificarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.btnModificarArticulos);
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
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Name = "FormModificarArticulos";
            this.Text = "FormModificarArticulos";
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
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificarArticulos;
    }
}