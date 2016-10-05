using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Player")]
public class Player
{
    [XmlArray("BasicInfo")]
    public List<playerBasicInfo> BasicInfo = new List<playerBasicInfo>();
}