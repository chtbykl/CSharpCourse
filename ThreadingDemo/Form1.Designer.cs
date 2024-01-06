namespace ThreadingDemo
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
            btnProcess2 = new Button();
            btnProcess1 = new Button();
            SuspendLayout();
            // 
            // btnProcess2
            // 
            btnProcess2.Location = new Point(388, 112);
            btnProcess2.Name = "btnProcess2";
            btnProcess2.Size = new Size(183, 87);
            btnProcess2.TabIndex = 0;
            btnProcess2.Text = "işlem2";
            btnProcess2.UseVisualStyleBackColor = true;
            btnProcess2.Click += btnProcess2_Click;
            // 
            // btnProcess1
            // 
            btnProcess1.Location = new Point(102, 112);
            btnProcess1.Name = "btnProcess1";
            btnProcess1.Size = new Size(183, 87);
            btnProcess1.TabIndex = 2;
            btnProcess1.Text = "işlem1";
            btnProcess1.UseVisualStyleBackColor = true;
            btnProcess1.Click += btnProcess1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProcess1);
            Controls.Add(btnProcess2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProcess2;
        private Button btnProcess1;
    }
}
