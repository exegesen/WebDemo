function getPeopleList() {
    $.get("/Ajax/PeopleButton", null, function (response) {
        $('#peopleDiv').html(response);
    });
}
function getPersonByID() {
    var IDValue = document.getElementById('detailsInput').value;
    console.warn("getPersonByID IDValue =" + IDValue);
    $.post("/Ajax/DetailsButton", { id: IDValue }, function (response) {
        $('#peopleDiv').html(response);
        console.warn(response);
    });
}

function deleteCarByID() {
    var IDValue = document.getElementById('deleteInput').value;
    $.post("/Ajax/DeleteButton", { id: IDValue }, function (response) {
    })
        .done(function () {
            console.warn("Delete succesful");
            getPeopleList();
        })
        .fail(function () {
            console.warn("Delete error, failed!");
        });

}