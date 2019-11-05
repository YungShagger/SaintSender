namespace SaintSender
{
    partial class EmailForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SenderNameLabel = new System.Windows.Forms.Label();
            this.Bodytxt = new System.Windows.Forms.RichTextBox();
            this.Sendertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Subjecttxt = new System.Windows.Forms.TextBox();
            this.Datetxt = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.Addresstxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saint Sender";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 36);
            this.panel1.TabIndex = 4;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.White;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(1147, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(69, 28);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back <<";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateLabel.Location = new System.Drawing.Point(8, 105);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(50, 21);
            this.DateLabel.TabIndex = 18;
            this.DateLabel.Text = "Date:";
            // 
            // SenderNameLabel
            // 
            this.SenderNameLabel.AutoSize = true;
            this.SenderNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SenderNameLabel.Location = new System.Drawing.Point(8, 43);
            this.SenderNameLabel.Name = "SenderNameLabel";
            this.SenderNameLabel.Size = new System.Drawing.Size(117, 21);
            this.SenderNameLabel.TabIndex = 17;
            this.SenderNameLabel.Text = "Sender Name:";
            // 
            // Bodytxt
            // 
            this.Bodytxt.BackColor = System.Drawing.Color.White;
            this.Bodytxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Bodytxt.Location = new System.Drawing.Point(12, 243);
            this.Bodytxt.Name = "Bodytxt";
            this.Bodytxt.ReadOnly = true;
            this.Bodytxt.Size = new System.Drawing.Size(1195, 423);
            this.Bodytxt.TabIndex = 16;
            this.Bodytxt.Text = "";
            // 
            // Sendertxt
            // 
            this.Sendertxt.BackColor = System.Drawing.Color.White;
            this.Sendertxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Sendertxt.Location = new System.Drawing.Point(12, 67);
            this.Sendertxt.Name = "Sendertxt";
            this.Sendertxt.ReadOnly = true;
            this.Sendertxt.Size = new System.Drawing.Size(584, 35);
            this.Sendertxt.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Subject:";
            // 
            // Subjecttxt
            // 
            this.Subjecttxt.BackColor = System.Drawing.Color.White;
            this.Subjecttxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Subjecttxt.Location = new System.Drawing.Point(12, 190);
            this.Subjecttxt.Name = "Subjecttxt";
            this.Subjecttxt.ReadOnly = true;
            this.Subjecttxt.Size = new System.Drawing.Size(1195, 35);
            this.Subjecttxt.TabIndex = 19;
            // 
            // Datetxt
            // 
            this.Datetxt.BackColor = System.Drawing.Color.White;
            this.Datetxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Datetxt.Location = new System.Drawing.Point(12, 128);
            this.Datetxt.Name = "Datetxt";
            this.Datetxt.ReadOnly = true;
            this.Datetxt.Size = new System.Drawing.Size(1195, 35);
            this.Datetxt.TabIndex = 15;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddressLabel.Location = new System.Drawing.Point(619, 43);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(74, 21);
            this.AddressLabel.TabIndex = 22;
            this.AddressLabel.Text = "Address:";
            // 
            // Addresstxt
            // 
            this.Addresstxt.BackColor = System.Drawing.Color.White;
            this.Addresstxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Addresstxt.Location = new System.Drawing.Point(623, 67);
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.ReadOnly = true;
            this.Addresstxt.Size = new System.Drawing.Size(584, 35);
            this.Addresstxt.TabIndex = 21;
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 678);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.Addresstxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Subjecttxt);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.SenderNameLabel);
            this.Controls.Add(this.Bodytxt);
            this.Controls.Add(this.Datetxt);
            this.Controls.Add(this.Sendertxt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmailForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label SenderNameLabel;
        private System.Windows.Forms.RichTextBox Bodytxt;
        private System.Windows.Forms.TextBox Sendertxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Subjecttxt;
        private System.Windows.Forms.TextBox Datetxt;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox Addresstxt;
    }
}