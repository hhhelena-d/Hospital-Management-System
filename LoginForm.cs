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
            nameTxtBox = new TextBox();
            phoneTxtBox = new TextBox();
            passTxtBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            roleCmb = new ComboBox();
            logInBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.icon_png;
            pictureBox1.Location = new Point(278, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(206, 227);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(242, 27);
            nameTxtBox.TabIndex = 2;
            // 
            // phoneTxtBox
            // 
            phoneTxtBox.Location = new Point(206, 280);
            phoneTxtBox.Name = "phoneTxtBox";
            phoneTxtBox.Size = new Size(242, 27);
            phoneTxtBox.TabIndex = 3;
            // 
            // passTxtBox
            // 
            passTxtBox.Location = new Point(206, 390);
            passTxtBox.Name = "passTxtBox";
            passTxtBox.PasswordChar = '*';
            passTxtBox.Size = new Size(242, 27);
            passTxtBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(206, 316);
            label1.Name = "label1";
            label1.Size = new Size(41, 17);
            label1.TabIndex = 6;
            label1.Text = "Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(206, 370);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(206, 260);
            label3.Name = "label3";
            label3.Size = new Size(116, 17);
            label3.TabIndex = 8;
            label3.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(206, 205);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 9;
            label4.Text = "Full Name";
            // 
            // roleCmb
            // 
            roleCmb.AllowDrop = true;
            roleCmb.FormattingEnabled = true;
            roleCmb.Items.AddRange(new object[] { "Doctor", "Receptionist", "Admin" });
            roleCmb.Location = new Point(206, 337);
            roleCmb.Name = "roleCmb";
            roleCmb.Size = new Size(242, 28);
            roleCmb.TabIndex = 10;
            // 
            // logInBtn
            // 
            logInBtn.BackColor = Color.CornflowerBlue;
            logInBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logInBtn.Location = new Point(247, 433);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(153, 49);
            logInBtn.TabIndex = 11;
            logInBtn.Text = "Log In";
            logInBtn.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(646, 626);
            Controls.Add(logInBtn);
            Controls.Add(roleCmb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passTxtBox);
            Controls.Add(phoneTxtBox);
            Controls.Add(nameTxtBox);
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
        private TextBox nameTxtBox;
        private TextBox phoneTxtBox;
        private TextBox passTxtBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox roleCmb;
        private Button logInBtn;
    }
}
