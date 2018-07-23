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
    public partial class MatchForm : Form
    {
        User m_loggedInUser;
        public MatchForm(User loggedInUser)
        {
            m_loggedInUser = loggedInUser;
            InitializeComponent();
        }

        //private void listViewGroupA_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    this.listBoxGroupA.Items.Clear();
        //    this.listBoxGroupA.DisplayMember = "Name";
        //    int selectedIndex = this.listViewGroupA.SelectedIndices[0];
        //    string gender = null;
        //    if(selectedIndex == 0)
        //    {
        //        gender = "male";
        //    }
        //    else
        //    {
        //        gender = "female";
        //    }
        //    foreach (User friend in m_loggedInUser.Friends)
        //    {
        //        if(friend.Gender.ToString() == gender)
        //        {
        //            this.listBoxGroupA.Items.Add(friend);
        //        }
        //    }
        //    if(this.listBoxGroupA.Items.Count == 0)
        //    {
        //        this.listBoxGroupA.Items.Add(string.Format(@"No {0} friends", gender));
        //    }
        //}


        private void button1_Click(object sender, EventArgs e)
        {
            if(this.listBoxGroupA.SelectedItems.Count != 1 || this.listBoxGroupB.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please choose one person from each list", "Error!", MessageBoxButtons.OK);
            }
            if (this.listBoxGroupA.SelectedItem.ToString() == this.listBoxGroupB.SelectedItem.ToString())
            {
                MessageBox.Show("Can't select the same person twice", "Error!", MessageBoxButtons.OK);
            }
        }

        private void listViewGroupA_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            genderSelectionChanged(this.listViewGroupA ,this.listBoxGroupA, e);
        }

        private void genderSelectionChanged(ListView genderList, ListBox friendsList, ListViewItemSelectionChangedEventArgs genderChangedEvent)
        {
            string selectedGender = genderChangedEvent.Item.Text;
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
            foreach (User friend in m_loggedInUser.Friends)
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
    }
}
