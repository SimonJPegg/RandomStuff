﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
</head>
<body>
    <div>
        <form method="post" action="">
            <input type="text" name="SessionInput" />
            <input type="submit" value="add" name="add" />
            <input name="check" type="submit" value="Check" />
            <span id="SessionSpan"><%= Session["SampleText"] %></span>
        </form>
    </div>
</body>
</html>
