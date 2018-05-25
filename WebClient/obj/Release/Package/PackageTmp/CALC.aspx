<%@ Page Title="Расчет параметров" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CALC.aspx.cs" Inherits="WebClient.CALC" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="container">
        
        <div class="container col-lg-6 col-lg-offset-3 col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
            <asp:Label ID="warning" runat="server" CssClass="alert alert-warning component-label help-block"></asp:Label>
        </div>
        <div class="container">
        </div>
        <div class="container">
            <div class="flex-content">
                <asp:TextBox ID="TextBox1" runat="server" Height="300px" Width="400px" ReadOnly="True" Rows="300" Columns="400" TextMode="MultiLine" CssClass="content"></asp:TextBox>
            </div>
        </div>
        
    </div>
</asp:Content>

