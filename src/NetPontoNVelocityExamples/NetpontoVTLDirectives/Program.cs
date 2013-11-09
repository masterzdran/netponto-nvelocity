using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NVelocity;
using NVelocity.App;
using NetPontoVtlDemo.Model;

namespace NetpontoVtlDirectives
{
  class Program
  {
    static void Main(string[] args)
    {
      Boolean write2File = false;
      List<NetPontoModel> npm = new List<NetPontoModel>();
      #region JustForgetAboutIt

      
      npm.Add(new NetPontoModel("SAP Analytics Experience - O Poder da Inteligência Colectiva", "Centro Cultural de Belém, Lisboa "));
      npm.Add(new NetPontoModel("Testing Portugal 2013", "SANA Malhoa Hotel"));
      npm.Add(new NetPontoModel("CMO Forum 2013", "Centro Cultural de Belém"));
      npm.Add(new NetPontoModel("Oracle Day - Lisboa", "Centro de Congressos de Lisboa"));
      npm.Add(new NetPontoModel("LXJS - Lisbon Javascript 2013", "Cinema São Jorge"));
      npm.Add(new NetPontoModel("BSidesLisbon 2013", "Forum Picoas"));
      npm.Add(new NetPontoModel("The Portuguese Perl Workshop 2013", " Portugal Telecom"));
      npm.Add(new NetPontoModel("Cisco Connect Portugal 2013", "Centro de Congressos do Estor"));
      npm.Add(new NetPontoModel("Adobe - Create Now RoadShow 2013", "Meliá Ria Hotel & Spa"));
      npm.Add(new NetPontoModel("EMC Forum 2013", "Centro de Congresso Hotel Myriad by Sana Hotel"));
      npm.Add(new NetPontoModel("World Tech - Tour Novos Desafios e Tendências no eProcurement", " Centro Cultural de Belém - "));
      npm.Add(new NetPontoModel("LxMLS - 3rd Lisbon Machine Learning School", " Instituto Superior Técnico"));
      npm.Add(new NetPontoModel("Big Data & Analytics Forum", "Lisboa"));
      npm.Add(new NetPontoModel("43ª Reunião Presencial da Comunidade NetPonto", "Microsoft Lisbon Experience"));
      
      #endregion

      //1 - Initialize Velocity.
      Velocity.Init();
      //2 - Create a Context object (more on what that is later).
      VelocityContext context = new VelocityContext();

      //3 - Add your data objects to the Context.
      context.Put("Events", npm);

      //4 - Choose a template.
      Template t = Velocity.GetTemplate(@"templates/netponto.vm");
      //5 - 'Merge' the template and your data to produce the ouput.
      StringWriter sw = new StringWriter();
      t.Merge(context, sw);


      String page = sw.GetStringBuilder().ToString();
      //Show the result
      Console.WriteLine(page);

      #region Write2File
      if (write2File)
      {
        StreamWriter file = new StreamWriter(@"templates/netponto.html");
        file.WriteLine(page);
        file.Close();
      }
      #endregion
      Console.ReadKey();
    }
  }
}
