var Stars = [];

var Village = function() {};

//Returns the stars in the village.
Village.prototype.Stars = funtion() {
  return Stars;
};

//Adds a star to the village.
Village.prototype.AddStar = function(star) {
  Stars.push(star);
};

//Will sum all of the Stars passions and return the MacroPassion for the village.
Village.prototype.MacroPassion = function() {
  return null;
};

exports.Village = new Village();
