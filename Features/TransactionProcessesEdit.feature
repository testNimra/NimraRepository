Feature: TransactionProcessEdit

A short summary of the feature

@tag1
Scenario: TransactionEdit
	Given User clicks the Edit Submission icon on Transaction Process Page
	And   User edits the Name as "Sara" in NameField on Edit Process Transaction Setup Dialog
	And   User selects "Final Credit" from the Dropdown menu of Type field on Edit Process Transaction Setup Dialog
	And   User selects "FC" from the Dropdown menu of GL Reference field on Edit Process Transaction Setup Dialog
	And   User selects "A2" from the Dropdown menu of Workflows field on Edit Process Transaction Setup Dialog
	When  User clicks the Update Button on Edit Process Transaction Setup Page
	Then  User should be able to see Process Transaction Setup saved on Transaction Process Page

