namespace SE_GymTrainer.forms
{
    partial class Select
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.bttnBajar = new System.Windows.Forms.Button();
            this.btnMantener = new System.Windows.Forms.Button();
            this.btnTonificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(97, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "¿Que Desea Realizar?";
            // 
            // bttnBajar
            // 
            this.bttnBajar.Location = new System.Drawing.Point(28, 151);
            this.bttnBajar.Name = "bttnBajar";
            this.bttnBajar.Size = new System.Drawing.Size(90, 30);
            this.bttnBajar.TabIndex = 1;
            this.bttnBajar.Text = "Bajar de Peso";
            this.bttnBajar.UseVisualStyleBackColor = true;
            this.bttnBajar.Click += new System.EventHandler(this.bttnBajar_Click);
            // 
            // btnMantener
            // 
            this.btnMantener.Location = new System.Drawing.Point(178, 150);
            this.btnMantener.Name = "btnMantener";
            this.btnMantener.Size = new System.Drawing.Size(90, 30);
            this.btnMantener.TabIndex = 2;
            this.btnMantener.Text = "Mantenerme";
            this.btnMantener.UseVisualStyleBackColor = true;
            this.btnMantener.Click += new System.EventHandler(this.btnMantener_Click);
            // 
            // btnTonificar
            // 
            this.btnTonificar.Location = new System.Drawing.Point(336, 149);
            this.btnTonificar.Name = "btnTonificar";
            this.btnTonificar.Size = new System.Drawing.Size(90, 30);
            this.btnTonificar.TabIndex = 3;
            this.btnTonificar.Text = "Tonificar";
            this.btnTonificar.UseVisualStyleBackColor = true;
            this.btnTonificar.Click += new System.EventHandler(this.btnTonificar_Click);
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 261);
            this.Controls.Add(this.btnTonificar);
            this.Controls.Add(this.btnMantener);
            this.Controls.Add(this.bttnBajar);
            this.Controls.Add(this.lblTitle);
            this.Name = "Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select";
            this.Load += new System.EventHandler(this.Select_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button bttnBajar;
        private System.Windows.Forms.Button btnMantener;
        private System.Windows.Forms.Button btnTonificar;
    }
}