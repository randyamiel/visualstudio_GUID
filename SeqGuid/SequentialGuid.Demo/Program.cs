//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Randy Amiel 2017">
//     Copyright © Randy Amiel 2017
// </copyright>
//-----------------------------------------------------------------------
namespace SequentialGuid.Demo
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Windows.Forms;

  /// <summary>
  /// The entry point of the application.
  /// </summary>
  public static class Program 
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    public static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new SequentialGuidDemoForm());
    }
  }
}
