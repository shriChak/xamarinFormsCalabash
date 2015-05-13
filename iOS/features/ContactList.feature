Feature: Running a test
  As an iOS developer
  I want to have a sample feature file
  So I can begin testing quickly

  Background:
    Given I am on the Contact List Screen
    
  Scenario: Contact list page items
    Then I see the "CONTACT LIST"
    Then I see the "Add"

  Scenario: Contact list delete button on swipe
    Then I swipe left on number 2 at x 20 and y 10
    Then I see the "Delete"

  Scenario: Contact list delete button touch
    Then I swipe left on number 2 at x 20 and y 10
    Then I see the "Delete"
    Then I touch "Delete"
    Then I don't see the "Shri"
    
    


