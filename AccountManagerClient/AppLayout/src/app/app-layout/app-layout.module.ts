import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MainNavbarComponent } from './main-navbar/main-navbar.component';
import { SidebarPushComponent } from './sidebar-push/sidebar-push.component';
import { MainContentAreaComponent } from './main-content-area/main-content-area.component';
import { SearchBarComponent } from './main-content-area/search-bar/search-bar.component';
import { TableComponent } from './main-content-area/table/table.component';
import { EventListComponent } from './main-content-area/event-list/event-list.component';
import { GameListComponent } from './main-content-area/game-list/game-list.component';
import { AccountListComponent } from './main-content-area/account-list/account-list.component';



@NgModule({
  declarations: [MainNavbarComponent, SidebarPushComponent, MainContentAreaComponent, SearchBarComponent, TableComponent, EventListComponent, GameListComponent, AccountListComponent],
  imports: [
    CommonModule
  ]
})
export class AppLayoutModule { }
