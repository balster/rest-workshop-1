<%@ Page Language="C#" AutoEventWireup="true"  Inherits="OpenRasta.Codecs.WebForms.ResourceView<Open.Documents.Resources.SearchResults>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    
</head>
<body>
    <form action="/search-results" method="post">
    <input type=text name="documentname" />
    <input type=submit>
    </form>
</body>
</html>
