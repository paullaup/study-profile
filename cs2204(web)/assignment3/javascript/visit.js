const errorMsg = document.querySelector('.errorMsg');

function registerReservation() {
    var date = document.querySelector('#date').value;
    var time = document.querySelector('#time').value;
    var num = document.querySelector('#visitorsNum').value;
    if(date == '' || time=='' || num=='') {
        errorMsg.innerHTML = 'Data not completed, please re-enter.';
        errorMsg.setAttribute('style', 'display : block');
    }
    else if(isNaN(parseInt(num)) || parseInt(num)<=0 || parseFloat(num) != parseInt(num)) {
        errorMsg.innerHTML = 'Please enter a valid number of people!';
        errorMsg.setAttribute('style', 'display : block');
    }
    else {
        if(reserve(date, time, num)) {
            alert('Your reservation is successful!');
        }
        else {
            alert('Sorry, the reservation is full!');
        }
        document.querySelector('form').reset();
        errorMsg.innerHTML = "";
    }
}

function isAllSpace(str) {
    for(let i = 0 ; i<str.length ; i++) {
        if(str[i]!=' ') {
            return false
        }
    }
    return true
}