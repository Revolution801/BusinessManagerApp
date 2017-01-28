// THIS FILE WAS AUTO-GENERATED. DO NOT ALTER!
using System.Threading.Tasks;

namespace Com.Revolutionlandscaping.Businessmanager.Api
{
    public interface IMainService
    {
		Task<Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse> get_accounts(Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerRequest request);
		Task<Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse> save_accounts(Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerRequest request);
		Task<Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse> delete_accounts(Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerRequest request);
		Task<Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse> get_employees(Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerRequest request);
		Task<Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse> save_employees(Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerRequest request);
		Task<Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse> delete_employees(Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerRequest request);
		Task<Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse> get_jobs(Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerRequest request);
		Task<Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse> save_jobs(Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerRequest request);
		Task<Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse> delete_jobs(Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerRequest request);
	}
}
