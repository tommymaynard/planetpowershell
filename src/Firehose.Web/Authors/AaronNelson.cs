using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class AaronNelson : IAmAMicrosoftMVP, IFilterMyBlogPosts
    {
        public string FirstName => "Aaron";
        public string LastName => "Nelson";
        public string ShortBioOrTagLine => "Microsoft SQL Server (Data Platform) MVP and leader of the PowerShell Virtual Group of PASS";
        public string StateOrRegion => "Georgia, USA";
        public string EmailAddress => "";
        public string TwitterHandle => "SQLvariant";
        public string GitHubHandle => "SQLvariant";
        public string GravatarHash => "";
        public GeoPosition Position => new GeoPosition(, );
        public Uri WebSite => new Uri("http://SQLvariant.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://feeds.feedburner.com/Sqlvariations"); } }
        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("powershell"));
        }
    }
}