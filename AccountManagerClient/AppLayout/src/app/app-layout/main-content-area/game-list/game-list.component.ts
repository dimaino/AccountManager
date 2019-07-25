import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

import { GameService } from '../../../game.service';

import { Game } from '../../../models/game';

declare const MoveSidebarNav: any;

// declare const TableFunctions: any;

import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-game-list',
  templateUrl: './game-list.component.html',
  styleUrls: ['./game-list.component.scss']
})
export class GameListComponent implements OnInit {

  // All of the games information from api
  private allGames = [];

  // Currently typed variable
  public searchText: string;

  // Total number of games
  public numberOfGames: number;

  // Starting page number
  public p: number;

  // Items per page in pagination
  public devices: any = [];

  // Starting value of items per page
  public numberToShow: number;

  // Sorting
  key: string = 'GameTitle';
  reverse: boolean = false;
  sort(key) {
    this.key = key;
    this.reverse = !this.reverse;
  }


  constructor(public httpClient: HttpClient) {}

  async ngOnInit(): Promise<void> {
    MoveSidebarNav();
    await this.getGames().then((res: any) =>
    {
      this.allGames = res;
    });
    this.p = 1;
    this.numberOfGames = this.allGames.length;
    this.devices = [10, 25, 50, 100, this.numberOfGames];
    this.numberToShow = 25;
  }

  // Track the Change of
  onChange(deviceValue) {
    this.numberToShow = deviceValue;
}


  async getGames()
  {
    return this.httpClient.get("https://localhost:5001/api/test/games").toPromise();
  }
}
