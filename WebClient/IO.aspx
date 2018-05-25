<%@ Page Title="Входные/выходные узлы" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IO.aspx.cs" Inherits="WebClient.IO" %>

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
                                    <label class="col-md-12 component-label">Входные узлы</label>
                                </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                           <%-- <div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-6 component-label">l+</label>
                                    <asp:TextBox ID="m_lp" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-6"></asp:TextBox>
                                </div>
                          <%--  </div>--%>
                        </div>
                        <div class="form-group flex-content">
                           <%-- <div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-6 component-label">l-</label>
                                    <asp:TextBox ID="m_lm" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-6"></asp:TextBox>
                                </div>
                           <%-- </div>--%>
                        </div> 
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-12 component-label">Выходные узлы</label>
                                </div>
                           <%-- </div>--%>
                        </div>
                        <div class="form-group flex-content">
                           <%-- <div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-6 component-label">k+</label>
                                    <asp:TextBox ID="m_kp" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-6"></asp:TextBox>
                                </div>
                         <%--   </div>--%>
                        </div>
                        <div class="form-group flex-content">
                           <%-- <div class="container flex-content">--%>
                                <div class="row col-md-12">
                                    <label class="col-md-6 component-label">k-</label>
                                    <asp:TextBox ID="m_km" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-6"></asp:TextBox>
                                </div>
                           <%-- </div>--%>
                        </div>
                        <div class="form-group">
                            <div class="container flex-content">
                            <%--<div class="row col-md-12 flex-content">--%>
                                <asp:Button ID="OK" runat="server" OnClick="OK_Click" Text="Сохранить данные" CssClass="btn btn-info" />
                            </div>
                            <%--</div>--%>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <%--<div class="container flex-content">
        <div class="panel panel-default col-md-5">
            <div class="panel-body">
                <div class="form-group row">
                    <label class="component-label" aria-readonly="true">Входные узлы</label>
                </div>
                <div class="form-group row">
                    <div class="container flex-content">
                        <label class="col-sm-3 component-label">l+</label>
                        <div class="col-sm-9">
                            <asp:TextBox ID="m_lp" runat="server" AutoCompleteType="Disabled" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="form-group row">
                    <div class="container flex-content">
                        <label class="col-sm-3 component-label">l-</label>
                        <div class="col-sm-9">
                            <asp:TextBox ID="m_lm" runat="server" AutoCompleteType="Disabled" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="form-group row">
                    <label class="component-label" aria-readonly="true">Выходные узлы</label>
                </div>
                <div class="form-group row">
                    <div class="container flex-content">
                        <label class="col-sm-3 component-label">k+</label>
                        <div class="col-sm-9">
                            <asp:TextBox ID="m_kp" runat="server" AutoCompleteType="Disabled" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="form-group row">
                    <div class="container flex-content">
                        <label class="col-sm-3 component-label">k-</label>
                        <div class="col-sm-9">
                            <asp:TextBox ID="m_km" runat="server" AutoCompleteType="Disabled" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="flex-content">
                    <asp:Button ID="OK" runat="server" OnClick="OK_Click" Text="Сохранить данные" CssClass="btn btn-info" />
                </div>
            </div>
        </div>
    </div>--%>
</asp:Content>
