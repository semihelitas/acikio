$('#imageFile').live('change', function () {
    @imageBase64 = $("#profile-image").attr("src");
    console.log(@imageBase64);
    });