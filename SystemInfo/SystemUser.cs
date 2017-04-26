using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemInfo
{
    [Serializable]
    public class SystemUser
    {
        private string _userID = "0";
        public string UserID
        {
            get { return _userID; }
            //set { _userID = value; }
        }

        private string _name = "User";
        public string Name
        {
            get { return _name; }
            //set { _name = value; }
        }

        private string _systemId = "0";
        public string SystemId
        {
            get { return _systemId; }
            //set { _systemId = value; }
        }

    }
}
