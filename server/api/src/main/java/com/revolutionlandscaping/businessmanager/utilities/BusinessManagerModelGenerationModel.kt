package  com.revolutionlandscaping.businessmanager.utilities
import  com.google.protobuf.GeneratedMessageV3
import  org.roylance.yaorm.services.proto.BaseProtoGeneratedMessageBuilder

object  BusinessManagerModelGenerationModel: BaseProtoGeneratedMessageBuilder() {
    override val name: String
        get() = "BusinessManagerModelModel"

    override fun buildGeneratedMessage(name: String): GeneratedMessageV3 {
        if (com.revolutionlandscaping.businessmanager.BusinessManagerModel.Account.getDescriptor().name == name) {
            return com.revolutionlandscaping.businessmanager.BusinessManagerModel.Account.getDefaultInstance()
        }
        if (com.revolutionlandscaping.businessmanager.BusinessManagerModel.Employee.getDescriptor().name == name) {
            return com.revolutionlandscaping.businessmanager.BusinessManagerModel.Employee.getDefaultInstance()
        }
        if (com.revolutionlandscaping.businessmanager.BusinessManagerModel.Job.getDescriptor().name == name) {
            return com.revolutionlandscaping.businessmanager.BusinessManagerModel.Job.getDefaultInstance()
        }
        if (com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest.getDescriptor().name == name) {
            return com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest.getDefaultInstance()
        }
        if (com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse.getDescriptor().name == name) {
            return com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse.getDefaultInstance()
        }
        if (com.revolutionlandscaping.businessmanager.BusinessManagerController.CommonAction.getDescriptor().name == name) {
            return com.revolutionlandscaping.businessmanager.BusinessManagerController.CommonAction.getDefaultInstance()
        }
        if (com.revolutionlandscaping.businessmanager.BusinessManagerController.MainController.getDescriptor().name == name) {
            return com.revolutionlandscaping.businessmanager.BusinessManagerController.MainController.getDefaultInstance()
        }
        return super.buildGeneratedMessage(name)
    }
}