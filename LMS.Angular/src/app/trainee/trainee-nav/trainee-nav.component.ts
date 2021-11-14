import { Component, OnInit } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { TraineeNavbarService } from 'src/app/Service/trainee-navbar.service';

@Component({
  selector: 'app-trainee-nav',
  templateUrl: './trainee-nav.component.html',
  styleUrls: ['./trainee-nav.component.css','../../../assets/css/style.css']
})
export class TraineeNavComponent implements OnInit {

  constructor( private spinner: NgxSpinnerService,public traineeService:TraineeNavbarService) { }

  ngOnInit(): void {
     this.getMyCartItem()
     this.traineeService.getMyWishListItem(2)
  }

  getMyCartItem(){
    this.traineeService.getMyCartItem2(2)
  }

  submit(){
    this.spinner.show();

    setTimeout(() => {


      this.spinner.hide();

    }, 1820);
   }
}
