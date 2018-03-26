var vehiclePrototype = {

    init: function (carModel) {
        this.model = carModel;
    },

    getModel: function () {
        console.log("The model of this vehicle is.." + this.model);
    }
};

var beget = (function () {

    function F() { }

    return function (proto) {
        F.prototype = proto;
        return new F();
    };
})();

var car = beget(vehiclePrototype);