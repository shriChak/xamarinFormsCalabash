Feature: Running a test
  As an mobile developer
  I want to have a sample feature file
  So I can begin testing quickly

  Background:
    Given I am on the Contact List Screen
    Then I touch "Add"

  Scenario: Check contact add page
    Then I see the "NAME"
    Then I see the "PHONE NUMBER"
    Then I see the "ADDRESS"

  Scenario: Contact entry not to be kept empty
    Then I touch "ADD"
    Then I see the "Enter all fields"
    Then I touch "OK"

  Scenario: Contact entry not to be kept empty
    Then I enter "Alison" into the "Name" field
    Then I enter "0472384976" into the "PhoneNo" field
    Then I enter "89 George street, Sydney" into the "Address" field
    Then I touch "ADD"

  Scenario: Contact entry not to be kept empty
    Then I enter "Maureen" into the "Name" field
    Then I touch "ADD"
    Then I see the "Enter all fields"


