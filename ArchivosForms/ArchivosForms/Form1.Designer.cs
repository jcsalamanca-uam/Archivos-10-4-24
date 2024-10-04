namespace ArchivosForms
{
    partial class Form1
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
            TbNombre = new TextBox();
            TbEdad = new TextBox();
            TbGenero = new TextBox();
            TbNota = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Genero = new Label();
            label4 = new Label();
            BtnAdd = new Button();
            BtnLeer = new Button();
            DgvPerfil = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvPerfil).BeginInit();
            SuspendLayout();
            // 
            // TbNombre
            // 
            TbNombre.Location = new Point(9, 12);
            TbNombre.Name = "TbNombre";
            TbNombre.Size = new Size(150, 31);
            TbNombre.TabIndex = 0;
            TbNombre.TextChanged += textBox1_TextChanged;
            // 
            // TbEdad
            // 
            TbEdad.Location = new Point(191, 16);
            TbEdad.Name = "TbEdad";
            TbEdad.Size = new Size(150, 31);
            TbEdad.TabIndex = 1;
            // 
            // TbGenero
            // 
            TbGenero.Location = new Point(393, 16);
            TbGenero.Name = "TbGenero";
            TbGenero.Size = new Size(150, 31);
            TbGenero.TabIndex = 2;
            // 
            // TbNota
            // 
            TbNota.Location = new Point(594, 16);
            TbNota.Name = "TbNota";
            TbNota.Size = new Size(150, 31);
            TbNota.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 72);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 72);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 5;
            label2.Text = "Edad";
            // 
            // Genero
            // 
            Genero.AutoSize = true;
            Genero.Location = new Point(438, 72);
            Genero.Name = "Genero";
            Genero.Size = new Size(69, 25);
            Genero.TabIndex = 6;
            Genero.Text = "Genero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(669, 72);
            label4.Name = "label4";
            label4.Size = new Size(51, 25);
            label4.TabIndex = 7;
            label4.Text = "Nota";
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(12, 120);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(112, 34);
            BtnAdd.TabIndex = 8;
            BtnAdd.Text = "Añadir";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += button1_Click;
            // 
            // BtnLeer
            // 
            BtnLeer.Location = new Point(608, 120);
            BtnLeer.Name = "BtnLeer";
            BtnLeer.Size = new Size(112, 34);
            BtnLeer.TabIndex = 9;
            BtnLeer.Text = "Leer";
            BtnLeer.UseVisualStyleBackColor = true;
            BtnLeer.Click += button1_Click_1;
            // 
            // DgvPerfil
            // 
            DgvPerfil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPerfil.Location = new Point(9, 160);
            DgvPerfil.Name = "DgvPerfil";
            DgvPerfil.RowHeadersWidth = 62;
            DgvPerfil.Size = new Size(735, 231);
            DgvPerfil.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DgvPerfil);
            Controls.Add(BtnLeer);
            Controls.Add(BtnAdd);
            Controls.Add(label4);
            Controls.Add(Genero);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TbNota);
            Controls.Add(TbGenero);
            Controls.Add(TbEdad);
            Controls.Add(TbNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DgvPerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TbNombre;
        private TextBox TbEdad;
        private TextBox TbGenero;
        private TextBox TbNota;
        private Label label1;
        private Label label2;
        private Label Genero;
        private Label label4;
        private Button BtnAdd;
        private Button BtnLeer;
        private DataGridView DgvPerfil;
    }
}
