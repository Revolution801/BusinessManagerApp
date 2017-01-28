<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>
<!DOCTYPE html>
<!--[if IE 8]> <html class="no-js lt-ie9 ie8" lang="en"> <![endif]-->
<!--[if IE 9]> <html class="ie9" lang="en"> <![endif]-->
<!--[if IE 10]> <html class="ie10" lang="en"> <![endif]-->
<!--[if (gt IE 10)|!(IE)]> <html lang="en"> <![endif]-->
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="">
    <link rel="shortcut icon" href="/ico/favIcon_48x48.ico">

    <title>ChaperApp | Home</title>

    <link rel="stylesheet" href="/Dist/all.css">
  </head>

  <body ng-app="com.roylance.chaperapp.jsapp">

    <div class="preloader">
       <div class="spinner">
          <div class="bounce1"></div>
          <div class="bounce2"></div>
          <div class="bounce3"></div>
        </div>
    </div>

    <!-- NAVBAR
    ================================================== -->
    <div class="navbar-wrapper cbp-af-header" ng-controller="navigationController">
      <div class="container">

        <!-- Fixed navbar -->
        <div class="navbar cbp-af-inner" role="navigation">
          <div class="container">
            <div class="navbar-header">
              <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
              </button>
              <h1><a class="navbar-brand scroll" href="#intro">ChaperApp</a></h1>
            </div>
            <div class="navbar-collapse collapse">
              <ul class="nav navbar-nav pull-right">
                <li><a href="#about" ng-show="!i.loggedinUserService.userName">About</a></li>
                <li><a href="#featured1" ng-show="!i.loggedinUserService.userName">Features</a></li>
                <li><a href="#pricing" ng-show="!i.loggedinUserService.userName">Pricing</a></li>
                <li><a class="hidden-sm login" href="#" ng-show="!i.loggedinUserService.userName">Login</a></li>
                <li><a class="signup" href="#" ng-show="!i.loggedinUserService.userName">Sign up</a></li>
                <li><a href="#" ng-show="i.loggedinUserService.userName" ng-click="i.loggedinUserService.logout()">Sign out</a></li>
              </ul>
            </div>
          </div>
        </div>

      </div>
    </div>


    <!-- Hero Banner
    ================================================== -->
    <div id="intro" ng-show="false">
        <div class="item background-cover" style="background: url('/img/bg-featuredapp1.jpg')">
          <div class="container">
            <div class="row">
              <div class="carousel-caption-center colour-white">
                <h2>Keep track of others when you go out. No GPS or internet required!</h2>
                <h1>Start today.</h1>
                <p>Donec sed odio dui. Etiam porta sem malesuada magna sem mollis sed odio dui malesuada euismod.</p>
                <p><a class="btn btn-lg btn-primary signup" href="#" role="button">Get started</a></p>
              </div>
            </div>
          </div>
          <div class="overlay-bg"></div>
        </div>
    </div>

    <!-- Home -->
    <div id="home" ng-controller="homeController" ng-show="i.loggedinUserService.userName">
        <div class="container" style="height: 300px;">
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
                                <label class="control-label" ng-bind="i.selectedUserCreatedBeacon.beaconId"></label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-md-2 control-label text-right">Major Id</label>
                            <div class="col-md-10 text-left">
                                <label class="control-label" ng-bind="i.selectedUserCreatedBeacon.majorId"></label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-md-2 control-label text-right">Minor Id</label>
                            <div class="col-md-10 text-left">
                                <label class="control-label" ng-bind="i.selectedUserCreatedBeacon.minorId"></label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-md-2 control-label text-right">Display Name</label>
                            <div class="col-md-10 text-left">
                                <input type="text"
                                    id="CustomerName"
                                    class="form-control"
                                    placeholder="Enter the name of the person the beacon will be attached to."
                                    ng-disabled="!i.selectedUserCreatedBeacon || i.isDoingWork"
                                    ng-model="i.selectedUserCreatedBeacon.displayName" />
                            </div>
                        </div>
                        <div class="form-group">
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
    </div>



    <!-- About Section
    ================================================== -->
    <section id="about" ng-controller="navigationController" ng-show="!i.loggedinUserService.userName" class="content text-center light">

      <div class="container">
        <!-- Three columns of text below the carousel -->
        <div class="row">
          <div class="col-lg-12 overlay-text">
            <h2>Prestige helps you escape the daily grind</h2>
          </div><!-- /.col-lg-12 -->
        </div><!-- /.row -->

        <div class="row">
          <div class="col-sm-4 text-center overlay-text icons">
            <div class="icon-wrapper">
              <i class="fa fa-cloud icon-large"></i>
            </div>
            <h3>Sky's the limit</h3>
            <p>Donec sed odio dui. Etiam porta sem malesuada magna mollis euismod.</p>
          </div>
          <div class="col-sm-4 text-center overlay-text icons">
            <div class="icon-wrapper">
              <i class="fa fa-rocket icon-large"></i>
            </div>
            <h3>Big Ideas</h3>
            <p>Donec sed odio dui. Etiam porta sem malesuada magna mollis euismod.</p>
          </div>
          <div class="col-sm-4 text-center overlay-text icons">
            <div class="icon-wrapper">
              <i class="fa fa-lightbulb-o icon-large"></i>
            </div>
            <h3>Creative Execution</h3>
            <p>Donec sed odio dui. Etiam porta sem malesuada magna mollis euismod.</p>
          </div>
        </div><!-- /.row -->
      </div>

      <div class="overlay-bg light"></div>

    </section>


    <!-- Featured Sections
    ================================================== -->
    <section id="featured1" ng-controller="navigationController" ng-show="!i.loggedinUserService.userName" class="dark with-bg">

      <div class="container">
        <div class="row">
          <div class="col-sm-5 overlay-text">
            <div class="vertical-align">
              <h2>Work to your own schedule</h2>
              <p>Donec ullamcorper nulla non metus auctor fringilla. Vestibulum id ligula porta felis euismod semper. Praesent commodo cursus magna, vel scelerisque nisl consectetur. Fusce dapibus, tellus ac cursus commodo.</p>
            </div>
          </div>
        </div>
      </div>

      <div class="overlay-bg black"></div>

    </section>


    <section id="featured2" ng-controller="navigationController" ng-show="!i.loggedinUserService.userName" class="featured">

      <div class="container">
        <div class="row">
          <div class="col-sm-5 text-center">
            <img class="margin-top img-responsive" src="img/imac.png" alt="Generic placeholder image" data-scrollreveal="move 100px and enter from the left after 0.55s" width="429">
          </div>
          <div class="col-sm-5 col-sm-offset-1">
            <div class="vertical-align">
              <h2>Effortless time management</h2>
              <p>Donec ullamcorper nulla non metus auctor fringilla. Vestibulum id ligula porta felis euismod semper. Praesent commodo cursus magna, vel scelerisque nisl consectetur. Fusce dapibus, tellus ac cursus commodo.</p>
            </div>
          </div>
        </div>
      </div>

    </section>

    <!-- Gallery
    ================================================== -->
    <section id="gallery" ng-controller="navigationController" ng-show="!i.loggedinUserService.userName">

      <div class="page-header text-center">
        <h3>Screenshots</h3>
        <h2>Here's a sneak peek</h2>
      </div>

      <div class="container">
        <div class="row">
          <div class="col-md-12">
            <div id="owl-example" class="owl-carousel">
              <div class="item">
                <a href="/img/thumbs/thumb1.jpg" class="popup-gallery">
                  <img src="/img/thumbs/thumb1.jpg" alt="Prestige Portfolio Thumbnail Image">
                </a>
              </div>
              <div class="item">
                <a href="/img/thumbs/thumb2.jpg" class="popup-gallery">
                  <img src="/img/thumbs/thumb2.jpg" alt="Prestige Portfolio Thumbnail Image">
                </a>
              </div>
              <div class="item">
                <a href="/img/thumbs/thumb3.jpg" class="popup-gallery">
                  <img src="/img/thumbs/thumb3.jpg" alt="Prestige Portfolio Thumbnail Image">
                </a>
              </div>
              <div class="item">
                <a href="/img/thumbs/thumb4.jpg" class="popup-gallery">
                  <img src="/img/thumbs/thumb4.jpg" alt="Prestige Portfolio Thumbnail Image">
                </a>
              </div>
              <div class="item">
                <a href="/img/thumbs/thumb5.jpg" class="popup-gallery">
                  <img src="/img/thumbs/thumb5.jpg" alt="Prestige Portfolio Thumbnail Image">
                </a>
              </div>
              <div class="item">
                <a href="/img/thumbs/thumb6.jpg" class="popup-gallery">
                  <img src="/img/thumbs/thumb6.jpg" alt="Prestige Portfolio Thumbnail Image">
                </a>
              </div>

            </div>
          </div>
        </div>
      </div>

    </section>


    <!-- Pricing
    ================================================== -->
    <section id="pricing"  ng-controller="navigationController" ng-show="!i.loggedinUserService.userName"class="dark">

      <div class="page-header text-center">
        <h3>Pricing</h3>
        <h2>Pay as you grow</h2>
      </div>

      <div class="container">
        <div class="row">
          <div class="plans">
              <div class="col-xs-12 col-sm-6 col-md-3">
                <div class="plan" data-scrollreveal="enter over 1s">
                  <div class="plan-title">
                    <h2>Beginner</h2>
                    <h3><sup>$</sup>0<sub>/ month</sub></h3>
                  </div>

                  <ul class="plan-features">
                    <li>1 user</li>
                    <li>5 projects</li>
                    <li>2GB storage</li>
                  </ul>
                  <div class="plan-cta">
                    <p class="plan-buy"><a href="index.html" class="btn">Select plan</a></p>
                 </div>
                </div>
              </div>

              <div class="col-xs-12 col-sm-6 col-md-3">
                <div class="plan featured" data-scrollreveal="enter over 1s">
                  <div class="plan-title">
                    <h2>Advanced</h2>
                    <h3><sup>$</sup>47<sub>/ month</sub></h3>
                  </div>

                  <ul class="plan-features">
                    <li><strong>5 users</strong></li>
                    <li>15 projects</li>
                    <li>20GB storage</li>
                  </ul>
                  <div class="plan-cta">
                    <p class="plan-buy"><a href="index.html" class="btn">Select plan</a></p>
                 </div>
                </div>
              </div>

              <div class="col-xs-12 col-sm-6 col-md-3">
                <div class="plan featured" data-scrollreveal="enter over 1s">
                  <div class="plan-title">
                    <h2>Pro</h2>
                    <h3><sup>$</sup>147<sub>/ month</sub></h3>
                  </div>

                  <ul class="plan-features">
                    <li><strong>50 users</strong></li>
                    <li>Unlimited projects</li>
                    <li>Unlimited storage</li>
                  </ul>
                  <div class="plan-cta">
                    <p class="plan-buy"><a href="index.html" class="btn">Select plan</a></p>
                 </div>
                </div>
              </div>

              <div class="col-xs-12 col-sm-6 col-md-3">
                <div class="plan" data-scrollreveal="enter over 1s">
                  <div class="plan-title">
                    <h2>Enterprise</h2>
                    <h3><sup>$</sup>199<sub>/ month</sub></h3>
                  </div>

                  <ul class="plan-features">
                    <li><strong>Unlimited users</strong></li>
                    <li>Unlimited projects</li>
                    <li>Unlimited storage</li>
                  </ul>
                  <div class="plan-cta">
                    <p class="plan-buy"><a href="index.html" class="btn">Select plan</a></p>
                 </div>
                </div>
              </div>
            </div>
        </div>
      </div>

    </section>


    <!-- Call to Action
    ================================================== -->
    <section class="cta text-center" ng-controller="navigationController" ng-show="!i.loggedinUserService.userName">

      <div class="container">
        
        <div class="row">
          <div class="col-lg-12">
            <h2>Start freelancing now.</h2>
            <p><a href="#" class="btn signup" role="button">Get started</a></p>
          </div>
        </div>

      </div>

    </section>


    <!-- Footer
    ================================================== -->
    <footer id="contact" class="footer">

      <div class="container">    
        <div class="row">
          <div class="col-lg-12">
            <div class="col-sm-3 col-md-3">
              <div class="footer-logo">
                <h2>Prestige</h2>
                <p>1024 Main Street, Vancouver BC<br>+1 (123) 456-7890</p>
                <br>
                <p class="muted">© 2013 Prestige Inc.</p>
                <a href="#">Terms of Service</a>    
                <a href="#">Privacy</a>
              </div>
            </div>
            <div class="col-sm-3 col-md-3">
              <h3>Product</h3>
              <ul class="list-unstyled">
                <li><a href="#">Product for iOS</a></li>
                <li><a href="#">Product for Android</a></li>
                <li><a href="#">Product for Windows</a></li>           
              </ul>
            </div>
            <div class="col-sm-3 col-md-3">
              <h3>Company</h3>
              <ul class="list-unstyled">
                <li><a href="#">About Us</a></li>
                <li><a href="#">Our Team</a></li>
                <li><a href="#">Jobs&emsp;<span class="label label-info">We're hiring!</span></a></li>           
              </ul>
            </div>
            <div class="col-sm-3 col-md-3">
              <h3>Documentation</h3>
              <ul class="list-unstyled">
                <li><a href="#">Product Help</a></li>
                <li><a href="#">Developer API</a></li>
                <li><a href="#">Product Markdown</a></li>             
              </ul>
            </div>  
          </div>
        </div>
        <div class="row">
          <div class="col-lg-12 text-center">
            <a class="icon" href="http://www.twitter.com/dparrelli" target="_blank"><i class="fa fa-twitter"></i></a>
            <a class="icon" href="#" target="_blank"><i class="fa fa-facebook"></i></a>
            <a class="icon" href="http://www.dribbble.com/dparrelli" target="_blank"><i class="fa fa-dribbble"></i></a>
            <a class="icon" href="http://www.workingnomads.co" target="_blank"><i class="fa fa-globe"></i></a>
          </div>
        </div>
      </div>

		</footer>

    <div id="login" class="overlay overlay-content" ng-controller="loginController">
  
      <button id="loginCloseButton" type="button" class="overlay-close">Close</button>
      <section class="login-part">
        <p class="login-overlay">
          Log In
        </p>
        <form method="post">
          <input class="form-control" type="email" name="u" placeholder="Email" required="required" ng-model="i.userName" />
          <input class="form-control" type="password" name="p" placeholder="Password" required="required" ng-model="i.password" />
          <button type="submit" class="btn btn-primary btn-block btn-large" ng-click="i.login()" ng-disabled="i.loggingIn || !i.userName || !i.password">Log me in</button>
          <!--<a href="#" class="forgot-pw">Forgot password? We can help!</a>-->
        </form>
       </section>
      
    </div>

    <div id="signup" class="overlay overlay-content" ng-controller="registerController">
  
      <button id="registerCloseButton" type="button" class="overlay-close">Close</button>
      <section class="login-part">
        <p class="login-overlay">
          Sign up to Prestige
        </p>
        <form method="post">
          <input class="form-control" type="text" name="email" placeholder="Email" required="required" ng-model="i.userName" />
          <input class="form-control" type="password" name="pw" placeholder="Password" required="required" ng-model="i.password" />
          <input class="form-control" type="password" name="repeat-pw" placeholder="Repeat Password" required="required" ng-model="i.confirmPassword" />
          <input class="form-control" type="text" id="RegisterDisplay" placeholder="First and Last Name" required="required"  ng-model="i.display" />
          <button type="submit" class="btn btn-primary btn-block btn-large" ng-click="i.register()" ng-disabled="i.cannotRegister()">Get started</button>
          <!--<p class="disclaimer">By signing up, you agree with our <a href="#">Terms of Service</a> & <a href="#">Privacy Policy</a></p>-->
        </form>
       </section>
      
    </div>


    <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="/Dist/vendor.min.js"></script>
    <script src="/Dist/all.min.js"></script>

    <script>

      $(document).ready(function(){
        isotope();
        signupOverlay();
        loginOverlay();
      });

    </script>

  </body>
</html>
