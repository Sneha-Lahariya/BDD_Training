Feature: EmergencyContacts
In order to reach the employee relation on emergency
As an admin
I should have access to add, edit, delete records

@high
Scenario Outline: Add Emergency Contact
Given I have browser with orangehrm page
When I enter username as '<username>'
And I enter password as '<password>'
And I click on login
And I click on My Info
And I click on Emergency Contacts
And I click on Add
And I fill the Save Emergency Contact section
| name   | relationship   | home_telephone   | mobile   | work_telephone   |
| <name> | <relationship> | <home_telephone> | <mobile> | <work_telephone> |
And I click on save emergency contact
Then I should see be navigated to emergency contacts containing the emergency contact records
Examples:
      | username | password | name   | relationship | home_telephone | mobile       | work_telephone |
      | Admin | admin123 | ABC | Mother       | 1234567        | 9988776655   | 7654321        |
      | Admin | admin123 | XYZ  | Father       | 2468901        | 9440100948 | 1098642        |