using System;
using System.IO;
using NVelocity;
using NVelocity.App;
using NetPontoVtlDemo.Model;

namespace NetPontoVtlDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      NetPontoModel npm = new NetPontoModel();
      npm.EventName="Netponto";
      npm.EventLocalization="Parque das Nações";

      //1 - Initialize Velocity.
      Velocity.Init();
      //2 - Create a Context object (more on what that is later).
      VelocityContext context = new VelocityContext();
      
      //3 - Add your data objects to the Context.
      context.Put("Name", "Netponto");
      context.Put("Event",npm);


      //4 - Choose a template.
      Template t = Velocity.GetTemplate(@"template/netponto.vm");
      //5 - 'Merge' the template and your data to produce the ouput.
      StringWriter sw = new StringWriter();
      t.Merge(context, sw);

      //Show the result
      Console.WriteLine(sw.GetStringBuilder().ToString());
      Console.ReadKey();
    }
  }
}
