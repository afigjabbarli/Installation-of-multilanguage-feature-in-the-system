﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Common
{
    public interface ICommandHandler
    {
        void Handle(); //ABSTRACT method
    }
}
