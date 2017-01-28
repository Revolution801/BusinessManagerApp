<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<div class="container">
    <h2>Log in</h2>
    <div class="row">
        <section class="col-md-12">
            <form class="form-horizontal" role="form">
                <hr />
                <div class="form-group">
                    <label for="LoginUserName" class="col-md-2 control-label">Email</label>
                    <div class="col-md-10">
                        <input type="text" id="LoginUserName" class="form-control" ng-model="i.userName" />
                    </div>
                </div>
                <div class="form-group">
                    <label for="LoginPassword" class="col-md-2 control-label">Password</label>
                    <div class="col-md-10">
                        <input type="password" id="LoginPassword" class="form-control" ng-model="i.password" />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <button type="submit" class="btn btn-default" ng-click="i.login()" ng-disabled="i.loggingIn || !i.userName || !i.password">
                            <span title="Log in" class="glyphicon glyphicon-log-in"></span>
                        </button>
                    </div>
                </div>
                <p>
                    <a href="#register">Register</a> if you don't have an account.
                </p>
            </form>
        </section>
    </div>
</div>