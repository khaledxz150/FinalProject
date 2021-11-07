import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  email = new FormControl(localStorage.getItem('email'),[Validators.required,Validators.email]);
  password = new FormControl(localStorage.getItem('password'),[Validators.required,Validators.minLength(8)]);
  // rememberMe = new FormControl(false);
  // checked = false;
  // indeterminate = false;

  // labelPosition: 'before' | 'after' = 'after';
  // disabled = false;

  constructor(
    private spinner: NgxSpinnerService,
    private router: Router) { }

  ngOnInit(): void {
  }
  submit(){

    console.log(`Email: ${this.email.value}`);
    console.log(`Password:  ${this.password.value}`);
 /** spinner starts on init */
 this.spinner.show();

 setTimeout(() => {
   /** spinner ends after 5 seconds */
  //Go to home page
   this.router.navigate(['client']);
   this.spinner.hide();

 }, 5000);


    // if (this.checked == true) {

    // const email =  localStorage.setItem('email', this.email.value);
    //  const pass = localStorage.setItem('password', this.password.value);



    // }

  }

}
