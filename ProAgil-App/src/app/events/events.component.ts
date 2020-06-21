import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.css']
})
export class EventsComponent implements OnInit {

  events: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getEvents();
  }

  getEvents(){
    this.events = this.http.get('http://localhost:5000/api/events').subscribe(res => {
      this.events = res;
    }, error => {
      console.log(error);
    });
  }
}
