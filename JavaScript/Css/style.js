/*
------------------------------------

Changes the style of a html element by Id.

------------------------------------
Rules:
All the parameters has to be strings, Correct: "10" | Wrong: 10 
Always camelCase for property Correct: "fontFamily" | Wrong: "font-family"
------------------------------------
Example of styling
style("myCube", backgroundColor, "green");
------------------------------------

*/
function style(id, property, value){
	document.getElementById(id).style[property] = value;
}

