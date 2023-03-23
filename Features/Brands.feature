Feature: BrandsAdd

BrandsAdd will add respective information related to brands in the fields

@tag1
	Scenario:  Brands Add
	Given User clicks the ProfileIcon on the Dashboard Page
	And User selects the Brands option from the drop down menu of the ProfileIcon
	And User clicks on the AddNewCase Brand option from the Brands Page
	And User enters values in their corresponding fields in the AddBrand Page
		| Key                              | Value                    |
		| Brand Name                       | Nike                     |
		| Charter                          | Nk                       |
		| Email                            | abdul@finboa.com         |
		| Address                          | P-2205                   |
		| City                             | Rawalpindi               |
		| State                            | Punjab                   |
		| Zip                              | 45000                    |
		| Phone                            | 0322                     |
		| Fax                              | 051                      |