
function LoadDeals() {
    //$.ajax({
    //    type: 'GET',
    //    url: '/api/sitecore/Deals/GetDeals?settingsid=' + $('#deallist').data('settingsid')
    //        + '&categoryid=' + $('#category').val() + "&subcategoryid=" + $('#subcategory').val()
    //        + '&SearchQuery=' + $('#searchquery').val(),
    //    success: function (data) {
    //        UpdateDealsTemplate(data);
    //    }
    //});
    $.ajax({
        type: 'POST',
        url: '/api/sitecore/Deals/GetPostDeals',
        data: {
            "settingsid": $('#deallist').data('settingsid'),
            "categoryid": $('#category').val(),
            "subcategoryid": $('#subcategory').val(),
            "SearchQuery": $('#searchquery').val(),

        },
        
        success: function (data) {
            UpdateDealsTemplate(data);
        }
    });
}
function UpdateDealsTemplate(data) {
    var template = document.getElementById('Deals-template').innerHTML;
    var templateScript = Handlebars.compile(template);
    var context = data;
    var html = templateScript(context);
    document.getElementById('deallist').innerHTML = html;
}