/// <reference path="../../Scripts/knockout-2.2.1.debug.js" />



define(function (require) {
    var http = require('durandal/http'),
        system = require('durandal/system');


    var scanViewModel = {
        item: ko.observable()
        
    };
    var searchResults = ko.observableArray();

    return {
        scanViewModel: scanViewModel,
        searchResults:searchResults,
        search: function () {
            var data = scanViewModel.item();
            console.log(data.size);
            if (data.length > 4) {
                searchResults.removeAll();
                $.getJSON("/api/Product/GetSearch?keywords=" + data, function (results) {
                    $.each(results, function (key, list) {
                        searchResults.push(list);
                    });
                });
            }

        },
        activate: function () {
            console.log('scan handled 2');
        }
    };

    ko.applyBindings(scanViewModel);
});