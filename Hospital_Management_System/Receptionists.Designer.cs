namespace Hospital_Management_System
{
    partial class receptionistMenu
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
            appointBtn = new Button();
            treatmentsBtn = new Button();
            patientBtn = new Button();
            logOBtn = new Button();
            dataGridView1 = new DataGridView();
            receptionLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // appointBtn
            // 
            appointBtn.BackColor = SystemColors.ActiveCaption;
            appointBtn.Font = new Font("HP Simplified", 8.999999F);
            appointBtn.Location = new Point(9, 384);
            appointBtn.Name = "appointBtn";
            appointBtn.Size = new Size(127, 54);
            appointBtn.TabIndex = 0;
            appointBtn.Text = "Appointements";
            appointBtn.UseVisualStyleBackColor = false;
            // 
            // treatmentsBtn
            // 
            treatmentsBtn.BackColor = SystemColors.ActiveCaption;
            treatmentsBtn.Font = new Font("HP Simplified", 8.999999F);
            treatmentsBtn.Location = new Point(275, 384);
            treatmentsBtn.Name = "treatmentsBtn";
            treatmentsBtn.Size = new Size(127, 54);
            treatmentsBtn.TabIndex = 2;
            treatmentsBtn.Text = "Treatments";
            treatmentsBtn.UseVisualStyleBackColor = false;
            // 
            // patientBtn
            // 
            patientBtn.BackColor = SystemColors.ActiveCaption;
            patientBtn.Font = new Font("HP Simplified", 8.999999F);
            patientBtn.Location = new Point(142, 384);
            patientBtn.Name = "patientBtn";
            patientBtn.Size = new Size(127, 54);
            patientBtn.TabIndex = 3;
            patientBtn.Text = "Patients";
            patientBtn.UseVisualStyleBackColor = false;
            // 
            // logOBtn
            // 
            logOBtn.BackColor = SystemColors.ActiveCaption;
            logOBtn.Font = new Font("HP Simplified", 8.999999F);
            logOBtn.Location = new Point(677, 384);
            logOBtn.Name = "logOBtn";
            logOBtn.Size = new Size(108, 54);
            logOBtn.TabIndex = 4;
            logOBtn.Text = "Log Out";
            logOBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 320);
            dataGridView1.TabIndex = 5;
            // 
            // receptionLbl
            // 
            receptionLbl.AutoSize = true;
            receptionLbl.Font = new Font("HP Simplified", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            receptionLbl.Location = new Point(202, 9);
            receptionLbl.Name = "receptionLbl";
            receptionLbl.Size = new Size(394, 37);
            receptionLbl.TabIndex = 6;
            receptionLbl.Text = "Receptionist's Control Panel";
            // 
            // receptionistMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(receptionLbl);
            Controls.Add(dataGridView1);
            Controls.Add(logOBtn);
            Controls.Add(patientBtn);
            Controls.Add(treatmentsBtn);
            Controls.Add(appointBtn);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "receptionistMenu";
            Text = "Receptionist's Menu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button appointBtn;
        private Button treatmentsBtn;
        private Button patientBtn;
        private Button logOBtn;
        private DataGridView dataGridView1;
        private Label receptionLbl;
    }
}