namespace SoundPanelProto
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
            PanelContainer1 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            Prev_btn = new Button();
            Next_Btn = new Button();
            PanelContainer5 = new Panel();
            PanelContainer4 = new Panel();
            PanelContainer2 = new Panel();
            PanelContainer3 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            LoadablePnl1 = new Panel();
            button2 = new Button();
            FilenameLbl1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelContainer3.SuspendLayout();
            panel1.SuspendLayout();
            LoadablePnl1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelContainer1
            // 
            PanelContainer1.BorderStyle = BorderStyle.FixedSingle;
            PanelContainer1.Location = new Point(48, 200);
            PanelContainer1.Name = "PanelContainer1";
            PanelContainer1.Size = new Size(109, 169);
            PanelContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = Properties.Resources._default;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(31, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 90);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(31, 179);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 0;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Prev_btn
            // 
            Prev_btn.Location = new Point(12, 209);
            Prev_btn.Name = "Prev_btn";
            Prev_btn.Size = new Size(24, 160);
            Prev_btn.TabIndex = 0;
            Prev_btn.Text = "<";
            Prev_btn.UseVisualStyleBackColor = true;
            // 
            // Next_Btn
            // 
            Next_Btn.Location = new Point(780, 209);
            Next_Btn.Name = "Next_Btn";
            Next_Btn.Size = new Size(24, 160);
            Next_Btn.TabIndex = 1;
            Next_Btn.Text = ">";
            Next_Btn.UseVisualStyleBackColor = true;
            Next_Btn.Click += Next_Btn_Click;
            // 
            // PanelContainer5
            // 
            PanelContainer5.BorderStyle = BorderStyle.FixedSingle;
            PanelContainer5.Location = new Point(661, 200);
            PanelContainer5.Name = "PanelContainer5";
            PanelContainer5.Size = new Size(109, 169);
            PanelContainer5.TabIndex = 1;
            // 
            // PanelContainer4
            // 
            PanelContainer4.BorderStyle = BorderStyle.FixedSingle;
            PanelContainer4.Location = new Point(508, 176);
            PanelContainer4.Name = "PanelContainer4";
            PanelContainer4.Size = new Size(139, 218);
            PanelContainer4.TabIndex = 2;
            // 
            // PanelContainer2
            // 
            PanelContainer2.BorderStyle = BorderStyle.FixedSingle;
            PanelContainer2.Location = new Point(171, 176);
            PanelContainer2.Name = "PanelContainer2";
            PanelContainer2.Size = new Size(139, 218);
            PanelContainer2.TabIndex = 3;
            // 
            // PanelContainer3
            // 
            PanelContainer3.BorderStyle = BorderStyle.FixedSingle;
            PanelContainer3.Controls.Add(panel1);
            PanelContainer3.Location = new Point(331, 153);
            PanelContainer3.Name = "PanelContainer3";
            PanelContainer3.Size = new Size(161, 259);
            PanelContainer3.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(159, 257);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(57, 225);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // LoadablePnl1
            // 
            LoadablePnl1.BackColor = SystemColors.GradientInactiveCaption;
            LoadablePnl1.Controls.Add(button2);
            LoadablePnl1.Controls.Add(FilenameLbl1);
            LoadablePnl1.Location = new Point(342, 65);
            LoadablePnl1.Name = "LoadablePnl1";
            LoadablePnl1.Size = new Size(139, 218);
            LoadablePnl1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(21, 92);
            button2.Name = "button2";
            button2.Size = new Size(90, 23);
            button2.TabIndex = 2;
            button2.Text = "Play";
            button2.UseVisualStyleBackColor = true;
            // 
            // FilenameLbl1
            // 
            FilenameLbl1.Anchor = AnchorStyles.None;
            FilenameLbl1.AutoSize = true;
            FilenameLbl1.Location = new Point(47, 135);
            FilenameLbl1.Name = "FilenameLbl1";
            FilenameLbl1.Size = new Size(27, 15);
            FilenameLbl1.TabIndex = 5;
            FilenameLbl1.Text = "null";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 447);
            Controls.Add(PanelContainer3);
            Controls.Add(PanelContainer2);
            Controls.Add(PanelContainer4);
            Controls.Add(PanelContainer5);
            Controls.Add(Next_Btn);
            Controls.Add(Prev_btn);
            Controls.Add(PanelContainer1);
            Controls.Add(LoadablePnl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelContainer3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            LoadablePnl1.ResumeLayout(false);
            LoadablePnl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelContainer1;
        private Button Prev_btn;
        private Button Next_Btn;
        private Panel PanelContainer5;
        private Panel PanelContainer4;
        private Panel PanelContainer2;
        private Panel PanelContainer3;
        private PictureBox pictureBox1;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private Panel LoadablePnl1;
        private Button button2;
        private Label FilenameLbl1;
    }
}