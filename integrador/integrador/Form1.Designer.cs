namespace integrador
{
    partial class FrmMain_Mostrar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblTitulo = new Label();
            DgvSabores = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            Btn_Siguente = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvSabores).BeginInit();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Location = new Point(357, 20);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(68, 15);
            LblTitulo.TabIndex = 1;
            LblTitulo.Text = "HELADERIA";
            // 
            // DgvSabores
            // 
            DgvSabores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvSabores.Columns.AddRange(new DataGridViewColumn[] { nombre, descripcion, precio });
            DgvSabores.Location = new Point(205, 61);
            DgvSabores.Name = "DgvSabores";
            DgvSabores.Size = new Size(374, 252);
            DgvSabores.TabIndex = 2;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre del sabor:";
            nombre.Name = "nombre";
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripcion:";
            descripcion.Name = "descripcion";
            // 
            // precio
            // 
            precio.HeaderText = "Precio:";
            precio.Name = "precio";
            // 
            // Btn_Siguente
            // 
            Btn_Siguente.Location = new Point(631, 36);
            Btn_Siguente.Name = "Btn_Siguente";
            Btn_Siguente.Size = new Size(137, 67);
            Btn_Siguente.TabIndex = 3;
            Btn_Siguente.Text = "Siguiente";
            Btn_Siguente.UseVisualStyleBackColor = true;
            Btn_Siguente.Click += Btn_Siguente_Click;
            // 
            // FrmMain_Mostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_Siguente);
            Controls.Add(DgvSabores);
            Controls.Add(LblTitulo);
            Name = "FrmMain_Mostrar";
            Text = "FrmMain";
            Activated += FrmMain_Mostrar_Activated;
            ((System.ComponentModel.ISupportInitialize)DgvSabores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblTitulo;
        private DataGridView DgvSabores;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn precio;
        private Button Btn_Siguente;
    }
}
