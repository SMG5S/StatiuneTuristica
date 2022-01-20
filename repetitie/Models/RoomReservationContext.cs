using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RoomReservationApp.Models
{
    public class RoomReservationContext : DbContext
    {
        public RoomReservationContext() : base("RoomContext")
        {
        }
        public DbSet<Room> Rooms { get; set; }
    }
}
