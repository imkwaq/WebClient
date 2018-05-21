<%@ Page Title="Описание ИТУН" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="JU.aspx.cs" Inherits="WebClient.JU" %>

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
                                    <label class="col-md-6 component-label">ИТУТ</label>
                                    <asp:TextBox ID="m_nextju" runat="server" ReadOnly="True" AutoCompleteType="Disabled" CssClass="form-control col-md-6">1</asp:TextBox>
                                </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-6 component-label">Узел n1+</label>
                                    <asp:TextBox ID="m_np1ju" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-6"></asp:TextBox>
                                </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-6 component-label">Узел n1-</label>
                                    <asp:TextBox ID="m_nm1ju" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-6"></asp:TextBox>
                                <%--</div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-6 component-label">Узел n2+</label>
                                    <asp:TextBox ID="m_np2ju" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-6"></asp:TextBox>
                                </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-6 component-label">Узел n2-</label>
                                    <asp:TextBox ID="m_nm2ju" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-6"></asp:TextBox>
                                <%--</div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-6 component-label">T1 (мсек)</label>
                                    <asp:TextBox ID="m_t1ju" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-6 component-label">T2 (мсек)</label>
                                    <asp:TextBox ID="m_t2ju" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-6 component-label">y0 мА/В</label>
                                    <asp:TextBox ID="m_y0ju" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="container flex-content">
                                <asp:Button ID="NextJU" runat="server" OnClick="NextJU_Click" Text="Следующий" CssClass="btn btn-info" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

