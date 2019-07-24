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
  public searchText: string;
  public numberOfGames: number;
  public p: number;
  public devices: any = [];
  public numberToShow: number;


  constructor(public httpClient: HttpClient) {}

  async ngOnInit(): Promise<void> {
    MoveSidebarNav();
    let data = await this.getGames().then((res: any) =>
    {
      this.allGames = res;
    });
    TableFunctions(<HTMLElement>document.getElementById("table"), this.allGames);
    this.p = 1;
    this.numberOfGames = this.allGames.length;
    this.devices = [10, 25, 50, 100, this.numberOfGames];
    this.numberToShow = 25;
  }

  onChange(deviceValue) {
    console.log(deviceValue);
    this.numberToShow = deviceValue;
}


  async getGames()
  {
    return this.httpClient.get("https://localhost:5001/api/test/games").toPromise();
  }
}
