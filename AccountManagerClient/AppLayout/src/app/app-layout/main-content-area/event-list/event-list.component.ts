import { Component, OnInit } from '@angular/core';

import { EventService } from '../../../event.service';

import { Event } from '../../../models/event';

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

  ngOnInit()
  {
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
