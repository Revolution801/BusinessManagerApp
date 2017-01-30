"use strict";
var _root = dcodeIO.ProtoBuf.newBuilder({})['import']({
    "package": "com.revolutionlandscaping.businessmanager",
    "messages": [
        {
            "name": "Account",
            "fields": [
                {
                    "rule": "optional",
                    "type": "string",
                    "name": "id",
                    "id": 1
                },
                {
                    "rule": "optional",
                    "type": "string",
                    "name": "first_name",
                    "id": 2
                },
                {
                    "rule": "optional",
                    "type": "string",
                    "name": "last_name",
                    "id": 3
                },
                {
                    "rule": "optional",
                    "type": "string",
                    "name": "address",
                    "id": 4
                },
                {
                    "rule": "optional",
                    "type": "string",
                    "name": "city",
                    "id": 5
                },
                {
                    "rule": "optional",
                    "type": "string",
                    "name": "state",
                    "id": 6
                },
                {
                    "rule": "optional",
                    "type": "string",
                    "name": "zip",
                    "id": 7
                },
                {
                    "rule": "optional",
                    "type": "string",
                    "name": "phone",
                    "id": 8
                }
            ]
        },
        {
            "name": "Employee",
            "fields": [
                {
                    "rule": "optional",
                    "type": "string",
                    "name": "id",
                    "id": 1
                },
                {
                    "rule": "optional",
                    "type": "string",
                    "name": "first_name",
                    "id": 2
                },
                {
                    "rule": "optional",
                    "type": "string",
                    "name": "last_name",
                    "id": 3
                },
                {
                    "rule": "optional",
                    "type": "double",
                    "name": "hourly_rate",
                    "id": 4
                }
            ]
        },
        {
            "name": "Job",
            "fields": [
                {
                    "rule": "optional",
                    "type": "string",
                    "name": "id",
                    "id": 1
                },
                {
                    "rule": "optional",
                    "type": "string",
                    "name": "account_id",
                    "id": 2
                },
                {
                    "rule": "optional",
                    "type": "string",
                    "name": "date",
                    "id": 3
                },
                {
                    "rule": "optional",
                    "type": "string",
                    "name": "description",
                    "id": 4
                },
                {
                    "rule": "optional",
                    "type": "double",
                    "name": "fixed_price",
                    "id": 5
                },
                {
                    "rule": "optional",
                    "type": "double",
                    "name": "hourly_rate",
                    "id": 6
                },
                {
                    "rule": "optional",
                    "type": "double",
                    "name": "hours",
                    "id": 7
                }
            ]
        },
        {
            "name": "UIBusinessManagerRequest",
            "fields": [
                {
                    "rule": "optional",
                    "type": "string",
                    "name": "token",
                    "id": 1
                },
                {
                    "rule": "repeated",
                    "type": "Account",
                    "name": "accounts",
                    "id": 2
                },
                {
                    "rule": "repeated",
                    "type": "Employee",
                    "name": "employees",
                    "id": 3
                },
                {
                    "rule": "repeated",
                    "type": "Job",
                    "name": "jobs",
                    "id": 4
                }
            ]
        },
        {
            "name": "UIBusinessManagerResponse",
            "fields": [
                {
                    "rule": "repeated",
                    "type": "Account",
                    "name": "accounts",
                    "id": 1
                },
                {
                    "rule": "repeated",
                    "type": "Employee",
                    "name": "employees",
                    "id": 2
                },
                {
                    "rule": "repeated",
                    "type": "Job",
                    "name": "jobs",
                    "id": 3
                }
            ]
        },
        {
            "name": "CommonAction",
            "fields": [
                {
                    "rule": "optional",
                    "type": "UIBusinessManagerRequest",
                    "name": "request",
                    "id": 1
                },
                {
                    "rule": "optional",
                    "type": "UIBusinessManagerResponse",
                    "name": "response",
                    "id": 2
                }
            ]
        },
        {
            "name": "MainController",
            "fields": [
                {
                    "rule": "optional",
                    "type": "CommonAction",
                    "name": "get_accounts",
                    "id": 1
                },
                {
                    "rule": "optional",
                    "type": "CommonAction",
                    "name": "save_accounts",
                    "id": 2
                },
                {
                    "rule": "optional",
                    "type": "CommonAction",
                    "name": "delete_accounts",
                    "id": 3
                },
                {
                    "rule": "optional",
                    "type": "CommonAction",
                    "name": "get_employees",
                    "id": 4
                },
                {
                    "rule": "optional",
                    "type": "CommonAction",
                    "name": "save_employees",
                    "id": 5
                },
                {
                    "rule": "optional",
                    "type": "CommonAction",
                    "name": "delete_employees",
                    "id": 6
                },
                {
                    "rule": "optional",
                    "type": "CommonAction",
                    "name": "get_jobs",
                    "id": 7
                },
                {
                    "rule": "optional",
                    "type": "CommonAction",
                    "name": "save_jobs",
                    "id": 8
                },
                {
                    "rule": "optional",
                    "type": "CommonAction",
                    "name": "delete_jobs",
                    "id": 9
                }
            ]
        }
    ]
}).build();
exports.BusinessManagerModel = _root;
//# sourceMappingURL=BusinessManagerModelFactory.js.map