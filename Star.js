var _passions = [];
var _activePassions = [];
var _hiddenPassions = [];

var _maxActivePassions = 3;
var _maxHiddenPassions = 1;

var Star = function() {};

//The list of passions a star can have.
Star.prototype.Passions = function() {
  return _passions;
};

//Returns the list of active passions the Star has during player's game.
Star.prototype.ActivePassions = function() {
  return _activePassions;
};

Star.prototype.AddPassion = function(passion) {
  _passions.push(passion);
};

//Doesn't account for idiots. Put enough stuff into passions.
Star.prototype.AssignPassions = function() {
  var temporaryPassionList = _passions;

  for (i = 0; i < _maxActivePassions; i++) {
    //Find random index.
    var index = Math.floor((Math.random() * _temporaryPassionsList.length));
    //Push it into
    _activePassions.push(temporaryPassionList[index]);

    //Remove the element so that we cannot accidentally iterate over it.
    temporaryPassionList.splice(index, 1);
  }

  for (i = 0; i < _maxHiddenPassions; i++) {
    //Find random index.
    var index = Math.floor((Math.random() * _temporaryPassionsList.length));
    //Push it into
    _hiddenPassions.push(temporaryPassionList[index]);

    //Remove the element so that we cannot accidentally iterate over it.
    temporaryPassionList.splice(index, 1);
  }
};

//Calculate the stars macro passion. Their overall
//feelings about the player's actions.
Star.prototype.MacroPassion = function() {
  return null;
};

exports.Star = new Star();
