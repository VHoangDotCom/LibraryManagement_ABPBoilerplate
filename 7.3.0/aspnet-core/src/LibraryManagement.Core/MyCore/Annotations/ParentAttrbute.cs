﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.MyCore.Annotations
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ParentAttrbute : Attribute
    {
        public Type ParentType { get; set; }
    }
}
