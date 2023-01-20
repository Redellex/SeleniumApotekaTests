Feature: Basket

Scenario: I add to Basket and i should see confirmation popup 
    Given I am logged
    When I add to basket first item from search
    Then I see item added to basket on popup
    
Scenario: I add to Basket and should see it on basket list
    Given I am logged
    When I add to basket first item from search
    And I go to basket list from basket popup
    Then I should see item on the basket list
    
Scenario: I delete added item in basket list
    Given I am logged
    When I add to basket first item from search
    And I go to basket list from basket popup
    And I remove item from basket list
    Then I should see empty basket list