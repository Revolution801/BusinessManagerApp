// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: business_manager_controller.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Com.Revolutionlandscaping.Businessmanager {

  /// <summary>Holder for reflection information generated from business_manager_controller.proto</summary>
  public static partial class BusinessManagerControllerReflection {

    #region Descriptor
    /// <summary>File descriptor for business_manager_controller.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BusinessManagerControllerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFidXNpbmVzc19tYW5hZ2VyX2NvbnRyb2xsZXIucHJvdG8SKWNvbS5yZXZv",
            "bHV0aW9ubGFuZHNjYXBpbmcuYnVzaW5lc3NtYW5hZ2VyGhxidXNpbmVzc19t",
            "YW5hZ2VyX21vZGVsLnByb3RvIrwBCgxDb21tb25BY3Rpb24SVAoHcmVxdWVz",
            "dBgBIAEoCzJDLmNvbS5yZXZvbHV0aW9ubGFuZHNjYXBpbmcuYnVzaW5lc3Nt",
            "YW5hZ2VyLlVJQnVzaW5lc3NNYW5hZ2VyUmVxdWVzdBJWCghyZXNwb25zZRgC",
            "IAEoCzJELmNvbS5yZXZvbHV0aW9ubGFuZHNjYXBpbmcuYnVzaW5lc3NtYW5h",
            "Z2VyLlVJQnVzaW5lc3NNYW5hZ2VyUmVzcG9uc2Ui2gUKDk1haW5Db250cm9s",
            "bGVyEk0KDGdldF9hY2NvdW50cxgBIAEoCzI3LmNvbS5yZXZvbHV0aW9ubGFu",
            "ZHNjYXBpbmcuYnVzaW5lc3NtYW5hZ2VyLkNvbW1vbkFjdGlvbhJOCg1zYXZl",
            "X2FjY291bnRzGAIgASgLMjcuY29tLnJldm9sdXRpb25sYW5kc2NhcGluZy5i",
            "dXNpbmVzc21hbmFnZXIuQ29tbW9uQWN0aW9uElAKD2RlbGV0ZV9hY2NvdW50",
            "cxgDIAEoCzI3LmNvbS5yZXZvbHV0aW9ubGFuZHNjYXBpbmcuYnVzaW5lc3Nt",
            "YW5hZ2VyLkNvbW1vbkFjdGlvbhJOCg1nZXRfZW1wbG95ZWVzGAQgASgLMjcu",
            "Y29tLnJldm9sdXRpb25sYW5kc2NhcGluZy5idXNpbmVzc21hbmFnZXIuQ29t",
            "bW9uQWN0aW9uEk8KDnNhdmVfZW1wbG95ZWVzGAUgASgLMjcuY29tLnJldm9s",
            "dXRpb25sYW5kc2NhcGluZy5idXNpbmVzc21hbmFnZXIuQ29tbW9uQWN0aW9u",
            "ElEKEGRlbGV0ZV9lbXBsb3llZXMYBiABKAsyNy5jb20ucmV2b2x1dGlvbmxh",
            "bmRzY2FwaW5nLmJ1c2luZXNzbWFuYWdlci5Db21tb25BY3Rpb24SSQoIZ2V0",
            "X2pvYnMYByABKAsyNy5jb20ucmV2b2x1dGlvbmxhbmRzY2FwaW5nLmJ1c2lu",
            "ZXNzbWFuYWdlci5Db21tb25BY3Rpb24SSgoJc2F2ZV9qb2JzGAggASgLMjcu",
            "Y29tLnJldm9sdXRpb25sYW5kc2NhcGluZy5idXNpbmVzc21hbmFnZXIuQ29t",
            "bW9uQWN0aW9uEkwKC2RlbGV0ZV9qb2JzGAkgASgLMjcuY29tLnJldm9sdXRp",
            "b25sYW5kc2NhcGluZy5idXNpbmVzc21hbmFnZXIuQ29tbW9uQWN0aW9uYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Com.Revolutionlandscaping.Businessmanager.BusinessManagerModelReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Revolutionlandscaping.Businessmanager.CommonAction), global::Com.Revolutionlandscaping.Businessmanager.CommonAction.Parser, new[]{ "Request", "Response" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Revolutionlandscaping.Businessmanager.MainController), global::Com.Revolutionlandscaping.Businessmanager.MainController.Parser, new[]{ "GetAccounts", "SaveAccounts", "DeleteAccounts", "GetEmployees", "SaveEmployees", "DeleteEmployees", "GetJobs", "SaveJobs", "DeleteJobs" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CommonAction : pb::IMessage<CommonAction> {
    private static readonly pb::MessageParser<CommonAction> _parser = new pb::MessageParser<CommonAction>(() => new CommonAction());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CommonAction> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Revolutionlandscaping.Businessmanager.BusinessManagerControllerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonAction() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonAction(CommonAction other) : this() {
      Request = other.request_ != null ? other.Request.Clone() : null;
      Response = other.response_ != null ? other.Response.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonAction Clone() {
      return new CommonAction(this);
    }

    /// <summary>Field number for the "request" field.</summary>
    public const int RequestFieldNumber = 1;
    private global::Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerRequest request_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerRequest Request {
      get { return request_; }
      set {
        request_ = value;
      }
    }

    /// <summary>Field number for the "response" field.</summary>
    public const int ResponseFieldNumber = 2;
    private global::Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse response_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse Response {
      get { return response_; }
      set {
        response_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CommonAction);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CommonAction other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Request, other.Request)) return false;
      if (!object.Equals(Response, other.Response)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (request_ != null) hash ^= Request.GetHashCode();
      if (response_ != null) hash ^= Response.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (request_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Request);
      }
      if (response_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Response);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (request_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Request);
      }
      if (response_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Response);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CommonAction other) {
      if (other == null) {
        return;
      }
      if (other.request_ != null) {
        if (request_ == null) {
          request_ = new global::Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerRequest();
        }
        Request.MergeFrom(other.Request);
      }
      if (other.response_ != null) {
        if (response_ == null) {
          response_ = new global::Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse();
        }
        Response.MergeFrom(other.Response);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (request_ == null) {
              request_ = new global::Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerRequest();
            }
            input.ReadMessage(request_);
            break;
          }
          case 18: {
            if (response_ == null) {
              response_ = new global::Com.Revolutionlandscaping.Businessmanager.UIBusinessManagerResponse();
            }
            input.ReadMessage(response_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class MainController : pb::IMessage<MainController> {
    private static readonly pb::MessageParser<MainController> _parser = new pb::MessageParser<MainController>(() => new MainController());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MainController> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Revolutionlandscaping.Businessmanager.BusinessManagerControllerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MainController() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MainController(MainController other) : this() {
      GetAccounts = other.getAccounts_ != null ? other.GetAccounts.Clone() : null;
      SaveAccounts = other.saveAccounts_ != null ? other.SaveAccounts.Clone() : null;
      DeleteAccounts = other.deleteAccounts_ != null ? other.DeleteAccounts.Clone() : null;
      GetEmployees = other.getEmployees_ != null ? other.GetEmployees.Clone() : null;
      SaveEmployees = other.saveEmployees_ != null ? other.SaveEmployees.Clone() : null;
      DeleteEmployees = other.deleteEmployees_ != null ? other.DeleteEmployees.Clone() : null;
      GetJobs = other.getJobs_ != null ? other.GetJobs.Clone() : null;
      SaveJobs = other.saveJobs_ != null ? other.SaveJobs.Clone() : null;
      DeleteJobs = other.deleteJobs_ != null ? other.DeleteJobs.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MainController Clone() {
      return new MainController(this);
    }

    /// <summary>Field number for the "get_accounts" field.</summary>
    public const int GetAccountsFieldNumber = 1;
    private global::Com.Revolutionlandscaping.Businessmanager.CommonAction getAccounts_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.Revolutionlandscaping.Businessmanager.CommonAction GetAccounts {
      get { return getAccounts_; }
      set {
        getAccounts_ = value;
      }
    }

    /// <summary>Field number for the "save_accounts" field.</summary>
    public const int SaveAccountsFieldNumber = 2;
    private global::Com.Revolutionlandscaping.Businessmanager.CommonAction saveAccounts_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.Revolutionlandscaping.Businessmanager.CommonAction SaveAccounts {
      get { return saveAccounts_; }
      set {
        saveAccounts_ = value;
      }
    }

    /// <summary>Field number for the "delete_accounts" field.</summary>
    public const int DeleteAccountsFieldNumber = 3;
    private global::Com.Revolutionlandscaping.Businessmanager.CommonAction deleteAccounts_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.Revolutionlandscaping.Businessmanager.CommonAction DeleteAccounts {
      get { return deleteAccounts_; }
      set {
        deleteAccounts_ = value;
      }
    }

    /// <summary>Field number for the "get_employees" field.</summary>
    public const int GetEmployeesFieldNumber = 4;
    private global::Com.Revolutionlandscaping.Businessmanager.CommonAction getEmployees_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.Revolutionlandscaping.Businessmanager.CommonAction GetEmployees {
      get { return getEmployees_; }
      set {
        getEmployees_ = value;
      }
    }

    /// <summary>Field number for the "save_employees" field.</summary>
    public const int SaveEmployeesFieldNumber = 5;
    private global::Com.Revolutionlandscaping.Businessmanager.CommonAction saveEmployees_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.Revolutionlandscaping.Businessmanager.CommonAction SaveEmployees {
      get { return saveEmployees_; }
      set {
        saveEmployees_ = value;
      }
    }

    /// <summary>Field number for the "delete_employees" field.</summary>
    public const int DeleteEmployeesFieldNumber = 6;
    private global::Com.Revolutionlandscaping.Businessmanager.CommonAction deleteEmployees_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.Revolutionlandscaping.Businessmanager.CommonAction DeleteEmployees {
      get { return deleteEmployees_; }
      set {
        deleteEmployees_ = value;
      }
    }

    /// <summary>Field number for the "get_jobs" field.</summary>
    public const int GetJobsFieldNumber = 7;
    private global::Com.Revolutionlandscaping.Businessmanager.CommonAction getJobs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.Revolutionlandscaping.Businessmanager.CommonAction GetJobs {
      get { return getJobs_; }
      set {
        getJobs_ = value;
      }
    }

    /// <summary>Field number for the "save_jobs" field.</summary>
    public const int SaveJobsFieldNumber = 8;
    private global::Com.Revolutionlandscaping.Businessmanager.CommonAction saveJobs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.Revolutionlandscaping.Businessmanager.CommonAction SaveJobs {
      get { return saveJobs_; }
      set {
        saveJobs_ = value;
      }
    }

    /// <summary>Field number for the "delete_jobs" field.</summary>
    public const int DeleteJobsFieldNumber = 9;
    private global::Com.Revolutionlandscaping.Businessmanager.CommonAction deleteJobs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.Revolutionlandscaping.Businessmanager.CommonAction DeleteJobs {
      get { return deleteJobs_; }
      set {
        deleteJobs_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MainController);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MainController other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GetAccounts, other.GetAccounts)) return false;
      if (!object.Equals(SaveAccounts, other.SaveAccounts)) return false;
      if (!object.Equals(DeleteAccounts, other.DeleteAccounts)) return false;
      if (!object.Equals(GetEmployees, other.GetEmployees)) return false;
      if (!object.Equals(SaveEmployees, other.SaveEmployees)) return false;
      if (!object.Equals(DeleteEmployees, other.DeleteEmployees)) return false;
      if (!object.Equals(GetJobs, other.GetJobs)) return false;
      if (!object.Equals(SaveJobs, other.SaveJobs)) return false;
      if (!object.Equals(DeleteJobs, other.DeleteJobs)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (getAccounts_ != null) hash ^= GetAccounts.GetHashCode();
      if (saveAccounts_ != null) hash ^= SaveAccounts.GetHashCode();
      if (deleteAccounts_ != null) hash ^= DeleteAccounts.GetHashCode();
      if (getEmployees_ != null) hash ^= GetEmployees.GetHashCode();
      if (saveEmployees_ != null) hash ^= SaveEmployees.GetHashCode();
      if (deleteEmployees_ != null) hash ^= DeleteEmployees.GetHashCode();
      if (getJobs_ != null) hash ^= GetJobs.GetHashCode();
      if (saveJobs_ != null) hash ^= SaveJobs.GetHashCode();
      if (deleteJobs_ != null) hash ^= DeleteJobs.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (getAccounts_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(GetAccounts);
      }
      if (saveAccounts_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(SaveAccounts);
      }
      if (deleteAccounts_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(DeleteAccounts);
      }
      if (getEmployees_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(GetEmployees);
      }
      if (saveEmployees_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(SaveEmployees);
      }
      if (deleteEmployees_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(DeleteEmployees);
      }
      if (getJobs_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(GetJobs);
      }
      if (saveJobs_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(SaveJobs);
      }
      if (deleteJobs_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(DeleteJobs);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (getAccounts_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GetAccounts);
      }
      if (saveAccounts_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SaveAccounts);
      }
      if (deleteAccounts_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DeleteAccounts);
      }
      if (getEmployees_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GetEmployees);
      }
      if (saveEmployees_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SaveEmployees);
      }
      if (deleteEmployees_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DeleteEmployees);
      }
      if (getJobs_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GetJobs);
      }
      if (saveJobs_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SaveJobs);
      }
      if (deleteJobs_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DeleteJobs);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MainController other) {
      if (other == null) {
        return;
      }
      if (other.getAccounts_ != null) {
        if (getAccounts_ == null) {
          getAccounts_ = new global::Com.Revolutionlandscaping.Businessmanager.CommonAction();
        }
        GetAccounts.MergeFrom(other.GetAccounts);
      }
      if (other.saveAccounts_ != null) {
        if (saveAccounts_ == null) {
          saveAccounts_ = new global::Com.Revolutionlandscaping.Businessmanager.CommonAction();
        }
        SaveAccounts.MergeFrom(other.SaveAccounts);
      }
      if (other.deleteAccounts_ != null) {
        if (deleteAccounts_ == null) {
          deleteAccounts_ = new global::Com.Revolutionlandscaping.Businessmanager.CommonAction();
        }
        DeleteAccounts.MergeFrom(other.DeleteAccounts);
      }
      if (other.getEmployees_ != null) {
        if (getEmployees_ == null) {
          getEmployees_ = new global::Com.Revolutionlandscaping.Businessmanager.CommonAction();
        }
        GetEmployees.MergeFrom(other.GetEmployees);
      }
      if (other.saveEmployees_ != null) {
        if (saveEmployees_ == null) {
          saveEmployees_ = new global::Com.Revolutionlandscaping.Businessmanager.CommonAction();
        }
        SaveEmployees.MergeFrom(other.SaveEmployees);
      }
      if (other.deleteEmployees_ != null) {
        if (deleteEmployees_ == null) {
          deleteEmployees_ = new global::Com.Revolutionlandscaping.Businessmanager.CommonAction();
        }
        DeleteEmployees.MergeFrom(other.DeleteEmployees);
      }
      if (other.getJobs_ != null) {
        if (getJobs_ == null) {
          getJobs_ = new global::Com.Revolutionlandscaping.Businessmanager.CommonAction();
        }
        GetJobs.MergeFrom(other.GetJobs);
      }
      if (other.saveJobs_ != null) {
        if (saveJobs_ == null) {
          saveJobs_ = new global::Com.Revolutionlandscaping.Businessmanager.CommonAction();
        }
        SaveJobs.MergeFrom(other.SaveJobs);
      }
      if (other.deleteJobs_ != null) {
        if (deleteJobs_ == null) {
          deleteJobs_ = new global::Com.Revolutionlandscaping.Businessmanager.CommonAction();
        }
        DeleteJobs.MergeFrom(other.DeleteJobs);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (getAccounts_ == null) {
              getAccounts_ = new global::Com.Revolutionlandscaping.Businessmanager.CommonAction();
            }
            input.ReadMessage(getAccounts_);
            break;
          }
          case 18: {
            if (saveAccounts_ == null) {
              saveAccounts_ = new global::Com.Revolutionlandscaping.Businessmanager.CommonAction();
            }
            input.ReadMessage(saveAccounts_);
            break;
          }
          case 26: {
            if (deleteAccounts_ == null) {
              deleteAccounts_ = new global::Com.Revolutionlandscaping.Businessmanager.CommonAction();
            }
            input.ReadMessage(deleteAccounts_);
            break;
          }
          case 34: {
            if (getEmployees_ == null) {
              getEmployees_ = new global::Com.Revolutionlandscaping.Businessmanager.CommonAction();
            }
            input.ReadMessage(getEmployees_);
            break;
          }
          case 42: {
            if (saveEmployees_ == null) {
              saveEmployees_ = new global::Com.Revolutionlandscaping.Businessmanager.CommonAction();
            }
            input.ReadMessage(saveEmployees_);
            break;
          }
          case 50: {
            if (deleteEmployees_ == null) {
              deleteEmployees_ = new global::Com.Revolutionlandscaping.Businessmanager.CommonAction();
            }
            input.ReadMessage(deleteEmployees_);
            break;
          }
          case 58: {
            if (getJobs_ == null) {
              getJobs_ = new global::Com.Revolutionlandscaping.Businessmanager.CommonAction();
            }
            input.ReadMessage(getJobs_);
            break;
          }
          case 66: {
            if (saveJobs_ == null) {
              saveJobs_ = new global::Com.Revolutionlandscaping.Businessmanager.CommonAction();
            }
            input.ReadMessage(saveJobs_);
            break;
          }
          case 74: {
            if (deleteJobs_ == null) {
              deleteJobs_ = new global::Com.Revolutionlandscaping.Businessmanager.CommonAction();
            }
            input.ReadMessage(deleteJobs_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
