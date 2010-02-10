<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<HoodCMS.Data.Article>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="whatsHappeningInSunnyside">
    <H2 class="Orange">Latest Article</H2>
</div>
    <% foreach (var t in Model)
       { 
         Html.RenderPartial("ArticleBlurb", t);
    } %>
</asp:Content>
