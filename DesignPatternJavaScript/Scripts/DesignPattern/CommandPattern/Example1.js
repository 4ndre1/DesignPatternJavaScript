﻿var carManager = (function () {

    var manager = {

        // request information
        requestInfo: function (model, id) {
            return "The information for " + model + " with ID " + id + " is foobar";
        },

        // purchase the car
        buyVehicle: function (model, id) {
            return "You have successfully purchased Item " + id + ", a " + model;
        },

        // arrange a viewing
        arrangeViewing: function (model, id) {
            return "You have successfully booked a viewing of " + model + " ( " + id + " ) ";
        },

        execute: function (name) {
            return carManager[name] && carManager[name].apply(carManager, [].slice.call(arguments, 1));
        }

    };

    return manager;
})();

carManager.execute("buyVehicle", "Ford Escort", "453543");
carManager.execute("arrangeViewing", "Ferrari", "14523");
carManager.execute("requestInfo", "Ford Mondeo", "54323");
carManager.execute("requestInfo", "Ford Escort", "34232");
carManager.execute("buyVehicle", "Ford Escort", "34232");


