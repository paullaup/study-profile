const welcomMsg = new Array(
    "Join Hong Kong Industrial University's College of Science for world-class education and research opportunities in science and technology! 20 QUOTAS LEFT!",
    "Join the future of engineering with Hong Kong Industrial University's College of Engineering, offering innovative programs and world-class faculty to prepare you for success in the field! 40 QUOTAS LEFT!",
    "Join the future of interdisciplinary studies with Hong Kong Industrial University's College of Interdisciplinary Studies, offering innovative programs and world-class faculty to prepare you for success in various fields! 30 QUOTAS LEFT!"
);

const video = document.querySelector('video');
const msgBox = document.querySelector('#msgBox');

document.querySelector('video').onended = swapVideoSource


var currentMsgIndex = Math.floor(Math.random()*3);
var currentVideoIndex = '1';

function loopMsg() {
    currentMsgIndex = (currentMsgIndex+1) % 3;
    msgBox.innerHTML = welcomMsg[currentMsgIndex];
}

function swapVideoSource() {
    currentVideoIndex = (currentVideoIndex=='1')? '2':'1';
    document.querySelector("#source1").src = 'https://personal.cs.cityu.edu.hk/~cs2204/2023/video/video' + currentVideoIndex + '.mp4';
    document.querySelector("#source2").src = 'https://personal.cs.cityu.edu.hk/~cs2204/2023/video/video' + currentVideoIndex + '.mkv';
    this.load();
}

setInterval(loopMsg, 3000) 
