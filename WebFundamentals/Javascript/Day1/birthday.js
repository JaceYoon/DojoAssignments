var daysUntilMyBirthday = 62;
    function birthday(daysUntilMyBirthday)
    {
        while(daysUntilMyBirthday > 60)
        {
            console.log(daysUntilMyBirthday + "days until my birthday Such a long time... :(");
            daysUntilMyBirthday--;
        }
        while(daysUntilMyBirthday <= 60 && daysUntilMyBirthday >=30)
        {
            console.log(daysUntilMyBirthday +"days until my birthday almost..:)");
            daysUntilMyBirthday--;
        }
        while(daysUntilMyBirthday < 30 && daysUntilMyBirthday >=2)
        {
            console.log(daysUntilMyBirthday +"DAYS UNTIL MY BIRTHDAY!!");
            daysUntilMyBirthday--;
        }
        if(daysUntilMyBirthday == 1)
        {
            console.log(daysUntilMyBirthday + "DAY UNTIL MY BIRTHDAY!!");
            daysUntilMyBirthday--;
        }
        if(daysUntilMyBirthday === 0)
        {
            console.log("♪ღ♪*•.¸¸¸.•*¨¨*•.¸¸¸.•*•♪ღ♪¸.•*¨¨*•.¸¸¸.•*•♪ღ♪•*");
            console.log("♪ღ♪░H░A░P░P░Y░ B░I░R░T░H░D░A░Y░░♪ღ♪");
            console.log("*•♪ღ♪*•.¸¸¸.•*¨¨*•.¸¸¸.•*•♪¸.•*¨¨*•.¸¸¸.•*•♪ღ♪•«)");
        }

    }
    birthday(daysUntilMyBirthday);
