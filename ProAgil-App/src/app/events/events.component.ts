import { Component, OnInit, TemplateRef } from '@angular/core';
import { EventService } from './../_services/event.service';
import { Event } from './../_models/Event';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.css']
})
export class EventsComponent implements OnInit {
  events: any = [];
  imageWidth = 60;
  imageMargin = 2;
  showImage = false;
  modalRef: BsModalRef;

  // tslint:disable-next-line: variable-name
  _listFilter: string;

  constructor(
    private eventService: EventService,
    private modalService: BsModalService
    ) { }

  get listFilter(){
    return this._listFilter;
  }
  set listFilter(value: string){
    this._listFilter = value;
  }

  openModal(template: TemplateRef<any>){
    this.modalRef = this.modalService.show(template);
  }

  ngOnInit() {
    this.getEvents();
  }

  changeImage(){
    this.showImage = !this.showImage;
  }

  getEvents(){
    this.eventService.getEvents().subscribe((events: Event[]) => {
      this.events = events;
    }, error => {
      console.log(error);
    });
  }
}
