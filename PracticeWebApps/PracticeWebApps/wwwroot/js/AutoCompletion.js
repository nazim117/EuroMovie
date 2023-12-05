$(function () {
    console.log("Document ready!");

    $("#searchQuery").autocomplete({
        source: '/AutoCompletion',
        minLength: 3
    });
});