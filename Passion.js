var _passionScore = 0; //Starts at neutral.
var _threshholds = [];


var Passion = function() {};

//Possible to have hit no threshholds.
Passion.prototype.ThreshholdsHit = function() {
  var hitThreshholds = [];
  _threshholds.forEach(function(threshhold) {
    if((threshhold.Value >= _passion && _passion > 0) ||
      (threshhold.Value <= _passion && _passion < 0 )) {
      hitThreshholds.push(threshhold);
    }
  });

  return hitThreshholds;
};

exports.Passion = new Passion();
