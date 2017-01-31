
    var hour = 7;
    var minute = 15;
    var period = "PM";

    if (minute == 15)
    {
        console.log("quarter after");
    }
    if (minute == 30)
    {
        console.log("half past");
    }
    if (hour !== 12 && period =="AM")
    {
        console.log(hour + " in the morning");
    }
    if (hour !== 12 && period =="PM")
    {
        console.log(hour + " in the night")
    }
    if( hour == 12 && period =="PM")
    {
        console.log("noon");
    }
    if(hour == 12 && period =="AM")
    {
        console.log("midnight");
    }
