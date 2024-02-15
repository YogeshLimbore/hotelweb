function but() {
    alert("Logi  sucssefully");
}

function handleButtonClick(event) {
    event.preventDefault();
    $('.row').hide();
    alert('Logi  sucssefully!');
}
document.addEventListener('DOMContentLoaded', function () {
    var getStartedBtns = document.querySelectorAll('#loginsubmit');
    getStartedBtns.forEach(function (btn) {
        btn.addEventListener('click', handleButtonClick);
    });
});

