<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmPageLoad.aspx.cs" Inherits="DevASPNET.FrmPageLoad" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<title>Page Class</title>
</head>
<body>
	<form id="form1" runat="server">
            <div>
                <asp:Button id="btnPostBack" runat="server"
                            Text="Post again(PostBack)" OnClick="btnPostBack_Click" />
                <asp:Button id="btnNewLoad" runat="server"
                            OnClick="btnNewLoad_Click" Text="Load again" />
            </div>
	</form>
</body>
</html>
