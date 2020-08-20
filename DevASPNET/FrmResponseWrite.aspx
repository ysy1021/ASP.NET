<%@ Page Language="C#" Inherits="DevASPNET.FrmResponseWrite" %>
<!DOCTYPE html>
<html>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<head runat="server">
	<title>FrmResponseWrite</title>
</head>
<body>
	<form id="form1" runat="server">
        <div>
            <asp:Button id="btnClick" runat="server" Text="Click" OnClick="btnClick_Click"/>
            <br/>
            <%="See you again<br/>"%>
            <asp:Button id="btnJavaScript" runat="server" Text="자바스크립트로 인사말 출력" onClick="btnJavaScript_Click"/>
        </div>
	</form>
</body>
</html>
