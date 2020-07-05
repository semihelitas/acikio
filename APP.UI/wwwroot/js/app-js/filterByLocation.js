$("#getAdsWithSearch").click(function () {
    var locationKeyword = $("#autocomplete-input").val();
    console.log(locationKeyword);
    var returnUrl = '/ustalar?' + 'location=' + locationKeyword;
    window.location.href = returnUrl;
});