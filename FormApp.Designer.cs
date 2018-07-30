namespace C18_Ex01
{
    public partial class FormApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApp));
            this.textBoxStatus = new System.Windows.Forms.TextBox();
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
            this.labelConnected = new System.Windows.Forms.Label();
            this.buttonWhoUnfriendedMe = new System.Windows.Forms.Button();
            this.buttonMakeAMatch = new System.Windows.Forms.Button();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Enabled = false;
            this.textBoxStatus.Location = new System.Drawing.Point(323, 28);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(429, 20);
            this.textBoxStatus.TabIndex = 4;
            // 
            // labelConnect
            // 
            this.labelConnect.AutoSize = true;
            this.labelConnect.BackColor = System.Drawing.Color.Transparent;
            this.labelConnect.ForeColor = System.Drawing.Color.White;
            this.labelConnect.Location = new System.Drawing.Point(94, 31);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(144, 13);
            this.labelConnect.TabIndex = 7;
            this.labelConnect.Text = "Please connect to Facebook";
            // 
            // labelPostStatus
            // 
            this.labelPostStatus.AutoSize = true;
            this.labelPostStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelPostStatus.Enabled = false;
            this.labelPostStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostStatus.ForeColor = System.Drawing.Color.White;
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
            this.listBoxFriends.HorizontalScrollbar = true;
            this.listBoxFriends.Location = new System.Drawing.Point(663, 122);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(156, 212);
            this.listBoxFriends.TabIndex = 9;
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.BackColor = System.Drawing.Color.Transparent;
            this.labelFriends.Enabled = false;
            this.labelFriends.ForeColor = System.Drawing.Color.White;
            this.labelFriends.Location = new System.Drawing.Point(660, 101);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(44, 13);
            this.labelFriends.TabIndex = 10;
            this.labelFriends.Text = "Friends:";
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.BackColor = System.Drawing.Color.Transparent;
            this.labelPosts.Enabled = false;
            this.labelPosts.ForeColor = System.Drawing.Color.White;
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
            this.listBoxPosts.HorizontalScrollbar = true;
            this.listBoxPosts.Location = new System.Drawing.Point(485, 122);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(156, 212);
            this.listBoxPosts.TabIndex = 11;
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.BackColor = System.Drawing.Color.Transparent;
            this.labelEvents.Enabled = false;
            this.labelEvents.ForeColor = System.Drawing.Color.White;
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
            this.listBoxEvents.HorizontalScrollbar = true;
            this.listBoxEvents.Location = new System.Drawing.Point(305, 122);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(156, 212);
            this.listBoxEvents.TabIndex = 13;
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.BackColor = System.Drawing.Color.Transparent;
            this.labelPages.Enabled = false;
            this.labelPages.ForeColor = System.Drawing.Color.White;
            this.labelPages.Location = new System.Drawing.Point(119, 101);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(40, 13);
            this.labelPages.TabIndex = 16;
            this.labelPages.Text = "Pages:";
            // 
            // listBoxPages
            // 
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.HorizontalScrollbar = true;
            this.listBoxPages.Location = new System.Drawing.Point(122, 122);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(156, 212);
            this.listBoxPages.TabIndex = 15;
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
            // buttonWhoUnfriendedMe
            // 
            this.buttonWhoUnfriendedMe.Enabled = false;
            this.buttonWhoUnfriendedMe.Image = global::C18_Ex01_Yoav_301675872_Miri_314256397.Properties.Resources.unfriend;
            this.buttonWhoUnfriendedMe.Location = new System.Drawing.Point(26, 215);
            this.buttonWhoUnfriendedMe.Name = "buttonWhoUnfriendedMe";
            this.buttonWhoUnfriendedMe.Size = new System.Drawing.Size(55, 48);
            this.buttonWhoUnfriendedMe.TabIndex = 18;
            this.buttonWhoUnfriendedMe.UseVisualStyleBackColor = true;
            this.buttonWhoUnfriendedMe.Click += new System.EventHandler(this.buttonWhoUnfriendedMe_Click);
            // 
            // buttonMakeAMatch
            // 
            this.buttonMakeAMatch.Enabled = false;
            this.buttonMakeAMatch.Image = global::C18_Ex01_Yoav_301675872_Miri_314256397.Properties.Resources.match_jpg;
            this.buttonMakeAMatch.Location = new System.Drawing.Point(15, 164);
            this.buttonMakeAMatch.Name = "buttonMakeAMatch";
            this.buttonMakeAMatch.Size = new System.Drawing.Size(77, 27);
            this.buttonMakeAMatch.TabIndex = 17;
            this.buttonMakeAMatch.UseVisualStyleBackColor = true;
            this.buttonMakeAMatch.Click += new System.EventHandler(this.buttonMakeAMatch_Click);
            // 
            // buttonPost
            // 
            this.buttonPost.Enabled = false;
            this.buttonPost.Image = global::C18_Ex01_Yoav_301675872_Miri_314256397.Properties.Resources.FB_Post;
            this.buttonPost.Location = new System.Drawing.Point(758, 22);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(61, 31);
            this.buttonPost.TabIndex = 6;
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Image = global::C18_Ex01_Yoav_301675872_Miri_314256397.Properties.Resources.FB_Connect;
            this.buttonConnect.Location = new System.Drawing.Point(12, 101);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(81, 27);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Image = global::C18_Ex01_Yoav_301675872_Miri_314256397.Properties.Resources.facebook_blank_photo_11;
            this.pictureBoxProfile.Location = new System.Drawing.Point(12, 22);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(80, 73);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::C18_Ex01_Yoav_301675872_Miri_314256397.Properties.Resources.facebook_background;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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