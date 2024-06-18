namespace Practice_Excel
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
            dtgContent = new DataGridView();
            Brand = new DataGridViewTextBoxColumn();
            Model = new DataGridViewTextBoxColumn();
            Motor = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            btnSaveAsExcel = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgContent).BeginInit();
            SuspendLayout();
            // 
            // dtgContent
            // 
            dtgContent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgContent.Columns.AddRange(new DataGridViewColumn[] { Brand, Model, Motor, Price });
            dtgContent.Location = new Point(62, 59);
            dtgContent.Name = "dtgContent";
            dtgContent.Size = new Size(442, 181);
            dtgContent.TabIndex = 0;
            // 
            // Brand
            // 
            Brand.HeaderText = "Brand";
            Brand.Name = "Brand";
            // 
            // Model
            // 
            Model.HeaderText = "Model";
            Model.Name = "Model";
            // 
            // Motor
            // 
            Motor.HeaderText = "Motor";
            Motor.Name = "Motor";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // btnSaveAsExcel
            // 
            btnSaveAsExcel.Location = new Point(62, 272);
            btnSaveAsExcel.Name = "btnSaveAsExcel";
            btnSaveAsExcel.Size = new Size(111, 50);
            btnSaveAsExcel.TabIndex = 1;
            btnSaveAsExcel.Text = "Save as Excel File";
            btnSaveAsExcel.UseVisualStyleBackColor = true;
            btnSaveAsExcel.Click += btnSaveAsExcel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 16.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(249, 21);
            label1.Name = "label1";
            label1.Size = new Size(95, 29);
            label1.TabIndex = 2;
            label1.Text = "Car Info";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 383);
            Controls.Add(label1);
            Controls.Add(btnSaveAsExcel);
            Controls.Add(dtgContent);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgContent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgContent;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn Motor;
        private DataGridViewTextBoxColumn Price;
        private Button btnSaveAsExcel;
        private Label label1;
    }
}
