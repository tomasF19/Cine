namespace CineFarma
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
            this.Ejecutar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnClearListBox = new System.Windows.Forms.Button();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.btnAgregarPeliculas = new System.Windows.Forms.Button();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.btnVotar = new System.Windows.Forms.Button();
            this.listboxVotaciones = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResultadoVotacion = new System.Windows.Forms.Button();
            this.btnBuscarInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ejecutar
            // 
            this.Ejecutar.Location = new System.Drawing.Point(159, 80);
            this.Ejecutar.Name = "Ejecutar";
            this.Ejecutar.Size = new System.Drawing.Size(143, 49);
            this.Ejecutar.TabIndex = 0;
            this.Ejecutar.Text = "Buscar pelicula";
            this.Ejecutar.UseVisualStyleBackColor = true;
            this.Ejecutar.Click += new System.EventHandler(this.Ejecutar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre de pelicula :";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(318, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(395, 319);
            this.checkedListBox1.TabIndex = 5;
            // 
            // btnClearListBox
            // 
            this.btnClearListBox.Location = new System.Drawing.Point(318, 337);
            this.btnClearListBox.Name = "btnClearListBox";
            this.btnClearListBox.Size = new System.Drawing.Size(108, 35);
            this.btnClearListBox.TabIndex = 6;
            this.btnClearListBox.Text = "Limpiar lista de peliculas";
            this.btnClearListBox.UseVisualStyleBackColor = true;
            this.btnClearListBox.Click += new System.EventHandler(this.btnClearListBox_Click);
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Items.AddRange(new object[] {
            "Organizador",
            "Concurrente"});
            this.ComboBox.Location = new System.Drawing.Point(870, 7);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(125, 21);
            this.ComboBox.TabIndex = 7;
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // btnAgregarPeliculas
            // 
            this.btnAgregarPeliculas.Location = new System.Drawing.Point(719, 76);
            this.btnAgregarPeliculas.Name = "btnAgregarPeliculas";
            this.btnAgregarPeliculas.Size = new System.Drawing.Size(123, 43);
            this.btnAgregarPeliculas.TabIndex = 9;
            this.btnAgregarPeliculas.Text = "Agregar peliculas seleccionadas";
            this.btnAgregarPeliculas.UseVisualStyleBackColor = true;
            this.btnAgregarPeliculas.Click += new System.EventHandler(this.btnAgregarPeliculas_Click);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(318, 20);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(395, 304);
            this.checkedListBox2.TabIndex = 10;
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(719, 27);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(123, 43);
            this.btnVotar.TabIndex = 11;
            this.btnVotar.Text = "Votar pelicula";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // listboxVotaciones
            // 
            this.listboxVotaciones.FormattingEnabled = true;
            this.listboxVotaciones.Location = new System.Drawing.Point(5, 170);
            this.listboxVotaciones.Name = "listboxVotaciones";
            this.listboxVotaciones.Size = new System.Drawing.Size(297, 173);
            this.listboxVotaciones.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Votaciones";
            // 
            // btnResultadoVotacion
            // 
            this.btnResultadoVotacion.Location = new System.Drawing.Point(5, 349);
            this.btnResultadoVotacion.Name = "btnResultadoVotacion";
            this.btnResultadoVotacion.Size = new System.Drawing.Size(297, 23);
            this.btnResultadoVotacion.TabIndex = 14;
            this.btnResultadoVotacion.Text = "Obtener resultado de votación";
            this.btnResultadoVotacion.UseVisualStyleBackColor = true;
            this.btnResultadoVotacion.Click += new System.EventHandler(this.btnResultadoVotacion_Click);
            // 
            // btnBuscarInfo
            // 
            this.btnBuscarInfo.Location = new System.Drawing.Point(719, 125);
            this.btnBuscarInfo.Name = "btnBuscarInfo";
            this.btnBuscarInfo.Size = new System.Drawing.Size(123, 43);
            this.btnBuscarInfo.TabIndex = 15;
            this.btnBuscarInfo.Text = "Información";
            this.btnBuscarInfo.UseVisualStyleBackColor = true;
            this.btnBuscarInfo.Click += new System.EventHandler(this.btnBuscarInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 415);
            this.Controls.Add(this.btnBuscarInfo);
            this.Controls.Add(this.btnResultadoVotacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listboxVotaciones);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.btnAgregarPeliculas);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.btnClearListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Ejecutar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ejecutar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnClearListBox;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Button btnAgregarPeliculas;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.ListBox listboxVotaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnResultadoVotacion;
        private System.Windows.Forms.Button btnBuscarInfo;
    }
}

