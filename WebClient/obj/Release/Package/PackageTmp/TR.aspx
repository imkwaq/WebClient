<%@ Page Title="Описание трансформаторов" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TR.aspx.cs" Inherits="WebClient.TR" %>

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
                                    <label class="col-md-8 col-lg-6 component-label">Транформатор</label>
                                    <asp:TextBox ID="m_nexttr" runat="server" ReadOnly="True" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6">1</asp:TextBox>
                                </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Узел n1+</label>
                                    <asp:TextBox ID="m_np1tr" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                                </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Узел n1-</label>
                                    <asp:TextBox ID="m_nm1tr" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                                <%--</div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Узел n2+</label>
                                    <asp:TextBox ID="m_np2tr" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                                </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">Узел n2-</label>
                                    <asp:TextBox ID="m_nm2tr" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                                <%--</div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">R1</label>
                                    <asp:TextBox ID="m_ztrr1" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">R2</label>
                                    <asp:TextBox ID="m_ztrr2" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">L1</label>
                                    <asp:TextBox ID="m_ztrl1" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">L2</label>
                                    <asp:TextBox ID="m_ztrl2" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-8 col-lg-6 component-label">M</label>
                                    <asp:TextBox ID="m_ztrm" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="container flex-content">
                                <asp:Button ID="NextTR" runat="server" OnClick="NextTR_Click" Text="Следующий" CssClass="btn btn-info" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
