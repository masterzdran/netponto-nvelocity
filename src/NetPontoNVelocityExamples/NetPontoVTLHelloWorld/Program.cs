using System;
using NVelocity.App;
using NVelocity;
using System.IO;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      //1 - Initialize Velocity.
      Velocity.Init();
      //2 - Create a Context object (more on what that is later).
      VelocityContext context = new VelocityContext();
      //3 - Add your data objects to the Context.
      context.Put("Name", "Netponto");
      //4 - Choose a template.
      Template t = Velocity.GetTemplate(@"templates/HelloWorld.vm");
      //5 - 'Merge' the template and your data to produce the ouput.
      StringWriter sw = new StringWriter();
      t.Merge(context, sw);

      //Show the result
      Console.WriteLine(sw.GetStringBuilder().ToString());
      Console.ReadKey();
    }
  }
}
