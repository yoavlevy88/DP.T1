namespace C18_Ex01
{
    partial class MatchMessageForm
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
            this.labelMatchMessage = new System.Windows.Forms.Label();
            this.textBoxMatchMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMatchMessage
            // 
            this.labelMatchMessage.AutoSize = true;
            this.labelMatchMessage.Location = new System.Drawing.Point(12, 12);
            this.labelMatchMessage.Name = "labelMatchMessage";
            this.labelMatchMessage.Size = new System.Drawing.Size(321, 13);
            this.labelMatchMessage.TabIndex = 0;
            this.labelMatchMessage.Text = "Would you like to add why you think they would be a good match?";
            // 
            // textBoxMatchMessage
            // 
            this.textBoxMatchMessage.Location = new System.Drawing.Point(15, 40);
            this.textBoxMatchMessage.Multiline = true;
            this.textBoxMatchMessage.Name = "textBoxMatchMessage";
            this.textBoxMatchMessage.Size = new System.Drawing.Size(421, 178);
            this.textBoxMatchMessage.TabIndex = 1;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(226, 224);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(98, 27);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(339, 224);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(98, 27);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // MatchMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 261);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxMatchMessage);
            this.Controls.Add(this.labelMatchMessage);
            this.Name = "MatchMessageForm";
            this.Text = "Add a note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMatchMessage;
        private System.Windows.Forms.TextBox textBoxMatchMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonCancel;
    }
}