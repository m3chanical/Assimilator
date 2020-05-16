using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clio.Utilities;
using ff14bot.Enums;

namespace Assimilator.Models
{
    public class TimedNodesDataBase
    {
        public List<TimedNode> TimedNodes { get; set; }
    }

    public class TimedNode
    {
        public uint NodeId { get; set; }
        public GatheringType Type { get; set; }
        public int Level { get; set; }
        public List<KeyValuePair<byte, byte>> TimeSlots { get; set; } // first -> start time, second -> end time
        public uint ItemId { get; set; }
        public ushort ZoneId { get; set; }
        public List<Vector3> Locations { get; set; }
    }
}
