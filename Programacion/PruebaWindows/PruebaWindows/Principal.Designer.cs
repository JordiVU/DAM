namespace PruebaWindows
{
    partial class Principal
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
            txtNumber2 = new TextBox();
            txtNumber1 = new TextBox();
            cmbOperator = new ComboBox();
            lblResult = new Label();
            btnGo = new Button();
            SuspendLayout();
            // 
            // txtNumber2
            // 
            txtNumber2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNumber2.Location = new Point(213, 41);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(125, 27);
            txtNumber2.TabIndex = 12;
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(35, 41);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(125, 27);
            txtNumber1.TabIndex = 16;
            // 
            // cmbOperator
            // 
            cmbOperator.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbOperator.FormattingEnabled = true;
            cmbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperator.Location = new Point(111, 95);
            cmbOperator.Name = "cmbOperator";
            cmbOperator.Size = new Size(151, 28);
            cmbOperator.TabIndex = 17;
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Impact", 12F);
            lblResult.Location = new Point(152, 187);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(68, 25);
            lblResult.TabIndex = 18;
            lblResult.Text = "RESULT";
            // 
            // btnGo
            // 
            btnGo.Location = new Point(139, 142);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(94, 29);
            btnGo.TabIndex = 19;
            btnGo.Text = "DESTRUIR";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(378, 249);
            Controls.Add(btnGo);
            Controls.Add(lblResult);
            Controls.Add(cmbOperator);
            Controls.Add(txtNumber1);
            Controls.Add(txtNumber2);
            MaximumSize = new Size(500, 500);
            MinimumSize = new Size(300, 200);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNumber2;
        private TextBox txtNumber1;
        private ComboBox cmbOperator;
        private Label lblResult;
        private Button btnGo;
    }
}
