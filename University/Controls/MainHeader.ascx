<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MainHeader.ascx.cs" Inherits="University.Controls.MainHeader" %>

<header class="main-header">
    <div class="header-content-container">
        <a class="logo-container" href="/">
            <img src="/Resources/Images/MainLogo.png" alt="РТУ МИРЭА" />
        </a>

        <nav class="main-navigation">
            <div class="main-navigation-top">
                <div class="lang-container link-container">
                    <a class="lang-button-link"><span class="lang-button-text">eng</span></a>
                    <a class="lang-button-link"><span class="lang-button-text selected">рус</span></a>
                </div>

                <a class="link-container" href="tel:+74992156565">
                    <div class="tel-button">
                        <span>+7 (499) 215 65 65</span>
                    </div>
                </a>
                <a href="/Login">
                    <div class="account-button">
                        <span>Личный кабинет</span>
                    </div>
                </a>
            </div>
            <ul class="main-navigation-links">
                <li><a>Поступающим</a></li>
                <li><a>Студентам</a></li>
                <li><a>Аспирантам</a></li>
                <li><a>Выпускникам</a></li>
                <li><a>Сотрудникам</a></li>
            </ul>
        </nav>
    </div>
</header>