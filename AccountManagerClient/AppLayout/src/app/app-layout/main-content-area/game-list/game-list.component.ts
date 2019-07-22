import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

import { GameService } from '../../../game.service';

import { Game } from '../../../models/game';

@Component({
  selector: 'app-game-list',
  templateUrl: './game-list.component.html',
  styleUrls: ['./game-list.component.scss']
})
export class GameListComponent implements OnInit {

  private games : Game[] = [];


  constructor(private gameService: GameService) {
    this.gameService.get_games().subscribe((res: any[]) => {
      this.games = res;
      console.log(res);
    })
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

}
