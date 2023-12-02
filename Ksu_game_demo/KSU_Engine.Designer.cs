namespace Ksu_game_demo
{
    partial class KSU_Engine
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
            KeytoPressLB = new Label();
            pointsLB = new Label();
            SuspendLayout();
            // 
            // KeytoPressLB
            // 
            KeytoPressLB.AutoSize = true;
            KeytoPressLB.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KeytoPressLB.ForeColor = SystemColors.ControlLight;
            KeytoPressLB.Location = new Point(257, 214);
            KeytoPressLB.Name = "KeytoPressLB";
            KeytoPressLB.Size = new Size(232, 54);
            KeytoPressLB.TabIndex = 0;
            KeytoPressLB.Text = "KeytoPress";
            // 
            // pointsLB
            // 
            pointsLB.AutoSize = true;
            pointsLB.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pointsLB.ForeColor = Color.White;
            pointsLB.Location = new Point(339, 37);
            pointsLB.Name = "pointsLB";
            pointsLB.Size = new Size(39, 45);
            pointsLB.TabIndex = 1;
            pointsLB.Text = "0";
            // 
            // KSU_Engine
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(800, 450);
            Controls.Add(pointsLB);
            Controls.Add(KeytoPressLB);
            Name = "KSU_Engine";
            Text = "KSU_Engine";
            FormClosing += KSU_Engine_FormClosing;
            Load += KSU_Engine_Load;
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KeytoPressLB;
        private Label pointsLB;
    }
}