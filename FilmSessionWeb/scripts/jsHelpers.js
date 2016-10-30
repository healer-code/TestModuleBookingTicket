//convert time 
function ConvertTime(value)
{
    alert(0);
    //var result = value.split(":");
    //var hour, minute;
    //hour = parseInt(result[0]);
    //minute = parseInt(result[1]);
    //alert(hour);
    //return hour + ":" + minute;
}

//modal

var formBookingTicket = {
    InitialFormBookingTicket: function () {
        $('#film-ticket-amount').val('0');
    },
    onClickBookingTicket: function(timeBooking, roomBooking)
    {
        $.ajax({
            url:
        });
    }
};

$('.film-session-time').off('click').on('click', function () {
    $('#more-ticket-detail').modal('show');
    formBookingTicket.InitialFormBookingTicket();
    var sessionID = $(this).attr('sessionID');
    var roomID = (this).getAttribute('roomID');
    $('#btn-submit-booking').off('click').on('click', function () {       
        formBookingTicket.onClickBookingTicket();
    });
});

