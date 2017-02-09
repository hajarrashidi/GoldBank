/*
JavaScript Variables
 - Variables store data / value

Standar Variable
<variable> <name> = <value>
 */

//Default JavaScript variable. 
var fruit = "I am fruit variable";

//Declare a variable
var fish;
//initialize a variable
fish = "I am a new fish";

//Contant Variables, variables that can't be changed
const PI = 3.141;
const life = "eat and sleep";


// "let" works like "var" but are stricter when it comes to scoping.
//https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Statements/let
let tuna = "I am a fish";

//JavaScript Variables can be:

//String
var apple = "I am String";
//Numbers
var banana = -5.5;
//Array, its a list with values
var house = ["Floor", "Ceiling", "Door", "Wall", "Window", 420, true];

//Object, objects can be nested.
var human = {
    firstName: "Hajar",
    lastName: "Rashidi",
    age: 20,
    favoriteBooks: ["Harry Potter", "Fallen", "Twilight"],
    github: "www.github.com/hajarrashidi",
    pets: {
        dog: {name: "Jack", age: 2 },
        snake: {name: "Frank", age: 1 }
    }

};

console.log(human.firstName + " is " + human.age + " years old" + ", he also have a dog called " + human.pets.dog.name);

/*
Tips:
 - Use a JavaScript Variable Name Validator: https://mothereff.in/js-variables

 */