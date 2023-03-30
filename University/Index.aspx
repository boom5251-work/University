<%@ Page Title="МИРЭА &mdash; Российский технологический университет"
         Language="C#"
         MasterPageFile="~/Site.Master"
         AutoEventWireup="true"
         CodeBehind="Index.aspx.cs"
         Inherits="University.Index" %>


<%@ Register TagPrefix="common" TagName="MainHeader" Src="~/Controls/MainHeader.ascx" %>
<%@ Register TagPrefix="common" TagName="MainFooter" Src="~/Controls/MainFooter.ascx" %>


<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <link rel="stylesheet" href="/Styles/Controls/Common/MainHeader.css" />
    <link rel="stylesheet" href="/Styles/Controls/Common/MainFooter.css" />
    <link rel="stylesheet" href="/Styles/Controls/Main/HeadlineBlock.css" />

    <link rel="stylesheet" href="/Styles/Pages/Main/MainSection.css" />
    <link rel="stylesheet" href="/Styles/Pages/Main/AboutSection.css" />
    <link rel="stylesheet" href="/Styles/Pages/Main/AdditionalEducationSection.css" />
    <link rel="stylesheet" href="/Styles/Pages/Main/LifeSection.css" />
    <link rel="stylesheet" href="/Styles/Pages/Main/FacultiesSection.css" />
    <link rel="stylesheet" href="/Styles/Pages/Main/NewsSection.css" />
</asp:Content>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <common:MainHeader runat="server" />

    <section class="main-section">
        <div class="content-container">
            <div class="title-block">
                <h1 class="main-title">
                    <span>Стань профи &mdash;</span>
                    <br />
                    <span>получи образование</span>
                    <br />
                    <span>в РТУ МИРЭА</span>
                </h1>
                <img alt="Шар" src="/Resources/Images/Sphere.png" />
            </div>

            <div class="search-block">
                <img class="search-icon" alt="" src="/Resources/Icons/Search.svg" />
                <input class="search-input" type="text" placeholder="Что вы ищите?" />
            </div>

            <div class="anchors-block">
                <a href="#life-section">
                    <div class="anchor blue">
                        <span>
                            Жизнь @
                            <br />
                            Наука и сообщество
                        </span>
                    </div>
                </a>
                <a href="#faculties-section">
                    <div class="anchor black">
                        <span>
                            Факультеты @
                            <br />
                            Программы обучения
                        </span>
                    </div>
                </a>
            </div>
        </div>
    </section>

    <section class="about-section">
        <div class="content-container">
            <div class="text-container">
                <h2 class="header">
                    <span>Московский институт</span>
                    <br />
                    <span>радио электроники</span>
                    <br />
                    <span>и автоматики</span>
                </h2>
                <p>РТУ МИРЭА &mdash; признанный в&nbsp;России и&nbsp;в&nbsp;мире современный образовательный и&nbsp;научно-исследовательский центр, сочетающий в&nbsp;своей работе классические университетские традиции и&nbsp;современные образовательные технологии.</p>
                <p>Начиная с&nbsp;момента своего образования, вуз всегда шел в&nbsp;ногу со&nbsp;временем и&nbsp;постоянно расширял спектр образовательных программ в&nbsp;соответствии с&nbsp;потребностями страны в инженерных кадрах, повышая качество подготовки специалистов</p>
            </div>

            <div class="link-container">
                <a>
                    <div class="link-box">
                        <span>Подробнее</span>
                        <img class="arrow-icon" alt="Стрелка" src="/Resources/Icons/Arrow.svg" />
                    </div>
                </a>
            </div>

            <img class="sphere" alt="Шар" src="/Resources/Images/Sphere.png" />
        </div>
    </section>

    <section class="additional-education-section">
        <div class="content-container">
            <div class="text-block">
                <h2 class="header">
                    <span>Программы</span>
                    <br />
                    <span>дополнительного</span>
                    <br />
                    <span>образования</span>
                </h2>

                <p class="text">В МИРЭА &mdash; Российском технологическом университете действуют программы дополнительного образования. В их число входят цифровая кафедра, после окончания которой студент получает диплом о повышении кваллификации, а также военная кафедра, на которой можно обучится азам военного дела и получить военный билет.</p>
            </div>

            <div class="education-cell">
                <span class="label top">Начиная с 2022</span>
                <span class="label highlighted">ИТ</span>
                <span class="label">
                    Цифровая
                    <br />
                    кафедра
                </span>
                <a>
                    <svg class="more-button" viewBox="0 0 24 24" fill="#9088FF" xmlns="http://www.w3.org/2000/svg">
                        <path d="M12.5858 12L9.29291 8.70703L10.7071 7.29297L15.4142 12L10.7071 16.707L9.29291 15.293L12.5858 12Z" />
                        <path fill-rule="evenodd" clip-rule="evenodd" d="M12 24C18.6274 24 24 18.6274 24 12C24 5.37256 18.6274 0 12 0C5.37256 0 0 5.37256 0 12C0 18.6274 5.37256 24 12 24ZM22 12C22 17.5229 17.5228 22 12 22C6.47717 22 2 17.5229 2 12C2 6.47705 6.47717 2 12 2C17.5228 2 22 6.47705 22 12Z" />
                    </svg>
                </a>
            </div>

            <div class="education-cell cell-d">
                <span class="label highlighted">Искусство</span>
                <span class="label">
                    Медиа-
                    <br />
                    школа
                </span>
                <a>
                    <svg class="more-button" viewBox="0 0 24 24" fill="#9088FF" xmlns="http://www.w3.org/2000/svg">
                        <path d="M12.5858 12L9.29291 8.70703L10.7071 7.29297L15.4142 12L10.7071 16.707L9.29291 15.293L12.5858 12Z" />
                        <path fill-rule="evenodd" clip-rule="evenodd" d="M12 24C18.6274 24 24 18.6274 24 12C24 5.37256 18.6274 0 12 0C5.37256 0 0 5.37256 0 12C0 18.6274 5.37256 24 12 24ZM22 12C22 17.5229 17.5228 22 12 22C6.47717 22 2 17.5229 2 12C2 6.47705 6.47717 2 12 2C17.5228 2 22 6.47705 22 12Z" />
                    </svg>
                </a>
            </div>

            <div class="education-cell cell-e">
                <span class="label highlighted">ВП</span>
                <span class="label">
                    Военная
                    <br />
                    кафедра
                </span>
                <a>
                    <svg class="more-button highlighted" viewBox="0 0 24 24" fill="#DDDDDD" xmlns="http://www.w3.org/2000/svg">
                        <path d="M12.5858 12L9.29291 8.70703L10.7071 7.29297L15.4142 12L10.7071 16.707L9.29291 15.293L12.5858 12Z" />
                        <path fill-rule="evenodd" clip-rule="evenodd" d="M12 24C18.6274 24 24 18.6274 24 12C24 5.37256 18.6274 0 12 0C5.37256 0 0 5.37256 0 12C0 18.6274 5.37256 24 12 24ZM22 12C22 17.5229 17.5228 22 12 22C6.47717 22 2 17.5229 2 12C2 6.47705 6.47717 2 12 2C17.5228 2 22 6.47705 22 12Z" />
                    </svg>
                </a>
            </div>

            <img class="sphere" alt="Шар" src="/Resources/Images/Sphere.png" />
        </div>
    </section>

    <section class="life-section" id="life-section">
        <div class="content-container">
            <div class="text-container">
                <h2 class="header">Жизнь @</h2>
                <p class="text">В нашем вузе проводится более 300 студенческих мероприятий ежегодно.</p>
                <p class="text">Студентам доступны тридцать студенческих научных объединений, двадцать творческих коллективов, а&nbsp;также семь спортивных секций.</p>

                <a>
                    <div class="link-box">
                        <span>
                            Узнать
                            <br />
                            больше
                        </span>
                        <img class="arrow-icon" alt="Стрелка" src="/Resources/Icons/Arrow.svg" />
                    </div>
                </a>
            </div>

            <img class="life-image" alt="Ученые" src="/Resources/Images/Life1.png" />
            <img class="life-image" alt="Программист" src="/Resources/Images/Life2.png" />
            <img class="life-image" alt="Дополненная реальность" src="/Resources/Images/Life3.png" />
            <img class="life-image" alt="Сообщество" src="/Resources/Images/Life4.png" />
        </div>
    </section>

    <section class="faculties-section" id="faculties-section">
        <div class="content-container">
            <div class="text-container">
                <h2 class="header">Факультеты @</h2>
                <p class="text">В РТУ МИРЭА проводистся подготовка специалистов по&nbsp;множеству разных направлений, как&nbsp;технических так&nbsp;и&nbsp;гумунитарных. Обучение ведется по&nbsp;программам бакалавриата, специалитета, магистратуры и&nbsp;аспирантуры.</p>
                
                <a>
                    <div class="link-box">
                        <span>
                            Узнать
                            <br />
                            больше
                        </span>
                        <img class="arrow-icon" alt="Стрелка" src="/Resources/Icons/Arrow.svg" />
                    </div>
                </a>
            </div>

            <div class="separator"></div>

            <div class="faculty-block">
                <img class="logo-icon" alt="ИТ" src="/Resources/Icons/IT.svg" />
                <span class="title">Информационные<br />технологии</span>
                <p class="description">Институт информационных технологий осуществлят подготовку бакалавров и&nbsp;магистров по&nbsp;приоритетным ИТ&#8209;направлениям.</p>
                <a href="/Institute/IT">
                    <svg class="more-button" viewBox="0 0 24 24" fill="#DDDDDD" xmlns="http://www.w3.org/2000/svg">
                        <path d="M12.5858 12L9.29291 8.70703L10.7071 7.29297L15.4142 12L10.7071 16.707L9.29291 15.293L12.5858 12Z" />
                        <path fill-rule="evenodd" clip-rule="evenodd" d="M12 24C18.6274 24 24 18.6274 24 12C24 5.37256 18.6274 0 12 0C5.37256 0 0 5.37256 0 12C0 18.6274 5.37256 24 12 24ZM22 12C22 17.5229 17.5228 22 12 22C6.47717 22 2 17.5229 2 12C2 6.47705 6.47717 2 12 2C17.5228 2 22 6.47705 22 12Z" />
                    </svg>
                </a>
            </div>

            <div class="faculty-block">
                <img class="logo-icon" alt="ИИ" src="/Resources/Icons/AI.svg" />
                <span class="title">Искусственный<br />интеллект</span>
                <p class="description">Институт искусственного интеллекта в&nbsp;рамках обучения реализует подготовку специалистов в&nbsp;области искусственного интеллекта.</p>
                <a href="/Institute/AI">
                    <svg class="more-button" viewBox="0 0 24 24" fill="#DDDDDD" xmlns="http://www.w3.org/2000/svg">
                        <path d="M12.5858 12L9.29291 8.70703L10.7071 7.29297L15.4142 12L10.7071 16.707L9.29291 15.293L12.5858 12Z" />
                        <path fill-rule="evenodd" clip-rule="evenodd" d="M12 24C18.6274 24 24 18.6274 24 12C24 5.37256 18.6274 0 12 0C5.37256 0 0 5.37256 0 12C0 18.6274 5.37256 24 12 24ZM22 12C22 17.5229 17.5228 22 12 22C6.47717 22 2 17.5229 2 12C2 6.47705 6.47717 2 12 2C17.5228 2 22 6.47705 22 12Z" />
                    </svg>
                </a>
            </div>

            <div class="faculty-block">
                <img class="logo-icon" alt="ИТ" src="/Resources/Icons/CDT.svg" />
                <span class="title">Кибербезопасность и&nbsp;цифровые технологии</span>
                <p class="description">В&nbsp;институте ведется подготовка специалистов в&nbsp;области информационной, экономической безопаснсти, и&nbsp;защиты нац. киберпространства.</p>
                <a href="/Institute/CDT">
                    <svg class="more-button" viewBox="0 0 24 24" fill="#DDDDDD" xmlns="http://www.w3.org/2000/svg">
                        <path d="M12.5858 12L9.29291 8.70703L10.7071 7.29297L15.4142 12L10.7071 16.707L9.29291 15.293L12.5858 12Z" />
                        <path fill-rule="evenodd" clip-rule="evenodd" d="M12 24C18.6274 24 24 18.6274 24 12C24 5.37256 18.6274 0 12 0C5.37256 0 0 5.37256 0 12C0 18.6274 5.37256 24 12 24ZM22 12C22 17.5229 17.5228 22 12 22C6.47717 22 2 17.5229 2 12C2 6.47705 6.47717 2 12 2C17.5228 2 22 6.47705 22 12Z" />
                    </svg>
                </a>
            </div>

            <div class="faculty-block">
                <img class="logo-icon" alt="ИПТИП" src="/Resources/Icons/ATIP.svg" />
                <span class="title">Перспективные технологии и&nbsp;индуст. программирование</span>
                <p class="description">Институт ведёт подготовку специалистов в&nbsp;различных областях от&nbsp;программирования до&nbsp;оптики, аддитивных технологий и&nbsp;метрологи.</p>
                <a href="/Institute/ATIP">
                    <svg class="more-button" viewBox="0 0 24 24" fill="#DDDDDD" xmlns="http://www.w3.org/2000/svg">
                        <path d="M12.5858 12L9.29291 8.70703L10.7071 7.29297L15.4142 12L10.7071 16.707L9.29291 15.293L12.5858 12Z" />
                        <path fill-rule="evenodd" clip-rule="evenodd" d="M12 24C18.6274 24 24 18.6274 24 12C24 5.37256 18.6274 0 12 0C5.37256 0 0 5.37256 0 12C0 18.6274 5.37256 24 12 24ZM22 12C22 17.5229 17.5228 22 12 22C6.47717 22 2 17.5229 2 12C2 6.47705 6.47717 2 12 2C17.5228 2 22 6.47705 22 12Z" />
                    </svg>
                </a>
            </div>

            <div class="faculty-block">
                <img class="logo-icon" alt="РЭИ" src="/Resources/Icons/RECS.svg" />
                <span class="title">Радиоэлектроника<br />и&nbsp;информатика</span>
                <p class="description">Институт готовит специалистов в&nbsp;области исследования, проектирования и&nbsp;разработок радиотехнических и&nbsp;инфокомму-никационных систем и&nbsp;устройств.</p>
                <a href="/Institute/RECS">
                    <svg class="more-button" viewBox="0 0 24 24" fill="#DDDDDD" xmlns="http://www.w3.org/2000/svg">
                        <path d="M12.5858 12L9.29291 8.70703L10.7071 7.29297L15.4142 12L10.7071 16.707L9.29291 15.293L12.5858 12Z" />
                        <path fill-rule="evenodd" clip-rule="evenodd" d="M12 24C18.6274 24 24 18.6274 24 12C24 5.37256 18.6274 0 12 0C5.37256 0 0 5.37256 0 12C0 18.6274 5.37256 24 12 24ZM22 12C22 17.5229 17.5228 22 12 22C6.47717 22 2 17.5229 2 12C2 6.47705 6.47717 2 12 2C17.5228 2 22 6.47705 22 12Z" />
                    </svg>
                </a>
            </div>

            <div class="faculty-block">
                <img class="logo-icon" alt="ТУ" src="/Resources/Icons/MT.svg" />
                <span class="title">Технологии<br />управления</span>
                <p class="description">Институт готовит специалистов по&nbsp;самым востребованным гомунитарным специальностям от&nbsp;экономики и&nbsp;менеджмента до&nbsp;государственного управления.</p>
                <a href="/Institute/MT">
                    <svg class="more-button" viewBox="0 0 24 24" fill="#DDDDDD" xmlns="http://www.w3.org/2000/svg">
                        <path d="M12.5858 12L9.29291 8.70703L10.7071 7.29297L15.4142 12L10.7071 16.707L9.29291 15.293L12.5858 12Z" />
                        <path fill-rule="evenodd" clip-rule="evenodd" d="M12 24C18.6274 24 24 18.6274 24 12C24 5.37256 18.6274 0 12 0C5.37256 0 0 5.37256 0 12C0 18.6274 5.37256 24 12 24ZM22 12C22 17.5229 17.5228 22 12 22C6.47717 22 2 17.5229 2 12C2 6.47705 6.47717 2 12 2C17.5228 2 22 6.47705 22 12Z" />
                    </svg>
                </a>
            </div>

            <div class="faculty-block">
                <img class="logo-icon" alt="Химия" src="/Resources/Icons/Lomonosov.svg" />
                <span class="title">Тонкие химические<br />технологии</span>
                <p class="description">Институт осуществляет подготовку в&nbsp;области химии, химической технологии, фармации, экологии и&nbsp;техносферной безопасности.</p>
                <a href="Institute/Lomonosov">
                    <svg class="more-button" viewBox="0 0 24 24" fill="#DDDDDD" xmlns="http://www.w3.org/2000/svg">
                        <path d="M12.5858 12L9.29291 8.70703L10.7071 7.29297L15.4142 12L10.7071 16.707L9.29291 15.293L12.5858 12Z" />
                        <path fill-rule="evenodd" clip-rule="evenodd" d="M12 24C18.6274 24 24 18.6274 24 12C24 5.37256 18.6274 0 12 0C5.37256 0 0 5.37256 0 12C0 18.6274 5.37256 24 12 24ZM22 12C22 17.5229 17.5228 22 12 22C6.47717 22 2 17.5229 2 12C2 6.47705 6.47717 2 12 2C17.5228 2 22 6.47705 22 12Z" />
                    </svg>
                </a>
            </div>
        </div>

        <img class="sphere" alt="Шар" src="/Resources/Images/Sphere.png" />
    </section>

    <section class="news-section">
        <div class="content-container">
            <div class="text-container">
                <h2 class="header">Новости</h2>
                <a class="all-link" href="/News">Смотреть все новости</a>

                <div class="move-buttons-container">
                    <svg class="arrow-button" viewBox="0 0 32 32" fill="#DDDDDD" xmlns="http://www.w3.org/2000/svg">
                        <path d="M0.280754 16.7401L8.87915 25.3417C9.0595 25.522 9.30411 25.6233 9.55915 25.6233C9.8142 25.6233 10.0588 25.522 10.2392 25.3417C10.4195 25.1613 10.5208 24.9167 10.5208 24.6617C10.5208 24.4066 10.4195 24.162 10.2392 23.9817L3.27595 17.0217L31.0392 17.0217C31.2938 17.0217 31.5379 16.9205 31.718 16.7405C31.898 16.5605 31.9992 16.3163 31.9992 16.0617C31.9992 15.8071 31.898 15.5629 31.718 15.3828C31.5379 15.2028 31.2938 15.1017 31.0392 15.1017L3.27595 15.1017L10.2392 8.14167C10.4195 7.96132 10.5208 7.71671 10.5208 7.46167C10.5208 7.20662 10.4195 6.96201 10.2392 6.78167C10.0588 6.60132 9.8142 6.5 9.55916 6.5C9.30411 6.5 9.0595 6.60132 8.87916 6.78166L0.280754 15.3833C0.100978 15.5633 2.22404e-08 15.8073 0 16.0617C-2.22404e-08 16.3161 0.100978 16.5601 0.280754 16.7401Z" />
                    </svg>

                    <svg class="arrow-button" viewBox="0 0 32 32" fill="#DDDDDD" xmlns="http://www.w3.org/2000/svg">
                        <path d="M31.7184 15.3833L23.12 6.78166C22.9397 6.60132 22.6951 6.5 22.44 6.5C22.185 6.5 21.9403 6.60132 21.76 6.78166C21.5797 6.96201 21.4783 7.20661 21.4783 7.46166C21.4783 7.71671 21.5797 7.96132 21.76 8.14166L28.7232 15.1017L0.960001 15.1017C0.705393 15.1017 0.461213 15.2028 0.281178 15.3828C0.101143 15.5629 4.4517e-08 15.8071 0 16.0617C-4.4517e-08 16.3163 0.101143 16.5604 0.281177 16.7405C0.461212 16.9205 0.705393 17.0217 0.960001 17.0217L28.7232 17.0217L21.76 23.9817C21.5797 24.162 21.4783 24.4066 21.4783 24.6617C21.4783 24.9167 21.5797 25.1613 21.76 25.3417C21.9403 25.522 22.1849 25.6233 22.44 25.6233C22.695 25.6233 22.9397 25.522 23.12 25.3417L31.7184 16.7401C31.8982 16.5601 31.9992 16.3161 31.9992 16.0617C31.9992 15.8073 31.8982 15.5633 31.7184 15.3833Z" />
                    </svg>
                </div>
            </div>

            <asp:Panel ID="NewsContainer" CssClass="news-container" runat="server" />
        </div>
    </section>
    
    <common:MainFooter runat="server" />
</asp:Content>