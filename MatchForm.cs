namespace C18_Ex01
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using FacebookWrapper;
    using FacebookWrapper.ObjectModel;

    public partial class MatchForm : Form
    {
        private User m_loggedInUser;
        private AppUtils m_appLogic;

        public MatchForm(User loggedInUser)
        {
            this.m_loggedInUser = loggedInUser;
            InitializeComponent();
            this.m_appLogic = new AppUtils();
        }

        private void buttonMatch_Click(object sender, EventArgs e)
        {
            string personalMessage = string.Empty;
            if (this.listBoxGroupA.SelectedItems.Count != 1 || this.listBoxGroupB.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please choose one person from each list", "Error!", MessageBoxButtons.OK);
            }

            if (((User)this.listBoxGroupA.Items[this.listBoxGroupA.SelectedIndex]).Name == ((User)this.listBoxGroupB.Items[this.listBoxGroupB.SelectedIndex]).Name)
            {
                MessageBox.Show("Cannot choose the same person twice", "Error!", MessageBoxButtons.OK);
            }

            personalMessage = getPersonalMessage();
            User[] friendsToMatch = new User[] { this.listBoxGroupA.Items[this.listBoxGroupA.SelectedIndex] as User, this.listBoxGroupB.Items[this.listBoxGroupB.SelectedIndex] as User };
            if(friendsToMatch[0].Email == null || friendsToMatch[1].Email == null)
            {
                MessageBox.Show(this, "We are unable to send the match message at the time, due to Facebook persmission. The friend's emails are unavailable.", "error", MessageBoxButtons.OK);
            }
            else
            {
                this.m_appLogic.generateMatchMessages(this.m_loggedInUser, friendsToMatch, personalMessage);
            }

            this.Close();
        }

        private void listViewGroupA_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            genderSelectionChanged(this.listViewGroupA, this.listBoxGroupA, e);
        }

        private void genderSelectionChanged(ListView genderList, ListBox friendsList, ListViewItemSelectionChangedEventArgs genderChangedEvent)
        {
            string selectedGender = genderChangedEvent.Item.Text.ToLower();
            foreach (ListViewItem gender in genderList.Items)
            {
                if (gender != genderChangedEvent.Item)
                {
                    gender.ForeColor = Color.Gray;
                }
            }

            friendsList.Enabled = true;
            genderChangedEvent.Item.ForeColor = Color.Black;
            friendsList.Items.Clear();
            friendsList.DisplayMember = "Name";
            foreach (User friend in this.m_loggedInUser.Friends)
            {
                if (friend.Gender.ToString() == selectedGender)
                {
                    friendsList.Items.Add(friend);
                }
            }

            if (friendsList.Items.Count == 0)
            {
                friendsList.Enabled = false;
                friendsList.Items.Add(string.Format(@"No {0} friends", selectedGender.ToLower()));
            }
        }

        private void listViewGroupB_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            genderSelectionChanged(this.listViewGroupB, this.listBoxGroupB, e);
        }

        private string getPersonalMessage()
        {
            string message = string.Empty;
            MatchMessageForm matchMessage = new MatchMessageForm();
            matchMessage.ShowDialog();
            return matchMessage.MatchMessage;
        }
    }
}
