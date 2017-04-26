using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemInfo
{
    [Serializable]
    class SystemInfoLink
    {
        private string _userID;
        public string UserID
        {
            get { return _userID; }
            //set { _userID = value; }
        }

        private string _systemID;
        public string SystemID
        {
            get { return _systemID; }
            //set { _systemID = value; }
        }

        private int _systemHash;
        public int SystemHash
        {
            get { return _systemHash; }
            //set { _systemHash = value; }
        }

        private long _fileStartPoint;
        public long FileStartPoint
        {
            get { return _fileStartPoint; }
            //set { _fileStartPoint = value; }
        }

        public SystemInfoLink(SystemInformation info, long inFilestartPoint)
        {
            _systemID = info.ID;
            _systemHash = info.Hash;
            _userID = info.UserID;
            _fileStartPoint = inFilestartPoint;
        }
    }
}
