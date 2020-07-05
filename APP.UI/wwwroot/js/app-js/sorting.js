var elems = $.makeArray($("#date-sort"));
elems.sort(function (a, b) {
    return new Date($(a).text()) < new Date($(b).text());
});
$(".freelancers-container").html(elems);