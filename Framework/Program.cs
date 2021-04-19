using System;
using System.Runtime.CompilerServices;
using System.Xml;
using SimpleGameFramework;

namespace Framework
{
    public class Program
    {
        static void Main(string[] args)
        {
            GameWorker gWorker = new GameWorker(ReadMaxX(), ReadMaxY());
            gWorker.Start();
        }

        // Here is where the config file is read and returns the max X of the game world.
        private static int ReadMaxX()
        {
            XmlDocument configDoc = new XmlDocument();
            configDoc.Load(@"F:\ASWC\GameWorldConfig.conf");

            XmlNode maxXNode = configDoc.DocumentElement.SelectSingleNode("MaxX");
            if (maxXNode != null)
            {
                String maxXStr = maxXNode.InnerText.Trim();
                int maxX = Convert.ToInt32(maxXStr);


                Console.WriteLine("Max X er " + maxX);
                return maxX;
            }

            return ReadMaxX();
        }

        // Here is where the config file is read, again, and returns the max Y of the game world.
        private static int ReadMaxY()
        {
            XmlDocument configDoc = new XmlDocument();
            configDoc.Load(@"F:\ASWC\GameWorldConfig.conf");

            XmlNode maxYNode = configDoc.DocumentElement.SelectSingleNode("MaxY");
            if (maxYNode != null)
            {
                String maxYStr = maxYNode.InnerText.Trim();
                int maxY = Convert.ToInt32(maxYStr);


                Console.WriteLine("Max Y er " + maxY);
                return maxY;
            }

            return ReadMaxY();
        }
    }
}
