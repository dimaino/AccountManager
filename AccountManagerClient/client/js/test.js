$(document).ready(function () {

    // Adds inital arrows and removes the already sorted column
    $('.arrow-down-placeholder').addClass('arrow-down');
    $('.arrow-up-placeholder').addClass('arrow-up');
    $('.active-arrow').removeClass('arrow-down');

    // Used to track dark mode
    var darkmode = false;
    
    // Show/Hide Sidenavbar
    $('#sidenavbar-postion').on('click', function () {
        $('#sidebar').toggleClass('active');
        $('#main-content').toggleClass('expanded');
        $('.ui-helper-hidden-accessible').toggleClass('expanded');
        $('#ui-id-1').toggleClass('expanded');
    });

    // Data table creation
    var table = $('#data-table').DataTable({
        "lengthMenu": [[25, 50, -1], [25, 50, "All"]],
        "dom":'<"row table-title-bar"<"col-3 left-side-table-title"l><"col-9 right-side-table-title"if>>tp',
        "pagingType": "numbers"
    });

    // Flips sorting arrows up or down and removes one.
    $('th').click(function() {
        $('tr').removeClass('even');
        $('tr').removeClass('even-darkmode');
        $('tr').removeClass('odd');
        $('tr').removeClass('odd-darkmode');
        if(!darkmode)
        {
            $('tr:nth-child(even)').addClass('even');
            $('tr:nth-child(odd)').addClass('odd');
            $('.arrow-down-placeholder').addClass('arrow-down');
            $('.arrow-up-placeholder').addClass('arrow-up');
            if($(this).hasClass('sorting_asc'))
            {
                $(this).find('.arrow-down-placeholder').removeClass('arrow-down');
            }
            else if($(this).hasClass('sorting_desc'))
            {
                $(this).find('.arrow-up-placeholder').removeClass('arrow-up');
            }
        }
        else
        {
            $('tr:nth-child(even)').addClass('even-darkmode');
            $('tr:nth-child(odd)').addClass('odd-darkmode');
            $('.arrow-down-placeholder').addClass('arrow-down-darkmode');
            $('.arrow-up-placeholder').addClass('arrow-up-darkmode');
            if($(this).hasClass('sorting_asc'))
            {
                $(this).find('.arrow-down-placeholder').removeClass('arrow-down-darkmode');
            }
            else if($(this).hasClass('sorting_desc'))
            {
                $(this).find('.arrow-up-placeholder').removeClass('arrow-up-darkmode');
            }
        }
    });

    // Dark Mode Button - Toggles classes to make main area appear lighter or darker.
    // TODO: Remove all light and more dark when switching.
    // TODO: When Changing the table if in dark mode make sure new table elments are dark
    $('#darkmode-button').click(function() {
        if(!darkmode)
        {
            darkmode = true;
        }
        else
        {
            darkmode = false;
        }
        // Body
        $('body').toggleClass('darkmode');

        // Main Content
        $('#wrapper').toggleClass('wrapper');
        $('#wrapper').toggleClass('wrapper-darkmode');

        // Title Header
        $('#main-content-header').toggleClass('main-content-header');
        $('#main-content-header').toggleClass('main-content-header-darkmode');

        // Main Content Wrapper
        $('#main-content-wrapper').toggleClass('main-content-wrapper');
        $('#main-content-wrapper').toggleClass('main-content-wrapper-dark');

        // Content Header
        $('#items-content-wrapper').toggleClass('items-content-wrapper');        
        $('#items-content-wrapper').toggleClass('items-content-wrapper-darkmode');

        // Content Header Text
        $('#item-header').toggleClass('item-header');
        $('#item-header').toggleClass('item-header-darkmode');

        // Table Title (Show Entries/Currrently Showing/Search)
        $('#data-table_wrapper .row').toggleClass('table-title-bar');
        $('#data-table_wrapper .row').toggleClass('table-title-bar-darkmode');
        
        // Table Headers
        $('th').toggleClass('table-header');
        $('th').toggleClass('table-header-darkmode');

        // Table Header Arrows

        $('.arrow-up-placeholder').toggleClass('arrow-up');
        $('.arrow-up-placeholder').toggleClass('arrow-up-darkmode');
        $('.arrow-down-placeholder').toggleClass('arrow-down');
        $('.arrow-down-placeholder').toggleClass('arrow-down-darkmode');        
        $('.active-arrow').removeClass('arrow-down-darkmode');

        // Table Rows Even
        $('tr:nth-child(even)').toggleClass('even');
        $('tr:nth-child(even)').toggleClass('even-darkmode');

        // Table Rows Odd
        $('tr:nth-child(odd)').toggleClass('odd');
        $('tr:nth-child(odd)').toggleClass('odd-darkmode');
        
        // Inputs
        $('select.form-control.input-sm').toggleClass('select-show-entries');
        $('input.form-control.input-sm').toggleClass('input-search-entries');
        $('select.form-control.input-sm').toggleClass('select-show-entries-darkmode');
        $('input.form-control.input-sm').toggleClass('input-search-entries-darkmode');
    });

    // Select Number of Entries Darkmode check
    $('select[name="data-table_length"]').change(function() {
        $('tr').removeClass('even');
        $('tr').removeClass('even-darkmode');
        $('tr').removeClass('odd');
        $('tr').removeClass('odd-darkmode');
        if(darkmode)
        {
            $('tr:nth-child(even)').addClass('even-darkmode');
            $('tr:nth-child(odd)').addClass('odd-darkmode');
        }
        else
        {
            $('tr:nth-child(even)').addClass('even');
            $('tr:nth-child(odd)').addClass('odd');
        }
    });

    // Search value Darkmode check
    $('input[type="search"]').keyup(function() {
        $('tr').removeClass('even');
        $('tr').removeClass('even-darkmode');
        $('tr').removeClass('odd');
        $('tr').removeClass('odd-darkmode');
        if(darkmode)
        {
            $('tr:nth-child(even)').addClass('even-darkmode');
            $('tr:nth-child(odd)').addClass('odd-darkmode');
        }
        else
        {
            $('tr:nth-child(even)').addClass('even');
            $('tr:nth-child(odd)').addClass('odd');
        }
    });

    // 
    // var count = 0;
    // $('a').click(function() {
    //     $('tr').removeClass('even');
    //     $('tr').removeClass('even-darkmode');
    //     $('tr').removeClass('odd');
    //     $('tr').removeClass('odd-darkmode');
    //     if(darkmode)
    //     {
    //         $('tr:nth-child(even)').addClass('even-darkmode');
    //         $('tr:nth-child(odd)').addClass('odd-darkmode');
    //     }
    //     else
    //     {
    //         $('tr:nth-child(even)').addClass('even');
    //         $('tr:nth-child(odd)').addClass('odd');
    //     }
    //     console.log("%c lol", 'color: red; font-weight: bold;');
        
    // });
    $("#data-table").on("click", "a.page-link", function(){
        // your code goes here
        console.log("c% HERE", "color: red");
     });
});