import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { CalendarOptions } from '@fullcalendar/angular';

// import { MbscEventcalendarOptions, Notifications, MbscCalendarEvent , localeAr } from '@mobiscroll/angular';

const now = new Date();


@Component({
  selector: 'app-calender',
  templateUrl: './calender.component.html',
  styleUrls: ['./calender.component.css']
})

export class CalenderComponent implements OnInit {

  calendarOptions: CalendarOptions | undefined;
  
  constructor(private httpClient: HttpClient) { }

  onDateClick(res:any) {
    alert('Clicked on date : ' + res.dateStr)
  }
   Events:any;
  ngOnInit(){
    setTimeout(() => {
      return this.httpClient.get('http://localhost:8888/event.php')
        .subscribe(res  => {
            this.Events.push(res);
            console.log(this.Events);
        });
    }, 2200);

    setTimeout(() => {
      this.calendarOptions = {
        initialView: 'dayGridMonth',
        dateClick: this.onDateClick.bind(this),
        events: this.Events
      };
    }, 2500);
        
    }
    










    

}












