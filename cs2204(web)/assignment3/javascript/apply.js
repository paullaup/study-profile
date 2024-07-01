const engineeringBox = document.querySelector('.engineering');
const scienceBox = document.querySelector('.science');
const interdisciplinaryBox = document.querySelector('.Interdisciplinary');
const engineeringSelector = document.querySelector('.selector1');
const scienceselector = document.querySelector('.selector2');
const interdisciplinaryselector = document.querySelector('.selector3');
const rankedProgramCountor = document.querySelector('.majorsNum');
const lastChangeTimeBox = document.querySelector('.date');
const errorMsgBox = document.querySelector('.errorMsg');

class program {
    constructor(colleage, name) {
        this.colleage = colleage;
        this.name = name;
    }
}
var cs = new program('College of Engineering', 'BSc in Computer Science and Technology');
var ei = new program('College of Engineering', 'BEng in Electronic Information');
var mse = new program('College of Engineering', 'BEng in Materials Science and Engineering');
var mc = new program('College of Engineering', 'BEng in Materials and Chemicals');
var est = new program('College of Engineering', 'BSc in Electronic Science and Technology');

var phy = new program('College of Science', 'BSc in Physics BSc in Physics');
var chem = new program('College of Science', 'BSc in Chemistry BSc in Chemistry');
var bio = new program('College of Science', 'BSc in Biology BSc in Biology');

var cogs = new program('College of Interdisciplinary Studies', 'BSc in Cognitive Science BSc in Cognitive Science');
var be = new program('College of Interdisciplinary Studies', 'BEng in Biomedical Engineering');
var bm = new program('College of Interdisciplinary Studies', 'BSc in Biology and Medicine BSc in Biology and Medicine');

const programes = new Map();
programes.set('cs', cs);
programes.set('ei', ei);
programes.set('mse', mse);
programes.set('mc', mc);
programes.set('est', est);
programes.set('phy', phy);
programes.set('chem', chem);
programes.set('bio', bio);
programes.set('cogs', cogs);
programes.set('be', be);
programes.set('bm', bm);

var rankList = new Array();
for(let i = 0 ; i<10 ; i++) {
    rankList.push(null);
}

var rankedCount = 0;

engineeringSelector.onclick = showEngineering;
scienceselector.onclick = showScience;
interdisciplinaryselector.onclick = showInterdisciplinary;
document.querySelector('.majorsNum + a').onclick = submit;
document.querySelector('.majorsNum + a + a').onclick = clearTable;

function showEngineering() {
    clearAll()
    engineeringBox.setAttribute('style', 'display : block')
    engineeringSelector.setAttribute('style', 'background: white');
}

function showScience() {
    clearAll();
    scienceBox.setAttribute('style', 'display : block');
    scienceselector.setAttribute('style', 'background: white');
}

function showInterdisciplinary() {
    clearAll();
    interdisciplinaryBox.setAttribute('style', 'display : block');
    interdisciplinaryselector.setAttribute('style', 'background: white');
}

function clearAll() {
    engineeringBox.setAttribute('style', 'display : None');
    scienceBox.setAttribute('style', 'display : None');
    interdisciplinaryBox.setAttribute('style', 'display : None');
    engineeringSelector.setAttribute('style', 'background: rgb(191,191,191,255)');
    scienceselector.setAttribute('style', 'background: rgb(191,191,191,255)');
    interdisciplinaryselector.setAttribute('style', 'background: rgb(191,191,191,255)');
}
showEngineering();

var buttons = document.querySelectorAll('button');
for(let i = 0 ; i<buttons.length; i++) {
    buttons[i].onclick = onsubmit;
}

function addth(num) {
    var ans = '';
    switch(num) {
        case 1:
            ans += num + 'st';
            break;
        case 2:
            ans += num + 'nd'; 
            break;
        case 3:
            ans += num + 'rd';
            break;
        default:
            ans += num + 'th';
            break;
    }
    return ans;
}

function rankChoice(form) {
    var programid = form.id;
    var rank = parseInt(form.elements.rank.value);
    if(isNaN(rank)) {
        alert("Please enter the rank of chosen major");
        return;
    }
    if(isRanked(programid)) {
        alert("You have already chosen this major");
        return;
    }
    if(rank <= 0 || rank > 10) {
        alert("Please enter the rank of chosen between 1 and 10");
        return;
    }
    if(rankList[rank-1] != null) {
        alert("You have already chosen this rank");
        return;
    }
    let reply = "You have chosen " + programes.get(programid).name + " as your " + addth(rank) + ' chosen major in '+ programes.get(programid).colleage + " successfully";
    rankList[rank-1] = programid;
    rankedCount++;
    alert(reply)
    updateTable(rank);
}

function isRanked(id) {
    for(let i = 0 ; i<rankList.length ; i++) {
        if(rankList[i] == id) {
            return true
        }
    }
    return false;
}

function updateTable(rank) {
    rankedProgramCountor.innerHTML = 'Total Number of completed choice: ' + rankedCount;
    let now = new Date();
    lastChangeTimeBox.innerHTML = 'Last change time: ' + now.toLocaleString("en-UK", {timeZone: "Asia/Hong_Kong"});
    let rows = document.querySelectorAll('tr');
    rows[rank].children[0].innerHTML = programes.get(rankList[rank-1]).colleage;
    rows[rank].children[1].innerHTML = programes.get(rankList[rank-1]).name;
}

function submit() {
    gap = checkRankedList();
    if(!gap) {
        errorMsgBox.innerHTML = 'You have not chosen any major';
        return;
    }
    if(gap.length!=0) {
        msg = 'You have not chosen your ';
        for(let i = 0 ; i<gap.length-1 ; i++) {
            msg += addth(gap[i]) + ' chosen major, and ';
        }
        msg += addth(gap[gap.length-1]) + ' chosen major, you can not leave any gap between majors';
        errorMsgBox.innerHTML = msg;
    }
    else {
        let now = new Date();
        errorMsgBox.innerHTML = 'You have successfully submitted your application at time ' + now.toLocaleString("en-UK", {timeZone: "Asia/Hong_Kong"});
    }
}

function checkRankedList() {
    var empties = new Array();
    let lastItem = 0;
    for(let i = 0 ; i<rankList.length ; i++) {
        if(rankList[i]==null) {
            empties.push(i+1);
        }
        else {
            lastItem = i;
        }
    }
    if(empties.length==rankList.length) {
        return false
    }
    let unRankedQueueLength = rankList.length-1-lastItem;
    for(let i = 0 ; i<unRankedQueueLength ; i++) {
        empties.pop();
    }
    return empties
}

function clearTable() {
    rankedCount = 0;
    rankedProgramCountor.innerHTML = 'Total Number of completed choice: 0';
    var rows = document.querySelectorAll('tr')
    for(let i = 0 ; i<rankList.length ; i++) {
        rankList[i] = null;
        rows[i+1].children[0].innerHTML = '';
        rows[i+1].children[1].innerHTML = '';
    }
    let now = new Date();
    lastChangeTimeBox.innerHTML = 'Last change time: ' + now.toLocaleString("en-UK", {timeZone: "Asia/Hong_Kong"});
    errorMsgBox.innerHTML = '';
}
