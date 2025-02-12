function checkStaffID() {
    
}

function verify() {
    if(document.getElementById("txtStaffID").value === "admin"){
        document.getElementById("lblName").textContent = "Welcome admin";
        document.getElementById("lblInvaildIDMsg").style = "display: none";
        document.getElementById("txtStaffID").disabled = true;
        document.getElementById("txtStaffID").style = "border-color: gray";
    }
    else {
        document.getElementById("txtStaffID").style = "border-color: darkred";
        document.getElementById("lblInvaildIDMsg").style = "display: inline-block; color: red";
        document.getElementById("lblInvaildIDMsg").textContent = "Input ID invaild";
        document.getElementById("txtStaffID").value = "";
        document.getElementById("txtStaffID").focus();
    }
}

function calPrice() {
    alert(index);
}

var index = -1;

function setItemIndex(index) {
    this.index = index;
    alert(index);
}
