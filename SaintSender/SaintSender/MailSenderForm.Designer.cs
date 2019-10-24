namespace SaintSender
{
    partial class MailSenderForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.recipenttxt = new System.Windows.Forms.TextBox();
            this.subjecttxt = new System.Windows.Forms.TextBox();
            this.bodytxt = new System.Windows.Forms.RichTextBox();
            this.FileAttacherButton = new System.Windows.Forms.Button();
            this.FileAttacherLabel = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.RecipentLabel = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 36);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1165, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "New Email";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.White;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(688, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(69, 28);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back <<";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // recipenttxt
            // 
            this.recipenttxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.recipenttxt.Location = new System.Drawing.Point(17, 69);
            this.recipenttxt.Name = "recipenttxt";
            this.recipenttxt.Size = new System.Drawing.Size(740, 35);
            this.recipenttxt.TabIndex = 3;
            this.recipenttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // subjecttxt
            // 
            this.subjecttxt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subjecttxt.Location = new System.Drawing.Point(17, 130);
            this.subjecttxt.Name = "subjecttxt";
            this.subjecttxt.Size = new System.Drawing.Size(740, 35);
            this.subjecttxt.TabIndex = 4;
            this.subjecttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bodytxt
            // 
            this.bodytxt.BackColor = System.Drawing.Color.White;
            this.bodytxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bodytxt.Location = new System.Drawing.Point(17, 181);
            this.bodytxt.Name = "bodytxt";
            this.bodytxt.Size = new System.Drawing.Size(740, 319);
            this.bodytxt.TabIndex = 5;
            this.bodytxt.Text = "";
            // 
            // FileAttacherButton
            // 
            this.FileAttacherButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.FileAttacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileAttacherButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FileAttacherButton.ForeColor = System.Drawing.Color.Transparent;
            this.FileAttacherButton.Location = new System.Drawing.Point(158, 506);
            this.FileAttacherButton.Name = "FileAttacherButton";
            this.FileAttacherButton.Size = new System.Drawing.Size(99, 33);
            this.FileAttacherButton.TabIndex = 8;
            this.FileAttacherButton.Text = "Browse";
            this.FileAttacherButton.UseVisualStyleBackColor = false;
            // 
            // FileAttacherLabel
            // 
            this.FileAttacherLabel.AutoSize = true;
            this.FileAttacherLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FileAttacherLabel.Location = new System.Drawing.Point(13, 511);
            this.FileAttacherLabel.Name = "FileAttacherLabel";
            this.FileAttacherLabel.Size = new System.Drawing.Size(139, 21);
            this.FileAttacherLabel.TabIndex = 9;
            this.FileAttacherLabel.Text = "File Attachment: ";
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SendButton.ForeColor = System.Drawing.Color.Transparent;
            this.SendButton.Location = new System.Drawing.Point(657, 506);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(99, 33);
            this.SendButton.TabIndex = 11;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            // 
            // RecipentLabel
            // 
            this.RecipentLabel.AutoSize = true;
            this.RecipentLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RecipentLabel.Location = new System.Drawing.Point(13, 45);
            this.RecipentLabel.Name = "RecipentLabel";
            this.RecipentLabel.Size = new System.Drawing.Size(81, 21);
            this.RecipentLabel.TabIndex = 12;
            this.RecipentLabel.Text = "Recipent:";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SubjectLabel.Location = new System.Drawing.Point(13, 107);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(71, 21);
            this.SubjectLabel.TabIndex = 13;
            this.SubjectLabel.Text = "Subject:";
            // 
            // MailSenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(773, 560);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.RecipentLabel);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.FileAttacherLabel);
            this.Controls.Add(this.FileAttacherButton);
            this.Controls.Add(this.bodytxt);
            this.Controls.Add(this.subjecttxt);
            this.Controls.Add(this.recipenttxt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MailSenderForm";
            this.Text = "MailSenderForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox recipenttxt;
        private System.Windows.Forms.TextBox subjecttxt;
        private System.Windows.Forms.RichTextBox bodytxt;
        private System.Windows.Forms.Button FileAttacherButton;
        private System.Windows.Forms.Label FileAttacherLabel;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label RecipentLabel;
        private System.Windows.Forms.Label SubjectLabel;
    }
}