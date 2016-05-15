Feature: Search
    In order to find articles on BDD
    As a BDD fanatic 
    I want to enter a keyword into a search engine and be shown a list of related websites


Scenario: Navigate to Search Engine
    Given I have navigated to the application
    Then I should be on the home page


Scenario: Perform search
    Given I am on the home page
    And I have entered "BDD" into the keyword textbox
    Then I should see a list of articles related to "BDD" 