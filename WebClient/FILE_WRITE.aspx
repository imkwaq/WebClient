<%@ Page Title="Запись в файл" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FILE_WRITE.aspx.cs" Inherits="WebClient.FILE_WRITE" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="container">
        <div class="row">
            <div class="container col-md-5 col-md-offset-3">
                <div class="alert alert-info">
                    <p>Все файлы хранятся на сервере, запомните имя файла для повторной работы с ним</p>
                </div>
                <div class="panel panel-default">
                    <div class="panel-body">
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                            <div class="row col-md-12">
                                <label class="col-md-6 col-lg-6 component-label">Введите имя файла</label>
                               <asp:TextBox ID="TextBox1" runat="server" placeholder="например z" AutoCompleteType="Disabled" CssClass="form-control col-md-6 col-lg-6"></asp:TextBox>
                            </div>
                            <%--</div>--%>
                        </div>                        
                        <div class="form-group">
                            <div class="container flex-content">
                                <asp:Button ID="WriteFile" runat="server" OnClick="WriteFile_Click" Text="Сохранить в файл" CssClass="btn btn-info" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
