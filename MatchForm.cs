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

namespace C18_Ex01
{
    public partial class MatchForm : Form
    {
        User m_loggedInUser;
        //ArrayList manualFriendsList;
        public MatchForm(User loggedInUser/*, ArrayList manualFriends*/)    //USING THE MANUAL FRIENDS LIST
        {
            this.m_loggedInUser = loggedInUser;
            //this.manualFriendsList = manualFriends;
            InitializeComponent();
        }

        //USING THE MANUAL FRIENDS LIST
        private void buttonMatch_Click(object sender, EventArgs e)
        {
            if (this.listBoxGroupA.SelectedItems.Count != 1 || this.listBoxGroupB.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please choose one person from each list", "Error!", MessageBoxButtons.OK);
            }
            if (((User)this.listBoxGroupA.Items[this.listBoxGroupA.SelectedIndex]).Name == ((User)this.listBoxGroupB.Items[this.listBoxGroupB.SelectedIndex]).Name)
            {
                MessageBox.Show("Cannot choose the same person twice", "Error!", MessageBoxButtons.OK);
            }
            sendAMatchMessage();
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

        //this is for debugging. the real methos is in comments
        //private void genderSelectionChanged(ListView genderList, ListBox friendsList, ListViewItemSelectionChangedEventArgs genderChangedEvent)
        //{
        //    string selectedGender = genderChangedEvent.Item.Text.ToLower();
        //    foreach (ListViewItem gender in genderList.Items)
        //    {
        //        if (gender != genderChangedEvent.Item)
        //        {
        //            gender.ForeColor = Color.Gray;
        //        }
        //    }
        //    friendsList.Enabled = true;
        //    genderChangedEvent.Item.ForeColor = Color.Black;
        //    friendsList.Items.Clear();
        //    friendsList.DisplayMember = "name";
        //    foreach (manualFriend friend in this.manualFriendsList)
        //    {
        //        if (friend.gender == selectedGender)
        //        {
        //            friendsList.Items.Add(friend);
        //        }
        //    }
        //    if (friendsList.Items.Count == 0)
        //    {
        //        friendsList.Enabled = false;
        //        friendsList.Items.Add(string.Format(@"No {0} friends", selectedGender.ToLower()));
        //    }
        //}

        private void listViewGroupB_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            genderSelectionChanged(this.listViewGroupB, this.listBoxGroupB, e);
        }

        private void sendAMatchMessage()
        {
            User[] friendsToMatch = new User[] { (User)(this.listBoxGroupA.Items[this.listBoxGroupA.SelectedIndex]), (User)(this.listBoxGroupB.Items[this.listBoxGroupB.SelectedIndex]) };
            string message = string.Empty;
            MatchMessageForm matchMessage = new MatchMessageForm();
            int index = 1;
            matchMessage.ShowDialog();

            foreach (User friend in friendsToMatch)
            {
                message += string.Format(@"Hi {0}!
{1} thinks that you and {2} would be a great match!", friend.Name, this.m_loggedInUser.Name, friendsToMatch[index].Name);
                index = 0;
                if (!matchMessage.IsEmpty)
                {
                    message += string.Format(@" Here are a few of the reasons why:
{0}", matchMessage.MatchMessage);
                }
                //send a message to a friend
                message = string.Empty;
            }
        }
    }
}
