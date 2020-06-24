namespace Pizza_Hut
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.gvCliente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._rbIndividual = new System.Windows.Forms.RadioButton();
            this._rbMediana = new System.Windows.Forms.RadioButton();
            this._rbFamiliar = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._rbNull = new System.Windows.Forms.RadioButton();
            this._rbBebidaInd = new System.Windows.Forms.RadioButton();
            this._rbBebidaFam = new System.Windows.Forms.RadioButton();
            this._btAgregar = new System.Windows.Forms.Button();
            this._btnCerrar = new System.Windows.Forms.Button();
            this._lbTotal = new System.Windows.Forms.Label();
            this._lbMontoTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvCliente
            // 
            this.gvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCliente.Location = new System.Drawing.Point(62, 202);
            this.gvCliente.Name = "gvCliente";
            this.gvCliente.Size = new System.Drawing.Size(442, 150);
            this.gvCliente.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._rbIndividual);
            this.groupBox1.Controls.Add(this._rbMediana);
            this.groupBox1.Controls.Add(this._rbFamiliar);
            this.groupBox1.Location = new System.Drawing.Point(62, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza";
            // 
            // _rbIndividual
            // 
            this._rbIndividual.AutoSize = true;
            this._rbIndividual.Location = new System.Drawing.Point(6, 65);
            this._rbIndividual.Name = "_rbIndividual";
            this._rbIndividual.Size = new System.Drawing.Size(106, 17);
            this._rbIndividual.TabIndex = 3;
            this._rbIndividual.TabStop = true;
            this._rbIndividual.Text = "Individual $8.000";
            this._rbIndividual.UseVisualStyleBackColor = true;
            // 
            // _rbMediana
            // 
            this._rbMediana.AutoSize = true;
            this._rbMediana.Location = new System.Drawing.Point(6, 42);
            this._rbMediana.Name = "_rbMediana";
            this._rbMediana.Size = new System.Drawing.Size(108, 17);
            this._rbMediana.TabIndex = 2;
            this._rbMediana.TabStop = true;
            this._rbMediana.Text = "Mediana $12.000";
            this._rbMediana.UseVisualStyleBackColor = true;
            // 
            // _rbFamiliar
            // 
            this._rbFamiliar.AutoSize = true;
            this._rbFamiliar.Location = new System.Drawing.Point(6, 19);
            this._rbFamiliar.Name = "_rbFamiliar";
            this._rbFamiliar.Size = new System.Drawing.Size(102, 17);
            this._rbFamiliar.TabIndex = 1;
            this._rbFamiliar.TabStop = true;
            this._rbFamiliar.Text = "Familiar $22.000";
            this._rbFamiliar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._rbNull);
            this.groupBox2.Controls.Add(this._rbBebidaInd);
            this.groupBox2.Controls.Add(this._rbBebidaFam);
            this.groupBox2.Location = new System.Drawing.Point(304, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregado";
            // 
            // _rbNull
            // 
            this._rbNull.AutoSize = true;
            this._rbNull.Location = new System.Drawing.Point(6, 65);
            this._rbNull.Name = "_rbNull";
            this._rbNull.Size = new System.Drawing.Size(88, 17);
            this._rbNull.TabIndex = 3;
            this._rbNull.TabStop = true;
            this._rbNull.Text = "Sin agregado";
            this._rbNull.UseVisualStyleBackColor = true;
            // 
            // _rbBebidaInd
            // 
            this._rbBebidaInd.AutoSize = true;
            this._rbBebidaInd.Location = new System.Drawing.Point(6, 19);
            this._rbBebidaInd.Name = "_rbBebidaInd";
            this._rbBebidaInd.Size = new System.Drawing.Size(106, 17);
            this._rbBebidaInd.TabIndex = 2;
            this._rbBebidaInd.TabStop = true;
            this._rbBebidaInd.Text = "Individual $1.500";
            this._rbBebidaInd.UseVisualStyleBackColor = true;
            // 
            // _rbBebidaFam
            // 
            this._rbBebidaFam.AutoSize = true;
            this._rbBebidaFam.Location = new System.Drawing.Point(6, 42);
            this._rbBebidaFam.Name = "_rbBebidaFam";
            this._rbBebidaFam.Size = new System.Drawing.Size(96, 17);
            this._rbBebidaFam.TabIndex = 1;
            this._rbBebidaFam.TabStop = true;
            this._rbBebidaFam.Text = "Familiar $5.000";
            this._rbBebidaFam.UseVisualStyleBackColor = true;
            // 
            // _btAgregar
            // 
            this._btAgregar.Location = new System.Drawing.Point(68, 158);
            this._btAgregar.Name = "_btAgregar";
            this._btAgregar.Size = new System.Drawing.Size(108, 23);
            this._btAgregar.TabIndex = 3;
            this._btAgregar.Text = "Agregar pedido";
            this._btAgregar.UseVisualStyleBackColor = true;
            this._btAgregar.Click += new System.EventHandler(this._btAgregar_Click);
            // 
            // _btnCerrar
            // 
            this._btnCerrar.Location = new System.Drawing.Point(308, 158);
            this._btnCerrar.Name = "_btnCerrar";
            this._btnCerrar.Size = new System.Drawing.Size(108, 23);
            this._btnCerrar.TabIndex = 4;
            this._btnCerrar.Text = "Cerrar caja";
            this._btnCerrar.UseVisualStyleBackColor = true;
            this._btnCerrar.Click += new System.EventHandler(this._btnCerrar_Click);
            // 
            // _lbTotal
            // 
            this._lbTotal.AutoSize = true;
            this._lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbTotal.ForeColor = System.Drawing.Color.Red;
            this._lbTotal.Location = new System.Drawing.Point(59, 386);
            this._lbTotal.Name = "_lbTotal";
            this._lbTotal.Size = new System.Drawing.Size(48, 16);
            this._lbTotal.TabIndex = 5;
            this._lbTotal.Text = "Total:";
            // 
            // _lbMontoTotal
            // 
            this._lbMontoTotal.AutoSize = true;
            this._lbMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbMontoTotal.Location = new System.Drawing.Point(113, 388);
            this._lbMontoTotal.Name = "_lbMontoTotal";
            this._lbMontoTotal.Size = new System.Drawing.Size(0, 16);
            this._lbMontoTotal.TabIndex = 6;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 428);
            this.Controls.Add(this._lbMontoTotal);
            this.Controls.Add(this._lbTotal);
            this.Controls.Add(this._btnCerrar);
            this.Controls.Add(this._btAgregar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gvCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(553, 467);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(553, 467);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.gvCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton _rbMediana;
        private System.Windows.Forms.RadioButton _rbFamiliar;
        private System.Windows.Forms.RadioButton _rbIndividual;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton _rbBebidaInd;
        private System.Windows.Forms.RadioButton _rbBebidaFam;
        private System.Windows.Forms.Button _btAgregar;
        private System.Windows.Forms.Button _btnCerrar;
        private System.Windows.Forms.RadioButton _rbNull;
        private System.Windows.Forms.Label _lbTotal;
        private System.Windows.Forms.Label _lbMontoTotal;
    }
}