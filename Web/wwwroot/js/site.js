var LoadAppointmentList = function (id, containerId) {
    $.ajax({
        type: 'POST',
        url: '/Home/Remove',
        data: {
            'id': id
        },
        success: function (result) {
            $("#" + containerId).html(result);
        }
    });
};