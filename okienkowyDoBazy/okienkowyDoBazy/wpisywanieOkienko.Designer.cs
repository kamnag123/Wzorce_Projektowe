namespace okienkowyDoBazy
{
    partial class wpisywanieOkienko
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tak = new System.Windows.Forms.Button();
            this.nie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 98);
            this.textBox1.MaxLength = 45;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tak
            // 
            this.tak.Location = new System.Drawing.Point(75, 163);
            this.tak.Name = "tak";
            this.tak.Size = new System.Drawing.Size(151, 50);
            this.tak.TabIndex = 1;
            this.tak.Text = "Akceptuj";
            this.tak.UseVisualStyleBackColor = true;
            this.tak.Click += new System.EventHandler(this.tak_Click);
            // 
            // nie
            // 
            this.nie.Location = new System.Drawing.Point(282, 163);
            this.nie.Name = "nie";
            this.nie.Size = new System.Drawing.Size(155, 50);
            this.nie.TabIndex = 2;
            this.nie.Text = "Anuluj";
            this.nie.UseVisualStyleBackColor = true;
            this.nie.Click += new System.EventHandler(this.nie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(115, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wpisz pożądaną nazwę poniżej.";
            // 
            // wpisywanieOkienko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 254);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nie);
            this.Controls.Add(this.tak);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "wpisywanieOkienko";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "wpisywanieOkienko";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button tak;
        private System.Windows.Forms.Button nie;
        private System.Windows.Forms.Label label1;
    }
}