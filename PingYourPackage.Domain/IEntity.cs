﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingYourPackage.Domain
{
    public interface IEntity
    {
        Guid Key { get; set; }
    }
}
