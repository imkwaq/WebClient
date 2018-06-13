<%@ Page Title="Чтение из файла" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FILE_READ.aspx.cs" Inherits="WebClient.FILE_READ" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="container">
        <div class="row">            
            <div class="container col-md-5 col-md-offset-3">
                <asp:Label ID="warning" runat="server" CssClass="alert alert-warning component-label help-block"></asp:Label>
                <div class="alert alert-info">
                    <p>Все файлы хранятся на сервере, запомните имя файла для повторной работы с ним</p>
                </div>
                <div class="panel panel-default">
                    <div class="panel-body">
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                            <div class="row col-md-12">
                                <label class="col-md-6 col-lg-6 component-label">Введите имя файла</label>                              
                                <asp:TextBox ID="TextBox1" placeholder="например z" runat="server"  AutoCompleteType="Disabled" CssClass="form-control col-md-6 col-lg-6"></asp:TextBox>
                            </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group">
                            <div class="container flex-content">
                                <asp:Button ID="ReadFile" runat="server" OnClick="ReadFile_Click" Text="Ввести данные" CssClass="btn btn-info" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>    
</asp:Content>
