using System.Collections.Generic;

namespace login.Models
{
    public class Accounts
    {
    public List<Info> Info { get; private set; } = new List<Info>();

    public void AddAcount(Info field){
      Info.Add(field);
    }
  }
}