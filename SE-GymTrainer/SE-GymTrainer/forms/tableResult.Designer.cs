namespace SE_GymTrainer.forms
{
    partial class tableResult
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
            this.components = new System.ComponentModel.Container();
            this.table = new System.Windows.Forms.DataGridView();
            this.gymTrainerDataSet1 = new SE_GymTrainer.DataSets.GymTrainerDataSet1();
            this.ejerciciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ejerciciosTableAdapter = new SE_GymTrainer.DataSets.GymTrainerDataSet1TableAdapters.ejerciciosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymTrainerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejerciciosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(74, 65);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(944, 416);
            this.table.TabIndex = 0;
            // 
            // gymTrainerDataSet1
            // 
            this.gymTrainerDataSet1.DataSetName = "GymTrainerDataSet1";
            this.gymTrainerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ejerciciosBindingSource
            // 
            this.ejerciciosBindingSource.DataMember = "ejercicios";
            this.ejerciciosBindingSource.DataSource = this.gymTrainerDataSet1;
            // 
            // ejerciciosTableAdapter
            // 
            this.ejerciciosTableAdapter.ClearBeforeFill = true;
            // 
            // tableResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SE_GymTrainer.Properties.Resources.Publicidad_para_gimnasio;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.table);
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "tableResult";
            this.Text = "Ejercicios";
            this.Load += new System.EventHandler(this.tableResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymTrainerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejerciciosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private DataSets.GymTrainerDataSet1 gymTrainerDataSet1;
        private System.Windows.Forms.BindingSource ejerciciosBindingSource;
        private DataSets.GymTrainerDataSet1TableAdapters.ejerciciosTableAdapter ejerciciosTableAdapter;
    }
}