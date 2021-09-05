<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Mi aplicación ASP.NET</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <div class="col-sm-2">
        <div class="vertical-nav bg-white" id="sidebar">
            <div class="mb-4 text-center">
                <h1 class="white strong">TEC</h1>
            </div>


            <div class="mt-5 ">
                <ul class="nav flex-column bg-white mb-0 "> 
                    <li class="navbar-li ">@Html.ActionLink("Ficha del Investigador", "Index", "Home")</li> 

                    <li class="navbar-li">@Html.ActionLink("Convocatorias", "About", "Home")</li>
                    <li class="navbar-li">@Html.ActionLink("Formulación de Propuestas", "Contact", "Home")</li>
                    <li class="navbar-li">@Html.ActionLink("Seguimiento de Proyectos", "Index", "Home")</li>
                    <li class="navbar-li">@Html.ActionLink("Evaluaciones", "About", "Home")</li>
                </ul>
            </div> 

        </div>

    </div>

    <div class="col-sm-10">
        <div class="container body-content">
            @RenderBody()
            <hr />
            <footer>
                <p>&copy; @DateTime.Now.Year - Mi aplicación ASP.NET</p>
            </footer>
        </div>
    </div>

        @Scripts.Render("~/bundles/jquery")
        @Scripts.Render("~/bundles/bootstrap")
        @RenderSection("scripts", required:=False)
</body>
</html>
