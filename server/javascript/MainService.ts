// THIS FILE WAS AUTO-GENERATED. DO NOT ALTER!
import {IMainService} from "./IMainService";
import {IHttpExecute} from "./IHttpExecute";
import ProtoBufBuilder = com.revolutionlandscaping.businessmanager.ProtoBufBuilder;

export class MainService implements IMainService {
    httpExecute:IHttpExecute;
    modelFactory:ProtoBufBuilder;

    constructor(httpExecute:IHttpExecute,
                modelFactory:ProtoBufBuilder) {
        this.httpExecute = httpExecute;
        this.modelFactory = modelFactory;
    }
	get_accounts(request: com.revolutionlandscaping.businessmanager.UIBusinessManagerRequest, onSuccess:(response: com.revolutionlandscaping.businessmanager.UIBusinessManagerResponse)=>void, onError:(response:any)=>void) {
            const self = this;
            this.httpExecute.performPost("/rest/main/get-accounts",
                    request.toBase64(),
                    function(result:string) {
                        onSuccess(self.modelFactory.UIBusinessManagerResponse.decode64(result));
                    },
                    onError);
        }
	save_accounts(request: com.revolutionlandscaping.businessmanager.UIBusinessManagerRequest, onSuccess:(response: com.revolutionlandscaping.businessmanager.UIBusinessManagerResponse)=>void, onError:(response:any)=>void) {
            const self = this;
            this.httpExecute.performPost("/rest/main/save-accounts",
                    request.toBase64(),
                    function(result:string) {
                        onSuccess(self.modelFactory.UIBusinessManagerResponse.decode64(result));
                    },
                    onError);
        }
	delete_accounts(request: com.revolutionlandscaping.businessmanager.UIBusinessManagerRequest, onSuccess:(response: com.revolutionlandscaping.businessmanager.UIBusinessManagerResponse)=>void, onError:(response:any)=>void) {
            const self = this;
            this.httpExecute.performPost("/rest/main/delete-accounts",
                    request.toBase64(),
                    function(result:string) {
                        onSuccess(self.modelFactory.UIBusinessManagerResponse.decode64(result));
                    },
                    onError);
        }
	get_employees(request: com.revolutionlandscaping.businessmanager.UIBusinessManagerRequest, onSuccess:(response: com.revolutionlandscaping.businessmanager.UIBusinessManagerResponse)=>void, onError:(response:any)=>void) {
            const self = this;
            this.httpExecute.performPost("/rest/main/get-employees",
                    request.toBase64(),
                    function(result:string) {
                        onSuccess(self.modelFactory.UIBusinessManagerResponse.decode64(result));
                    },
                    onError);
        }
	save_employees(request: com.revolutionlandscaping.businessmanager.UIBusinessManagerRequest, onSuccess:(response: com.revolutionlandscaping.businessmanager.UIBusinessManagerResponse)=>void, onError:(response:any)=>void) {
            const self = this;
            this.httpExecute.performPost("/rest/main/save-employees",
                    request.toBase64(),
                    function(result:string) {
                        onSuccess(self.modelFactory.UIBusinessManagerResponse.decode64(result));
                    },
                    onError);
        }
	delete_employees(request: com.revolutionlandscaping.businessmanager.UIBusinessManagerRequest, onSuccess:(response: com.revolutionlandscaping.businessmanager.UIBusinessManagerResponse)=>void, onError:(response:any)=>void) {
            const self = this;
            this.httpExecute.performPost("/rest/main/delete-employees",
                    request.toBase64(),
                    function(result:string) {
                        onSuccess(self.modelFactory.UIBusinessManagerResponse.decode64(result));
                    },
                    onError);
        }
	get_jobs(request: com.revolutionlandscaping.businessmanager.UIBusinessManagerRequest, onSuccess:(response: com.revolutionlandscaping.businessmanager.UIBusinessManagerResponse)=>void, onError:(response:any)=>void) {
            const self = this;
            this.httpExecute.performPost("/rest/main/get-jobs",
                    request.toBase64(),
                    function(result:string) {
                        onSuccess(self.modelFactory.UIBusinessManagerResponse.decode64(result));
                    },
                    onError);
        }
	save_jobs(request: com.revolutionlandscaping.businessmanager.UIBusinessManagerRequest, onSuccess:(response: com.revolutionlandscaping.businessmanager.UIBusinessManagerResponse)=>void, onError:(response:any)=>void) {
            const self = this;
            this.httpExecute.performPost("/rest/main/save-jobs",
                    request.toBase64(),
                    function(result:string) {
                        onSuccess(self.modelFactory.UIBusinessManagerResponse.decode64(result));
                    },
                    onError);
        }
	delete_jobs(request: com.revolutionlandscaping.businessmanager.UIBusinessManagerRequest, onSuccess:(response: com.revolutionlandscaping.businessmanager.UIBusinessManagerResponse)=>void, onError:(response:any)=>void) {
            const self = this;
            this.httpExecute.performPost("/rest/main/delete-jobs",
                    request.toBase64(),
                    function(result:string) {
                        onSuccess(self.modelFactory.UIBusinessManagerResponse.decode64(result));
                    },
                    onError);
        }
}