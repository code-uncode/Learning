using System;
using System.Collections.Generic;
using System.Drawing;
using Microsoft.AspNetCore.Components;
using ScrumPoker.Common;

namespace ScrumPoker.Services
{
    public class DataService : IDataService
    {
        private Dictionary<Guid, SessionInfo> sessionInfoDict;

        [Inject]
        private NavigationManager _navService { get; set; }
        public DataService()
        {
            sessionInfoDict = new Dictionary<Guid, SessionInfo>();
        }

        public void AddUser(Guid sessionId, string userName)
        {
            
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
            
            sessionInfoDict[sessionId].userInfo[user] = points;
        }

        public void RemoveUser(Guid sessionId, string userName)
        {
            
            sessionInfoDict[sessionId].userInfo.Remove(userName);
        }

        public void UpdateStory(Guid sessionId, string story)
        {
            
            sessionInfoDict[sessionId].story = story;
        }

        public bool IsUserAdmin(Guid sessionId, string user)
        {

            return sessionInfoDict[sessionId].adminUser == user;
        }

        public  bool IsValidSession(Guid sessionId)
        {
            
            return sessionInfoDict.ContainsKey(sessionId);
        }
    }
}
