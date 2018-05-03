namespace AccessXSDDataAccess
{
    partial class Form1
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
            this.patientsTableAdapter1 = new AccessXSDDataAccess.DataSetTableAdapters.PatientsTableAdapter();
            this.PatientData = new System.Windows.Forms.BindingSource(this.components);
            this.maindataset = new AccessXSDDataAccess.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.PatientData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maindataset)).BeginInit();
            this.SuspendLayout();
            // 
            // patientsTableAdapter1
            // 
            this.patientsTableAdapter1.ClearBeforeFill = true;
            // 
            // maindataset
            // 
            this.maindataset.DataSetName = "DataSet";
            this.maindataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PatientData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maindataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource PatientData;
        private DataSetTableAdapters.PatientsTableAdapter patientsTableAdapter1;
        private DataSet maindataset;
    }
}

