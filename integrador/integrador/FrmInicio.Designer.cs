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
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            BtnCrear = new Button();
            BtnMod = new Button();
            BtnEliminar = new Button();
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
            DgvSabores.AllowUserToAddRows = false;
            DgvSabores.AllowUserToDeleteRows = false;
            DgvSabores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvSabores.Columns.AddRange(new DataGridViewColumn[] { id, nombre, descripcion, precio });
            DgvSabores.Location = new Point(205, 61);
            DgvSabores.MultiSelect = false;
            DgvSabores.Name = "DgvSabores";
            DgvSabores.ReadOnly = true;
            DgvSabores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvSabores.Size = new Size(374, 252);
            DgvSabores.TabIndex = 2;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre del sabor:";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripcion:";
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            // 
            // precio
            // 
            precio.HeaderText = "Precio:";
            precio.Name = "precio";
            precio.ReadOnly = true;
            // 
            // BtnCrear
            // 
            BtnCrear.Location = new Point(631, 36);
            BtnCrear.Name = "BtnCrear";
            BtnCrear.Size = new Size(137, 67);
            BtnCrear.TabIndex = 3;
            BtnCrear.Text = "Agregar Sabor";
            BtnCrear.UseVisualStyleBackColor = true;
            BtnCrear.Click += Btn_Siguente_Click;
            // 
            // BtnMod
            // 
            BtnMod.Location = new Point(631, 123);
            BtnMod.Name = "BtnMod";
            BtnMod.Size = new Size(137, 67);
            BtnMod.TabIndex = 4;
            BtnMod.Text = "Modificar";
            BtnMod.UseVisualStyleBackColor = true;
            BtnMod.Click += BtnMod_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(631, 215);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(137, 67);
            BtnEliminar.TabIndex = 5;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // FrmMain_Mostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnMod);
            Controls.Add(BtnCrear);
            Controls.Add(DgvSabores);
            Controls.Add(LblTitulo);
            Name = "FrmMain_Mostrar";
            Text = "FrmMain";
            Load += FrmMain_Mostrar_Load;
            ((System.ComponentModel.ISupportInitialize)DgvSabores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblTitulo;
        private DataGridView DgvSabores;
        private Button BtnCrear;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn precio;
        private Button BtnMod;
        private Button BtnEliminar;
    }
}
