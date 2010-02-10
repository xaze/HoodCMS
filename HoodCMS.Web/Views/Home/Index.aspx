<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<HoodCMS.Web.ViewHelpers.Home>" %>

<asp:Content ID="main" runat="server" ContentPlaceHolderID="MainContent">
<p class="small">
    <%= Html.Encode(Model.Header) %>
</p>
<div class="whatsHappeningInSunnyside">
    <H2><%=Html.ActionLink("Latest News", "Index", "Articles", null, new { @class = "Orange" } )%></H2>
</div>
<% Html.RenderAction("GetNextThree", "Articles"); %>
<div class="upcomingEvents">
    <H2 class="White">Upcoming Events</H2>
</div>
<% Html.RenderAction("GetNextThree", "Occasions"); %>
</asp:Content>
