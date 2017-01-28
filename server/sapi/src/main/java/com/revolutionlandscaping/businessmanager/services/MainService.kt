package com.revolutionlandscaping.businessmanager.services

import com.revolutionlandscaping.businessmanager.BusinessManagerModel
import com.revolutionlandscaping.businessmanager.utilities.BusinessManagerModelGenerationModel
import org.roylance.yaas.services.IAuthenticationService
import org.roylance.yaorm.YaormModel
import org.roylance.yaorm.services.IEntityBuilder
import java.util.*

class MainService(
        private val authenticationService: IAuthenticationService,
        private val entityBuilder: IEntityBuilder,
        private val connectionInfo: YaormModel.ConnectionInfo
): IMainService{
    override fun delete_accounts(request: BusinessManagerModel.UIBusinessManagerRequest): BusinessManagerModel.UIBusinessManagerResponse {
        val messageService = entityBuilder.buildMessageService(connectionInfo,
                BusinessManagerModelGenerationModel,
                HashMap())

        try {
            request.accountsList.forEach {
                messageService.delete(it)
            }
            return BusinessManagerModel.UIBusinessManagerResponse.getDefaultInstance()
        }
        finally {
            messageService.close()
        }
    }

    override fun delete_employees(request: BusinessManagerModel.UIBusinessManagerRequest): BusinessManagerModel.UIBusinessManagerResponse {
        val messageService = entityBuilder.buildMessageService(connectionInfo,
                BusinessManagerModelGenerationModel,
                HashMap())

        try {
            request.employeesList.forEach {
                messageService.delete(it)
            }
            return BusinessManagerModel.UIBusinessManagerResponse.getDefaultInstance()
        }
        finally {
            messageService.close()
        }
    }

    override fun delete_jobs(request: BusinessManagerModel.UIBusinessManagerRequest): BusinessManagerModel.UIBusinessManagerResponse {
        val messageService = entityBuilder.buildMessageService(connectionInfo,
                BusinessManagerModelGenerationModel,
                HashMap())

        try {
            request.jobsList.forEach {
                messageService.delete(it)
            }
            return BusinessManagerModel.UIBusinessManagerResponse.getDefaultInstance()
        }
        finally {
            messageService.close()
        }
    }

    override fun get_accounts(request: BusinessManagerModel.UIBusinessManagerRequest): BusinessManagerModel.UIBusinessManagerResponse {
        val messageService = entityBuilder.buildMessageService(connectionInfo,
                BusinessManagerModelGenerationModel,
                HashMap())

        try {
            return BusinessManagerModel.UIBusinessManagerResponse
                    .newBuilder()
                    .addAllAccounts(messageService.getMany(BusinessManagerModel.Account.getDefaultInstance()))
                    .build()
        }
        finally {
            messageService.close()
        }
    }

    override fun get_employees(request: BusinessManagerModel.UIBusinessManagerRequest): BusinessManagerModel.UIBusinessManagerResponse {
        val messageService = entityBuilder.buildMessageService(connectionInfo,
                BusinessManagerModelGenerationModel,
                HashMap())

        try {
            return BusinessManagerModel.UIBusinessManagerResponse
                    .newBuilder()
                    .addAllEmployees(messageService.getMany(BusinessManagerModel.Employee.getDefaultInstance()))
                    .build()
        }
        finally {
            messageService.close()
        }
    }

    override fun get_jobs(request: BusinessManagerModel.UIBusinessManagerRequest): BusinessManagerModel.UIBusinessManagerResponse {
        val messageService = entityBuilder.buildMessageService(connectionInfo,
                BusinessManagerModelGenerationModel,
                HashMap())

        try {
            return BusinessManagerModel.UIBusinessManagerResponse
                    .newBuilder()
                    .addAllJobs(messageService.getMany(BusinessManagerModel.Job.getDefaultInstance()))
                    .build()
        }
        finally {
            messageService.close()
        }
    }

    override fun save_accounts(request: BusinessManagerModel.UIBusinessManagerRequest): BusinessManagerModel.UIBusinessManagerResponse {
        val messageService = entityBuilder.buildMessageService(connectionInfo,
                BusinessManagerModelGenerationModel,
                HashMap())

        try {
            request.accountsList.forEach {
                messageService.merge(it)
            }
            return BusinessManagerModel.UIBusinessManagerResponse.getDefaultInstance()
        }
        finally {
            messageService.close()
        }
    }

    override fun save_employees(request: BusinessManagerModel.UIBusinessManagerRequest): BusinessManagerModel.UIBusinessManagerResponse {
        val messageService = entityBuilder.buildMessageService(connectionInfo,
                BusinessManagerModelGenerationModel,
                HashMap())

        try {
            request.employeesList.forEach {
                messageService.merge(it)
            }
            return BusinessManagerModel.UIBusinessManagerResponse.getDefaultInstance()
        }
        finally {
            messageService.close()
        }
    }

    override fun save_jobs(request: BusinessManagerModel.UIBusinessManagerRequest): BusinessManagerModel.UIBusinessManagerResponse {
        val messageService = entityBuilder.buildMessageService(connectionInfo,
                BusinessManagerModelGenerationModel,
                HashMap())

        try {
            request.jobsList.forEach {
                messageService.merge(it)
            }
            return BusinessManagerModel.UIBusinessManagerResponse.getDefaultInstance()
        }
        finally {
            messageService.close()
        }
    }
}