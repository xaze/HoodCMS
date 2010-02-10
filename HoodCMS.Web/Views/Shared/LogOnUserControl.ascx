<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%
    if (Request.IsAuthenticated) {
%>
        <span style="color: #fff;">Welcome <%= Html.Encode(Page.User.Identity.Name) %></span>
        <%= Html.ActionLink("Log Off", "LogOff", "Account", null, new { style = "color: #fff" })%>
<%
    }
    else {
%> 
        <%= Html.ActionLink("member login", "LogOn", "Account", null, new { style = "color: #fff" })%>
<%
    }
%>
