@Model Bartender.Models.Menu

@Code
    ViewData("Title") = "Menu"
End Code

<!DOCTYPE html>

<head>
    <title>Menu</title>
</head>

<body>  
@Using (Html.BeginForm())
    @<p>Name: @Html.TextBox("Name")</p>


End Using

</body>