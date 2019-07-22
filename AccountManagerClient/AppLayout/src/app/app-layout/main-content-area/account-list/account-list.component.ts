import { Component, OnInit } from '@angular/core';

import { AccountService } from '../../../account.service';

import { Account } from '../../../models/account';

declare const MoveSidebarNav: any;

@Component({
  selector: 'app-account-list',
  templateUrl: './account-list.component.html',
  styleUrls: ['./account-list.component.scss']
})
export class AccountListComponent implements OnInit {

  private accounts: Account[] = [];

  constructor(private accountService: AccountService) {
    this.accountService.get_accountlist().subscribe((res: any[]) => {
      this.accounts = res;
      console.log(res);
    })
  }

  ngOnInit() {
    MoveSidebarNav();
  }

}
