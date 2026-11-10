namespace Lab2DotNetAss
{
    partial class Bicycle
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
            labstart = new Label();
            logout = new Button();
            labend = new Label();
            labfee = new Label();
            textend = new TextBox();
            textfee = new TextBox();
            textstart = new TextBox();
            fee = new Button();
            SuspendLayout();
            // 
            // labstart
            // 
            labstart.AutoSize = true;
            labstart.Location = new Point(12, 64);
            labstart.Name = "labstart";
            labstart.Size = new Size(93, 25);
            labstart.TabIndex = 0;
            labstart.Text = "Start Hour";
            // 
            // logout
            // 
            logout.Location = new Point(215, 261);
            logout.Name = "logout";
            logout.Size = new Size(112, 34);
            logout.TabIndex = 1;
            logout.Text = "LogOut";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // labend
            // 
            labend.AutoSize = true;
            labend.Location = new Point(12, 111);
            labend.Name = "labend";
            labend.Size = new Size(87, 25);
            labend.TabIndex = 2;
            labend.Text = "End Hour";
            // 
            // labfee
            // 
            labfee.AutoSize = true;
            labfee.Location = new Point(12, 155);
            labfee.Name = "labfee";
            labfee.Size = new Size(0, 25);
            labfee.TabIndex = 3;
            labfee.Click += label3_Click;
            // 
            // textend
            // 
            textend.Location = new Point(147, 111);
            textend.Name = "textend";
            textend.Size = new Size(150, 31);
            textend.TabIndex = 4;
            // 
            // textfee
            // 
            textfee.Location = new Point(147, 155);
            textfee.Name = "textfee";
            textfee.Size = new Size(150, 31);
            textfee.TabIndex = 5;
            textfee.TextChanged += textBox2_TextChanged;
            // 
            // textstart
            // 
            textstart.Location = new Point(147, 64);
            textstart.Name = "textstart";
            textstart.Size = new Size(150, 31);
            textstart.TabIndex = 6;
            // 
            // fee
            // 
            fee.Location = new Point(12, 155);
            fee.Name = "fee";
            fee.Size = new Size(112, 34);
            fee.TabIndex = 7;
            fee.Text = "Fees";
            fee.UseVisualStyleBackColor = true;
            fee.Click += fee_Click;
            // 
            // Bicycle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fee);
            Controls.Add(textstart);
            Controls.Add(textfee);
            Controls.Add(textend);
            Controls.Add(labfee);
            Controls.Add(labend);
            Controls.Add(logout);
            Controls.Add(labstart);
            Name = "Bicycle";
            Text = "Bicycle Form";
            Load += Bicycle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labstart;
        private Button logout;
        private Label labend;
        private Label labfee;
        private TextBox textend;
        private TextBox textfee;
        private TextBox textstart;
        private Button fee;
    }
}