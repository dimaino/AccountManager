import { Component, OnInit } from '@angular/core';

import { AccountService } from '../../../account.service';

import { Account } from '../../../models/account';

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
