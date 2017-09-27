function getNextDay(year, month, day) {
    let date = new Date(year,month,day);
    let oneDay = 24 * 60 * 60 * 1000;
    let nextDay = new Date(date.getTime() + oneDay);

    console.log(nextDay.getFullYear() + "-" + (nextDay.getMonth() + 1) + '-' + nextDay.getDate());
}

getNextDay(2016, 9, 30);