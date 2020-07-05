using System.Collections.Generic;

namespace ScrumPoker.Common
{
    public class SessionInfo
    {
        public string adminUser;

        public string story;

        public Dictionary<string, int> userInfo;

        public SessionInfo()
        {
            userInfo = new Dictionary<string, int>();
        }
    }
}
