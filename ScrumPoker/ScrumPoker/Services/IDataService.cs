using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumPoker.Services
{
    public interface IDataService
    {
        public void CreateSession(Guid sessionId, string user);
        public void AddUser(Guid sessionId, string userName);
        public void RemoveUser(Guid sessionId, string userName);
        public void UpdateStory(Guid sessionId, string story);
        public void GivePoint(Guid sessionId, string user, int points);
        public bool IsUserAdmin(Guid sesionId, string user);
        public bool IsValidSession(Guid sessionId);
    }
}
