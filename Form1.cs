using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C18_Ex01
{
    public partial class Form1 : Form
    {
        LoginResult m_loginResult = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {

            MessageBoxButtons okButton = MessageBoxButtons.OK;
            try
            {
                m_loginResult = FacebookService.Login("1765156366870770", "public_profile", "email", "user_friends", "user_posts", "user_birthday", "user_gender", "user_likes", "user_photos", "user_events");
                pictureBoxProfile.AccessibleDescription = string.Format(@"{0}'s profile picture", m_loginResult.LoggedInUser.FirstName);
                pictureBoxProfile.Image = this.m_loginResult.LoggedInUser.ImageNormal;
                this.labelConnect.Visible = false;
                this.labelConnected.Font = new Font(this.labelConnected.Font, FontStyle.Bold);
                this.labelConnected.Text = string.Format(@"{0}'s Facebook profile", this.m_loginResult.LoggedInUser.Name);
                this.labelConnected.Visible = true;
                this.buttonConnect.Text = "Connected";
                this.buttonConnect.Enabled = false;
                this.labelFriends.Enabled = true;
                this.labelPosts.Enabled = true;
                this.labelEvents.Enabled = true;
                this.labelPages.Enabled = true;
                this.labelPostStatus.Enabled = true;
                this.textBoxStatus.Enabled = true;
                this.buttonMakeAMatch.Enabled = true;
                this.buttonPost.Enabled = true;
                this.buttonWhoUnfriendedMe.Enabled = true;
                this.listBoxEvents.Enabled = true;
                this.listBoxFriends.Enabled = true;
                this.listBoxPages.Enabled = true;
                this.listBoxPosts.Enabled = true;
                fetchFriends();
                fetchPosts();
                //fetchEvents();
                //fetchPages();
                MessageBox.Show(string.Format(@"Welcome {0}!", m_loginResult.LoggedInUser.FirstName), "Welcome", okButton);
            }
            catch (Exception loginException) //  IS THAT OK?
            {
                throw (loginException);
            }
        }

        private void fetchPages()
        {
            this.listBoxPages.Items.Clear();
            listBoxPages.DisplayMember = "Name";
            foreach (Page page in this.m_loginResult.LoggedInUser.LikedPages)
            {
                this.listBoxPages.Items.Add(page);
            }
            if(this.m_loginResult.LoggedInUser.LikedPages.Count == 0)
            {
                this.listBoxPages.Items.Add("No pages to display!");
                this.listBoxPages.Enabled = false;
            }
        }

        private void fetchEvents()
        {
            this.listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";
            foreach (Event userEvent in this.m_loginResult.LoggedInUser.Events)
            {
                this.listBoxEvents.Items.Add(userEvent);
            }
            if(this.m_loginResult.LoggedInUser.Events.Count == 0)
            {
                this.listBoxEvents.Items.Add("No events to display!");
                this.listBoxEvents.Enabled = false;
            }
        }

        private void fetchPosts()
        {
            this.listBoxPosts.Items.Clear();
            foreach (Post post in this.m_loginResult.LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }
            if (this.m_loginResult.LoggedInUser.Posts.Count == 0)
            {
                this.listBoxPages.Items.Add("No posts to display!");
                this.listBoxPages.Enabled = false;
            }
        }
        private void fetchFriends()
        {
            this.listBoxFriends.DisplayMember = "Name";
            foreach (User friend in this.m_loginResult.LoggedInUser.Friends)
            {
                this.listBoxFriends.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }
            if (this.m_loginResult.LoggedInUser.Friends.Count == 0)
            {
                this.listBoxFriends.Items.Add("No friends to display!");
                this.listBoxFriends.Enabled = false;
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            if (this.textBoxStatus.TextLength == 0)
            {
                MessageBox.Show(this, "Cannot upload empty post!", "Error!", MessageBoxButtons.OK);

            }
            else
            {
                try
                {
                    Status statusToPost = this.m_loginResult.LoggedInUser.PostStatus(this.textBoxStatus.Text);
                    MessageBox.Show(this, "Statuse posted! :)", "Posted", MessageBoxButtons.OK);
                }
                catch (Exception postException)
                {
                    throw (postException);
                }

            }
        }

        private void buttonMakeAMatch_Click(object sender, EventArgs e)
        {
            MatchForm match = new MatchForm(this.m_loginResult.LoggedInUser);
            match.Select();
            match.ShowDialog();
        }
    }
}
