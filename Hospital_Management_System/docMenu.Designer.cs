namespace Hospital_Management_System
{
    partial class docMenu
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
            appBtn = new Button();
            viewPBtn = new Button();
            editPBtn = new Button();
            treatBtn = new Button();
            logOutBtn = new Button();
            dataGridView1 = new DataGridView();
            doctorLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // appBtn
            // 
            appBtn.BackColor = SystemColors.ActiveCaption;
            appBtn.Font = new Font("HP Simplified", 8.999999F);
            appBtn.ForeColor = SystemColors.ActiveCaptionText;
            appBtn.Location = new Point(12, 380);
            appBtn.Name = "appBtn";
            appBtn.Size = new Size(157, 58);
            appBtn.TabIndex = 0;
            appBtn.Text = "View appointments";
            appBtn.UseVisualStyleBackColor = false;
            // 
            // viewPBtn
            // 
            viewPBtn.BackColor = SystemColors.ActiveCaption;
            viewPBtn.Font = new Font("HP Simplified", 8.999999F);
            viewPBtn.ForeColor = SystemColors.ActiveCaptionText;
            viewPBtn.Location = new Point(175, 380);
            viewPBtn.Name = "viewPBtn";
            viewPBtn.Size = new Size(135, 58);
            viewPBtn.TabIndex = 1;
            viewPBtn.Text = "View patients";
            viewPBtn.UseVisualStyleBackColor = false;
            // 
            // editPBtn
            // 
            editPBtn.BackColor = SystemColors.ActiveCaption;
            editPBtn.Font = new Font("HP Simplified", 8.999999F);
            editPBtn.ForeColor = SystemColors.ActiveCaptionText;
            editPBtn.Location = new Point(316, 380);
            editPBtn.Name = "editPBtn";
            editPBtn.Size = new Size(135, 58);
            editPBtn.TabIndex = 2;
            editPBtn.Text = "Edit patients";
            editPBtn.UseVisualStyleBackColor = false;
            // 
            // treatBtn
            // 
            treatBtn.BackColor = SystemColors.ActiveCaption;
            treatBtn.Font = new Font("HP Simplified", 8.999999F);
            treatBtn.ForeColor = SystemColors.ActiveCaptionText;
            treatBtn.Location = new Point(457, 380);
            treatBtn.Name = "treatBtn";
            treatBtn.Size = new Size(143, 58);
            treatBtn.TabIndex = 3;
            treatBtn.Text = "Treatment's list";
            treatBtn.UseVisualStyleBackColor = false;
            treatBtn.Click += button4_Click_1;
            // 
            // logOutBtn
            // 
            logOutBtn.BackColor = SystemColors.ActiveCaption;
            logOutBtn.Font = new Font("HP Simplified", 8.999999F);
            logOutBtn.ForeColor = SystemColors.ActiveCaptionText;
            logOutBtn.Location = new Point(676, 380);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(112, 58);
            logOutBtn.TabIndex = 4;
            logOutBtn.Text = "Log Out";
            logOutBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 314);
            dataGridView1.TabIndex = 5;
            // 
            // doctorLbl
            // 
            doctorLbl.AutoSize = true;
            doctorLbl.Font = new Font("HP Simplified", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorLbl.Location = new Point(239, 11);
            doctorLbl.Name = "doctorLbl";
            doctorLbl.Size = new Size(317, 37);
            doctorLbl.TabIndex = 6;
            doctorLbl.Text = "Doctor's Control Panel";
            // 
            // docMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(doctorLbl);
            Controls.Add(dataGridView1);
            Controls.Add(logOutBtn);
            Controls.Add(treatBtn);
            Controls.Add(editPBtn);
            Controls.Add(viewPBtn);
            Controls.Add(appBtn);
            Name = "docMenu";
            Text = "Doctor's Menu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button appBtn;
        private Button viewPBtn;
        private Button editPBtn;
        private Button treatBtn;
        private Button logOutBtn;
        private DataGridView dataGridView1;
        private Label doctorLbl;
    }
}