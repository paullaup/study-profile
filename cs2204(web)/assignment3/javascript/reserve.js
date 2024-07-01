function reserve(date, time, no) {
    /*
    *data: the date of reservation
    *time: the time of reservation
    *no: the number of people, type: int
    */
    if (arguments.length != 3) {
        alert("incorrect arguments detected"); // this is not a good way to handle error, this alert should not be activated by your code
        return;
    }
    //an random int as the valid quota
    let valid_quota = Math.floor(Math.random() * 2.0 * no);
    if (no > valid_quota) return false // the quota is full
    else return true; // the quota is not full
}