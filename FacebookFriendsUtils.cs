namespace C18_Ex01
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using FacebookWrapper;
    using FacebookWrapper.ObjectModel;

    public class FacebookFriendsUtils
    {
        private ArrayList m_currentFriends;
        private bool m_firstCreated;

        internal FacebookFriendsUtils()
        {
            m_firstCreated = true;
        }

        public ArrayList CurrentFriends
        {
            get
            {
                return this.m_currentFriends;
            }

            set
            {
                this.m_currentFriends = value;   
            }
        }

        public bool isFirstCreated
        {
            get
            {
                return this.m_firstCreated;
            }

            set
            {
                this.m_firstCreated = value;
            }
        }

        private ArrayList getFriendsFromFile(string i_fileName)
        {
            FacebookFriendsUtils friendFromFile = null;
            if (File.Exists(i_fileName))
            {
                this.m_firstCreated = false;
                using (Stream stream = new FileStream(i_fileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer deserializer = new XmlSerializer(this.GetType());
                    friendFromFile = deserializer.Deserialize(stream) as FacebookFriendsUtils;
                    friendFromFile.m_firstCreated = false;
                }
            }

            return friendFromFile.CurrentFriends;
        }

        internal void saveFriendListToFile(string i_filePath)
        {
            using (Stream stream = new FileStream(i_filePath, FileMode.OpenOrCreate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        internal void createFirstFriendsFile(string i_filePath)
        {
            if(!File.Exists(i_filePath))
            {
                saveFriendListToFile(i_filePath);
            }
        }

        internal string compareFriendLists(string i_filePath, ref int o_unfriendCount)
        {
            string unfriendedName = null;
            ArrayList friendsFromFile = getFriendsFromFile(i_filePath);
            if(this.m_currentFriends.Count < friendsFromFile.Count)
            {
                foreach(string friendName in friendsFromFile)
                {
                    if(!this.m_currentFriends.Contains(friendName))
                    {
                        unfriendedName += friendName;
                        unfriendedName += Environment.NewLine;
                        o_unfriendCount++;
                    }
                }
            }

            return unfriendedName;
        }
    }
}
