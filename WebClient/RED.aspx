<%@ Page Title="Редактирование компонентов" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RED.aspx.cs" Inherits="WebClient.RED" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />

    <div class="container">
        <div class="row">
            <div class="flex-content">
                <div class="col-md-8">
                    <asp:Label ID="warning" runat="server" CssClass="alert alert-warning component-label help-block"></asp:Label>
                </div>
            </div>
            <div class="container col-md-4 col-md-offset-2">
                <div class="panel panel-default">
                    <div class="panel-body">
                        <div class="form-check">
                            <asp:RadioButton ID="RadioR" runat="server" GroupName="MyGroup" AutoPostBack="True" Checked="True" OnCheckedChanged="RadioR_CheckedChanged" CssClass="form-check-input" />
                            <label class="form-check-label">
                                Резисторы
                            </label>
                        </div>
                        <div class="form-check">
                            <asp:RadioButton ID="RadioC" runat="server" GroupName="MyGroup" AutoPostBack="True" Checked="False" OnCheckedChanged="RadioC_CheckedChanged" CssClass="form-check-input" />
                            <label class="form-check-label">
                                Конденсаторы
                            </label>
                        </div>
                        <div class="form-check">
                            <asp:RadioButton ID="RadioL" runat="server" GroupName="MyGroup" AutoPostBack="True" Checked="False" OnCheckedChanged="RadioL_CheckedChanged" CssClass="form-check-input" />
                            <label class="form-check-label">
                                Индуктивности
                            </label>
                        </div>
                        <div class="form-check">
                            <asp:RadioButton ID="RadioJU" runat="server" GroupName="MyGroup" AutoPostBack="True" Checked="False" OnCheckedChanged="RadioJU_CheckedChanged" CssClass="form-check-input" />
                            <label class="form-check-label">
                                ИТУН
                            </label>
                        </div>                        
                        <div class="form-check">
                            <asp:RadioButton ID="RadioEU" runat="server" GroupName="MyGroup" AutoPostBack="True" Checked="False" OnCheckedChanged="RadioEU_CheckedChanged" CssClass="form-check-input" />
                            <label class="form-check-label">
                                ИНУН
                            </label>
                        </div>
                        <div class="form-check">
                            <asp:RadioButton ID="RadioJI" runat="server" GroupName="MyGroup" AutoPostBack="True" Checked="False" OnCheckedChanged="RadioJI_CheckedChanged" CssClass="form-check-input" />
                            <label class="form-check-label">
                                ИТУТ
                            </label>
                        </div>
                        <div class="form-check">
                            <asp:RadioButton ID="RadioEI" runat="server" GroupName="MyGroup" AutoPostBack="True" Checked="False" OnCheckedChanged="RadioEI_CheckedChanged" CssClass="form-check-input" />
                            <label class="form-check-label">
                                ИНУТ
                            </label>
                        </div>
                        <div class="form-check">
                            <asp:RadioButton ID="RadioTB" runat="server" GroupName="MyGroup" AutoPostBack="True" Checked="False" OnCheckedChanged="RadioTB_CheckedChanged" CssClass="form-check-input" />
                            <label class="form-check-label">
                                Биполярные транзисторы
                            </label>
                        </div>
                        <div class="form-check">
                            <asp:RadioButton ID="RadioTU" runat="server" GroupName="MyGroup" AutoPostBack="True" Checked="False" OnCheckedChanged="RadioTU_CheckedChanged" CssClass="form-check-input" />
                            <label class="form-check-label">
                                Униполярные транзисторы
                            </label>
                        </div>
                        <div class="form-check">
                            <asp:RadioButton ID="RadioOU" runat="server" GroupName="MyGroup" AutoPostBack="True" Checked="False" OnCheckedChanged="RadioOU_CheckedChanged" CssClass="form-check-input" />
                            <label class="form-check-label" for="RadioButton1">
                                Операционные усилители
                            </label>
                        </div>
                        <div class="form-check">
                            <asp:RadioButton ID="RadioTR" runat="server" GroupName="MyGroup" AutoPostBack="True" Checked="False" OnCheckedChanged="RadioTR_CheckedChanged" CssClass="form-check-input" />
                            <label class="form-check-label">
                                Трансформаторы
                            </label>
                        </div>
                        <div class="form-check">
                            <asp:RadioButton ID="RadioOUI" runat="server" GroupName="MyGroup" AutoPostBack="True" Checked="False" OnCheckedChanged="RadioOUI_CheckedChanged" CssClass="form-check-input" />
                            <label class="form-check-label">
                                Идеальные оп. усилители
                            </label>
                        </div>
                        <div class="form-check">
                            <asp:RadioButton ID="RadioTRI" runat="server" GroupName="MyGroup" AutoPostBack="True" Checked="False" OnCheckedChanged="RadioTRI_CheckedChanged" CssClass="form-check-input" />
                            <label class="form-check-label">
                                Ид. трансформаторы
                            </label>
                        </div>
                    </div>
                </div>
            </div>
            <div class="container col-md-4">
                <div class="panel panel-default">
                    <div class="panel-body row">
                        <div class="flex-content">
                            <div class="col-md-12">
                                <div class="form-group row">
                                    <asp:Label ID="Label1" runat="server" Text="Номер" CssClass="col-md-3 component-label"></asp:Label>
                                    <div class="col-md-6">
                                        <asp:TextBox ID="m_n" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="flex-content">
                                    <asp:Button ID="Button1" runat="server" Text="Вывод описания" OnClick="Out_Click" CssClass="btn btn-info" />
                                </div>
                                <br />
                                <div class="form-group row">
                                    <asp:Label ID="IDC_NP1_STATIC" runat="server" CssClass="col-md-3 component-label"></asp:Label>
                                    <div class="col-md-6">
                                        <asp:TextBox ID="m_np1" runat="server" AutoCompleteType="Disabled" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <asp:Label ID="IDC_NM1_STATIC" runat="server" CssClass="col-md-3 component-label"></asp:Label>
                                    <div class="col-md-3">
                                        <asp:TextBox ID="m_nm1" runat="server" AutoCompleteType="Disabled" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <asp:Label ID="IDC_NP2_STATIC" runat="server" CssClass="col-md-3 component-label"></asp:Label>
                                    <div class="col-md-6">
                                        <asp:TextBox ID="m_np2" runat="server" AutoCompleteType="Disabled" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <asp:Label ID="IDC_NM2_STATIC" runat="server" CssClass="col-md-3 component-label"></asp:Label>
                                    <div class="col-md-6">
                                        <asp:TextBox ID="m_nm2" runat="server" AutoCompleteType="Disabled" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>                                
                                <div class="form-group row">
                                    <asp:Label ID="IDC_Z1_STATIC" runat="server" CssClass="col-md-3 component-label"></asp:Label>
                                    <div class="col-md-6">
                                        <asp:TextBox ID="m_z1" runat="server" AutoCompleteType="Disabled" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <asp:Label ID="IDC_Z2_STATIC" runat="server" CssClass="col-md-3 component-label"></asp:Label>
                                    <div class="col-md-6">
                                        <asp:TextBox ID="m_z2" runat="server" AutoCompleteType="Disabled" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <asp:Label ID="IDC_Z3_STATIC" runat="server" CssClass="col-md-3 component-label"></asp:Label>
                                    <div class="col-md-6">
                                        <asp:TextBox ID="m_z3" runat="server" AutoCompleteType="Disabled" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <asp:Label ID="IDC_Z4_STATIC" runat="server" CssClass="col-md-3 component-label"></asp:Label>
                                    <div class="col-md-6">
                                        <asp:TextBox ID="m_z4" runat="server" AutoCompleteType="Disabled" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <asp:Label ID="IDC_Z5_STATIC" runat="server" CssClass="col-md-3 component-label"></asp:Label>
                                    <div class="col-md-6">
                                        <asp:TextBox ID="m_z5" runat="server" AutoCompleteType="Disabled" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <asp:Label ID="IDC_Z6_STATIC" runat="server" CssClass="col-md-3 component-label"></asp:Label>
                                    <div class="col-md-6">
                                        <asp:TextBox ID="m_z6" runat="server" AutoCompleteType="Disabled" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="flex-content">
                        <asp:Button ID="Button2" runat="server" Text="Ввод описания" OnClick="In_Click" CssClass="btn btn-info" />
                    </div>
                    <br />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
