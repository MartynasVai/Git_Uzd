
namespace Git_uzd
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Uzd1But = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Uzd1Ats = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uzd1Box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Uzd1But);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Uzd1Ats);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.uzd1Box);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Užd";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Piešti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(336, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(434, 401);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Įvesti 10 Skaičių be tarpų";
            // 
            // Uzd1But
            // 
            this.Uzd1But.Location = new System.Drawing.Point(165, 81);
            this.Uzd1But.Name = "Uzd1But";
            this.Uzd1But.Size = new System.Drawing.Size(75, 23);
            this.Uzd1But.TabIndex = 4;
            this.Uzd1But.Text = "Skaičiuoti";
            this.Uzd1But.UseVisualStyleBackColor = true;
            this.Uzd1But.Click += new System.EventHandler(this.Uzd1But_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Suma : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Uzd1Ats
            // 
            this.Uzd1Ats.Location = new System.Drawing.Point(3, 84);
            this.Uzd1Ats.Name = "Uzd1Ats";
            this.Uzd1Ats.ReadOnly = true;
            this.Uzd1Ats.Size = new System.Drawing.Size(128, 20);
            this.Uzd1Ats.TabIndex = 2;
            this.Uzd1Ats.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // uzd1Box
            // 
            this.uzd1Box.BackColor = System.Drawing.SystemColors.Window;
            this.uzd1Box.Location = new System.Drawing.Point(3, 45);
            this.uzd1Box.MaxLength = 10;
            this.uzd1Box.Name = "uzd1Box";
            this.uzd1Box.Size = new System.Drawing.Size(318, 20);
            this.uzd1Box.TabIndex = 0;
            this.uzd1Box.TextChanged += new System.EventHandler(this.uzd1Box_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Išvalyti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uzd1Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Uzd1Ats;
        private System.Windows.Forms.Button Uzd1But;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}

