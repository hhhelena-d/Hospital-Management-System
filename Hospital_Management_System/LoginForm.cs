namespace Hospital_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            logInBtn = new Button();
            nameTxtBox = new TextBox();
            phonetxtBox = new TextBox();
            passwordTxtBox = new TextBox();
            RolecomboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Image = Properties.Resources.icon_png;
            pictureBox1.Location = new Point(149, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 330);
            label1.Name = "label1";
            label1.Size = new Size(41, 17);
            label1.TabIndex = 6;
            label1.Text = "Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 384);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(71, 274);
            label3.Name = "label3";
            label3.Size = new Size(116, 17);
            label3.TabIndex = 8;
            label3.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(71, 219);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 9;
            label4.Text = "Full Name";
            // 
            // logInBtn
            // 
            logInBtn.BackColor = Color.CornflowerBlue;
            logInBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logInBtn.Location = new Point(149, 477);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(141, 65);
            logInBtn.TabIndex = 11;
            logInBtn.Text = "Log In";
            logInBtn.UseVisualStyleBackColor = false;
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(71, 244);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(298, 27);
            nameTxtBox.TabIndex = 12;
            // 
            // phonetxtBox
            // 
            phonetxtBox.Location = new Point(71, 294);
            phonetxtBox.Name = "phonetxtBox";
            phonetxtBox.Size = new Size(298, 27);
            phonetxtBox.TabIndex = 13;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Location = new Point(71, 404);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.Size = new Size(298, 27);
            passwordTxtBox.TabIndex = 14;
            // 
            // RolecomboBox
            // 
            RolecomboBox.FormattingEnabled = true;
            RolecomboBox.Location = new Point(71, 350);
            RolecomboBox.Name = "RolecomboBox";
            RolecomboBox.Size = new Size(298, 28);
            RolecomboBox.TabIndex = 15;
            // 
            // LoginForm
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(444, 626);
            Controls.Add(RolecomboBox);
            Controls.Add(passwordTxtBox);
            Controls.Add(phonetxtBox);
            Controls.Add(nameTxtBox);
            Controls.Add(logInBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = Color.Transparent;
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nameTxtBox;
        private TextBox phonetxtBox;
        private TextBox passwordTxtBox;
        private ComboBox RolecomboBox;
        private Button logInBtn;

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
