namespace SRTWorkbench.UserControls
{
    partial class PartialShifterHeaderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbxBottomBorder = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxBottomBorder).BeginInit();
            SuspendLayout();
            // 
            // pbxBottomBorder
            // 
            pbxBottomBorder.BackColor = Color.Black;
            pbxBottomBorder.Location = new Point(0, 40);
            pbxBottomBorder.Name = "pbxBottomBorder";
            pbxBottomBorder.Size = new Size(445, 10);
            pbxBottomBorder.TabIndex = 0;
            pbxBottomBorder.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(73, 32);
            label1.TabIndex = 1;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(134, 5);
            label2.Name = "label2";
            label2.Size = new Size(41, 32);
            label2.TabIndex = 2;
            label2.Text = "To";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(265, 5);
            label3.Name = "label3";
            label3.Size = new Size(66, 32);
            label3.TabIndex = 3;
            label3.Text = "Shift";
            // 
            // PartialShifterHeaderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbxBottomBorder);
            Name = "PartialShifterHeaderControl";
            Size = new Size(445, 50);
            ((System.ComponentModel.ISupportInitialize)pbxBottomBorder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxBottomBorder;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
