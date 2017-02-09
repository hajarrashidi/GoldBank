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

var params = {
  q: 'zlatan',
    count: 5
}

 T.get('search/tweets', params, getData);

function getData(err, data, response){
  var tweets = data.statuses;
  for(var i = 0; i < tweets.length; i++){
        console.log(tweets[i].text);
        console.log('---------------------------');

  }
}
