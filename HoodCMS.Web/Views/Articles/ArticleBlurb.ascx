<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<HoodCMS.Data.Article>" %>
<div class="headline">
    <div class="headlineHeader">
        <%= Html.ActionLink(Model.ArticleTitle, "Details", "Article", new { ID = Model.ArticleId }, null) %>
    </div>
    <div class="headlineSubHeader">
        posted in <%= Html.ActionLink(Model.ArticleCategory.ArticleCategoryLabel, "Category", "Article", new { ID = Url.Encode(Model.ArticleCategory.ArticleCategoryLabel) }, null) %>
        by <%= Html.ActionLink(Model.aspnet_User.UserName, "Details", "Account", new { ID = Model.aspnet_User.UserName }, null) %>
        at <%= Model.ArticleDate.ToShortTimeString() %>
        on <%= Model.ArticleDate.ToShortDateString() %>
    </div>
    <div class="headlineContent">
        <%= Html.Encode(Model.ArticleDescription.Length > 300 ? Model.ArticleDescription.Substring(0, 300) : Model.ArticleDescription )%>... Please see...(<%= Html.ActionLink("MORE", "Details", "Article", new { ID = Model.ArticleId}, null) %>)
    </div>
</div>
