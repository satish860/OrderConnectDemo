/// <reference path="../../Scripts/knockout-2.2.1.debug.js" />
/// <reference path="../durandal/http.js" />



define(function (require) {
    var http = require('durandal/http'),
        system = require('durandal/system'),
        app=require('durandal/app');


    var scanViewModel = {
        item: ko.observable()
        
    };
    var searchResults = ko.observableArray();

    return {
        scanViewModel: scanViewModel,
        searchResults:searchResults,
        search: function () {
            var data = scanViewModel.item();
            if (data.length > 2) {
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
    
});