<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<HoodCMS.Data.Occasion>" %>

<div class="headline">
    <div class="headlineHeader">
        <%= Html.ActionLink(Model.OccasionName, "Details", "Occasions", new { ID = Model.OccasionName.ToLower().Trim().Replace(' ', '-') }, null) %>
        @ <%= Html.ActionLink(Model.Entity.EntityName, "Details", "Entity", new { ID = Model.EntityId }, null) %>
    </div>
    <div class="headlineSubHeader">
        <%= Model.OccasionStartDate.ToShortTimeString() %> - <%= Model.OccasionEndDate.ToShortTimeString() %> <%= Model.OccasionStartDate.ToLongDateString() %>
    </div>
</div>