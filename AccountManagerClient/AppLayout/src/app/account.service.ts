import { Injectable } from '@angular/core';

import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  baseUrl: string = "https://localhost:5001/api/test";

  constructor(private httpClient: HttpClient) { }

  get_accountlist() {
    return this.httpClient.get(this.baseUrl + "/accountslist");
  }
}
