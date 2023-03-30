<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HeadlineBlock.ascx.cs" Inherits="University.Controls.Main.HeadlineBlock" %>


<div class="headline-block">
    <div class="separator"></div>

    <asp:Label ID="DateTimeBox" CssClass="published-at" runat="server" />
    <asp:Label ID="TitleBox" CssClass="title" runat="server" />
    <asp:Label ID="TextBox" CssClass="text" runat="server" />

    <asp:HyperLink ID="Link" runat="server">
        <svg class="more-button" viewBox="0 0 24 24" fill="#DDDDDD" xmlns="http://www.w3.org/2000/svg">
            <path d="M12.5858 12L9.29291 8.70703L10.7071 7.29297L15.4142 12L10.7071 16.707L9.29291 15.293L12.5858 12Z"></path>
            <path fill-rule="evenodd" clip-rule="evenodd" d="M12 24C18.6274 24 24 18.6274 24 12C24 5.37256 18.6274 0 12 0C5.37256 0 0 5.37256 0 12C0 18.6274 5.37256 24 12 24ZM22 12C22 17.5229 17.5228 22 12 22C6.47717 22 2 17.5229 2 12C2 6.47705 6.47717 2 12 2C17.5228 2 22 6.47705 22 12Z"></path>
        </svg>
    </asp:HyperLink>
</div>