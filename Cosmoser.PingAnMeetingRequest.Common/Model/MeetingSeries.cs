﻿using System;
using System.Collections.Generic;

using System.Text;

namespace Cosmoser.PingAnMeetingRequest.Common.Model
{
    public class MeetingSeries
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
