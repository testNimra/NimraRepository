Feature: Login

User will enter the username,password and click login button 

@login
Scenario: login_app
	Given User goes to DisputeDev Application
	And   User enters "abdul@finboa.com" in Username field on Login page
	And   User enters "Password@4" in Password field on Login page
	And   User clicks on Login button on Login page
	And   User enters OTP on Login Verification dialog
	When  User clicks on Authenicate button on Login Verification dialog
	Then  User should be able to see Dashboard in Application
	    



 

   

