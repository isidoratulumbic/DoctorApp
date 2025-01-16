
using Classes.Model;
using Classes.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Classes.Service
{
   public class RoomService
   {
      RoomRepository roomRepository = new RoomRepository();
      public void CreateRoom(Room room)
      {
          int id = GenerateNewId();
          room.id = id;
          roomRepository.CreateRoom(room);
        }
      public void CreatePendingRoom(Room room)
      {
         int id = GenerateNewId();
         room.id = id;
         roomRepository.CreatePendingRoom(room);
      }
      public Room ReadRoomById(int id)
      {
         return roomRepository.ReadRoomById(id);
      }
      public Room ReadRoomByName(string roomName)
      {
         return roomRepository.ReadRoomByName(roomName);
      }
      public void UpdateRoom(Room room)
      {
         roomRepository.UpdateRoom(room);
      }

        public void DeleteRoomById(int id)
        {
            roomRepository.DeleteRoomById(id);
        }
        public void DeleteRoomByName(string roomName)
        {
            roomRepository.DeleteRoomByName(roomName);
        }
      public List<Room> ReadAllRooms()
      {
         return roomRepository.ReadAllRooms();
      }
      
      public void MergeRooms(List<Room> RoomsForMerge)
      {
         //todo
      }
      
      public void SplitRoom(Classes.Model.Room roomForSplit, int numberOfSplits)
      {
         //todo
      }
        public int GenerateNewId()
        {
            try
            {
                List<Room> rooms = roomRepository.ReadAllRooms();
                int maxId = rooms.Max(obj => obj.id);
                return maxId + 1;
            }
            catch
            {
                return 1;
            }
        }
    }
}