﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models.Interfaces
{
    public interface ISoldier
    {
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
    }
}
