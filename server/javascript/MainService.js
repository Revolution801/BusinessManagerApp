"use strict";
var MainService = (function () {
    function MainService(httpExecute, modelFactory) {
        this.httpExecute = httpExecute;
        this.modelFactory = modelFactory;
    }
    MainService.prototype.get_accounts = function (request, onSuccess, onError) {
        var self = this;
        this.httpExecute.performPost("/rest/main/get-accounts", request.toBase64(), function (result) {
            onSuccess(self.modelFactory.UIBusinessManagerResponse.decode64(result));
        }, onError);
    };
    MainService.prototype.save_accounts = function (request, onSuccess, onError) {
        var self = this;
        this.httpExecute.performPost("/rest/main/save-accounts", request.toBase64(), function (result) {
            onSuccess(self.modelFactory.UIBusinessManagerResponse.decode64(result));
        }, onError);
    };
    MainService.prototype.delete_accounts = function (request, onSuccess, onError) {
        var self = this;
        this.httpExecute.performPost("/rest/main/delete-accounts", request.toBase64(), function (result) {
            onSuccess(self.modelFactory.UIBusinessManagerResponse.decode64(result));
        }, onError);
    };
    MainService.prototype.get_employees = function (request, onSuccess, onError) {
        var self = this;
        this.httpExecute.performPost("/rest/main/get-employees", request.toBase64(), function (result) {
            onSuccess(self.modelFactory.UIBusinessManagerResponse.decode64(result));
        }, onError);
    };
    MainService.prototype.save_employees = function (request, onSuccess, onError) {
        var self = this;
        this.httpExecute.performPost("/rest/main/save-employees", request.toBase64(), function (result) {
            onSuccess(self.modelFactory.UIBusinessManagerResponse.decode64(result));
        }, onError);
    };
    MainService.prototype.delete_employees = function (request, onSuccess, onError) {
        var self = this;
        this.httpExecute.performPost("/rest/main/delete-employees", request.toBase64(), function (result) {
            onSuccess(self.modelFactory.UIBusinessManagerResponse.decode64(result));
        }, onError);
    };
    MainService.prototype.get_jobs = function (request, onSuccess, onError) {
        var self = this;
        this.httpExecute.performPost("/rest/main/get-jobs", request.toBase64(), function (result) {
            onSuccess(self.modelFactory.UIBusinessManagerResponse.decode64(result));
        }, onError);
    };
    MainService.prototype.save_jobs = function (request, onSuccess, onError) {
        var self = this;
        this.httpExecute.performPost("/rest/main/save-jobs", request.toBase64(), function (result) {
            onSuccess(self.modelFactory.UIBusinessManagerResponse.decode64(result));
        }, onError);
    };
    MainService.prototype.delete_jobs = function (request, onSuccess, onError) {
        var self = this;
        this.httpExecute.performPost("/rest/main/delete-jobs", request.toBase64(), function (result) {
            onSuccess(self.modelFactory.UIBusinessManagerResponse.decode64(result));
        }, onError);
    };
    return MainService;
}());
exports.MainService = MainService;
//# sourceMappingURL=MainService.js.map