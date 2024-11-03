namespace redTaller.Vista.VistaLogin
{
    partial class VistaLoginConfirma
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.labPassword1 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.labPassword2 = new System.Windows.Forms.Label();
            this.textPassword2 = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(410, 240);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 38);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // labPassword1
            // 
            this.labPassword1.AutoSize = true;
            this.labPassword1.Location = new System.Drawing.Point(300, 94);
            this.labPassword1.Name = "labPassword1";
            this.labPassword1.Size = new System.Drawing.Size(129, 20);
            this.labPassword1.TabIndex = 8;
            this.labPassword1.Text = "Nueva Contraseña";
            // 
            // textPassword
            // 
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPassword.Location = new System.Drawing.Point(303, 117);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(189, 20);
            this.textPassword.TabIndex = 9;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // labPassword2
            // 
            this.labPassword2.AutoSize = true;
            this.labPassword2.Location = new System.Drawing.Point(300, 151);
            this.labPassword2.Name = "labPassword2";
            this.labPassword2.Size = new System.Drawing.Size(147, 20);
            this.labPassword2.TabIndex = 10;
            this.labPassword2.Text = "Repita la contraseña:";
            // 
            // textPassword2
            // 
            this.textPassword2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPassword2.Location = new System.Drawing.Point(303, 174);
            this.textPassword2.Name = "textPassword2";
            this.textPassword2.Size = new System.Drawing.Size(189, 20);
            this.textPassword2.TabIndex = 11;
            this.textPassword2.UseSystemPasswordChar = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(304, 240);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 38);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Acceder";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(180, 317);
            this.panelLeft.TabIndex = 7;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(221, 36);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(286, 20);
            this.labelInfo.TabIndex = 14;
            this.labelInfo.Text = "Introduzca su nueva contraseña de acceso";
            // 
            // VistaLoginConfirma
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(541, 317);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.textPassword2);
            this.Controls.Add(this.labPassword2);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.labPassword1);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VistaLoginConfirma";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaLoginConfirma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label labPassword1;
        public System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label labPassword2;
        public System.Windows.Forms.TextBox textPassword2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label labelInfo;
    }
}