<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmResponseRedirect.aspx.cs" Inherits="DevASPNET.FrmResponseRedirect" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />    
	<title>Response 개체</title>
</head>
<body>
	<form id="form1" runat="server">
            <div>
                <asp:Button id="btnDotNetKorea"
                            runat="server"
                            Text="DotNetKorea"
                            OnClick="btnDotNetKorea_Click"/>
                <br />
                <asp:LinkButton id="btnDevLec"
                                runat="server"
                                OnClick="btnDevLec_Click">DevLec</asp:LinkButton>
                <br />
                <asp:ImageButton id="btnVisualAcademy"
                                 runat="server"
                                 AlternateText="VisualAcademy"
                                 ToolTip="Hawaso"
                                 OnClick="btnVisualAcademy_Click"
                                 Style="height:16px" /><br />
            </div>
	</form>
</body>
</html>
