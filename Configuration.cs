using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace WSB_Editor
{
    [XmlRoot("Configuration")]
    public class Configuration
    {
        public string VGpu { get; set; }
        public string Networking { get; set; }
        [XmlElement("MappedFolders")]
        public MappedFolders mappedFolders;
        [XmlElement("LogonCommand")]
        public LogonCommand logonCommand;
    }

    public class MappedFolders
    {
        [XmlElement("MappedFolder")]
        public List<MappedFolder> mappedFolder {get; set; }
    }

    public class MappedFolder
    {
        public string HostFolder { get; set; }
        public string ReadOnly { get; set; }
    }


    public class LogonCommand
    {
        [XmlElement("Command")]
        public List<string> Command { get; set; }
    }
}
