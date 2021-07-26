﻿@model SimpleIdServer.OpenID.UI.ViewModels.RevokeSessionViewModel
@using $rootnamespace$.Resources

@{
    ViewBag.Title = Global.revoke_session_title;
}

@if (!string.IsNullOrWhiteSpace(Model.FrontChannelLogout))
{
    <iframe src="@Model.FrontChannelLogout" style="display: none"></iframe>
}

<a href="@Model.RevokeSessionCallbackUrl" class="btn btn-danger">@Global.revoke_session_title</a>