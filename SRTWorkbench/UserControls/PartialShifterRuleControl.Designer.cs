namespace SRTWorkbench.UserControls
{
    partial class PartialShifterRuleControl
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
            tbxStart = new TextBox();
            tbxEnd = new TextBox();
            numericUpDown = new NumericUpDown();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // tbxStart
            // 
            tbxStart.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxStart.Location = new Point(3, 15);
            tbxStart.MaxLength = 12;
            tbxStart.Name = "tbxStart";
            tbxStart.Size = new Size(125, 35);
            tbxStart.TabIndex = 0;
            tbxStart.TextChanged += tbxStart_TextChanged;
            tbxStart.Enter += tbxStart_Enter;
            tbxStart.Leave += tbxStart_Leave;
            // 
            // tbxEnd
            // 
            tbxEnd.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxEnd.Location = new Point(134, 16);
            tbxEnd.MaxLength = 12;
            tbxEnd.Name = "tbxEnd";
            tbxEnd.Size = new Size(125, 35);
            tbxEnd.TabIndex = 1;
            tbxEnd.TextChanged += tbxEnd_TextChanged;
            tbxEnd.Enter += tbxEnd_Enter;
            tbxEnd.Leave += tbxEnd_Leave;
            // 
            // numericUpDown
            // 
            numericUpDown.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown.Location = new Point(265, 17);
            numericUpDown.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDown.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(107, 35);
            numericUpDown.TabIndex = 2;
            numericUpDown.ValueChanged += numericUpDown_ValueChanged;
            // 
            // btnRemove
            // 
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.Location = new Point(378, 17);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(53, 35);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "X";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // PartialShifterRuleControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnRemove);
            Controls.Add(numericUpDown);
            Controls.Add(tbxEnd);
            Controls.Add(tbxStart);
            Name = "PartialShifterRuleControl";
            Size = new Size(445, 63);
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxStart;
        private TextBox tbxEnd;
        private NumericUpDown numericUpDown;
        private Button btnRemove;
    }
}
