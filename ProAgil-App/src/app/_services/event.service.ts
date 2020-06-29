import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Event } from '../_models/Event';

@Injectable({
  providedIn: 'root'
})
export class EventService {
  baseURL = 'http://localhost:5000/api/events';

  constructor(private http: HttpClient) { }

  getEvents(): Observable<Event[]>{
    return this.http.get<Event[]>(this.baseURL);
  }

  getEventById(id: number): Observable<Event>{
    return this.http.get<Event>(`${this.baseURL}/${id}`);
  }

  getEventByTheme(theme: string): Observable<Event>{
    return this.http.get<Event>(`${this.baseURL}/${theme}`);
  }
}
