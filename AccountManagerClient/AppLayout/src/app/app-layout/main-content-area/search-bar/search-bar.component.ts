import { Component, OnInit } from '@angular/core';

import { HttpClient } from '@angular/common/http';

declare const MoveSidebarNav: any;

@Component({
  selector: 'app-search-bar',
  templateUrl: './search-bar.component.html',
  styleUrls: ['./search-bar.component.scss']
})
export class SearchBarComponent implements OnInit {
  private allGames = [];

  constructor(public httpClient: HttpClient) {
    httpClient.get("https://localhost:5001/api/test/games").subscribe((res: any) => {
      // this.allGames = res;
      res.forEach(g => {
        this.allGames.push(g.GameTitle)
      });
    })
  }

  ngOnInit() {
    MoveSidebarNav();
    console.log(this.allGames);
  }
}
