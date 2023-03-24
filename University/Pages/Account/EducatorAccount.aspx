<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EducatorAccount.aspx.cs" Inherits="University.Pages.Account.EducatorAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Личный кабинет преподавателя</h1>
            <asp:Button ID="logoutButton" Text="Выйти" OnClick="LogOutButton_Click" runat="server" />
            <h4 id="test" runat="server"></h4>
        </div>
    </form>
</body>
</html>
