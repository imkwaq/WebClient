<%@ Page Title="Описание резисторов" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="R.aspx.cs" Inherits="WebClient.R1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="container">
        <div class="row">
            <div class="container col-lg-4 col-lg-offset-4 col-md-4 col-md-offset-4 col-sm-4 col-sm-offset-4">
                <asp:Label ID="warning" runat="server" CssClass="alert alert-warning component-label help-block"></asp:Label>
            </div>
            <div class="container col-lg-4 col-lg-offset-4 col-md-4 col-md-offset-4 col-sm-4 col-sm-offset-4">
                <div class="alert alert-info">
                    <p>разделяйте дробную часть с помощью запятой</p>
                    <p>например: 0,1</p>
                </div>
                <div class="panel panel-default">
                    <div class="panel-body">
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                            <div class="row col-md-12">
                                <label class="col-md-8 col-lg-6 component-label">Резистор R</label>
                                <asp:TextBox ID="m_nextr" runat="server" ReadOnly="True" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6">1</asp:TextBox>
                            </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                            <div class="row col-md-12">
                                <label class="col-md-8 col-lg-6 component-label">n+</label>
                                <asp:TextBox ID="m_npr" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                            </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                            <div class="row col-md-12">
                                <label class="col-md-8 col-lg-6 component-label">n-</label>
                                <asp:TextBox ID="m_nmr" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                                <%--</div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                            <div class="row col-md-12">
                                <label class="col-md-8 col-lg-6 component-label">Сопротивление (Ом)</label>
                                <asp:TextBox ID="m_zr" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                                <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="container flex-content">
                                <asp:Button ID="NextR" runat="server" OnClick="NextR_Click" Text="Следующий" CssClass="btn btn-info" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
