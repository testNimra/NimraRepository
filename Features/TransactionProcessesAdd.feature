Feature: TransactionProcesses

     User clicks the Add Transaction Process to add the details on Add Process Transaction Setup Dialog
	 and clicks the Save button

@TransactionAdd
Scenario: TransactionAdd
	Given User clicks the ProfileIcon on the Dashboard page
	And   User selects the Transaction Processes Field from the dropdown menu of ProfileIcon
	And   User clicks the AddTransactionProcessIcon on Transaction Process Page
	And   User enters the following data into the fields on Add Process Transaction Setup Dialog
	            | Field                | Value                |
                | Name                 |  Susan               |
                | Type                 | Fee                  |
                | GL Reference         | TestCustomer00001    |
                | Workflows            | Debit Card           |
			      
				  
	When  User clicks the Save Button on Add Process Transaction Setup Dialog
	Then  User should be able to see Process Transaction Setup saved on Transaction Process Page

	
				  



	
	


