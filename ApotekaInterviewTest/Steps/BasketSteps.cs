using ApotekaInterviewTest.Pages;
using FluentAssertions;

namespace ApotekaInterviewTest.Steps;

[Binding]
public class BasketSteps
{
    private const string ItemNameKey = "ItemName";
    
    private SearchBarSubPage _searchBar;
    private ItemPage _itemPage;
    private BasketPopup _basketPopup;
    private BasketListPage _basketListPage;
    private ScenarioContext _scenarioContext;
    
    public BasketSteps(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
        _searchBar = new SearchBarSubPage();
        _itemPage = new ItemPage();
        _basketPopup = new BasketPopup();
        _basketListPage = new BasketListPage();
    }
    
    [When("I add to basket first item from search")]
    public void WhenIAddToBasket()
    {
        _searchBar.SearchBarButtonClick();
        _searchBar.ClickOnFirstResult();
        _scenarioContext.Set<string>(_itemPage.GetItemName(), ItemNameKey);
        _itemPage.AddToBasket();
    }

    [When("I go to basket list from basket popup")]
    public void WhenIGoToBasketListFromBasketPopup()
    {
        _basketPopup.GoToBasket();
    }

    [When("I remove item from basket list")]
    public void WhenIRemoveItemFromBasketList()
    {
        _basketListPage.RemoveItem();
    }

    [Then("I should see item on the basket list")]
    public void ThenIShouldSeeItemOnTheBasketList()
    {
        var itemName = _scenarioContext.Get<string>(ItemNameKey);
        _basketListPage.GetItemName().Text.Should().Equals(itemName);
    }
    

    [Then("I see item added to basket on popup")]
    public void ThenISeeItemAddedToBasket()
    {
        _basketPopup.GetBasketSummaryText().Should().Equals($"{_scenarioContext.Get<string>(ItemNameKey)} er tilføjet til din kurv");
    }

    [Then("I should see empty basket list")]
    public void ThenIShouldSeeEmptyBasketList()
    {
        _basketListPage.GetBusketSummary().Should().Equals("Din kurv er tom");
    }
}