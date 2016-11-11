using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QuantosTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("QuantosExample.xml");
                //declare some blank variables
                string episode = "";
                //select nodes from the parent/child/
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/tvshows/tvshow/episode");
                //declare a top level element to grab attributes
                XmlElement element = xmlDoc.DocumentElement;
                for (int i = 0; i < nodeList.Count; i++)
                {
                    try
                    {
                        //category = nodeList[i].Attributes["category"].Value;
                        episode = nodeList[i].InnerText;
                        Console.WriteLine(episode);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                //tell the user how to leave
                Console.WriteLine(System.Environment.NewLine + "Hit a key to close this window.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
