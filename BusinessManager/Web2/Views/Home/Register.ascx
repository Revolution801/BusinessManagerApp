<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<div class="container">
    <h2>Register</h2>
    <form class="form-horizontal" role="form">
        <h4>Create a new account.</h4>
        <hr/>
        <ul class="text-danger">
            <li ng-show="i.password.localeCompare(i.confirmPassword) != 0">Passwords do not match</li>
        </ul>
        <div class="form-group">
            <label for="RegisterUserName" class="col-md-2 control-label">Email</label>
            <div class="col-md-10">
                <input type="email" id="RegisterUserName" class="form-control" ng-model="i.userName" />
            </div>
        </div>
        <div class="form-group">
            <label for="RegisterDisplay" class="col-md-2 control-label">Display</label>
            <div class="col-md-10">
                <input type="text" id="RegisterDisplay" class="form-control" ng-model="i.display" />
            </div>
        </div>
        <div class="form-group">
            <label for="RegisterPassword" class="col-md-2 control-label">Password</label>
            <div class="col-md-10">
                <input type="password" id="RegisterPassword" class="form-control" ng-model="i.password" />
            </div>
        </div>
        <div class="form-group">
            <label for="RegisterConfirmPassword" class="col-md-2 control-label">Confirm password</label>
            <div class="col-md-10">
                <input type="password" id="RegisterConfirmPassword" class="form-control" ng-model="i.confirmPassword" />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <button type="submit" class="btn btn-default" ng-click="i.register()" ng-disabled="i.cannotRegister()">Register</button>
            </div>
        </div>
        <p><a href="#login">Log in</a> if you already have an account already.</p>
    </form>
</div>