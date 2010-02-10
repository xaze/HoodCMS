<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<HoodCMS.Data.Occasion>>" %>

<%if (Model.Count() > 0)
  {
      foreach(var t in Model){
          Html.RenderPartial("OccasionBlurb", t);
        }
  }
  else
  {
      %>
      <div class="content">
        There are no upcoming Events
      </div>
      <%
  }
%>