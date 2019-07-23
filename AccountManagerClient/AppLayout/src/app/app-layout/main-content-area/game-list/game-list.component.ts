import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

import { GameService } from '../../../game.service';

import { Game } from '../../../models/game';

declare const MoveSidebarNav: any;

declare const TableFunctions: any;

import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-game-list',
  templateUrl: './game-list.component.html',
  styleUrls: ['./game-list.component.scss']
})
export class GameListComponent implements OnInit {

  private allGames = [];
  private thing = new Array();

  constructor(public httpClient: HttpClient) {
    httpClient.get("https://localhost:5001/api/test/games").subscribe((res: any) => {
      this.allGames = res;
      // console.log(this.allGames);
      // this.thing.push(res);
      res.forEach(g => {
        this.thing.push(g.GameTitle);
      });
    })
  }

  ngOnInit() {
    MoveSidebarNav();

    // console.log(this.allGames);
    // console.log("table");
    TableFunctions(document.getElementById("table"), this.thing);
  }
}
