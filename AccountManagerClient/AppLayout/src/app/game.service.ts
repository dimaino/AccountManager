import { Injectable } from '@angular/core';

import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class GameService {

  baseUrl: string = "https://localhost:5001/api/test";

  constructor(private httpClient: HttpClient) {}

  get_games() {
    return this.httpClient.get(this.baseUrl + "/listgames");
  }
}
