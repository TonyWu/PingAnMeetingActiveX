﻿using System;
using System.Collections.Generic;

using System.Text;

namespace Cosmoser.PingAnMeetingRequest.Common.Model
{
    public class MeetingRoom
    {
        public string RoomId { get; set; }
        public RoomCategory Category { get; set; }
        public RoomLevel Level { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
      
    }
}
