import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { TraineeNavbarService } from 'src/app/Service/trainee-navbar.service';

@Component({
  selector: 'app-trainee-nav',
  templateUrl: './trainee-nav.component.html',
  styleUrls: ['./trainee-nav.component.css','../../../assets/css/style.css']
})
export class TraineeNavComponent implements OnInit {

  constructor( private spinner: NgxSpinnerService,public router:Router,public traineeService:TraineeNavbarService) { }

  ngOnInit(): void {

    let user:any = localStorage.getItem('user');
    let trainee = JSON.parse(user);
    //  if(traineeId){
    //  }
     this.traineeService.getMyCartItem2(parseInt(trainee.TraineeId))
     this.traineeService.getMyWishListItem(parseInt(trainee.TraineeId))
  }

  submit(){
    this.spinner.show();

    setTimeout(() => {


      this.spinner.hide();

    }, 1820);
   }
   HomePage(){
     this.router.navigate(['pages',''])
    }
    AboutUs(){
      this.router.navigate(['pages','aboutus'])
    }
    Courses(){
      this.router.navigate(['pages','courses'])
    }
    ContactUs(){
      this.router.navigate(['pages','contactus'])
    }
    GoToPurches(){
      this.router.navigate(['client','purchase'])
    }
    Profile(){
      this.router.navigate(['client','profile'])
    }
    Logout(){
      this.router.navigate(['pages',''])
    }
    Learning(){
      this.router.navigate(['client','learning'])
    }

}
