namespace MultiStreamingReader
{
    partial class ConnectionInfo
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.UserId_Label = new System.Windows.Forms.Label();
            this.AccessToken_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "登録";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UserId_Label
            // 
            this.UserId_Label.AutoSize = true;
            this.UserId_Label.Location = new System.Drawing.Point(12, 35);
            this.UserId_Label.Name = "UserId_Label";
            this.UserId_Label.Size = new System.Drawing.Size(38, 12);
            this.UserId_Label.TabIndex = 3;
            this.UserId_Label.Text = "UserId";
            this.UserId_Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // AccessToken_Label
            // 
            this.AccessToken_Label.AutoSize = true;
            this.AccessToken_Label.Location = new System.Drawing.Point(12, 88);
            this.AccessToken_Label.Name = "AccessToken_Label";
            this.AccessToken_Label.Size = new System.Drawing.Size(74, 12);
            this.AccessToken_Label.TabIndex = 4;
            this.AccessToken_Label.Text = "AccessToken";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // ConnectionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AccessToken_Label);
            this.Controls.Add(this.UserId_Label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "ConnectionInfo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label UserId_Label;
        private System.Windows.Forms.Label AccessToken_Label;
        private System.Windows.Forms.Label label3;
    }
}