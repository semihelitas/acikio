$("#getAdsWithKeyword").click(function () {
    var searchKeyword = $(".keyword-input").val();
    console.log(searchKeyword);
    var returnUrl = '/ustalar?keyword=' + searchKeyword;
    window.location.href = returnUrl;
});