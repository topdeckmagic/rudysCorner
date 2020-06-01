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