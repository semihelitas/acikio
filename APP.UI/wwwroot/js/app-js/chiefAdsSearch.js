//$(document).ready(function () {
    // Initialization
    $("#getAdsWithSearch").click(function () {
        var location = $("#autocomplete-input").val();
        var keyword = $("#intro-keywords").val();
        let returnUrl = null;

        if (location != null && keyword != null) {
            returnUrl = '/ustalar?' + 'location=' + location + '&' + 'keyword=' + keyword;
        }
        else if (location != null && keyword == null) {
            returnUrl = '/ustalar?' + 'location=' + location;
        }
        else if (location == null && keyword == null) {
            returnUrl = '/ustalar';
        }

        $.ajax(
            {
                type: 'GET',
                url: '/ustalar',

                data: { location: location, keyword: keyword },
                success:
                    function (response) {
                        window.location.href = returnUrl;
                    },
                error:
                    function (response) {
                        console.log(response);
                    }
            });
    });
//});