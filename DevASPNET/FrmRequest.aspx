<%@ Page Language="C#" Inherits="DevASPNET.FrmRequest" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<title>FrmRequest</title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
        ID : <asp:TextBox id="UserID" runat="server"></asp:TextBox><br />
        Password : <asp:TextBox id="Password" runat="server"></asp:TextBox><br />
        Name : <asp:TextBox id="Name" runat="server"></asp:TextBox><br />
        Age : <asp:TextBox id="Age" runat="server"></asp:TextBox><br />
        <br />
        <asp:Button id="btnSubmit" runat="server" Text="Send" OnClick="btnSubmit_Click" />
    </div>
    </form>
</body>
</html>
