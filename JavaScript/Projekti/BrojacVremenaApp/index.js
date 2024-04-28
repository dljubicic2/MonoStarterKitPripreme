const decreseBtn = document.getElementById("decreseBtn");
const resetBtn = document.getElementById("resetBtn");
const incriseBtn = document.getElementById("incriseBtn");

const countLabel = document.getElementById("countLabel");

let count = 0;

incriseBtn.onclick = function() 
{
    count++;
    countLabel.textContent = count;
}

decreseBtn.onclick = function()
{
    count--;
    countLabel.textContent = count;
}

resetBtn.onclick = function(){
    count = 0;
    countLabel.textContent = count;
}