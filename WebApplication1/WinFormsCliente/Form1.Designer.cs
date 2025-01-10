namespace WinFormsCliente
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
            dgViews = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Nota = new DataGridViewTextBoxColumn();
            LU = new DataGridViewTextBoxColumn();
            tbxLU = new TextBox();
            tbxNombre = new TextBox();
            tbxNota = new TextBox();
            btnListar = new Button();
            btnAgregar = new Button();
            btnBorrar = new Button();
            btnBuscar = new Button();
            btnActualizar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbxID = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgViews).BeginInit();
            SuspendLayout();
            // 
            // dgViews
            // 
            dgViews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgViews.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Nota, LU });
            dgViews.Location = new Point(12, 110);
            dgViews.Name = "dgViews";
            dgViews.RowHeadersWidth = 51;
            dgViews.Size = new Size(527, 220);
            dgViews.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Nota
            // 
            Nota.HeaderText = "Nota";
            Nota.MinimumWidth = 6;
            Nota.Name = "Nota";
            Nota.Width = 125;
            // 
            // LU
            // 
            LU.HeaderText = "LU";
            LU.MinimumWidth = 6;
            LU.Name = "LU";
            LU.Width = 125;
            // 
            // tbxLU
            // 
            tbxLU.Location = new Point(234, 57);
            tbxLU.Name = "tbxLU";
            tbxLU.Size = new Size(91, 27);
            tbxLU.TabIndex = 1;
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(99, 16);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(226, 27);
            tbxNombre.TabIndex = 2;
            // 
            // tbxNota
            // 
            tbxNota.Location = new Point(102, 57);
            tbxNota.Name = "tbxNota";
            tbxNota.Size = new Size(91, 27);
            tbxNota.TabIndex = 3;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(554, 24);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(85, 72);
            btnListar.TabIndex = 4;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(554, 258);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(85, 72);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar Alumno";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(554, 102);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(85, 72);
            btnBorrar.TabIndex = 6;
            btnBorrar.Text = "Borrar Alumno";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(463, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(85, 72);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar Alumno";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(554, 180);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(85, 72);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar Alumno";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 57);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 9;
            label1.Text = "LU:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 16);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 10;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 57);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 11;
            label3.Text = "Nota:";
            // 
            // tbxID
            // 
            tbxID.Location = new Point(353, 57);
            tbxID.Name = "tbxID";
            tbxID.Size = new Size(91, 27);
            tbxID.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(353, 34);
            label4.Name = "label4";
            label4.Size = new Size(27, 20);
            label4.TabIndex = 13;
            label4.Text = "ID:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 342);
            Controls.Add(label4);
            Controls.Add(tbxID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnActualizar);
            Controls.Add(btnBuscar);
            Controls.Add(btnBorrar);
            Controls.Add(btnAgregar);
            Controls.Add(btnListar);
            Controls.Add(tbxNota);
            Controls.Add(tbxNombre);
            Controls.Add(tbxLU);
            Controls.Add(dgViews);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgViews).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgViews;
        private TextBox tbxLU;
        private TextBox tbxNombre;
        private TextBox tbxNota;
        private Button btnListar;
        private Button btnAgregar;
        private Button btnBorrar;
        private Button btnBuscar;
        private Button btnActualizar;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Nota;
        private DataGridViewTextBoxColumn LU;
        private TextBox tbxID;
        private Label label4;
    }
}
