using System;
using System.Collections.Generic;
using System.Drawing;
using ScrumPoker.Common;

namespace ScrumPoker.Services
{
    public class DataService : IDataService
    {
        private Dictionary<Guid, SessionInfo> sessionInfoDict;

        public DataService()
        {
            sessionInfoDict = new Dictionary<Guid, SessionInfo>();
        }

        public void AddUser(Guid sessionId, string userName)
        {
            if (IsInvalidSession(sessionId))
            {
                return;
            }
            sessionInfoDict[sessionId].userInfo.Add(userName, 0);
        }

        public void CreateSession(Guid sessionId, string user)
        {

            var sessionInfo = new SessionInfo();
            sessionInfo.adminUser = user;
            sessionInfo.userInfo.Add(user, 0);
            sessionInfoDict.Add(sessionId, sessionInfo);
        }

        public void GivePoint(Guid sessionId, string user, int points)
        {
            if (IsInvalidSession(sessionId))
            {
                return;
            }
            sessionInfoDict[sessionId].userInfo[user] = points;
        }

        public void RemoveUser(Guid sessionId, string userName)
        {
            if (IsInvalidSession(sessionId))
            {
                return;
            }
            sessionInfoDict[sessionId].userInfo.Remove(userName);
        }

        public void UpdateStory(Guid sessionId, string story)
        {
            if(IsInvalidSession(sessionId))
            {
                return;
            }
            sessionInfoDict[sessionId].story = story;
        }

        private bool IsInvalidSession(Guid sessionId)
        {
            return sessionInfoDict.ContainsKey(sessionId);
        }
    }
}
