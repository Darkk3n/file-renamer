namespace TreasuryToolkit.App
{
    partial class ProgressForm
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
            LblStatus = new Label();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblStatus.Location = new Point(21, 9);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(169, 25);
            LblStatus.TabIndex = 1;
            LblStatus.Text = "Procesando PDFs...";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(21, 47);
            progressBar1.MarqueeAnimationSpeed = 50;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(548, 23);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 2;
            progressBar1.Click += progressBar1_Click;
            // 
            // ProgressForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(581, 84);
            Controls.Add(progressBar1);
            Controls.Add(LblStatus);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProgressForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProgressForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblStatus;
        private ProgressBar progressBar1;
    }
}