namespace Hospital_Management_System
{
    partial class AdminMenu
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("HP Simplified", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 78);
            button1.Name = "button1";
            button1.Size = new Size(173, 49);
            button1.TabIndex = 0;
            button1.Text = "Manage doctors";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("HP Simplified", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 389);
            button2.Name = "button2";
            button2.Size = new Size(173, 49);
            button2.TabIndex = 1;
            button2.Text = "Log Out";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("HP Simplified", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 211);
            button3.Name = "button3";
            button3.Size = new Size(173, 49);
            button3.TabIndex = 2;
            button3.Text = "Manage patients";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("HP Simplified", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(12, 144);
            button4.Name = "button4";
            button4.Size = new Size(173, 49);
            button4.TabIndex = 3;
            button4.Text = "Manage receptionists";
            button4.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(214, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(574, 360);
            dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HP Simplified", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(353, 23);
            label1.Name = "label1";
            label1.Size = new Size(256, 37);
            label1.TabIndex = 5;
            label1.Text = "Admin Dashboard";
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(808, 458);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AdminMenu";
            Text = "AdminMenu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label1;
    }
}