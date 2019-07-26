import { Component, OnInit } from '@angular/core';

import { ActivatedRoute } from '@angular/router';

import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-game-view',
  templateUrl: './game-view.component.html',
  styleUrls: ['./game-view.component.scss']
})
export class GameViewComponent implements OnInit {

  private id: number;
  private sub: any;

  private game;

  constructor(private route: ActivatedRoute, private httpClient: HttpClient)
  {

    // this.route.params.subscribe(params => this.getGameRoute(params['id']));
  }

  // getGameRoute(id: number)
  // {
  //   this.router.navigate([])
  // }

  async ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
      this.id = +params['id'];
    })
    await this.getGame().then((res: any) => {
      this.game = res;
    })

  }

  async getGame()
  {
    return this.httpClient.get("https://localhost:5001/api/test/games/" + this.id).toPromise();
  }



  ngOnDestory() {
    this.sub.unsubscribe();
  }

}
