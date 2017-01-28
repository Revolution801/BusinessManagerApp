// THIS FILE WAS AUTO-GENERATED. DO NOT ALTER!
using System.Threading.Tasks;
using Google.Protobuf;

namespace Com.Revolutionlandscaping.Businessmanager.Api
{
    public class MainService: IMainService
    {
        private readonly IHttpExecute httpExecute;
        public MainService(IHttpExecute httpExecute)
        {
            this.httpExecute = httpExecute;
        }

        public async Task<Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse> get_accounts(Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerRequest request)
        {
            var base64request = System.Convert.ToBase64String(request.ToByteArray());
            var responseCall = await this.httpExecute.PostAsync("/rest/main/get-accounts", base64request);
            var bytes = System.Convert.FromBase64String(responseCall);
            return Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse.Parser.ParseFrom(bytes);
        }

        public async Task<Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse> save_accounts(Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerRequest request)
        {
            var base64request = System.Convert.ToBase64String(request.ToByteArray());
            var responseCall = await this.httpExecute.PostAsync("/rest/main/save-accounts", base64request);
            var bytes = System.Convert.FromBase64String(responseCall);
            return Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse.Parser.ParseFrom(bytes);
        }

        public async Task<Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse> delete_accounts(Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerRequest request)
        {
            var base64request = System.Convert.ToBase64String(request.ToByteArray());
            var responseCall = await this.httpExecute.PostAsync("/rest/main/delete-accounts", base64request);
            var bytes = System.Convert.FromBase64String(responseCall);
            return Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse.Parser.ParseFrom(bytes);
        }

        public async Task<Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse> get_employees(Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerRequest request)
        {
            var base64request = System.Convert.ToBase64String(request.ToByteArray());
            var responseCall = await this.httpExecute.PostAsync("/rest/main/get-employees", base64request);
            var bytes = System.Convert.FromBase64String(responseCall);
            return Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse.Parser.ParseFrom(bytes);
        }

        public async Task<Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse> save_employees(Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerRequest request)
        {
            var base64request = System.Convert.ToBase64String(request.ToByteArray());
            var responseCall = await this.httpExecute.PostAsync("/rest/main/save-employees", base64request);
            var bytes = System.Convert.FromBase64String(responseCall);
            return Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse.Parser.ParseFrom(bytes);
        }

        public async Task<Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse> delete_employees(Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerRequest request)
        {
            var base64request = System.Convert.ToBase64String(request.ToByteArray());
            var responseCall = await this.httpExecute.PostAsync("/rest/main/delete-employees", base64request);
            var bytes = System.Convert.FromBase64String(responseCall);
            return Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse.Parser.ParseFrom(bytes);
        }

        public async Task<Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse> get_jobs(Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerRequest request)
        {
            var base64request = System.Convert.ToBase64String(request.ToByteArray());
            var responseCall = await this.httpExecute.PostAsync("/rest/main/get-jobs", base64request);
            var bytes = System.Convert.FromBase64String(responseCall);
            return Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse.Parser.ParseFrom(bytes);
        }

        public async Task<Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse> save_jobs(Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerRequest request)
        {
            var base64request = System.Convert.ToBase64String(request.ToByteArray());
            var responseCall = await this.httpExecute.PostAsync("/rest/main/save-jobs", base64request);
            var bytes = System.Convert.FromBase64String(responseCall);
            return Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse.Parser.ParseFrom(bytes);
        }

        public async Task<Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse> delete_jobs(Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerRequest request)
        {
            var base64request = System.Convert.ToBase64String(request.ToByteArray());
            var responseCall = await this.httpExecute.PostAsync("/rest/main/delete-jobs", base64request);
            var bytes = System.Convert.FromBase64String(responseCall);
            return Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse.Parser.ParseFrom(bytes);
        }
	}
}