$(function () {
    $("#icono").click(function () {
        $(this).addClass("animated bounce");

        setTimeout(function () {
            $("#icono").removeClass("animated bounce")
        }, 1000);
    });
});