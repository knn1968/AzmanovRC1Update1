using Azmanov.Entities;
using Core;
using Core.Repositories;

namespace Azmanov.Data.Repositories
{
    public interface IEventRepository : IRepository<Event>, IPagingRepository<Event>
    {
        void AddEventPicture(string eventId, EventPicture eventPicture);
    }
}