// THIS FILE WAS AUTO-GENERATED. DO NOT ALTER!
/// <reference path="../node_modules/roylance.common/bytebuffer.d.ts" />
import {BusinessManagerModel} from "../node_modules/com.revolutionlandscaping.businessmanager.api/BusinessManagerModelFactory";
import {YadelModel} from "../node_modules/org.roylance.yadel.api/YadelModelFactory";
import {YaasModel} from "../node_modules/org.roylance.yaas.api/YaasModelFactory";

import {MainService} from "../node_modules/com.revolutionlandscaping.businessmanager.api/MainService";
import {ReportService} from "../node_modules/org.roylance.yadel.api/ReportService";
import {AdminService} from "../node_modules/org.roylance.yaas.api/AdminService";
import {AuthenticationService} from "../node_modules/org.roylance.yaas.api/AuthenticationService";
import {UserDeviceService} from "../node_modules/org.roylance.yaas.api/UserDeviceService";

import {HttpExecute} from "./HttpExecute"
import {furtherAngularSetup} from "./FurtherAngularSetup"

declare var angular: any;
const app = angular.module('jsapp', [
    "ngRoute"
]);

app.factory("httpExecute", function ($window, $http) {
    return new HttpExecute($http);
});

app.factory("businessManagerModel", function () {
    return BusinessManagerModel.com.revolutionlandscaping.businessmanager;
});
app.factory("yadelModel", function () {
    return YadelModel.org.roylance.yadel;
});
app.factory("yaasModel", function () {
    return YaasModel.org.roylance.yaas;
});

app.factory("mainService", function(httpExecute:HttpExecute, businessManagerModel:com.revolutionlandscaping.businessmanager.ProtoBufBuilder) {
    return new MainService(httpExecute, businessManagerModel)
});
app.factory("reportService", function(httpExecute:HttpExecute, yadelModel:org.roylance.yadel.ProtoBufBuilder) {
    return new ReportService(httpExecute, yadelModel)
});
app.factory("adminService", function(httpExecute:HttpExecute, yaasModel:org.roylance.yaas.ProtoBufBuilder) {
    return new AdminService(httpExecute, yaasModel)
});
app.factory("authenticationService", function(httpExecute:HttpExecute, yaasModel:org.roylance.yaas.ProtoBufBuilder) {
    return new AuthenticationService(httpExecute, yaasModel)
});
app.factory("userDeviceService", function(httpExecute:HttpExecute, yaasModel:org.roylance.yaas.ProtoBufBuilder) {
    return new UserDeviceService(httpExecute, yaasModel)
});


furtherAngularSetup(app);
