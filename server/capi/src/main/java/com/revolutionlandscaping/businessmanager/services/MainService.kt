// THIS FILE WAS AUTO-GENERATED. DO NOT ALTER!
package com.revolutionlandscaping.businessmanager.services

import org.roylance.common.service.IProtoSerializerService

class MainService(
        private val restMain: IMainRest,
        private val protoSerializer: IProtoSerializerService): IMainService {

    override fun get_accounts(request: com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest): com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse {
        val base64request = protoSerializer.serializeToBase64(request)
        val responseCall = restMain.get_accounts(base64request)
        val response = responseCall.execute()
        return protoSerializer.deserializeFromBase64(response.body(),
                com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse.getDefaultInstance())
    }

    override fun save_accounts(request: com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest): com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse {
        val base64request = protoSerializer.serializeToBase64(request)
        val responseCall = restMain.save_accounts(base64request)
        val response = responseCall.execute()
        return protoSerializer.deserializeFromBase64(response.body(),
                com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse.getDefaultInstance())
    }

    override fun delete_accounts(request: com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest): com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse {
        val base64request = protoSerializer.serializeToBase64(request)
        val responseCall = restMain.delete_accounts(base64request)
        val response = responseCall.execute()
        return protoSerializer.deserializeFromBase64(response.body(),
                com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse.getDefaultInstance())
    }

    override fun get_employees(request: com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest): com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse {
        val base64request = protoSerializer.serializeToBase64(request)
        val responseCall = restMain.get_employees(base64request)
        val response = responseCall.execute()
        return protoSerializer.deserializeFromBase64(response.body(),
                com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse.getDefaultInstance())
    }

    override fun save_employees(request: com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest): com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse {
        val base64request = protoSerializer.serializeToBase64(request)
        val responseCall = restMain.save_employees(base64request)
        val response = responseCall.execute()
        return protoSerializer.deserializeFromBase64(response.body(),
                com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse.getDefaultInstance())
    }

    override fun delete_employees(request: com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest): com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse {
        val base64request = protoSerializer.serializeToBase64(request)
        val responseCall = restMain.delete_employees(base64request)
        val response = responseCall.execute()
        return protoSerializer.deserializeFromBase64(response.body(),
                com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse.getDefaultInstance())
    }

    override fun get_jobs(request: com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest): com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse {
        val base64request = protoSerializer.serializeToBase64(request)
        val responseCall = restMain.get_jobs(base64request)
        val response = responseCall.execute()
        return protoSerializer.deserializeFromBase64(response.body(),
                com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse.getDefaultInstance())
    }

    override fun save_jobs(request: com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest): com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse {
        val base64request = protoSerializer.serializeToBase64(request)
        val responseCall = restMain.save_jobs(base64request)
        val response = responseCall.execute()
        return protoSerializer.deserializeFromBase64(response.body(),
                com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse.getDefaultInstance())
    }

    override fun delete_jobs(request: com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest): com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse {
        val base64request = protoSerializer.serializeToBase64(request)
        val responseCall = restMain.delete_jobs(base64request)
        val response = responseCall.execute()
        return protoSerializer.deserializeFromBase64(response.body(),
                com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse.getDefaultInstance())
    }
}