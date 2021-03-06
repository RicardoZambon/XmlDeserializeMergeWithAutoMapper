﻿using System.Xml.Serialization;
using XmlDeserializeMergeWithAutoMapper.Attributes;
using XmlDeserializeMergeWithAutoMapper.Interfaces;

namespace XmlDeserializeMergeWithAutoMapper.XmlNodes.Model
{
    public class Entity : IXmlNode
    {
        [XmlAttribute, MergeKey]
        public string Id { get; set; }

        [XmlAttribute]
        public string DisplayName { get; set; }
    }
}