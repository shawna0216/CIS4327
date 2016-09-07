@Code
    ViewData("Title") = "Home Page"
End Code


<div class="row">
 <h1>Welcome to the bar!</h1>
  @Html.ActionLink("Click Here for the menu and to place an order!", "Index", "Menus")    
    <br />
  @Html.ActionLink("Bartenders, click here to few your queue!", "Index", "Drinks")
</div>
