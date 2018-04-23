@Code
    ViewBag.Title = "How to register DevExpress scripts if an existing project has client libraries that use jQuery"
End Code
<script>
    $(function () {       
        $("#tabs").tabs({ hide: 'fade', show: 'fade' });
        $("#tabs").show();
        $("#gridContainer").dxDataGrid({
            dataSource: customers,
            paging: {
                pageSize: 10
            },
            grouping: {
                autoExpandAll: false,
            },
            searchPanel: {
                visible: true
            },
            paging: {
                pageSize: 10
            },
            filterRow: {
                visible: true,
                applyFilter: "auto"
            },
            groupPanel: {
                visible: true
            },
            columns: ['CompanyName', 'City', 'State', 'Phone', 'Fax']
        });     
    });
</script>
<h2>How to register DevExpress scripts with external client libraries that use jQuery</h2>

<div id="tabs" style="display:none">
    <ul>
        <li><a href="#tabs-1">MVC GridView</a></li>
        <li><a href="#tabs-2">dxDataGrid</a></li>
    </ul>
    <div id="tabs-1">
        @Html.Action("GridViewPartial")
    </div>
    <div id="tabs-2">
        <div id="gridContainer"></div>
    </div>
</div>

