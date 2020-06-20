import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.css']
})
export class EventsComponent implements OnInit {

  events: any = [
    {
      EventId: 1,
      Theme: 'Angular',
      Location: 'São Paulo'
    },
    {
      EventId: 2,
      Theme: '.NET Core',
      Location: 'Belo Horizonte'
    },
    {
      EventId: 3,
      Theme: 'Angular e .NET Core',
      Location: 'Rio de Janeiro'
    }
  ];
  constructor() { }

  ngOnInit() {
  }

}
