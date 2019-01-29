using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.ViewModels
{
    public class RoomCreateViewModel
    {
        public Room Room { get; set; }
        public Layout Layout { get; set; }
        public string Name { get; set; }
    }
}
