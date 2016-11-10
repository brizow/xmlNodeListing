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
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("QuantosExample.xml");
            //declare some blank variables
            string category = "", title = "", director = "", episode = "", year = "", price = "";
            //select nodes from the parent/child/
            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/tvshows/tvshow");
            //declare a top level element to grab attributes
            XmlElement element = xmlDoc.DocumentElement;
            for (int i = 0; i < nodeList.Count; i++)
            {
                try
                {
                    category = nodeList[i].Attributes["category"].Value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


            foreach (XmlNode node in nodeList)
            {
                try
                {
                    
                    title = node.SelectSingleNode("title").InnerText;
                    director = node.SelectSingleNode("director").InnerText;
                    episode = node.SelectSingleNode("episode").InnerText;
                    year = node.SelectSingleNode("year").InnerText;
                    price = node.SelectSingleNode("price").InnerText;
                    //MessageBox.Show(episode + " ");
                    if (episode != "")
                    {
                        //we just want episodes right now
                        Console.WriteLine(episode);
                    }
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
    }
}
