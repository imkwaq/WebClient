<%@ Page Title="Униполярный транзистор" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TU.aspx.cs" Inherits="WebClient.TU" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="container">
        <div class="row">
            <div class="container col-lg-4 col-lg-offset-4 col-md-4 col-md-offset-4 col-sm-4 col-sm-offset-4">
                <asp:Label ID="warning" runat="server" CssClass="alert alert-warning component-label help-block"></asp:Label>
            </div>
            <div class="container col-lg-4 col-lg-offset-4 col-md-4 col-md-offset-4 col-sm-4 col-sm-offset-4">
                <div class="panel panel-default">
                    <div class="panel-body">
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">У.транзистор</label>
                                    <asp:TextBox ID="m_nexttu" runat="server" ReadOnly="True" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6">1</asp:TextBox>
                                </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Узел nz</label>
                                    <asp:TextBox ID="m_tunz" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                                </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Узел ns</label>
                                    <asp:TextBox ID="m_tuns" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                                <%--</div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Узел ni</label>
                                    <asp:TextBox ID="m_tuni" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                                </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Rc</label>
                                    <asp:TextBox ID="m_zturc" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Czi</label>
                                    <asp:TextBox ID="m_ztuczi" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Czs</label>
                                    <asp:TextBox ID="m_ztuczs" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Csi</label>
                                    <asp:TextBox ID="m_ztucsi" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">S</label>
                                    <asp:TextBox ID="m_ztus" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>                        
                        <div class="form-group">
                            <div class="container flex-content">
                                <asp:Button ID="NextTU" runat="server" OnClick="NextTU_Click" Text="Следующий" CssClass="btn btn-info" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
