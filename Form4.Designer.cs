namespace Lab2DotNetAss
{
    partial class mushroom
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
            labmushroom = new Label();
            textmushroom = new TextBox();
            Identify = new Button();
            logout = new Button();
            SuspendLayout();
            // 
            // labmushroom
            // 
            labmushroom.AutoSize = true;
            labmushroom.Location = new Point(12, 107);
            labmushroom.Name = "labmushroom";
            labmushroom.Size = new Size(100, 25);
            labmushroom.TabIndex = 0;
            labmushroom.Text = "Mushroom";
            // 
            // textmushroom
            // 
            textmushroom.Location = new Point(118, 107);
            textmushroom.Name = "textmushroom";
            textmushroom.Size = new Size(150, 31);
            textmushroom.TabIndex = 1;
            // 
            // Identify
            // 
            Identify.Location = new Point(60, 198);
            Identify.Name = "Identify";
            Identify.Size = new Size(112, 34);
            Identify.TabIndex = 2;
            Identify.Text = "Identify";
            Identify.UseVisualStyleBackColor = true;
            Identify.Click += Identify_Click_1;
            // 
            // logout
            // 
            logout.Location = new Point(344, 208);
            logout.Name = "logout";
            logout.Size = new Size(112, 34);
            logout.TabIndex = 3;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // mushroom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logout);
            Controls.Add(Identify);
            Controls.Add(textmushroom);
            Controls.Add(labmushroom);
            Name = "mushroom";
            Text = "Mushroom Form";
            Load += mushroom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labmushroom;
        private TextBox textmushroom;
        private Button Identify;
        private Button logout;
    }
}