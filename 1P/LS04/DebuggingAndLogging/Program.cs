using System;
using static System.Console;
using System.Diagnostics;
using System.IO;

namespace DebuggingAndLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            // Debug -> Debug run
            // Trace -> Release run
            Trace.Listeners.Add(new TextWriterTraceListener(
                File.CreateText("log.txt")
            ));
            Trace.AutoFlush = true;
            Debug.WriteLine("Debug says, IM WATCHING YOU!!! ");
            Trace.WriteLine("Trace says, IVAN ET NIOJ");
        }
    }
}
