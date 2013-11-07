using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPontoNVelocityExamples
{
  class Methodz
  {

    public Methodz(String visibility, String name)
    {
      Visibility = visibility;
      Name = name;
    }
    public String Visibility { get; set; }
    public String Name { get; set; }
    public String ReturnType { get; set; }
    public IEnumerable<String> ParamType { get; set; }
  }
}
