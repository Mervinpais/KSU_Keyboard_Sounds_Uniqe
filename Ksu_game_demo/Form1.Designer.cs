namespace Ksu_game_demo
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
            PlayBTN = new Button();
            fileTB = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // PlayBTN
            // 
            PlayBTN.Location = new Point(349, 359);
            PlayBTN.Name = "PlayBTN";
            PlayBTN.Size = new Size(112, 34);
            PlayBTN.TabIndex = 0;
            PlayBTN.Text = "Play";
            PlayBTN.UseVisualStyleBackColor = true;
            PlayBTN.Click += PlayBTN_Click;
            // 
            // fileTB
            // 
            fileTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fileTB.Location = new Point(182, 178);
            fileTB.Name = "fileTB";
            fileTB.Size = new Size(446, 39);
            fileTB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 107);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
            label1.TabIndex = 2;
            label1.Text = "Enter your KSU file below";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(fileTB);
            Controls.Add(PlayBTN);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PlayBTN;
        private TextBox fileTB;
        private Label label1;
    }
}
