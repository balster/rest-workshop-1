using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Open.Documents.Resources;
using OpenRasta;
using OpenRasta.Web;

namespace Open.Documents.Handlers
{
    
    public class SearchResultsHandler
    {
        public OperationResult Post(string term)
        {
            // 303
            return new OperationResult.SeeOther()
                       {
                           RedirectLocation = new Uri("/search-results/{term}")
                       };
        }
        
        public OperationResult Get(string term)
        {
            if (term.Contains("coffee"))
                return new ImATeapotOperationResult() { ResponseResource = new ReturnCoffeMate(term)};
           return new OperationResult.OK { ResponseResource = new ReturnCoffeMate(term) };
        }
    }
}