<%@ Page Title="Размерность схемы" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Size.aspx.cs" Inherits="WebClient.Size1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />

    <div class="container">
        <div class="row">
            <div class="container col-lg-4 col-lg-offset-4 col-md-4 col-md-offset-4 col-sm-4 col-sm-offset-4">
                <div class="panel-group" id="accordion">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <h4 class="panel-title text-center">
                                <a data-toggle="collapse" data-parent="#accordion" href="#categoryCollapse0" class="collapsed">Принятые сокращения
                                </a>
                            </h4>
                        </div>
                        <div id="categoryCollapse0" class="panel-collapse collapse">
                            <div class="panel-body">
                                <ul class="text-center list-unstyled">
                                    <li><strong>Б/п</strong> - Биполярные транзисторы</li>
                                    <li><strong>У/п</strong> - униполярные транзисторы</li>
                                    <li><strong>Оп.</strong> - Операционные усилители</li>
                                    <li><strong>Ид.</strong> - Идеальные трансформаторы</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                <div class="panel panel-default">
                    <div class="panel-body">
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                            <div class="row col-md-12">
                                <label class="col-md-8 col-lg-6 component-label">Число узлов</label>
                                <asp:TextBox ID="m_nv" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6">1</asp:TextBox>
                            </div>
                            <%--</div>--%>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="container col-lg-4 col-lg-offset-4 col-md-4 col-md-offset-4 col-sm-4 col-sm-offset-4">
                <div class="panel panel-default">
                    <div class="panel-heading">Количество двухполюсников</div>
                    <div class="panel-body">
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                            <div class="row col-md-12">
                                <label class="col-md-8 col-lg-6 component-label">Резисторы</label>
                                <asp:TextBox ID="m_nr" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6">1</asp:TextBox>
                            </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                            <div class="row col-md-12">
                                <label class="col-md-8 col-lg-6 component-label">Конденсаторы</label>
                                <asp:TextBox ID="m_nc" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                            </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                            <div class="row col-md-12">
                                <label class="col-md-8 col-lg-6 component-label">Индуктивности</label>
                                <asp:TextBox ID="m_nl" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                                <%--</div>--%>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="container">
        <div class="row">
            <div class="container col-lg-4 col-lg-offset-4 col-md-4 col-md-offset-4 col-sm-4 col-sm-offset-4">
                <div class="panel panel-default">
                    <div class="panel-heading">Количество многополюсников</div>
                    <div class="panel-body">
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                            <div class="row col-md-12">
                                <label class="col-md-8 col-lg-6 component-label">ИТУН</label>
                                <asp:TextBox ID="m_nju" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6">1</asp:TextBox>
                            </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                            <div class="row col-md-12">
                                <label class="col-md-8 col-lg-6 component-label">ИНУН</label>
                                <asp:TextBox ID="m_neu" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                            </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                            <div class="row col-md-12">
                                <label class="col-md-8 col-lg-6 component-label">ИТУТ</label>
                                <asp:TextBox ID="m_nji" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                                <%--</div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                            <div class="row col-md-12">
                                <label class="col-md-8 col-lg-6 component-label">ИТУН</label>
                                <asp:TextBox ID="m_nei" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                                <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                            <div class="row col-md-12">
                                <label class="col-md-8 col-lg-6 component-label">Б/п транзисторы</label>
                                <asp:TextBox ID="m_ntb" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6">1</asp:TextBox>
                            </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                            <div class="row col-md-12">
                                <label class="col-md-8 col-lg-6 component-label">У/п транзисторы</label>
                                <asp:TextBox ID="m_ntu" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                            </div>
                            <%--</div>--%>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                            <div class="row col-md-12">
                                <label class="col-md-8 col-lg-6 component-label">Оп.усилители</label>
                                <asp:TextBox ID="m_nou" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                                <%--</div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                            <div class="row col-md-12">
                                <label class="col-md-8 col-lg-6 component-label">Трансформаторы</label>
                                <asp:TextBox ID="m_ntr" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                                <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                            <div class="row col-md-12">
                                <label class="col-md-8 col-lg-6 component-label">Ид. оп. усилители</label>
                                <asp:TextBox ID="m_noui" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                                <%--</div>--%>
                            </div>
                        </div>
                        <div class="form-group flex-content">
                            <%--<div class="container flex-content">--%>
                            <div class="row col-md-12">
                                <label class="col-md-8 col-lg-6 component-label">Ид. трансформаторы</label>
                                <asp:TextBox ID="m_ntri" runat="server" AutoCompleteType="Disabled" CssClass="form-control col-md-4 col-lg-6"></asp:TextBox>
                                <%--  </div>--%>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="container flex-content">
                                <asp:Button ID="EnterDATA" runat="server" OnClick="EnterDATA_Click" Text="Ввод данных" CssClass="btn btn-info" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

