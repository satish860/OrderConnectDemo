define(function (require) {

    var router = require('durandal/plugins/router'),
        system = require('durandal/system'),
        app = require('durandal/app'),
        composition = require('durandal/composition'),
        scan = require('viewmodels/scan');

    return {
        scan: function () {
            composition.compose($('#PageHost').get(0),scan);

            console.log('scan handled');
        },
        activate: function () {
            system.log(router.activeItem());
            system.log("Home has been activated");
        }
    };
});