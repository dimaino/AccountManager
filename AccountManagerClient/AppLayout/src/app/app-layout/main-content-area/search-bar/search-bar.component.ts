import { Component, OnInit } from '@angular/core';

import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-search-bar',
  templateUrl: './search-bar.component.html',
  styleUrls: ['./search-bar.component.scss']
})
export class SearchBarComponent implements OnInit {

  constructor() {
    // myFunction()

  }

  ngOnInit() {
    var sidebar = document.getElementById('sidebar');
    var mainContent = document.getElementById('main-content');
    if(sidebar.classList.contains('active'))
    {
      document.getElementById('main-content').className = "expanded";
    }
    document.getElementById('sidenavbar-postion').onclick = function() {
        sidebar.classList.toggle('active');
        mainContent.classList.toggle('expanded');
    };



    }






  // function myFunction()
  // {
  //   var httpClient: HttpClient;

  //   var input, filter, ul, li, a, i, txtValue;
  //   input = document.getElementById("SearchBar");
  //   filter = input.value.toUpperCase();
  //   var baseUrl = "https://localhost:5001/api/test/games"
  //   var listofgames = httpClient.get(baseUrl).subscribe((res: any[]) => {
  //     console.log(res);
  //   });
// }
}
