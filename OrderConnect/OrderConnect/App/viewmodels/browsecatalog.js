/// <reference path="../../Scripts/knockout-2.2.1.debug.js" />


define(function (require) {
    var http = require('durandal/http'),
        system = require('durandal/system'),
        app=require('durandal/app');

    var products = ko.observableArray();
    var categories = ko.observableArray(['ALL', 'Laboratory Products', 'Medical and Surgical Products', 'Physician Office Products', 'Snowden-Pencer® Products', 'Surgery Center']);
    var orginalProductList = ko.observableArray();
    var cartList = ko.observableArray();
    var productViewModel = function (name, description, category) {
        var self = this;
        self.Name = name;
        self.Description = description;
        self.Category = category;
    };

    return {
        productList: products,
        Categories: categories,
        CartList: cartList,
        activate: function () {
            products.removeAll();
            $.getJSON("/api/product", function (data) {
                $.each(data, function (key, list) {
                    orginalProductList.push(list);
                    products.push(list);
                });
            });
        },
        AddtoCart: function (data) {
            cartList.push(new productViewModel(data.Name, data.Description, data.Category));
            system.log(cartList());
        },
        categorylinkClick: function (data) {
            products.removeAll();
            if (data == "ALL") {
                ko.utils.arrayForEach(orginalProductList(), function (item) {
                    products.push(item);
                });
                return;
            }

            ko.utils.arrayForEach(orginalProductList(), function (item) {
                if (item.Category == data) {
                    products.push(item);
                }
            });
        },
        search: function (data, event) {
            if (event.keyCode == 13) {
                system.log('enter Code has been Clicked');
            }
            return true;
        }
    };
});