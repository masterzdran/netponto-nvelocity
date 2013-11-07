using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPontoNVelocityExamples
{
  class Classz
  {
    public String  Visibility { get; set; }
    public String Name { get; set; }
    public IEnumerable<Methodz> Methods { get; set; }

    public Classz(String name)
    {
      Name = name;
    }
  }
}
