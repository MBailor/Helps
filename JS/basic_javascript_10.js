

function count_To_Ten() {
  var Digit = "";
  var X = 1;
  while (X < 11) {
    Digit += "<br>" + X;
    X++;
  }
  document.getElementById("Counting_To_Ten").innerHTML = Digit;
}

function callLoop() {
var text = "";
var i = 0;

while (i < 5) {
  text += "<br>The Number Is " + i;
  i++;
  if (i === 3) {
    break;
  }
}  
document.getElementById("Loop").innerHTML = text;
}

