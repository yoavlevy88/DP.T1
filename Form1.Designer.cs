namespace C18_Ex01
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
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.labelConnect = new System.Windows.Forms.Label();
            this.labelPostStatus = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.labelFriends = new System.Windows.Forms.Label();
            this.labelPosts = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.labelEvents = new System.Windows.Forms.Label();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.labelPages = new System.Windows.Forms.Label();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.buttonMakeAMatch = new System.Windows.Forms.Button();
            this.buttonWhoUnfriendedMe = new System.Windows.Forms.Button();
            this.labelConnected = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(15, 8);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(62, 59);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(7, 87);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(78, 25);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Enabled = false;
            this.textBoxStatus.Location = new System.Drawing.Point(323, 28);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(429, 20);
            this.textBoxStatus.TabIndex = 4;
            // 
            // buttonPost
            // 
            this.buttonPost.Enabled = false;
            this.buttonPost.Location = new System.Drawing.Point(767, 28);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(61, 20);
            this.buttonPost.TabIndex = 6;
            this.buttonPost.Text = "POST";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // labelConnect
            // 
            this.labelConnect.AutoSize = true;
            this.labelConnect.Location = new System.Drawing.Point(94, 25);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(144, 13);
            this.labelConnect.TabIndex = 7;
            this.labelConnect.Text = "Please connect to Facebook";
            // 
            // labelPostStatus
            // 
            this.labelPostStatus.AutoSize = true;
            this.labelPostStatus.Enabled = false;
            this.labelPostStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostStatus.Location = new System.Drawing.Point(320, 7);
            this.labelPostStatus.Name = "labelPostStatus";
            this.labelPostStatus.Size = new System.Drawing.Size(155, 13);
            this.labelPostStatus.TabIndex = 8;
            this.labelPostStatus.Text = "What\'s on your mind right now?";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Enabled = false;
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(663, 122);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(156, 212);
            this.listBoxFriends.TabIndex = 9;
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Enabled = false;
            this.labelFriends.Location = new System.Drawing.Point(660, 101);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(44, 13);
            this.labelFriends.TabIndex = 10;
            this.labelFriends.Text = "Friends:";
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Enabled = false;
            this.labelPosts.Location = new System.Drawing.Point(482, 101);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(36, 13);
            this.labelPosts.TabIndex = 12;
            this.labelPosts.Text = "Posts:";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Enabled = false;
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(485, 122);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(156, 212);
            this.listBoxPosts.TabIndex = 11;
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Enabled = false;
            this.labelEvents.Location = new System.Drawing.Point(302, 101);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(43, 13);
            this.labelEvents.TabIndex = 14;
            this.labelEvents.Text = "Events:";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Enabled = false;
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(305, 122);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(156, 212);
            this.listBoxEvents.TabIndex = 13;
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Enabled = false;
            this.labelPages.Location = new System.Drawing.Point(119, 101);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(40, 13);
            this.labelPages.TabIndex = 16;
            this.labelPages.Text = "Pages:";
            // 
            // listBoxPages
            // 
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.Location = new System.Drawing.Point(122, 122);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(156, 212);
            this.listBoxPages.TabIndex = 15;
            // 
            // buttonMakeAMatch
            // 
            this.buttonMakeAMatch.Enabled = false;
            this.buttonMakeAMatch.Location = new System.Drawing.Point(8, 153);
            this.buttonMakeAMatch.Name = "buttonMakeAMatch";
            this.buttonMakeAMatch.Size = new System.Drawing.Size(95, 27);
            this.buttonMakeAMatch.TabIndex = 17;
            this.buttonMakeAMatch.Text = "Make a match";
            this.buttonMakeAMatch.UseVisualStyleBackColor = true;
            this.buttonMakeAMatch.Click += new System.EventHandler(this.buttonMakeAMatch_Click);
            // 
            // buttonWhoUnfriendedMe
            // 
            this.buttonWhoUnfriendedMe.Enabled = false;
            this.buttonWhoUnfriendedMe.Location = new System.Drawing.Point(7, 197);
            this.buttonWhoUnfriendedMe.Name = "buttonWhoUnfriendedMe";
            this.buttonWhoUnfriendedMe.Size = new System.Drawing.Size(95, 37);
            this.buttonWhoUnfriendedMe.TabIndex = 18;
            this.buttonWhoUnfriendedMe.Text = "Who unfriended me?";
            this.buttonWhoUnfriendedMe.UseVisualStyleBackColor = true;
            this.buttonWhoUnfriendedMe.Click += new System.EventHandler(this.buttonWhoUnfriendedMe_Click);
            // 
            // labelConnected
            // 
            this.labelConnected.AutoSize = true;
            this.labelConnected.Location = new System.Drawing.Point(88, 25);
            this.labelConnected.Name = "labelConnected";
            this.labelConnected.Size = new System.Drawing.Size(0, 13);
            this.labelConnected.TabIndex = 19;
            this.labelConnected.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(843, 346);
            this.Controls.Add(this.labelConnected);
            this.Controls.Add(this.buttonWhoUnfriendedMe);
            this.Controls.Add(this.buttonMakeAMatch);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.listBoxPages);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.labelPostStatus);
            this.Controls.Add(this.labelConnect);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.pictureBoxProfile);
            this.Name = "Form1";
            this.Text = "Facebook Desktop App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Label labelConnect;
        private System.Windows.Forms.Label labelPostStatus;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label labelEvents;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.Button buttonMakeAMatch;
        private System.Windows.Forms.Button buttonWhoUnfriendedMe;
        private System.Windows.Forms.Label labelConnected;
    }
}

