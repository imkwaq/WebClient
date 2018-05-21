<%@ Page Title="Биполярный транзистор" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TB.aspx.cs" Inherits="WebClient.TB" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="container">
        <div class="row">
            <div class="container col-lg-4 col-lg-offset-4 col-md-4 col-md-offset-4 col-sm-4 col-sm-offset-4">
                <div class="panel panel-default">
                    <div class="panel-body">
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Б.транзистор</label>
                                    <asp:TextBox ID="m_nexttb" runat="server" ReadOnly="True" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6">1</asp:TextBox>
                                </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Узел ne</label>
                                    <asp:TextBox ID="m_tbne" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                                </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Узел nc</label>
                                    <asp:TextBox ID="m_tbnc" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                                <%--</div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Узел nb</label>
                                    <asp:TextBox ID="m_tbnb" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                                </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Rb</label>
                                    <asp:TextBox ID="m_ztbrb" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Re</label>
                                    <asp:TextBox ID="m_ztbre" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Rc</label>
                                    <asp:TextBox ID="m_ztbrc" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Ce</label>
                                    <asp:TextBox ID="m_ztbce" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Cc</label>
                                    <asp:TextBox ID="m_ztbcc" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">beta</label>
                                    <asp:TextBox ID="m_ztbb" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="container flex-content">
                                <asp:Button ID="NextTB" runat="server" OnClick="NextTB_Click" Text="Следующий" CssClass="btn btn-info" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
