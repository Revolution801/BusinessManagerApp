<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<div style="margin: 20px 20px 80px 20px">
    <div class="row">
        <h4>Add Administrator</h4>
        <section class="col-md-12">
            <form class="form-horizontal" role="form">
                <hr />
                <div class="form-group">
                    <label for="NewAdmin" class="col-md-2 control-label">Email</label>
                    <div class="col-md-10">
                        <select class="form-control"
                            id="NewAdmin" name="NewAdmin"
                            ng-model="i.newAdmin"
                            ng-options="userInformation.userName as userInformation.userName for userInformation in i.userInformations">
                    	</select>	
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <button type="submit" class="btn btn-default" ng-click="i.setAdmin()" ng-disabled="!i.newAdmin || i.uploadingData">Set Admin</button>
                    </div>
                </div>
                <h4>{{i.addAdminMessage}}</h4>
            </form>
        </section>
    </div>
    <div class="row">
        <h4>Set Password</h4>
        <section class="col-md-12">
            <form class="form-horizontal" role="form">
                <hr />
                <div class="form-group">
                    <label for="ChangePasswordUserName" class="col-md-2 control-label">Email</label>
                    <div class="col-md-10">
                        <select class="form-control"
                            id="ChangePasswordUserName" name="ChangePasswordUserName"
                            ng-model="i.changePasswordUserName"
                            ng-options="userInformation.userName as userInformation.userName for userInformation in i.userInformations">
                    	</select>	
                    </div>
                </div>
                <div class="form-group">
                    <label for="ChangePasswordPassword" class="col-md-2 control-label">Password</label>
                    <div class="col-md-10">
                        <input type="text" id="ChangePasswordPassword" class="form-control" ng-model="i.changePasswordPassword" />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <button type="submit" class="btn btn-default" ng-click="i.setPassword()" ng-disabled="i.uploadingData || !i.changePasswordUserName || !i.changePasswordPassword">Set Password</button>
                    </div>
                </div>
                <h4>{{i.changePasswordMessage}}</h4>
            </form>
        </section>
    </div>
    <div class="row">
    	<h4>Beacons</h4>
        <section class="col-md-12">
            <form class="form-horizontal" role="form">
                <hr />
                <div class="form-group">
                    <label class="col-md-2 control-label">Beacon Total ({{i.beaconTotal}})</label>
                    <label class="col-md-2 control-label">User Created Total ({{i.userCreatedTotal}})</label>
                    <div class="col-md-8">
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <button type="submit" class="btn btn-default" ng-click="i.getBeaconTotal()" ng-disabled="i.uploadingData">Get Beacon Total</button>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <button type="submit" class="btn btn-default" ng-click="i.allocateBeacons()" ng-disabled="i.uploadingData">Allocate 1000 Beacons</button>
                    </div>
                </div>
                <h4>{{i.beaconMessage}}</h4>
            </form>
        </section>
    </div>
    <div class="row">
        <h4>Users</h4>
        <table class="col-md-12 table table-bordered table-condensed table-hover">
            <thead>
                <tr>
                    <th></th>
                    <th>Email</th>
                    <th>Display</th>
                </tr>
            </thead>
            <tbody ng-repeat="user in i.users">
                <tr>
                    <td class="text-center">
                        <button type="submit"
                                class="btn btn-danger btn-xs"
                                ng-click="i.deleteUser(user)"
                                ng-disabled="i.uploadingData">
                            <span class="glyphicon glyphicon-remove" aria-hidden="true"></span>
                        </button>
                    </td>
                    <td>{{user.userName}}</td>
                    <td>{{user.display}}</td>
                </tr>
            </tbody>
        </table>
    </div>
</div>
