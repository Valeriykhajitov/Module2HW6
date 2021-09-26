using ModuleHomework.App;
using ModuleHomework.Providers;
using ModuleHomework.Services;
using System;

namespace ModuleHomework
{
  class Program
  {


    static void Main(string[] args)
    {
      var Starter = new Startup();
      Starter.Run();
    }
  }
}
