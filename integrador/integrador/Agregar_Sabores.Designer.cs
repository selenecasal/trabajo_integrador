namespace integrador
{
    partial class Agregar_Sabores
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
            components = new System.ComponentModel.Container();
            LblAgregar = new Label();
            LblNombre = new Label();
            LblDescrip = new Label();
            LblPrecio = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            TxtDescrip = new TextBox();
            TxtPre = new TextBox();
            TxtNom = new TextBox();
            BtnAgregar = new Button();
            BtnModif = new Button();
            SuspendLayout();
            // 
            // LblAgregar
            // 
            LblAgregar.AutoSize = true;
            LblAgregar.Location = new Point(337, 36);
            LblAgregar.Name = "LblAgregar";
            LblAgregar.Size = new Size(98, 15);
            LblAgregar.TabIndex = 0;
            LblAgregar.Text = "Agregar Helados:";
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Location = new Point(88, 85);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(54, 15);
            LblNombre.TabIndex = 1;
            LblNombre.Text = "Nombre:";
            // 
            // LblDescrip
            // 
            LblDescrip.AutoSize = true;
            LblDescrip.Location = new Point(348, 85);
            LblDescrip.Name = "LblDescrip";
            LblDescrip.Size = new Size(72, 15);
            LblDescrip.TabIndex = 2;
            LblDescrip.Text = "Descripcion:";
            // 
            // LblPrecio
            // 
            LblPrecio.AutoSize = true;
            LblPrecio.Location = new Point(641, 85);
            LblPrecio.Name = "LblPrecio";
            LblPrecio.Size = new Size(43, 15);
            LblPrecio.TabIndex = 3;
            LblPrecio.Text = "Precio:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // TxtDescrip
            // 
            TxtDescrip.Location = new Point(301, 116);
            TxtDescrip.Name = "TxtDescrip";
            TxtDescrip.Size = new Size(177, 23);
            TxtDescrip.TabIndex = 5;
            // 
            // TxtPre
            // 
            TxtPre.Location = new Point(575, 116);
            TxtPre.Name = "TxtPre";
            TxtPre.Size = new Size(177, 23);
            TxtPre.TabIndex = 6;
            // 
            // TxtNom
            // 
            TxtNom.Location = new Point(31, 116);
            TxtNom.Name = "TxtNom";
            TxtNom.Size = new Size(177, 23);
            TxtNom.TabIndex = 7;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(211, 214);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(134, 66);
            BtnAgregar.TabIndex = 8;
            BtnAgregar.Text = "Agregar Sabor";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += Btn_Enviar_Click;
            // 
            // BtnModif
            // 
            BtnModif.Location = new Point(456, 214);
            BtnModif.Name = "BtnModif";
            BtnModif.Size = new Size(134, 66);
            BtnModif.TabIndex = 9;
            BtnModif.Text = "Modificar";
            BtnModif.UseVisualStyleBackColor = true;
            BtnModif.Visible = false;
            BtnModif.Click += BtnModif_Click;
            // 
            // Agregar_Sabores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnModif);
            Controls.Add(BtnAgregar);
            Controls.Add(TxtNom);
            Controls.Add(TxtPre);
            Controls.Add(TxtDescrip);
            Controls.Add(LblPrecio);
            Controls.Add(LblDescrip);
            Controls.Add(LblNombre);
            Controls.Add(LblAgregar);
            Name = "Agregar_Sabores";
            Text = "Agregar_Sabores";
            FormClosing += Agregar_Sabores_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAgregar;
        private Label LblNombre;
        private Label LblDescrip;
        private Label LblPrecio;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox TxtDescrip;
        private TextBox TxtPre;
        private TextBox TxtNom;
        private Button BtnAgregar;
        private Button BtnModif;
    }
}