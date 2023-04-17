<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PersonInfo.ascx.cs" Inherits="University.Controls.PersonInfo" %>

<div class="person-info-container">
    <asp:Image CssClass="person-photo" ID="PersonPhoto" runat="server" />

    <span class="person-name" id="PersonName" runat="server"></span>
    <span class="person-description" id="PersonDescription" runat="server"></span>
</div>