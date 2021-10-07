<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Entity2.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Entity Clase 2</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Delegados</h1>
            <div class="row">
                <div class="form-group col-4">
                    <label>Numero 1:</label>
                    <asp:TextBox CssClass="form-control" runat="server" ID="txt_del_1" />
                </div>
                <div class="form-group col-4">
                    <label>Numero 2:</label>
                    <asp:TextBox CssClass="form-control" runat="server" ID="txt_del_2" />
                </div>
                <div class="form-group col-2">
                    <asp:Button CssClass="btn btn-primary mt-4" runat="server" OnClick="SumarDelegado" Text="Enviar" />
                </div>
                <div class="form-group col-2 mt-4">
                   <b><asp:Label ID="lb_delegate" runat="server" /></b>
                </div>
            </div>
            <h1>Métodos Anónimos</h1>
            <div class="row">
                <div class="form-group col-4">
                    <label>Numero 1:</label>
                    <asp:TextBox CssClass="form-control" runat="server" ID="txt_an_1" />
                </div>
                <div class="form-group col-4">
                    <label>Numero 2:</label>
                    <asp:TextBox CssClass="form-control" runat="server" ID="txt_an_2" />
                </div>
                <div class="form-group col-2">
                    <asp:Button CssClass="btn btn-primary mt-4" runat="server" OnClick="RestarAnonimo" Text="Enviar" />
                </div>
                <div class="form-group col-2 mt-4">
                   <b><asp:Label ID="lb_anonimo" runat="server" /></b>
                </div>
            </div>
            <h1>Action</h1>
            <div class="row">
                <div class="form-group col-4">
                    <label>Numero 1:</label>
                    <asp:TextBox CssClass="form-control" runat="server" ID="txt_action_1" />
                </div>
                <div class="form-group col-4">
                    <label>Numero 2:</label>
                    <asp:TextBox CssClass="form-control" runat="server" ID="txt_action_2" />
                </div>
                <div class="form-group col-2">
                    <asp:Button CssClass="btn btn-primary mt-4" runat="server" OnClick="MultiplicarAction" Text="Enviar" />
                </div>
                <div class="form-group col-2 mt-4">
                   <b><asp:Label ID="lb_action" runat="server" /></b>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
