using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumPoker.Services
{
    public interface IDataService
    {
        public void CreateSession(Guid sessionId);
        public void AddUser(string userName);
        public void RemoveUser(string userName);
        public void UpdateStory(string story);
        public void GivePoint(string user, int points);
    }
}
