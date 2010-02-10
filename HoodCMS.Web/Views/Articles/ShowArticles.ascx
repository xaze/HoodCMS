<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<HoodCMS.Data.Article>>" %>

<%if (Model.Count() > 0)
  {
      foreach(var t in Model){
            Html.RenderPartial("ArticleBlurb", t); 
        }
  }
  else
  {
      %>
      <div class="content">
        There are no new Articles
      </div>
      <%
  }
%>