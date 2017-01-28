import base64
import requests
import business_manager_model_pb2


class MainService(object):
    def __init__(self, base_url):
        self.base_url = base_url

	def get_accounts(request):
		base64_request = base64.b64encode(request.SerializeToString())
		response_call = requests.post(self.base_url + '/rest/main/get-accounts', data = base64_request)
		response = business_manager_model_pb2.UIBusinessManagerResponse()
		response.ParseFromString(base64.b64decode(response_call.text))
		return response

	def save_accounts(request):
		base64_request = base64.b64encode(request.SerializeToString())
		response_call = requests.post(self.base_url + '/rest/main/save-accounts', data = base64_request)
		response = business_manager_model_pb2.UIBusinessManagerResponse()
		response.ParseFromString(base64.b64decode(response_call.text))
		return response

	def delete_accounts(request):
		base64_request = base64.b64encode(request.SerializeToString())
		response_call = requests.post(self.base_url + '/rest/main/delete-accounts', data = base64_request)
		response = business_manager_model_pb2.UIBusinessManagerResponse()
		response.ParseFromString(base64.b64decode(response_call.text))
		return response

	def get_employees(request):
		base64_request = base64.b64encode(request.SerializeToString())
		response_call = requests.post(self.base_url + '/rest/main/get-employees', data = base64_request)
		response = business_manager_model_pb2.UIBusinessManagerResponse()
		response.ParseFromString(base64.b64decode(response_call.text))
		return response

	def save_employees(request):
		base64_request = base64.b64encode(request.SerializeToString())
		response_call = requests.post(self.base_url + '/rest/main/save-employees', data = base64_request)
		response = business_manager_model_pb2.UIBusinessManagerResponse()
		response.ParseFromString(base64.b64decode(response_call.text))
		return response

	def delete_employees(request):
		base64_request = base64.b64encode(request.SerializeToString())
		response_call = requests.post(self.base_url + '/rest/main/delete-employees', data = base64_request)
		response = business_manager_model_pb2.UIBusinessManagerResponse()
		response.ParseFromString(base64.b64decode(response_call.text))
		return response

	def get_jobs(request):
		base64_request = base64.b64encode(request.SerializeToString())
		response_call = requests.post(self.base_url + '/rest/main/get-jobs', data = base64_request)
		response = business_manager_model_pb2.UIBusinessManagerResponse()
		response.ParseFromString(base64.b64decode(response_call.text))
		return response

	def save_jobs(request):
		base64_request = base64.b64encode(request.SerializeToString())
		response_call = requests.post(self.base_url + '/rest/main/save-jobs', data = base64_request)
		response = business_manager_model_pb2.UIBusinessManagerResponse()
		response.ParseFromString(base64.b64decode(response_call.text))
		return response

	def delete_jobs(request):
		base64_request = base64.b64encode(request.SerializeToString())
		response_call = requests.post(self.base_url + '/rest/main/delete-jobs', data = base64_request)
		response = business_manager_model_pb2.UIBusinessManagerResponse()
		response.ParseFromString(base64.b64decode(response_call.text))
		return response


