namespace bin2dec
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
            Bin = new TextBox();
            Decimal = new TextBox();
            btnTransform = new Button();
            Binário = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Bin
            // 
            Bin.BackColor = SystemColors.Control;
            Bin.BorderStyle = BorderStyle.None;
            Bin.Location = new Point(12, 76);
            Bin.Name = "Bin";
            Bin.Size = new Size(167, 16);
            Bin.TabIndex = 0;
            // 
            // Decimal
            // 
            Decimal.BackColor = SystemColors.Control;
            Decimal.BorderStyle = BorderStyle.None;
            Decimal.Location = new Point(344, 76);
            Decimal.Name = "Decimal";
            Decimal.Size = new Size(167, 16);
            Decimal.TabIndex = 1;
            // 
            // btnTransform
            // 
            btnTransform.BackColor = SystemColors.Control;
            btnTransform.FlatStyle = FlatStyle.Flat;
            btnTransform.Location = new Point(185, 63);
            btnTransform.Name = "btnTransform";
            btnTransform.Size = new Size(153, 41);
            btnTransform.TabIndex = 2;
            btnTransform.Text = "Transformar";
            btnTransform.UseVisualStyleBackColor = false;
            btnTransform.Click += btnTransform_Click_1;
            // 
            // Binário
            // 
            Binário.AutoSize = true;
            Binário.BackColor = Color.Transparent;
            Binário.ForeColor = SystemColors.Control;
            Binário.Location = new Point(68, 41);
            Binário.Name = "Binário";
            Binário.Size = new Size(44, 15);
            Binário.TabIndex = 3;
            Binário.Text = "Binário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(401, 41);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 4;
            label1.Text = "Decimal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(531, 152);
            Controls.Add(label1);
            Controls.Add(Binário);
            Controls.Add(btnTransform);
            Controls.Add(Decimal);
            Controls.Add(Bin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Bin;
        private TextBox Decimal;
        private Button btnTransform;
        private Label Binário;
        private Label label1;
    }
}
