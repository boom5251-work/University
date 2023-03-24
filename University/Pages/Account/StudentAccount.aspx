<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentAccount.aspx.cs" Inherits="University.Pages.Account.StudentAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Личный кабинет студента</h1>
            <asp:Button ID="LogOutButton" Text="Выйти" OnClick="LogOutButton_Click" runat="server" />
            <h4 id="test" runat="server"></h4>
        </div>
    </form>
</body>
</html>
