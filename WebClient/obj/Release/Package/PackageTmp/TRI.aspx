<%@ Page Title="Описание идеальных трансформаторов" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TRI.aspx.cs" Inherits="WebClient.TRI" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <%--<div class="container flex-content">
        <div class="panel panel-default col-md-6">
            <div class="panel-body">
                <div class="form-group row">
                    <label class="col-sm-4 component-label">Идеальный транформатор</label>
                    <div class="col-sm-4">
                        <asp:TextBox ID="m_nexttri" runat="server" ReadOnly="True" CssClass="form-control">1</asp:TextBox>
                    </div>
                </div>
                <div class="form-group row">
                    <label class="col-sm-4 component-label">Узел n1+</label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="m_np1tri" runat="server" AutoCompleteType="Disabled" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group row">
                    <label class="col-sm-4 component-label">Узел n1-</label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="m_nm1tri" runat="server" AutoCompleteType="Disabled" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group row">
                    <label class="col-sm-4 component-label">Узел n2+</label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="m_np2tri" runat="server" AutoCompleteType="Disabled" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group row">
                    <label class="col-sm-4 component-label">Узел n2-</label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="m_nm2tri" runat="server" AutoCompleteType="Disabled" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group row">
                    <label class="col-sm-4 component-label">n</label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="m_ztri" runat="server" AutoCompleteType="Disabled" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="flex-content">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Следующий" CssClass="btn btn-info" />
                </div>
            </div>
        </div>
    </div>--%>
    <div class="container">
        <div class="row">
            <div class="container col-lg-4 col-lg-offset-4 col-md-4 col-md-offset-4 col-sm-4 col-sm-offset-4">
                <div class="panel panel-default">
                    <div class="panel-body">
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Ид.<%--еальный --%> транформатор</label>
                                    <asp:TextBox ID="m_nexttri" runat="server" ReadOnly="True" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6">1</asp:TextBox>
                                </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Узел n1+</label>
                                    <asp:TextBox ID="m_np1tri" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                                </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Узел n1-</label>
                                    <asp:TextBox ID="m_nm1tri" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                                <%--</div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Узел n2+</label>
                                    <asp:TextBox ID="m_np2tri" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                                </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Узел n2-</label>
                                    <asp:TextBox ID="m_nm2tri" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                                <%--</div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">n</label>
                                    <asp:TextBox ID="m_ztri" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="container flex-content">
                                <asp:Button ID="NextTRI" runat="server" OnClick="NextTRI_Click" Text="Следующий" CssClass="btn btn-info" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

