namespace Lab2DotNetAss
{
    partial class Menu
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
            mushroom = new Button();
            bicycle = new Button();
            SuspendLayout();
            // 
            // mushroom
            // 
            mushroom.Location = new Point(471, 103);
            mushroom.Name = "mushroom";
            mushroom.Size = new Size(204, 53);
            mushroom.TabIndex = 0;
            mushroom.Text = "Mushroom Form";
            mushroom.UseVisualStyleBackColor = true;
            mushroom.Click += mushroom_Click;
            // 
            // bicycle
            // 
            bicycle.Location = new Point(77, 103);
            bicycle.Name = "bicycle";
            bicycle.Size = new Size(168, 53);
            bicycle.TabIndex = 1;
            bicycle.Text = "BicycleForm";
            bicycle.UseVisualStyleBackColor = true;
            bicycle.Click += bicycle_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bicycle);
            Controls.Add(mushroom);
            Name = "Menu";
            Text = "Menu Form";
            ResumeLayout(false);
        }

        #endregion

        private Button mushroom;
        private Button bicycle;
    }
}