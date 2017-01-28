// This file was auto-generated, but can be altered. It will not be overwritten.
package com.revolutionlandscaping.businessmanager.utilities

import com.revolutionlandscaping.businessmanager.services.MainService
import org.roylance.common.service.ILogger
import org.roylance.yaas.yaorm.EntityAuthenticationService
import org.roylance.yaorm.YaormModel
import org.roylance.yaorm.services.sqlite.SQLiteBuilder

object ServiceLocator: IServiceLocator {
    override val protobufSerializerService: org.roylance.common.service.IProtoSerializerService
        get() = org.roylance.common.service.ProtoSerializerService(com.revolutionlandscaping.businessmanager.services.Base64Service())
    override val mainService: com.revolutionlandscaping.businessmanager.services.IMainService
        get() = MainService(authenticationService, SQLiteBuilder(), commonConnection)
    override val reportService: org.roylance.yadel.services.IReportService
        get() = throw UnsupportedOperationException()
    override val adminService: org.roylance.yaas.services.IAdminService
        get() = throw UnsupportedOperationException()
    override val authenticationService: org.roylance.yaas.services.IAuthenticationService
        get() = EntityAuthenticationService(SQLiteBuilder(), commonConnection, systemLogger)
    override val userDeviceService: org.roylance.yaas.services.IUserDeviceService
        get() = throw UnsupportedOperationException()


    val commonConnection = YaormModel.ConnectionInfo.newBuilder()
            .setSchema("temp.db")
            .build()!!

    val systemLogger = object: ILogger {
        override fun debug(message: String) {
            println(message)
        }

        override fun error(message: String) {
            println(message)
        }

        override fun info(message: String) {
            println(message)
        }
    }

}
