$(function () {
    RegisterMVCGrid();
    $("#GridButton").on("click", function (e) {
        e.preventDefault();
        $("#ExampleResultsModal").modal("show");
    });
})

function RegisterMVCGrid() {
    [].forEach.call(document.getElementsByClassName('mvc-grid'), function (element) {
        new MvcGrid(element);
    });
}