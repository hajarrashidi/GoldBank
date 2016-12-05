console.log('Started...');

var Twit = require('twit'); 
/*Make a config.js file, and put this code:
------------------------------------------
module.exports = {
	consumer_key: '',
	consumer_secret: '',
	access_token: '',
	access_token_secret: ''
}
---------------------------------------------
*/
var config = require('./config');
var T = new Twit(config);

//Post-------------------------------
var tweet = {
	status: "Hello World!"
}

T.post('statuses/update', tweet, tweeted)

function tweeted(err, data, response){
	if (err) {
		console.log("Something went wrong");
	}else {
		console.log("It worked!");
	}
}




