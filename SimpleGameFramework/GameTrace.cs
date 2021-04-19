using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using SimpleGameFramework.Interface;

namespace SimpleGameFramework
{
    public class GameTrace : ITrace
    {
        // This class has been into a singleton.
        private static GameTrace _gameTrace = new GameTrace();

        public static GameTrace GT => _gameTrace;

        private TraceSource ts = new TraceSource("Marc's game");

        // Here is the logic of how tracing works and where the information will be sent to.
        private GameTrace()
        {
            ts.Switch = new SourceSwitch("Marc", "All");

            TraceListener consoleLog = new ConsoleTraceListener();
            ts.Listeners.Add(consoleLog);

            TraceListener fileLog = new TextWriterTraceListener(new StreamWriter("GameTrace.txt"));
            ts.Listeners.Add(fileLog);
        }

        // This method makes it possible for Tracing to be used.
        public void TraceEvent(string text)
        {
            ts.TraceEvent(TraceEventType.Information, 333, text);
        }

        public void Close()
        {
            ts.Close();
        }
    }
}
