using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.IO;
using System.Xml.Serialization;

namespace C18_Ex01
{
    internal class FacebookFriendsUtils
    {
        internal ArrayList m_friendsFromFile;
        internal ArrayList m_currentFriends;
        internal bool m_firstCreated;
        internal FacebookFriendsUtils(string fileName, string userName)
        {
            getFriendsFromFile(fileName, userName);
            m_firstCreated = true;
        }

        internal ArrayList CurrentFriends
        {
            set
            {
                this.m_currentFriends = value;   
            }
        }

        private void getFriendsFromFile(string fileName, string userName)
        {
            if (File.Exists(fileName))
            {
                this.m_firstCreated = false;
                using (Stream stream = new FileStream(fileName, FileMode.OpenOrCreate))
                    {
                        XmlSerializer deserializer = new XmlSerializer(this.m_friendsFromFile.GetType());
                        this.m_friendsFromFile = deserializer.Deserialize(stream) as ArrayList;
                    }
            }
        }

        internal void saveFriendListToFile()
        {
            using (Stream stream = new FileStream(@"C:/Users/miril/Desktop/fbFriends.xml", FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.m_currentFriends.GetType());
                serializer.Serialize(stream, this.m_currentFriends);
            }
        }
    }
}
