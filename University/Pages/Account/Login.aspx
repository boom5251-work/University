<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="University.Pages.Account.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Вход в личный кабинет студента и преподавателя</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="EmailInput" TextMode="Email" runat="server" />
            <asp:TextBox ID="PasswordInput" TextMode="Password" runat="server" />
            <asp:Button ID="LoginButton" OnClick="LoginButton_Click" runat="server" Text="Войти" />
        </div>
    </form>
</body>
</html>
