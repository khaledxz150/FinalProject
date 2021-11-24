import { Component, OnInit } from '@angular/core';
import 'rxjs/add/operator/map';
import { IntervalObservable } from "rxjs/observable/IntervalObservable";
import 'rxjs/add/operator/share';
import * as moment from 'moment';
@Component({
  selector: 'app-clock',
  templateUrl: './clock.component.html',
  styleUrls: ['./clock.component.css']
})
export class ClockComponent implements OnInit {
  date:any | undefined;
  hours:any;
  minutes:any;
  seconds:any;
  currentLocale: any;

  isTwelveHrFormat:false | undefined;
  test:any;
  constructor(){
   //   let now = moment(); // add this 2 of 4
     //navigator.language || navigator.userLanguage; 

 //var test = moment('2016-01-24 14:23:45');

       //ja-JP;
 //de-DE
    setInterval(() =>{
   const currentDate = new Date();
   this.date = currentDate.toLocaleTimeString();
    }, 1000);
  }
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }
}
