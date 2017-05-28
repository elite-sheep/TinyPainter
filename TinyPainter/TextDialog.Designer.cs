namespace TinyPainter
{
    partial class TextDialog
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
            this.EditArea = new System.Windows.Forms.RichTextBox();
            this.FontBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditArea
            // 
            this.EditArea.Location = new System.Drawing.Point(11, 4);
            this.EditArea.Name = "EditArea";
            this.EditArea.Size = new System.Drawing.Size(409, 229);
            this.EditArea.TabIndex = 0;
            this.EditArea.Text = "";
            // 
            // FontBtn
            // 
            this.FontBtn.Location = new System.Drawing.Point(435, 5);
            this.FontBtn.Name = "FontBtn";
            this.FontBtn.Size = new System.Drawing.Size(66, 25);
            this.FontBtn.TabIndex = 1;
            this.FontBtn.Text = "Font";
            this.FontBtn.UseVisualStyleBackColor = true;
            this.FontBtn.Click += new System.EventHandler(this.FontBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(435, 45);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(65, 25);
            this.OkBtn.TabIndex = 2;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(435, 89);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(65, 25);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // TextDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 244);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.FontBtn);
            this.Controls.Add(this.EditArea);
            this.Name = "TextDialog";
            this.Text = "TextDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox EditArea;
        private System.Windows.Forms.Button FontBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}