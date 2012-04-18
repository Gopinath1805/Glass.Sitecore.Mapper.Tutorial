<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Tutorial11Sublayout.ascx.cs" Inherits="Glass.Sitecore.Mapper.Tutorial.layouts.Tutorial11Sublayout" %>

<h1>
    <%= Editable(x => x.Title) %>
</h1>

<p>
    <%= Model.Content %>
</p>
<p>
    <%= Model.Date%>
</p>