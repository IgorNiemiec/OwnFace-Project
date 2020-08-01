

var friends = document.getElementById("M-M-AddFriends");
friends.hidden = true;



var UserIcon = document.getElementById("M-M-User-Plus").addEventListener('click', function ()
{


    var friends = document.getElementById("M-M-AddFriends");

    if (friends.hidden == false) {
        friends.hidden = true;
    }
    else {
        friends.hidden = false;
        messages.hidden = true;
        notifications.hidden = true;
    }


});


var messages = document.getElementById("M-M-Messages");
messages.hidden = true;

var MessagesIcon = document.getElementById("M-M-icon-Comment").addEventListener('click', function () {


    var messages = document.getElementById("M-M-Messages");

    if (messages.hidden == false) {
        messages.hidden = true;
    }
    else {
        messages.hidden = false;
        friends.hidden = true;
        notifications.hidden = true;
    }


});



var notifications = document.getElementById("M-M-Notifications");
notifications.hidden = true;

var notificationsIcon = document.getElementById("M-M-HomeButton").addEventListener('click', function () {


    var notifications = document.getElementById("M-M-Notifications");

    if (notifications.hidden == false) {
        notifications.hidden = true;
    }
    else {
        notifications.hidden = false;
        friends.hidden = true;
        messages.hidden = true;
    }

});













