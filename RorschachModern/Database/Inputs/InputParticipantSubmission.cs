﻿using System.Collections.Generic;
using RorschachModern.Database.Models;

namespace RorschachModern.Database.Inputs
{
    public class InputParticipantSubmission
    {
        public int ID { get; set; }
        public List<Response> Responses { get; set; }
    }
}
