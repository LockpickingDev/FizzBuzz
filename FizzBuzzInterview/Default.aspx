<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FizzBuzzInterview.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--Enter a string <asp:TextBox ID="userString" runat="server" DefaultButton="userString"></asp:TextBox>--%>
            Input string array is located in backend in var: userInputString<br /><br />
            <asp:Button ID="submitButton" runat="server" Text="Run FizzBuzz" OnClick="submitButton_Click" />
        </div>

        <div style="display:block;">
            <b>FizzBuzz Results:</b><br />
            <label id="FizzBuzzText" runat="server"></label>
        </div>
    </form>
</body>
</html>
