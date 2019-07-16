$(document).ready(function() {
    console.log("jQuery is working");
    var AutocompleteData = [];
    $.getJSON("https://localhost:5001/api/test/games", function(data) 
	{
		$.each( data, function( key, val ) {
			AutocompleteData.push(val.Name);
		});
	});

    $('#SearchBar').autocomplete({
        source: AutocompleteData
    }).data("ui-autocomplete")._renderItem = function (ul, item) {
        return $('<li class="autocomplete-results"></li>')
            .data("item.autocomplete", item)
            .append('<a href="table.html?Game=">' + item.label + '</a>')
            .appendTo(ul);
    };

    // $('#SearchBar').on('keypress', function(e) {

    //     // If a value of the search box is not 0.
    //     if($(this).val().length !== 0)
    //     {
    //         // If the enter button is pressed.
    //         if(e.which == 13)
    //         {
    //             var searchedItem = $(this);
    //             location.href = 'table.html';
    //             console.log(`You are searching for the value: ${searchedItem.val()}`);
    //         }
    //     }
        
    // });

    // $('.ui-state-active').on('keypress', function(e) {
    //     if(e.which == 13)
    //         {
    //             var searchedItem = $(this);
    //             console.log(`You are searching for the value: ${searchedItem.val()}`);
    //         }
    // });
})