import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { MainContentAreaComponent } from './app-layout/main-content-area/main-content-area.component';
import { MainNavbarComponent } from './app-layout/main-navbar/main-navbar.component';
import { SidebarPushComponent } from './app-layout/sidebar-push/sidebar-push.component';
import { SearchBarComponent } from './app-layout/main-content-area/search-bar/search-bar.component';

import { TableComponent } from './app-layout/main-content-area/table/table.component';

import { EventListComponent } from './app-layout/main-content-area/event-list/event-list.component';

import { AccountListComponent } from './app-layout/main-content-area/account-list/account-list.component';
import { GameListComponent } from './app-layout/main-content-area/game-list/game-list.component';

@NgModule({
  declarations: [
    AppComponent,
    MainContentAreaComponent,
    MainNavbarComponent,
    SidebarPushComponent,
    SearchBarComponent,
    TableComponent,
    EventListComponent,
    AccountListComponent,
    GameListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
