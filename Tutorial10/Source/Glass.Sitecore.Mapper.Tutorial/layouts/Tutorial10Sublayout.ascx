<%@ Control Language="c#" AutoEventWireup="true" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" Inherits="Glass.Sitecore.Mapper.Web.Ui.GlassDynamicUserControl, Glass.Sitecore.Mapper" %>

<div>
<%= Model.Title %>
</div>

<div>
<%= Model.Content.Editable() %>
</div>

<div>
<%= Model.Date %>
</div>

<div>
<%= Model.Url %>
</div>

<div>
<%= Model.Path %>
</div>

<ul>
    <%foreach(var child in Model.Children){ %>
    <li><a href="<%=child.Url %>"><%=child.Title %></a></li>

    <%} %>
</ul>

<a href="<%=Model.Parent.Url%>"><%=Model.Parent.Title %></a>