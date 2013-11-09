using System;
using System.Linq;

namespace NetPontoVtlDemo.Model
{
  class NetPontoModel
  {

    public NetPontoModel()
    {
    }

    public NetPontoModel(String name, String localization)
    {
      EventLocalization = localization;
      EventName = name;
    }

    public String EventName { get; set; }
    public String EventLocalization { get; set; }

  }
}
