namespace Lab_1
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
            btnClick = new Button();
            lblHelloWorld = new Label();
            pictureBox1 = new PictureBox();
            lblBatter = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnClick
            // 
            btnClick.Location = new Point(689, 65);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(112, 34);
            btnClick.TabIndex = 0;
            btnClick.Text = "Ввод";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.AutoSize = true;
            lblHelloWorld.Location = new Point(623, 163);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(0, 25);
            lblHelloWorld.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources._111;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(659, 360);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblBatter
            // 
            lblBatter.AutoSize = true;
            lblBatter.BackColor = SystemColors.ActiveCaptionText;
            lblBatter.ForeColor = SystemColors.ButtonHighlight;
            lblBatter.Location = new Point(564, 334);
            lblBatter.Name = "lblBatter";
            lblBatter.Size = new Size(0, 25);
            lblBatter.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(689, 329);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lblBatter);
            Controls.Add(pictureBox1);
            Controls.Add(lblHelloWorld);
            Controls.Add(btnClick);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClick;
        private Label lblHelloWorld;
        private PictureBox pictureBox1;
        private Label lblBatter;
        private Button button1;
    }
}
