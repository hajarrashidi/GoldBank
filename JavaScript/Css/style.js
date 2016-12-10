/*
------------------------------------
Purpose:
Styles the html element with a Id tag
------------------------------------
Rules:
All the parameters has to be strings
Always camelCase
------------------------------------*/
function style(id, property, value){
	document.getElementById(id).style[property] = value;
}

//Example of styling, see that i am camelcasing background_color property
//style("myCube", backgroundColor, "green");