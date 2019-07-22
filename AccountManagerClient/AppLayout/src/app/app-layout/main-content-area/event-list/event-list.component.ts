import { Component, OnInit } from '@angular/core';

import { EventService } from '../../../event.service';

import { Event } from '../../../models/event';

declare const MoveSidebarNav: any;

@Component({
  selector: 'app-event-list',
  templateUrl: './event-list.component.html',
  styleUrls: ['./event-list.component.scss']
})
export class EventListComponent implements OnInit {

  private events: Event[] = [];

  constructor(private eventService: EventService) {
    this.eventService.get_events().subscribe((res: any[]) => {
      this.events = res;
      console.log(res);
    })
   }

   ngOnInit() {
    MoveSidebarNav();
  }

}
