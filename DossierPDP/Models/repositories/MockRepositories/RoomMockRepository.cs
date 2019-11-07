using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DossierPDP.Models.repositories
{
    public class RoomMockRepository : IRoomRepository
    {
        private List<Room> _roomList;
        public RoomMockRepository()
        {
            _roomList = new List<Room>()
            {
                new Room() { RoomId = 1, RoomName = "Orangerie"},
                new Room() { RoomId = 2, RoomName = "Feestaal"},
                new Room() { RoomId = 3, RoomName = "Tuin"}
            };
        }
        public IEnumerable<Room> GetAllRoom()
        {
            return _roomList;
        }
    }
}
