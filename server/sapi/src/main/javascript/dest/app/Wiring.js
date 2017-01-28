"use strict";
// THIS FILE WAS AUTO-GENERATED. DO NOT ALTER!
/// <reference path="../node_modules/roylance.common/bytebuffer.d.ts" />
var BusinessManagerModelFactory_1 = require("../node_modules/com.revolutionlandscaping.businessmanager.api/BusinessManagerModelFactory");
var YadelModelFactory_1 = require("../node_modules/org.roylance.yadel.api/YadelModelFactory");
var YaasModelFactory_1 = require("../node_modules/org.roylance.yaas.api/YaasModelFactory");
var MainService_1 = require("../node_modules/com.revolutionlandscaping.businessmanager.api/MainService");
var ReportService_1 = require("../node_modules/org.roylance.yadel.api/ReportService");
var AdminService_1 = require("../node_modules/org.roylance.yaas.api/AdminService");
var AuthenticationService_1 = require("../node_modules/org.roylance.yaas.api/AuthenticationService");
var UserDeviceService_1 = require("../node_modules/org.roylance.yaas.api/UserDeviceService");
var HttpExecute_1 = require("./HttpExecute");
var FurtherAngularSetup_1 = require("./FurtherAngularSetup");
var app = angular.module('jsapp', [
    "ngRoute"
]);
app.factory("httpExecute", function ($window, $http) {
    return new HttpExecute_1.HttpExecute($http);
});
app.factory("businessManagerModel", function () {
    return BusinessManagerModelFactory_1.BusinessManagerModel.com.revolutionlandscaping.businessmanager;
});
app.factory("yadelModel", function () {
    return YadelModelFactory_1.YadelModel.org.roylance.yadel;
});
app.factory("yaasModel", function () {
    return YaasModelFactory_1.YaasModel.org.roylance.yaas;
});
app.factory("mainService", function (httpExecute, businessManagerModel) {
    return new MainService_1.MainService(httpExecute, businessManagerModel);
});
app.factory("reportService", function (httpExecute, yadelModel) {
    return new ReportService_1.ReportService(httpExecute, yadelModel);
});
app.factory("adminService", function (httpExecute, yaasModel) {
    return new AdminService_1.AdminService(httpExecute, yaasModel);
});
app.factory("authenticationService", function (httpExecute, yaasModel) {
    return new AuthenticationService_1.AuthenticationService(httpExecute, yaasModel);
});
app.factory("userDeviceService", function (httpExecute, yaasModel) {
    return new UserDeviceService_1.UserDeviceService(httpExecute, yaasModel);
});
FurtherAngularSetup_1.furtherAngularSetup(app);
