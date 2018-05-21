<%@ Page Title="Описание ИТУТ" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="JI.aspx.cs" Inherits="WebClient.JI" %>

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
                                    <asp:TextBox ID="m_nextji" runat="server" ReadOnly="True" AutoCompleteType="Disabled" CssClass="form-control col-md-6">1</asp:TextBox>
                                </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-6 component-label">Узел n1+</label>
                                    <asp:TextBox ID="m_np1ji" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-6"></asp:TextBox>
                                </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-6 component-label">Узел n1-</label>
                                    <asp:TextBox ID="m_nm1ji" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-6"></asp:TextBox>
                                <%--</div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-6 component-label">Узел n2+</label>
                                    <asp:TextBox ID="m_np2ji" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-6"></asp:TextBox>
                                </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-6 component-label">Узел n2-</label>
                                    <asp:TextBox ID="m_nm2ji" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-6"></asp:TextBox>
                                <%--</div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-6 component-label">T1 (мсек)</label>
                                    <asp:TextBox ID="m_t1ji" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-6 component-label">T2 (мсек)</label>
                                    <asp:TextBox ID="m_t2ji" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-6 component-label">B</label>
                                    <asp:TextBox ID="m_bji" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="container flex-content">
                                <asp:Button ID="NextJI" runat="server" OnClick="NextJI_Click" Text="Следующий" CssClass="btn btn-info" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

