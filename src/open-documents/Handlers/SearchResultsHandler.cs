using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Open.Documents.Resources;

namespace Open.Documents.Handlers
{
    
    public class SearchResultsHandler
    {
        public SearchResults Post(string document)
        {
            return new SearchResults();
        }
        // querystring
        public SearchResults Get (string querys)
        {
            return new SearchResults();
        }
    }
}