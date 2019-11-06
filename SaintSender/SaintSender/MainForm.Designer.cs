namespace SaintSender
{
    partial class MainForm
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
            this.NewMailButton = new System.Windows.Forms.Button();
            this.MailListView = new System.Windows.Forms.ListView();
            this.SortAllButton = new System.Windows.Forms.Button();
            this.SortSeenButton = new System.Windows.Forms.Button();
            this.SortUnseenButton = new System.Windows.Forms.Button();
            this.SentButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 36);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1147, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit <<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // NewMailButton
            // 
            this.NewMailButton.BackColor = System.Drawing.Color.Green;
            this.NewMailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewMailButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewMailButton.ForeColor = System.Drawing.Color.Transparent;
            this.NewMailButton.Location = new System.Drawing.Point(12, 71);
            this.NewMailButton.Name = "NewMailButton";
            this.NewMailButton.Size = new System.Drawing.Size(137, 37);
            this.NewMailButton.TabIndex = 3;
            this.NewMailButton.Text = "Nem Email";
            this.NewMailButton.UseVisualStyleBackColor = false;
            this.NewMailButton.Click += new System.EventHandler(this.NewMailButton_Click);
            // 
            // MailListView
            // 
            this.MailListView.FullRowSelect = true;
            this.MailListView.HideSelection = false;
            this.MailListView.Location = new System.Drawing.Point(161, 114);
            this.MailListView.Name = "MailListView";
            this.MailListView.Size = new System.Drawing.Size(1046, 552);
            this.MailListView.TabIndex = 5;
            this.MailListView.UseCompatibleStateImageBehavior = false;
            this.MailListView.View = System.Windows.Forms.View.Details;
            this.MailListView.DoubleClick += new System.EventHandler(this.MailListView_Click);
            // 
            // SortAllButton
            // 
            this.SortAllButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SortAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortAllButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SortAllButton.ForeColor = System.Drawing.Color.Transparent;
            this.SortAllButton.Location = new System.Drawing.Point(12, 114);
            this.SortAllButton.Name = "SortAllButton";
            this.SortAllButton.Size = new System.Drawing.Size(137, 37);
            this.SortAllButton.TabIndex = 6;
            this.SortAllButton.Text = "Sort All";
            this.SortAllButton.UseVisualStyleBackColor = false;
            this.SortAllButton.Click += new System.EventHandler(this.SortAllButton_Click);
            // 
            // SortSeenButton
            // 
            this.SortSeenButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SortSeenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortSeenButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SortSeenButton.ForeColor = System.Drawing.Color.Transparent;
            this.SortSeenButton.Location = new System.Drawing.Point(12, 200);
            this.SortSeenButton.Name = "SortSeenButton";
            this.SortSeenButton.Size = new System.Drawing.Size(137, 37);
            this.SortSeenButton.TabIndex = 8;
            this.SortSeenButton.Text = "Sort Read";
            this.SortSeenButton.UseVisualStyleBackColor = false;
            this.SortSeenButton.Click += new System.EventHandler(this.SortSeenButton_Click);
            // 
            // SortUnseenButton
            // 
            this.SortUnseenButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SortUnseenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortUnseenButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SortUnseenButton.ForeColor = System.Drawing.Color.Transparent;
            this.SortUnseenButton.Location = new System.Drawing.Point(12, 157);
            this.SortUnseenButton.Name = "SortUnseenButton";
            this.SortUnseenButton.Size = new System.Drawing.Size(137, 37);
            this.SortUnseenButton.TabIndex = 7;
            this.SortUnseenButton.Text = "Sort Unread";
            this.SortUnseenButton.UseVisualStyleBackColor = false;
            this.SortUnseenButton.Click += new System.EventHandler(this.SortUnseenButton_Click);
            // 
            // SentButton
            // 
            this.SentButton.AutoEllipsis = true;
            this.SentButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SentButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SentButton.ForeColor = System.Drawing.Color.Transparent;
            this.SentButton.Location = new System.Drawing.Point(12, 243);
            this.SentButton.Name = "SentButton";
            this.SentButton.Size = new System.Drawing.Size(137, 37);
            this.SentButton.TabIndex = 11;
            this.SentButton.Text = "Sent Messages";
            this.SentButton.UseVisualStyleBackColor = false;
            this.SentButton.Click += new System.EventHandler(this.SentButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 678);
            this.Controls.Add(this.SentButton);
            this.Controls.Add(this.SortSeenButton);
            this.Controls.Add(this.SortUnseenButton);
            this.Controls.Add(this.SortAllButton);
            this.Controls.Add(this.MailListView);
            this.Controls.Add(this.NewMailButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NewMailButton;
        private System.Windows.Forms.ListView MailListView;
        private System.Windows.Forms.Button SortAllButton;
        private System.Windows.Forms.Button SortSeenButton;
        private System.Windows.Forms.Button SortUnseenButton;
        private System.Windows.Forms.Button SentButton;
    }
}