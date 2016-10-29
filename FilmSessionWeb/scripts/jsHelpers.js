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

$('.film-session-time').off('click').on('click', function () {
    $('#more-ticket-detail').modal('show');
});