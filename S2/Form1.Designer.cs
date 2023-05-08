namespace S2
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
            this.Sendbutton = new System.Windows.Forms.Button();
            this.Massegebox = new System.Windows.Forms.TextBox();
            this.chatScreentextBox = new System.Windows.Forms.TextBox();
            this.Connectbutton = new System.Windows.Forms.Button();
            this.clientPORTtextBox = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.clientIPtextBox = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Startbutton = new System.Windows.Forms.Button();
            this.serverPORTtextBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.serverIPtextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Sendbutton
            // 
            this.Sendbutton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Sendbutton.Location = new System.Drawing.Point(649, 528);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(115, 53);
            this.Sendbutton.TabIndex = 29;
            this.Sendbutton.Text = "SEND";
            this.Sendbutton.UseVisualStyleBackColor = false;
            this.Sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
            // 
            // Massegebox
            // 
            this.Massegebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Massegebox.Location = new System.Drawing.Point(89, 528);
            this.Massegebox.Margin = new System.Windows.Forms.Padding(4);
            this.Massegebox.Multiline = true;
            this.Massegebox.Name = "Massegebox";
            this.Massegebox.Size = new System.Drawing.Size(541, 53);
            this.Massegebox.TabIndex = 28;
            // 
            // chatScreentextBox
            // 
            this.chatScreentextBox.Location = new System.Drawing.Point(89, 256);
            this.chatScreentextBox.Multiline = true;
            this.chatScreentextBox.Name = "chatScreentextBox";
            this.chatScreentextBox.Size = new System.Drawing.Size(541, 265);
            this.chatScreentextBox.TabIndex = 27;
            // 
            // Connectbutton
            // 
            this.Connectbutton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Connectbutton.Location = new System.Drawing.Point(649, 191);
            this.Connectbutton.Name = "Connectbutton";
            this.Connectbutton.Size = new System.Drawing.Size(115, 45);
            this.Connectbutton.TabIndex = 26;
            this.Connectbutton.Text = "CONNECT";
            this.Connectbutton.UseVisualStyleBackColor = false;
            this.Connectbutton.Click += new System.EventHandler(this.Connectbutton_Click);
            // 
            // clientPORTtextBox
            // 
            this.clientPORTtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientPORTtextBox.Location = new System.Drawing.Point(485, 193);
            this.clientPORTtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientPORTtextBox.Multiline = true;
            this.clientPORTtextBox.Name = "clientPORTtextBox";
            this.clientPORTtextBox.Size = new System.Drawing.Size(145, 43);
            this.clientPORTtextBox.TabIndex = 25;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Control;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(405, 193);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(94, 29);
            this.textBox9.TabIndex = 24;
            this.textBox9.Text = "PORT";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clientIPtextBox
            // 
            this.clientIPtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientIPtextBox.Location = new System.Drawing.Point(89, 193);
            this.clientIPtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientIPtextBox.Multiline = true;
            this.clientIPtextBox.Name = "clientIPtextBox";
            this.clientIPtextBox.Size = new System.Drawing.Size(299, 43);
            this.clientIPtextBox.TabIndex = 23;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(27, 201);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(94, 21);
            this.textBox7.TabIndex = 22;
            this.textBox7.Text = "IP";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(18, 149);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(156, 44);
            this.textBox6.TabIndex = 21;
            this.textBox6.Text = "Client";
            // 
            // Startbutton
            // 
            this.Startbutton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Startbutton.Location = new System.Drawing.Point(649, 54);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(115, 47);
            this.Startbutton.TabIndex = 20;
            this.Startbutton.Text = "START";
            this.Startbutton.UseVisualStyleBackColor = false;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // serverPORTtextBox
            // 
            this.serverPORTtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverPORTtextBox.Location = new System.Drawing.Point(485, 64);
            this.serverPORTtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.serverPORTtextBox.Multiline = true;
            this.serverPORTtextBox.Name = "serverPORTtextBox";
            this.serverPORTtextBox.Size = new System.Drawing.Size(145, 43);
            this.serverPORTtextBox.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(405, 83);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(94, 21);
            this.textBox4.TabIndex = 18;
            this.textBox4.Text = "PORT";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // serverIPtextBox
            // 
            this.serverIPtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverIPtextBox.Location = new System.Drawing.Point(89, 64);
            this.serverIPtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.serverIPtextBox.Multiline = true;
            this.serverIPtextBox.Name = "serverIPtextBox";
            this.serverIPtextBox.Size = new System.Drawing.Size(299, 43);
            this.serverIPtextBox.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(27, 80);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 21);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "IP";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(18, 8);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 44);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Server";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 594);
            this.Controls.Add(this.Sendbutton);
            this.Controls.Add(this.Massegebox);
            this.Controls.Add(this.chatScreentextBox);
            this.Controls.Add(this.Connectbutton);
            this.Controls.Add(this.clientPORTtextBox);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.clientIPtextBox);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.serverPORTtextBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.serverIPtextBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sendbutton;
        private System.Windows.Forms.TextBox Massegebox;
        private System.Windows.Forms.TextBox chatScreentextBox;
        private System.Windows.Forms.Button Connectbutton;
        private System.Windows.Forms.TextBox clientPORTtextBox;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox clientIPtextBox;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.TextBox serverPORTtextBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox serverIPtextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

