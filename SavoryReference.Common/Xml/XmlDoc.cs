﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SavoryReference.Common.Xml
{
    public class XmlDoc
    {
        public XmlAssembly Assembly { get; set; }

        public XmlMember[] Members { get; set; }
    }
}