function LoadDealssam() {
    $.ajax({
        //type: 'GET',
        //url: '/api/sitecore/DealsSam/GetDealsSam?settingsid=' + $('#deallist').data('settingsid')
        //    + '&categoryid=' + $('#category').val() + '&subcategoryid=' + $('#subcategory').val()
        //    + '&searchlocation=' + $('#Location').val() + '&searchtitle=' + $('#searchtitle').val(), 

        type: 'POST',
        url: '/api/sitecore/DealsSam/GetDealsPost',
        data: {
            "settingsid": $('#deallist').data('settingsid'),
            "categoryid": $('#category').val(),
            "subcategoryid": $('#subcategory').val(),
            "searchlocation": $('#Location').val(),
            "searchtitle": $('#searchtitle').val(),

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