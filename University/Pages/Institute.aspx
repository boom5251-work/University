<%@ Page Language="C#"
         MasterPageFile="~/Site.Master"
         AutoEventWireup="true"
         CodeBehind="Institute.aspx.cs"
         Inherits="University.Pages.Institute" %>


<%@ Register TagPrefix="common" TagName="MainFooter" Src="~/Controls/MainFooter.ascx" %>


<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <link rel="stylesheet" href="/Styles/Pages/Institute/MainSection.css" />
    <link rel="stylesheet" href="/Styles/Pages/Institute/HeadsSection.css" />
    <link rel="stylesheet" href="/Styles/Pages/Institute/DepartmentsSection.css" />

    <link rel="stylesheet" href="/Styles/Controls/Common/PersonInfo.css" />
    <link rel="stylesheet" href="/Styles/Controls/Institute/DepartmentBlock.css" />
    <link rel="stylesheet" href="/Styles/Controls/Common/MainFooter.css" />
</asp:Content>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section class="main-section">
        <div class="content-container">
            <div class="text-container">
                <h1 id="Header" class="header" runat="server" />
                <p id="Description" class="text" runat="server"></p>
            </div>

            <div class="fields-of-study-cell">
                <span class="label highlighted">Хочу учиться</span>
                <span class="label">
                    Направления
                    <br>
                    подготовки
                </span>
                <asp:HyperLink ID="FieldsOfStudyLink" runat="server">
                    <svg class="more-button" viewBox="0 0 24 24" fill="#9088FF" xmlns="http://www.w3.org/2000/svg">
                        <path d="M12.5858 12L9.29291 8.70703L10.7071 7.29297L15.4142 12L10.7071 16.707L9.29291 15.293L12.5858 12Z"></path>
                        <path fill-rule="evenodd" clip-rule="evenodd" d="M12 24C18.6274 24 24 18.6274 24 12C24 5.37256 18.6274 0 12 0C5.37256 0 0 5.37256 0 12C0 18.6274 5.37256 24 12 24ZM22 12C22 17.5229 17.5228 22 12 22C6.47717 22 2 17.5229 2 12C2 6.47705 6.47717 2 12 2C17.5228 2 22 6.47705 22 12Z"></path>
                    </svg>
                </asp:HyperLink>
            </div>

            <img class="sphere" alt="Шар" src="/Resources/Images/Sphere.png">
        </div>
    </section>

    <section class="heads-section">
        <div class="content-container">
            <h2 class="header">Руководство института</h2>

            <div class="heads-container" id="HeadsContainer" runat="server">
                <div class="separator"></div>
            </div>
        </div>
    </section>

    <section class="departments-section">
        <div class="content-container">
            <h2 class="header">Кафедры института</h2>

            <div class="departments-containers" id="DepartmentsContainer" runat="server"></div>

            <div class="departments-links-container">
                <p class="base-departments-text">
                    Наш институт сотрудничает с&nbsp;внешними предпиятиями. Если вы&nbsp;планируете работать на&nbsp;одном из&nbsp;стратегических Российских предпиятиях и&nbsp;планируете проходит там&nbsp;практику во&nbsp;время учебы, то&nbsp;можете ознакомится со&nbsp;списком
                    <asp:HyperLink ID="BaseDepartmentsLink" CssClass="link" runat="server">базовых кафедр</asp:HyperLink>
                    .
                </p>

                <asp:HyperLink ID="DepartmentsLink" runat="server">
                    <div class="link-box">
                        <span>Все кафедры</span>
                        <img class="arrow-icon" alt="Стрелка" src="/Resources/Icons/Arrow.svg" />
                    </div>
                </asp:HyperLink>
            </div>
        </div>
    </section>

    <common:MainFooter runat="server" />

    <div id="test" runat="server"></div>
</asp:Content>