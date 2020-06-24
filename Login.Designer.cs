namespace Pizza_Hut
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this._iniciodesession = new System.Windows.Forms.Button();
            this._txtCuenta = new System.Windows.Forms.TextBox();
            this._txtPass = new System.Windows.Forms.TextBox();
            this._lbCuenta = new System.Windows.Forms.Label();
            this._lbPass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _iniciodesession
            // 
            this._iniciodesession.Location = new System.Drawing.Point(129, 231);
            this._iniciodesession.Name = "_iniciodesession";
            this._iniciodesession.Size = new System.Drawing.Size(75, 23);
            this._iniciodesession.TabIndex = 0;
            this._iniciodesession.Text = "Ingresar";
            this._iniciodesession.UseVisualStyleBackColor = true;
            this._iniciodesession.Click += new System.EventHandler(this._iniciodesession_Click);
            // 
            // _txtCuenta
            // 
            this._txtCuenta.Location = new System.Drawing.Point(117, 131);
            this._txtCuenta.Name = "_txtCuenta";
            this._txtCuenta.Size = new System.Drawing.Size(100, 20);
            this._txtCuenta.TabIndex = 1;
            // 
            // _txtPass
            // 
            this._txtPass.Location = new System.Drawing.Point(117, 184);
            this._txtPass.Name = "_txtPass";
            this._txtPass.PasswordChar = '*';
            this._txtPass.Size = new System.Drawing.Size(100, 20);
            this._txtPass.TabIndex = 2;
            // 
            // _lbCuenta
            // 
            this._lbCuenta.AutoSize = true;
            this._lbCuenta.Location = new System.Drawing.Point(143, 115);
            this._lbCuenta.Name = "_lbCuenta";
            this._lbCuenta.Size = new System.Drawing.Size(41, 13);
            this._lbCuenta.TabIndex = 3;
            this._lbCuenta.Text = "Cuenta";
            // 
            // _lbPass
            // 
            this._lbPass.AutoSize = true;
            this._lbPass.Location = new System.Drawing.Point(133, 168);
            this._lbPass.Name = "_lbPass";
            this._lbPass.Size = new System.Drawing.Size(64, 13);
            this._lbPass.TabIndex = 4;
            this._lbPass.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sistema de caja";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtCuenta);
            this.Controls.Add(this._iniciodesession);
            this.Controls.Add(this._txtPass);
            this.Controls.Add(this._lbPass);
            this.Controls.Add(this._lbCuenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 350);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "Login";
            this.Text = "Pizzhat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _iniciodesession;
        private System.Windows.Forms.TextBox _txtCuenta;
        private System.Windows.Forms.TextBox _txtPass;
        private System.Windows.Forms.Label _lbCuenta;
        private System.Windows.Forms.Label _lbPass;
        private System.Windows.Forms.Label label1;
    }
}

