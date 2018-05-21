<%@ Page Title="Домашняя страница" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebClient._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="jumbotron">
        <h2 class="fs-h2-default">MNS Web Service</h2>
        <p class="lead fs-p-default">
            Подсказка по работе с сайтом            
        </p>
        <ol class="fs-ol-default">
            <li>Выберите каким способом хотите ввести данные: через файл или клавиатуру.</li>
            <li>Выберите нужный раздел из пункта меню: "Описание".</li>
            <li>После ввода данных их можно записать в новый файл.</li>
            <li>Введите частотную характеристику, выбрав раздел в пункте меню: "Директивы расчета".</li>
            <li>Введите входные и выходные узлы схемы, выбрав раздел в пункте меню: "Директивы расчета".</li>
            <li>Введенные данные можно отредактировать в соответствующем пункте меню: "Редактирование".</li>
            <li>Произведите расчет.</li>
        </ol>
    </div>
</asp:Content>
