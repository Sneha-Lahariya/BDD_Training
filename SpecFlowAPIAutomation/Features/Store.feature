Feature: Store

In order to create an environment for managing pet shop
As a user
I want to handle the orders

Scenario: Find Purchase Order By ID
Given I have base url 'https://petstore.swagger.io/v2/' and resource 'store/order/3'
When I do the Get request
Then I should get the response as 200

Scenario: Find Purchase Order By Non existing ID
Given I have base url 'https://petstore.swagger.io/v2/' and resource 'store/order/101'
When I do the Get request
Then I should get the response as 404