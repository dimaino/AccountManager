import { Injectable } from '@angular/core';

import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class EventService {
  baseUrl: string = "https://localhost:5001/api/test";

  constructor(private httpClient: HttpClient) {}

  get_events() {
    return this.httpClient.get(this.baseUrl + "/events");
  }
}
