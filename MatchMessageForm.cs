﻿namespace C18_Ex01
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    internal partial class MatchMessageForm : Form
    {
        private bool m_isEmptyMessage;
        private string m_matchMessage;

        internal MatchMessageForm()
        {
            InitializeComponent();
        }

        internal bool IsEmpty
        {
            get
            {
                return this.m_isEmptyMessage;
            }
        }

        internal string MatchMessage
        {
            get
            {
                return this.m_matchMessage;
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if(this.textBoxMatchMessage.TextLength == 0)
            {
                this.m_isEmptyMessage = true;
                this.m_matchMessage = string.Empty;
            }
            else
            {
                this.m_matchMessage = this.textBoxMatchMessage.Text;
                this.m_isEmptyMessage = false;
            }

            this.Close();
        }
    }
}
