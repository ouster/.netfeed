using System;
using System.Collections.Generic;
using System.IO;

namespace dotnet_code_challenge
{

    public enum FeedType
    {
        XML,
        JSON
    }

    public interface IFeedReader
    {
        IDictionary<decimal, string> ProcessFeed();
    }

    public class FeedReader
    {

        public static FeedReader Init() => new FeedReader();

        //simple factory
        public IFeedReader Create(string feedFile)
        {
            string ext = Path.GetExtension(feedFile).ToUpper();
            if (ext == "." + FeedType.XML.ToString())
            {
                return (IFeedReader)new XMLFeedReader(feedFile);
            }
            if (ext == "." + FeedType.JSON.ToString())
            {
                return (IFeedReader)new JSONFeedReader(feedFile);
            }

            throw new NotSupportedException();
        }
    }
}
