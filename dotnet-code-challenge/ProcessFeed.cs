using System;
using System.Xml.Linq;

namespace dotnet_code_challenge
{
    class ProcessFeed
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: pass feed file as 1st parameter [feed.json | feed.xml ");
                Environment.Exit(-1);
                return;
            }

            FeedReader.Init().Create(args[0]).ProcessFeed();
        }
    }
}
