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
        $('#loading-image').hide();
    },

    onClickBookingTicket: function(timeBooking, roomBooking,ticketAmount)
    {
        $('#loading-image').show();
        $.ajax({
            url: '/BookingTicket/Booking',
            type: 'POST',
            data: {
                timeBooking: timeBooking,
                roomBooking: roomBooking,
                ticketAmount: ticketAmount
            },
            dataType: 'Json',
            success: function (respone) {
                if (respone.status)
                {
                    var url = urlRedirect.replace('current-room', timeBooking);
                    window.location.href = url;
                    //window.location.href = '/BookingTicket/DetailBooking';
                }
                $('#loading-image').hide();
            },
            error: function (xhr) {
                console.log(xhr.message);
            }
           
        });
        
    }
};

$('.film-session-time').off('click').on('click', function () {
    $('#more-ticket-detail').modal('show');
    formBookingTicket.InitialFormBookingTicket();
    var sessionID = $(this).attr('sessionID');
    var roomID = (this).getAttribute('roomID');
    $('#btn-submit-booking').off('click').on('click', function () {            
        var ticketAmount = $('#film-ticket-amount').val();
        formBookingTicket.onClickBookingTicket(sessionID,roomID,ticketAmount);
    });
});

