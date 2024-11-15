namespace MarcadorDeportivo
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxLocal = new System.Windows.Forms.ComboBox();
            this.comboBoxVisitante = new System.Windows.Forms.ComboBox();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.textBoxGolesLocal = new System.Windows.Forms.TextBox();
            this.textBoxGolesVisitante = new System.Windows.Forms.TextBox();
            this.buttonSumarGolLocal = new System.Windows.Forms.Button();
            this.buttonRestarGolLocal = new System.Windows.Forms.Button();
            this.buttonSumarGolVisitante = new System.Windows.Forms.Button();
            this.buttonRestarGolVisitante = new System.Windows.Forms.Button();
            this.buttonReiniciar = new System.Windows.Forms.Button();
            this.labelLocal = new System.Windows.Forms.Label();
            this.labelVisitante = new System.Windows.Forms.Label();
            this.btnGolVisitante = new System.Windows.Forms.Button();
            this.btnGolLocal = new System.Windows.Forms.Button();
            this.lstGoles = new System.Windows.Forms.ListBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.timerPartido = new System.Windows.Forms.Timer(this.components);
            this.lblCronometro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxLocal
            // 
            this.comboBoxLocal.FormattingEnabled = true;
            this.comboBoxLocal.Location = new System.Drawing.Point(112, 95);
            this.comboBoxLocal.Name = "comboBoxLocal";
            this.comboBoxLocal.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLocal.TabIndex = 0;
            // 
            // comboBoxVisitante
            // 
            this.comboBoxVisitante.FormattingEnabled = true;
            this.comboBoxVisitante.Location = new System.Drawing.Point(474, 95);
            this.comboBoxVisitante.Name = "comboBoxVisitante";
            this.comboBoxVisitante.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVisitante.TabIndex = 1;
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Location = new System.Drawing.Point(308, 204);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(107, 23);
            this.buttonIniciar.TabIndex = 2;
            this.buttonIniciar.Text = "Iniciar Partido";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // textBoxGolesLocal
            // 
            this.textBoxGolesLocal.Location = new System.Drawing.Point(121, 122);
            this.textBoxGolesLocal.Name = "textBoxGolesLocal";
            this.textBoxGolesLocal.Size = new System.Drawing.Size(100, 20);
            this.textBoxGolesLocal.TabIndex = 5;
            // 
            // textBoxGolesVisitante
            // 
            this.textBoxGolesVisitante.Location = new System.Drawing.Point(483, 122);
            this.textBoxGolesVisitante.Name = "textBoxGolesVisitante";
            this.textBoxGolesVisitante.Size = new System.Drawing.Size(100, 20);
            this.textBoxGolesVisitante.TabIndex = 6;
            // 
            // buttonSumarGolLocal
            // 
            this.buttonSumarGolLocal.Location = new System.Drawing.Point(85, 148);
            this.buttonSumarGolLocal.Name = "buttonSumarGolLocal";
            this.buttonSumarGolLocal.Size = new System.Drawing.Size(75, 23);
            this.buttonSumarGolLocal.TabIndex = 7;
            this.buttonSumarGolLocal.Text = "Gol";
            this.buttonSumarGolLocal.UseVisualStyleBackColor = true;
            this.buttonSumarGolLocal.Click += new System.EventHandler(this.buttonSumarGolLocal_Click);
            // 
            // buttonRestarGolLocal
            // 
            this.buttonRestarGolLocal.Location = new System.Drawing.Point(190, 148);
            this.buttonRestarGolLocal.Name = "buttonRestarGolLocal";
            this.buttonRestarGolLocal.Size = new System.Drawing.Size(75, 23);
            this.buttonRestarGolLocal.TabIndex = 8;
            this.buttonRestarGolLocal.Text = "Restar";
            this.buttonRestarGolLocal.UseVisualStyleBackColor = true;
            this.buttonRestarGolLocal.Click += new System.EventHandler(this.buttonRestarGolLocal_Click);
            // 
            // buttonSumarGolVisitante
            // 
            this.buttonSumarGolVisitante.Location = new System.Drawing.Point(450, 148);
            this.buttonSumarGolVisitante.Name = "buttonSumarGolVisitante";
            this.buttonSumarGolVisitante.Size = new System.Drawing.Size(75, 23);
            this.buttonSumarGolVisitante.TabIndex = 9;
            this.buttonSumarGolVisitante.Text = "Gol";
            this.buttonSumarGolVisitante.UseVisualStyleBackColor = true;
            this.buttonSumarGolVisitante.Click += new System.EventHandler(this.buttonSumarGolVisitante_Click);
            // 
            // buttonRestarGolVisitante
            // 
            this.buttonRestarGolVisitante.Location = new System.Drawing.Point(557, 148);
            this.buttonRestarGolVisitante.Name = "buttonRestarGolVisitante";
            this.buttonRestarGolVisitante.Size = new System.Drawing.Size(75, 23);
            this.buttonRestarGolVisitante.TabIndex = 10;
            this.buttonRestarGolVisitante.Text = "Restar";
            this.buttonRestarGolVisitante.UseVisualStyleBackColor = true;
            this.buttonRestarGolVisitante.Click += new System.EventHandler(this.buttonRestarGolVisitante_Click);
            // 
            // buttonReiniciar
            // 
            this.buttonReiniciar.Location = new System.Drawing.Point(322, 233);
            this.buttonReiniciar.Name = "buttonReiniciar";
            this.buttonReiniciar.Size = new System.Drawing.Size(75, 23);
            this.buttonReiniciar.TabIndex = 11;
            this.buttonReiniciar.Text = "Reiniciar";
            this.buttonReiniciar.UseVisualStyleBackColor = true;
            this.buttonReiniciar.Click += new System.EventHandler(this.buttonReiniciar_Click);
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Location = new System.Drawing.Point(138, 79);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(69, 13);
            this.labelLocal.TabIndex = 12;
            this.labelLocal.Text = "Equipo Local";
            // 
            // labelVisitante
            // 
            this.labelVisitante.AutoSize = true;
            this.labelVisitante.Location = new System.Drawing.Point(500, 79);
            this.labelVisitante.Name = "labelVisitante";
            this.labelVisitante.Size = new System.Drawing.Size(83, 13);
            this.labelVisitante.TabIndex = 13;
            this.labelVisitante.Text = "Equipo Visitante";
            // 
            // btnGolVisitante
            // 
            this.btnGolVisitante.Location = new System.Drawing.Point(503, 192);
            this.btnGolVisitante.Name = "btnGolVisitante";
            this.btnGolVisitante.Size = new System.Drawing.Size(75, 23);
            this.btnGolVisitante.TabIndex = 16;
            this.btnGolVisitante.Text = "Gol Visitante";
            this.btnGolVisitante.UseVisualStyleBackColor = true;
            this.btnGolVisitante.Click += new System.EventHandler(this.btnGolVisitante_Click);
            // 
            // btnGolLocal
            // 
            this.btnGolLocal.Location = new System.Drawing.Point(141, 192);
            this.btnGolLocal.Name = "btnGolLocal";
            this.btnGolLocal.Size = new System.Drawing.Size(75, 23);
            this.btnGolLocal.TabIndex = 17;
            this.btnGolLocal.Text = "Gol Local";
            this.btnGolLocal.UseVisualStyleBackColor = true;
            this.btnGolLocal.Click += new System.EventHandler(this.btnGolLocal_Click);
            // 
            // lstGoles
            // 
            this.lstGoles.FormattingEnabled = true;
            this.lstGoles.Location = new System.Drawing.Point(298, 95);
            this.lstGoles.Name = "lstGoles";
            this.lstGoles.Size = new System.Drawing.Size(130, 95);
            this.lstGoles.TabIndex = 18;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(308, 262);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(106, 23);
            this.btnReiniciar.TabIndex = 20;
            this.btnReiniciar.Text = "Reiniciar Prtido";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // timerPartido
            // 
            this.timerPartido.Tick += new System.EventHandler(this.timerPartido_Tick);
            // 
            // lblCronometro
            // 
            this.lblCronometro.AutoSize = true;
            this.lblCronometro.Location = new System.Drawing.Point(345, 79);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(34, 13);
            this.lblCronometro.TabIndex = 21;
            this.lblCronometro.Text = "00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCronometro);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lstGoles);
            this.Controls.Add(this.btnGolLocal);
            this.Controls.Add(this.btnGolVisitante);
            this.Controls.Add(this.labelVisitante);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.buttonReiniciar);
            this.Controls.Add(this.buttonRestarGolVisitante);
            this.Controls.Add(this.buttonSumarGolVisitante);
            this.Controls.Add(this.buttonRestarGolLocal);
            this.Controls.Add(this.buttonSumarGolLocal);
            this.Controls.Add(this.textBoxGolesVisitante);
            this.Controls.Add(this.textBoxGolesLocal);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.comboBoxVisitante);
            this.Controls.Add(this.comboBoxLocal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLocal;
        private System.Windows.Forms.ComboBox comboBoxVisitante;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.TextBox textBoxGolesLocal;
        private System.Windows.Forms.TextBox textBoxGolesVisitante;
        private System.Windows.Forms.Button buttonSumarGolLocal;
        private System.Windows.Forms.Button buttonRestarGolLocal;
        private System.Windows.Forms.Button buttonSumarGolVisitante;
        private System.Windows.Forms.Button buttonRestarGolVisitante;
        private System.Windows.Forms.Button buttonReiniciar;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.Label labelVisitante;
        private System.Windows.Forms.Button btnGolVisitante;
        private System.Windows.Forms.Button btnGolLocal;
        private System.Windows.Forms.ListBox lstGoles;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Timer timerPartido;
        private System.Windows.Forms.Label lblCronometro;
    }
}

