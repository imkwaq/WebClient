<%@ Page Title="Описание конденсаторов" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="C.aspx.cs" Inherits="WebClient.C" %>

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
                                    <label class="col-md-6 component-label">Конденсатор C</label>
                                    <asp:TextBox ID="m_nextc" runat="server" ReadOnly="True" AutoCompleteType="Disabled" CssClass="form-control col-md-6">1</asp:TextBox>
                                </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-6 component-label">n+</label>
                                    <asp:TextBox ID="m_npc" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-6"></asp:TextBox>
                                </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-6 component-label">n-</label>
                                    <asp:TextBox ID="m_nmc" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-6"></asp:TextBox>
                                <%--</div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-6 component-label">Емкость (мкФ)</label>
                                    <asp:TextBox ID="m_zc" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-6"></asp:TextBox>
                              <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="container flex-content">
                                <asp:Button ID="NextC" runat="server" OnClick="NextC_Click" Text="Следующий" CssClass="btn btn-info" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

