namespace HomeWork8
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            Originaltext = new RichTextBox();
            Cyphertext = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(18, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(661, 441);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(1260, 42);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "SIMULATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 54);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 3;
            label1.Text = "Distribution result";
            // 
            // Originaltext
            // 
            Originaltext.Location = new Point(697, 77);
            Originaltext.Name = "Originaltext";
            Originaltext.Size = new Size(657, 176);
            Originaltext.TabIndex = 4;
            Originaltext.Text = "";
            // 
            // Cyphertext
            // 
            Cyphertext.Location = new Point(697, 274);
            Cyphertext.Name = "Cyphertext";
            Cyphertext.Size = new Size(657, 244);
            Cyphertext.TabIndex = 5;
            Cyphertext.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(697, 251);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 6;
            label2.Text = "Encrypted Text";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(697, 54);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 7;
            label3.Text = "Original Text";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 77);
            label4.Name = "label4";
            label4.Size = new Size(208, 20);
            label4.TabIndex = 8;
            label4.Text = "Lime: original text distribution";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(444, 80);
            label5.Name = "label5";
            label5.Size = new Size(235, 20);
            label5.TabIndex = 9;
            label5.Text = "Sienna: encrypted text distribution";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 534);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Cyphertext);
            Controls.Add(Originaltext);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private RichTextBox Originaltext;
        private RichTextBox Cyphertext;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
