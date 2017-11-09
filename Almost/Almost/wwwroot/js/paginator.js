$(function () {
    var obj = $('#pagination').twbsPagination({
        totalPages: 35,
        visiblePages: 10,
        onPageClick: function (event, page) {
            console.info(page);
        }
    });
    console.info(obj.data());
});
