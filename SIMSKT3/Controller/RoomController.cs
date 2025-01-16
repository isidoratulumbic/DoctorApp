
using System;
using System.Collections.Generic;
using Classes.Model;
using Classes.Service;

namespace Classes.Controller
{
   public class RoomController
   {
      RoomService roomService = new RoomService();
      public void CreateRoom(Room rum)
      {
         roomService.CreateRoom(rum);
      }
      public void CreatePendingRoom(Room rum)
      {
         roomService.CreatePendingRoom(rum);
      }

      public Room ReadRoomById(int id)
      {
         return roomService.ReadRoomById(id);
      }
        public Room ReadRoomByName(string roomName)
        {
            return roomService.ReadRoomByName(roomName);
        }

        public void UpdateRoom(Room room)
        {
            roomService.UpdateRoom(room);
        }
      
      public void DeleteRoomById(int id)
      {
           roomService.DeleteRoomById(id);
      }

      public void DeleteRoomByName(string roomName)
      {
           roomService.DeleteRoomByName(roomName);
      }

      public List<Room> ReadAllRooms()
      {
           return roomService.ReadAllRooms();
      }
      
      public void MergeRooms(List<Room> RoomsForMerge)
      {
         throw new NotImplementedException();
      }
      
      public void SplitRoom(Classes.Model.Room roomForSplit, int numberOfSplits)
      {
         throw new NotImplementedException();
      }
   }
}