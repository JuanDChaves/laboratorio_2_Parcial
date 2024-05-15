namespace FrmAtencion
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
            btnAtender = new Button();
            btnSalir = new Button();
            rtbInfoMedico = new RichTextBox();
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            lblMedicos = new Label();
            lblPacientes = new Label();
            SuspendLayout();
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(887, 64);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(163, 86);
            btnAtender.TabIndex = 0;
            btnAtender.Text = "ATENDER";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(887, 418);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(163, 86);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // rtbInfoMedico
            // 
            rtbInfoMedico.Location = new Point(191, 341);
            rtbInfoMedico.Name = "rtbInfoMedico";
            rtbInfoMedico.Size = new Size(552, 188);
            rtbInfoMedico.TabIndex = 2;
            rtbInfoMedico.Text = "";
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 20;
            lstMedicos.Location = new Point(42, 64);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(396, 244);
            lstMedicos.TabIndex = 3;
            lstMedicos.SelectedIndexChanged += lstMedicos_SelectedIndexChanged;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 20;
            lstPacientes.Location = new Point(488, 64);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(374, 244);
            lstPacientes.TabIndex = 4;
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Location = new Point(75, 33);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(118, 20);
            lblMedicos.TabIndex = 5;
            lblMedicos.Text = "Personal Medico";
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Location = new Point(521, 35);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(70, 20);
            lblPacientes.TabIndex = 6;
            lblPacientes.Text = "Pacientes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 568);
            Controls.Add(lblPacientes);
            Controls.Add(lblMedicos);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Controls.Add(rtbInfoMedico);
            Controls.Add(btnSalir);
            Controls.Add(btnAtender);
            Name = "Form1";
            Text = "Juan David Chaves";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtender;
        private Button btnSalir;
        private RichTextBox rtbInfoMedico;
        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private Label lblMedicos;
        private Label lblPacientes;
    }
}
