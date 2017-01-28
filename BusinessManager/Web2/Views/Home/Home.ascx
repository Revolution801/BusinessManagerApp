<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<div style="margin: 20px 20px 80px 20px">
    <h2>Welcome to ChaperApp!</h2>

    <div class="row">
	    <div class="col-lg-4">
            <button type="submit" class="btn btn-default" ng-click="i.newUserCreatedBeacon()">
                    Purchase Beacon(s)
            </button>
	        <ul>
	            <li style="list-style-type: none" ng-repeat="userCreatedBeacon in i.userCreatedBeacons">
	                <label style="cursor: pointer">
	                    <input type="radio"
	                           name="userCreatedBeacons"
	                           ng-change="i.onChange()"
	                           ng-model="$parent.i.selectedUserCreatedBeacon"
	                           ng-value="userCreatedBeacon" /> <span ng-bind="userCreatedBeacon.displayName"></span>
	                </label>
	            </li>
	        </ul>
    	</div>

	    <div class="col-lg-8">
	        <h4><span ng-bind="i.selectedUserCreatedBeacon.displayName"></span></h4>

            <form class="form-horizontal" role="form" ng-show="i.selectedUserCreatedBeacon">
	            <div class="form-group">
	                <label class="col-md-2 control-label text-right">Beacon Id</label>
	                <div class="col-md-10 text-left">
	                    <label class="control-label">{{i.selectedUserCreatedBeacon.majorId}}_{{i.selectedUserCreatedBeacon.minorId}}</label>
	                </div>
	            </div>
	            <div class="form-group">
	                <label class="col-md-2 control-label text-right">Display Name</label>
	                <div class="col-md-10 text-left">
                        <input type="text" 
                        	id="CustomerName" 
                        	class="form-control" 
                        	placeholder="Enter the name of the person the beacon will be attached to." 
                        	ng-disabled="!i.selectedUserCreatedBeacon || i.isDoingWork || i.loggedinUserService.userName != i.selectedUserCreatedBeacon.createdUserName"
                        	ng-model="i.selectedUserCreatedBeacon.displayName" />
	                </div>
	            </div>
                <div class="form-group" ng-show="i.loggedinUserService.userName == i.selectedUserCreatedBeacon.createdUserName">
	                <div class="col-md-offset-2 col-md-10 text-left">
	                    <button type="submit" class="btn btn-default" ng-click="i.saveUserCreatedBeacon()" ng-disabled="!i.selectedUserCreatedBeacon || !i.selectedUserCreatedBeacon.displayName || i.isDoingWork">
	                        Save
	                    </button>
	                    <button type="submit" class="btn btn-default" ng-click="i.deleteUserCreatedBeacon()" ng-disabled="!i.selectedUserCreatedBeacon || i.isDoingWork">
	                        Delete
	                    </button>
	                </div>
            	</div>
		        <div class="text-info">{{i.messages}}</div>
            </form>
	    </div>
    </div>

    <div class="row" ng-show="i.selectedBeaconStatus">
        <div class="col-lg-12">
            <table class="table">
                <tr>
                    <th style="border: none;">Shipping Status</th>
                    <th style="border: none;">Status</th>
                    <th style="border: none;">Shipping Address</th>
                </tr>
                <tr>
                    <td style="border: none;">{{i.selectedBeaconStatus.shippingStatus}}</td>
                    <td style="border: none;">{{i.selectedBeaconStatus.status}}</td>
                    <td style="border: none;">
                        <table class="table">
                            <tr>
                                <td style="border: none;">{{i.selectedBeaconStatus.address.address}}</td>
                            </tr>
                            <tr>
                                <td style="border: none;">{{i.selectedBeaconStatus.address.city}}</td>
                            </tr>
                            <tr>
                                <td style="border: none;">{{i.selectedBeaconStatus.address.state}}</td>
                            </tr>
                            <tr>
                                <td style="border: none;">{{i.selectedBeaconStatus.address.zip}}</td>
                            </tr>
                            <tr>
                                <td style="border: none;">{{i.selectedBeaconStatus.address.country}}</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</div>