var RemoveAppointment = function (id, containerId) {
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

var LoadAppointmentDetails = function (id, containerId) {
    $.ajax({
        type: 'POST',
        url: '/Home/Details',
        data: {
            'id': id
        },
        success: function (result) {
            $("#" + containerId).html(result);
        }
    });
};