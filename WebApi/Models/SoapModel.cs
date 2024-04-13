using System.Runtime.Serialization;

namespace WebApi.Models;

[DataContract]
public class SoapModel
{
    [DataMember]
    public string Operation { get; set; }

    [DataMember]
    public string Number1 { get; set; }

    [DataMember]
    public string Number2 { get; set; }
}