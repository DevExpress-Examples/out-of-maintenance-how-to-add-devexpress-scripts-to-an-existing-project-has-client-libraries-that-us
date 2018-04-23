<!DOCTYPE html>

<html>
<head>
    <meta charset="UTF-8" />
    <title>@ViewBag.Title</title>

    <link rel="stylesheet" href="//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css">
    <link href="@Url.Content("~/Content/dx.light.css")" rel="stylesheet" />
    <script src="@Url.Content("~/Scripts/jquery-2.1.4.js")" type="text/javascript"></script>
    <script src="@Url.Content("~/Scripts/jquery.validate.js")"></script>
    <script src="@Url.Content("~/Scripts/jquery.validate.unobtrusive.js")"></script>
    <script src="@Url.Content("~/Scripts/jquery.unobtrusive-ajax.js")"></script>
    <script src="@Url.Content("~/Scripts/jquery-ui-1.10.3.js")" type="text/javascript"></script>
    <script src="@Url.Content("~/Scripts/globalize.js")" type="text/javascript"></script>
    <script src="@Url.Content("~/Scripts/knockout-3.0.0.js")" type="text/javascript"></script>
    <script src="@Url.Content("~/Scripts/dx.webappjs.js")"></script>
    <script src="@Url.Content("~/Scripts/data.js")"></script>
    @Html.DevExpress().GetStyleSheets(New StyleSheet With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.Editors},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.HtmlEditor},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.GridView},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.PivotGrid},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.Chart},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.Report},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.Scheduler},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.TreeList},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.RichEdit},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.Spreadsheet},
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.SpellChecker})

    @Html.DevExpress().GetScripts(New Script With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout},
    New Script With {.ExtensionSuite = ExtensionSuite.HtmlEditor},
    New Script With {.ExtensionSuite = ExtensionSuite.GridView},
    New Script With {.ExtensionSuite = ExtensionSuite.PivotGrid},
    New Script With {.ExtensionSuite = ExtensionSuite.Editors},
    New Script With {.ExtensionSuite = ExtensionSuite.Chart},
    New Script With {.ExtensionSuite = ExtensionSuite.Report},
    New Script With {.ExtensionSuite = ExtensionSuite.Scheduler},
    New Script With {.ExtensionSuite = ExtensionSuite.TreeList},
    New Script With {.ExtensionSuite = ExtensionSuite.RichEdit},
    New Script With {.ExtensionSuite = ExtensionSuite.Spreadsheet},
    New Script With {.ExtensionSuite = ExtensionSuite.SpellChecker})
</head>

<body>
    @RenderBody()
</body>
</html>
