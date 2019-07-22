import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { SearchBarComponent } from './app-layout/main-content-area/search-bar/search-bar.component';

import { EventListComponent } from './app-layout/main-content-area/event-list/event-list.component';

import { AccountListComponent } from './app-layout/main-content-area/account-list/account-list.component';
import { GameListComponent } from './app-layout/main-content-area/game-list/game-list.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: '/events',
    pathMatch: 'full'
  },
  {
    path: 'events',
    component: EventListComponent
  },
  {
    path: 'accounts',
    component: AccountListComponent
  },
  {
    path: 'searchbar',
    component: SearchBarComponent
  },
  {
    path: 'games',
    component: GameListComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
