@employee
Feature: Employee

In order to add employee to the portal 
as a admin
I want to add records  to the portal

@low @smoke
Scenario: Add Employee
	Given I have browser with orangehrm page
	When I enter username as 'Admin'
	And I enter password as 'admin123'
	And I click on login
	And I click on PIM
	And I click on Add Employee
	And I add all details
	| firstname | middle_name | last_name | employee_id | toggle_login_details | username | password      | confirm_password | status   |
	| Sneha     | A.          | Lahariya  | 101         | on                   | sneha    | Password@1234 | Password@1234    | disabled |
	And I click on save option
	Then I should navigate to personal details 

