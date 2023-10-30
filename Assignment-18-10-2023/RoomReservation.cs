using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class RoomReservation<T>
    {
       public static List<T> reservations = new List<T>();
        public  void  AddRoom(T room)
        {
            reservations.Add(room);
        }
        public void RemoveRoom(T room)
        {
            reservations.Remove(room);
        }
    }
}
