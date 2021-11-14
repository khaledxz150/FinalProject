import { Component, OnInit } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';

@Component({
  selector: 'app-trainee-nav',
  templateUrl: './trainee-nav.component.html',
  styleUrls: ['./trainee-nav.component.css','../../../assets/css/style.css']
})
export class TraineeNavComponent implements OnInit {

  constructor( private spinner: NgxSpinnerService) { }

  ngOnInit(): void {
  }
  submit(){

    this.spinner.show();

    setTimeout(() => {


      this.spinner.hide();

    }, 1000);


   }
}
