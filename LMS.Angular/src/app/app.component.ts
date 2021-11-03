import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'LMS';


  // imageLoader = false;
  constructor(private http: HttpClient){}

  getIMDBData() {
    return this.http
    .get<any>('http://www.omdbapi.com/?apikey=YOUR_OMDB_KEY&s=car')
    .subscribe((response) => {
      console.log(response);
    }, (error) => {
      alert('Error Found!');
    });
  }
}
