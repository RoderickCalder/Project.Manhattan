
$("submit-button").click({
    $:ajax ({
        type: "POST",
        url: "controllers/Home",
        data: message,
        succ
    });
});