namespace MonitorPartidoFutbol
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
            this.comboboxLocal = new System.Windows.Forms.ComboBox();
            this.comboBoxVisitante = new System.Windows.Forms.ComboBox();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.labelLocal = new System.Windows.Forms.Label();
            this.labelVisitante = new System.Windows.Forms.Label();
            this.textBoxGolesLocal = new System.Windows.Forms.TextBox();
            this.textBoxGolesVisitante = new System.Windows.Forms.TextBox();
            this.buttonSumarGolLocal = new System.Windows.Forms.Button();
            this.buttonRestarGolLocal = new System.Windows.Forms.Button();
            this.buttonSumarGolVisitante = new System.Windows.Forms.Button();
            this.buttonRestarGolVisitante = new System.Windows.Forms.Button();
            this.buttonReiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboboxLocal
            // 
            this.comboboxLocal.FormattingEnabled = true;
            this.comboboxLocal.Location = new System.Drawing.Point(144, 68);
            this.comboboxLocal.Name = "comboboxLocal";
            this.comboboxLocal.Size = new System.Drawing.Size(121, 21);
            this.comboboxLocal.TabIndex = 0;
            this.comboboxLocal.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxVisitante
            // 
            this.comboBoxVisitante.FormattingEnabled = true;
            this.comboBoxVisitante.Location = new System.Drawing.Point(532, 68);
            this.comboBoxVisitante.Name = "comboBoxVisitante";
            this.comboBoxVisitante.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVisitante.TabIndex = 1;
            this.comboBoxVisitante.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Location = new System.Drawing.Point(345, 68);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(115, 23);
            this.buttonIniciar.TabIndex = 2;
            this.buttonIniciar.Text = "Iniciar Partido";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Location = new System.Drawing.Point(191, 52);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(33, 13);
            this.labelLocal.TabIndex = 3;
            this.labelLocal.Text = "Local";
            this.labelLocal.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelVisitante
            // 
            this.labelVisitante.AutoSize = true;
            this.labelVisitante.Location = new System.Drawing.Point(581, 52);
            this.labelVisitante.Name = "labelVisitante";
            this.labelVisitante.Size = new System.Drawing.Size(47, 13);
            this.labelVisitante.TabIndex = 4;
            this.labelVisitante.Text = "Visitante";
            this.labelVisitante.Click += new System.EventHandler(this.labelVisitante_Click);
            // 
            // textBoxGolesLocal
            // 
            this.textBoxGolesLocal.Location = new System.Drawing.Point(156, 95);
            this.textBoxGolesLocal.Name = "textBoxGolesLocal";
            this.textBoxGolesLocal.Size = new System.Drawing.Size(100, 20);
            this.textBoxGolesLocal.TabIndex = 5;
            // 
            // textBoxGolesVisitante
            // 
            this.textBoxGolesVisitante.Location = new System.Drawing.Point(542, 95);
            this.textBoxGolesVisitante.Name = "textBoxGolesVisitante";
            this.textBoxGolesVisitante.Size = new System.Drawing.Size(100, 20);
            this.textBoxGolesVisitante.TabIndex = 6;
            // 
            // buttonSumarGolLocal
            // 
            this.buttonSumarGolLocal.Location = new System.Drawing.Point(120, 121);
            this.buttonSumarGolLocal.Name = "buttonSumarGolLocal";
            this.buttonSumarGolLocal.Size = new System.Drawing.Size(75, 23);
            this.buttonSumarGolLocal.TabIndex = 7;
            this.buttonSumarGolLocal.Text = "Gol";
            this.buttonSumarGolLocal.UseVisualStyleBackColor = true;
            this.buttonSumarGolLocal.Click += new System.EventHandler(this.buttonSumarGolLocal_Click);
            // 
            // buttonRestarGolLocal
            // 
            this.buttonRestarGolLocal.Location = new System.Drawing.Point(228, 121);
            this.buttonRestarGolLocal.Name = "buttonRestarGolLocal";
            this.buttonRestarGolLocal.Size = new System.Drawing.Size(75, 23);
            this.buttonRestarGolLocal.TabIndex = 8;
            this.buttonRestarGolLocal.Text = "Restar";
            this.buttonRestarGolLocal.UseVisualStyleBackColor = true;
            this.buttonRestarGolLocal.Click += new System.EventHandler(this.buttonRestarGolLocal_Click);
            // 
            // buttonSumarGolVisitante
            // 
            this.buttonSumarGolVisitante.Location = new System.Drawing.Point(504, 121);
            this.buttonSumarGolVisitante.Name = "buttonSumarGolVisitante";
            this.buttonSumarGolVisitante.Size = new System.Drawing.Size(75, 23);
            this.buttonSumarGolVisitante.TabIndex = 9;
            this.buttonSumarGolVisitante.Text = "Gol";
            this.buttonSumarGolVisitante.UseVisualStyleBackColor = true;
            this.buttonSumarGolVisitante.Click += new System.EventHandler(this.buttonSumarGolVisitante_Click);
            // 
            // buttonRestarGolVisitante
            // 
            this.buttonRestarGolVisitante.Location = new System.Drawing.Point(605, 121);
            this.buttonRestarGolVisitante.Name = "buttonRestarGolVisitante";
            this.buttonRestarGolVisitante.Size = new System.Drawing.Size(75, 23);
            this.buttonRestarGolVisitante.TabIndex = 10;
            this.buttonRestarGolVisitante.Text = "Restar";
            this.buttonRestarGolVisitante.UseVisualStyleBackColor = true;
            this.buttonRestarGolVisitante.Click += new System.EventHandler(this.buttonRestarGolVisitante_Click);
            // 
            // buttonReiniciar
            // 
            this.buttonReiniciar.Location = new System.Drawing.Point(362, 97);
            this.buttonReiniciar.Name = "buttonReiniciar";
            this.buttonReiniciar.Size = new System.Drawing.Size(75, 23);
            this.buttonReiniciar.TabIndex = 11;
            this.buttonReiniciar.Text = "Reiniciar";
            this.buttonReiniciar.UseVisualStyleBackColor = true;
            this.buttonReiniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReiniciar);
            this.Controls.Add(this.buttonRestarGolVisitante);
            this.Controls.Add(this.buttonSumarGolVisitante);
            this.Controls.Add(this.buttonRestarGolLocal);
            this.Controls.Add(this.buttonSumarGolLocal);
            this.Controls.Add(this.textBoxGolesVisitante);
            this.Controls.Add(this.textBoxGolesLocal);
            this.Controls.Add(this.labelVisitante);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.comboBoxVisitante);
            this.Controls.Add(this.comboboxLocal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboboxLocal;
        private System.Windows.Forms.ComboBox comboBoxVisitante;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.Label labelVisitante;
        private System.Windows.Forms.TextBox textBoxGolesLocal;
        private System.Windows.Forms.TextBox textBoxGolesVisitante;
        private System.Windows.Forms.Button buttonSumarGolLocal;
        private System.Windows.Forms.Button buttonRestarGolLocal;
        private System.Windows.Forms.Button buttonSumarGolVisitante;
        private System.Windows.Forms.Button buttonRestarGolVisitante;
        private System.Windows.Forms.Button buttonReiniciar;
    }
}

