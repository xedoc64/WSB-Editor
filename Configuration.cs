using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;


namespace WSB_Editor
{
    /// <summary>
    /// Configuration node
    /// </summary>
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

    /// <summary>
    /// MappedFolders node
    /// </summary>
    public class MappedFolders
    {
        [XmlElement("MappedFolder")]
        public List<MappedFolder> mappedFolder {get; set; }
    }

    /// <summary>
    /// MappedFolder item
    /// </summary>
    public class MappedFolder
    {
        public string HostFolder { get; set; }
        public string ReadOnly { get; set; }
    }

    /// <summary>
    /// LogonCommand node
    /// </summary>
    public class LogonCommand
    {
        [XmlElement("Command")]
        public List<string> Command { get; set; }
    }
}
