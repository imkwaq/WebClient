<%@ Page Title="Вид частотной характеристики" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="F.aspx.cs" Inherits="WebClient.F" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="container flex-content">
        <div class="panel panel-default col-md-6">
            <div class="panel-body">
                <div class="container">
                    <div class="alert alert-info">
                        разделяйте дробную часть с помощью запятой<br />
                        например: 0,16
                    </div>
                </div>
                <div class="container">
                    <div class="form-check">
                        <asp:RadioButton ID="RadioButton1" Text="Единственная частотная точка" runat="server" GroupName="MyGroup" OnCheckedChanged="RadioChanged" Checked="True" AutoPostBack="True" CssClass="form-check-input" />
                        <%--<label class="form-check-label" for="RadioButton1">
                            Единственная частотная точка
                        </label>--%>
                    </div>
                    <div class="form-check">
                        <asp:RadioButton ID="RadioButton2" Text="Линейный закон изменения частоты" runat="server" GroupName="MyGroup" OnCheckedChanged="RadioChanged" AutoPostBack="True" CssClass="form-check-input" />
                        <%--<label class="form-check-label" for="RadioButton2">
                            Линейный закон изменения частоты
                        </label>--%>
                    </div>
                    <div class="form-check disabled">
                        <asp:RadioButton ID="RadioButton3" Text="Логарифмический закон" runat="server" GroupName="MyGroup" OnCheckedChanged="RadioChanged" AutoPostBack="True" CssClass="form-check-input" />
                        <%--<label class="form-check-label" for="RadioButton3">
                            Логарифмический закон изменения частоты
                        </label>--%>
                    </div>

                    <div class="form-group row">
                        <asp:Label ID="m_t1" runat="server" Text="Значение частоты (кГц)" CssClass="col-sm-4 component-label"></asp:Label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="m_f1" runat="server" AutoCompleteType="Disabled" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                        <asp:Label ID="m_t2" runat="server" CssClass="col-sm-4 component-label"></asp:Label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="m_f2" runat="server" Visible="False" AutoCompleteType="Disabled" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                        <asp:Label ID="m_t3" runat="server" CssClass="col-sm-4 component-label"></asp:Label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="m_f3" runat="server" Visible="False" AutoCompleteType="Disabled" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="flex-content">
                        <asp:Button ID="EnterF" runat="server" OnClick="EnterF_Click" Text="Ввести частотную характеристику" CssClass="btn btn-info" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    
</asp:Content>