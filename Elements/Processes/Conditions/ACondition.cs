﻿using Org.Reddragonit.BpmEngine.Attributes;
using Org.Reddragonit.BpmEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Org.Reddragonit.BpmEngine.Elements.Processes.Conditions
{
    [ValidParent(typeof(ExtensionElements))]
    [ValidParent(typeof(AConditionSet))]
    internal abstract class ACondition : AParentElement
    {
        public abstract bool Evaluate(ProcessVariablesContainer variables);

        public ACondition(XmlElement elem, XmlPrefixMap map, AElement parent)
            : base(elem, map, parent) { }
    }
}
