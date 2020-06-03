// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

//allowDrop() specifies where a dragable item can be dropped  
function allowDrop(ev) {
    ev.preventDefault();
}

//drag() specifies what is being dragged
function drag(ev) {
    ev.dataTransfer.setData("text", ev.target.id);
}

//drop() when a dragged item is dropped this happens
function drop(ev) {
    ev.preventDefault();
    var data = ev.dataTransfer.getData("text");
    ev.target.appendChild(document.getElementById(data));
}

//toggleFavorite() when clicking to favorite or unfavorite a POI
function toggleFavorite(ev) {
    ev.preventDefault();
    document.getElementById("favorite-icon").setAttribute("src",
        ev.target.src === "http://localhost:5000/img/POIs/favorited.png" ?
            "/img/POIs/not-favorited.png" : "/img/POIs/favorited.png");
}

$(document).click(function (ev) {
    $target = $(ev.target);
    if (!$target.closest('#share-dialog').length && $('#share-dialog').is(":visible")) {
        $('#share-dialog').hide();
        $("main").css("opacity", "1");
    }
});

function displayShareDialog(ev) {
    ev.preventDefault();
    setTimeout(function () {
        $("#share-dialog").css("display", "block");
        $("main").css("opacity", "0.25");
    }, 50);
}
