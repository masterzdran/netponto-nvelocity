using System;
using System.IO;
using System.Linq;
using NVelocity;
using NVelocity.App;
using System.Collections.Generic;


/*
 * adapted from: 
 * http://francisodisi.wordpress.com/2010/07/24/nvelocity-exemplo-basico-de-utilizacao/
 * 
 * user guide
 * http://velocity.apache.org/engine/devel/developer-guide.html
 * */
namespace NetPontoNVelocityExamples
{
  class Program
  {
    static void Main(string[] args)
    {


      /*
       * from:
       * http://velocity.apache.org/engine/devel/developer-guide.html#thefundamentalpattern
       * When using Velocity in an application program or in a servlet (or anywhere, actually), you will generally do the following:
       * 1 - Initialize Velocity.
       * 2 - Create a Context object (more on what that is later).
       * 3 - Add your data objects to the Context.
       * 4 - Choose a template.
       * 5 - 'Merge' the template and your data to produce the ouput.
       * */
      List<String> argsType = new List<String>();
      argsType.Add("int");
      argsType.Add("String");

    
      Methodz m1 = new Methodz("public", "m1");
      m1.ReturnType ="void";
      m1.ParamType = argsType;
      
      Methodz m2 = new Methodz("private", "m2");
      m2.ReturnType = "String";
      m2.ParamType = argsType;

      List<Methodz> ms = new List<Methodz>();
      ms.Add(m1);
      ms.Add(m2);

      
      Classz c = new Classz("MyClass");
      c.Visibility = "public";
      c.Methods = ms;


      //1 - Initialize Velocity.
      Velocity.Init();
      //2 - Create a Context object (more on what that is later).
      VelocityContext context = new VelocityContext();
      //3 - Add your data objects to the Context.
      context.Put("Name", "Velocity");

      context.Put("Class", c);
      //4 - Choose a template.
      Template t = Velocity.GetTemplate(@"views/teste.vm");
      //5 - 'Merge' the template and your data to produce the ouput.
      StringWriter sw = new StringWriter();
      t.Merge(context, sw);



      //VelocityEngine v = new VelocityEngine();
      //v.Init();
      //ExtendedProperties p = new ExtendedProperties();
      //v.Init(p);
      //Template t = v.GetTemplate(@"views/teste.vm");
      //VelocityContext vc = new VelocityContext();
      //vc.Put("Name", "Netponto");
      //StringWriter sw = new StringWriter();
      //t.Merge(vc, sw);

      

      //Show the result
      Console.WriteLine(sw.GetStringBuilder().ToString());
      Console.ReadKey();
    }
  }
}
