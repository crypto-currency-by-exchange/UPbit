using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace ShareInvest.UPbit.Models;

public class MarketEvent
{
    public bool Warning
    {
        get; set;
    }

    [NotMapped]
    public virtual Caution? Caution
    {
        get; set;
    }

    [DataMember, Newtonsoft.Json.JsonIgnore, Key]
    public string? Code
    {
        get; set;
    }

    public virtual void SetPrimaryKey(string? key)
    {
        if (Caution != null)
        {
            Caution.Code = key;
        }
        Code = key;
    }
}