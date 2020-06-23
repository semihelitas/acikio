$(document).ready(function () {
    // Initialization
    $("#getAdsWithSearch").click(function () {
        var location = $("#autocomplete-input").val();
        var keyword = $("#intro-keywords").val();
        let returnUrl = null;

        if (location != null && keyword != null) {
            returnUrl = '/usta-ilanlari?' + 'location=' + location + '&' + 'keyword=' + keyword;
        }
        else if (location != null && keyword == null) {
            returnUrl = '/usta-ilanlari?' + 'location=' + location;
        }
        else if (location == null && keyword == null) {
            returnUrl = '/usta-ilanlari';
        }

        $.ajax(
            {
                type: 'GET',
                url: '/usta-ilanlari',

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
});