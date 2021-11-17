import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { AuthenticationService } from 'src/app/Service/authentication.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  //   formGroup = new FormGroup({
    //     username:new FormControl(''),
    //     password:new FormControl('')

    // })

    username = new FormControl('', [Validators.required]);
    password = new FormControl('', [Validators.required]);
      // constructor(
      //   public loginService:LoginService
      //   ) { }

      ngOnInit(): void {

      }

      //  UN = 'superadmin'; 
      //  pass = 's@admin1122'; 
       constructor(   public rout: Router,    public loginService:AuthenticationService) {​​​​​​ }​​​​​​


      LogIn(){
       this.loginService.submit()
        // let user: User = this.formGroup.value;
        // this.loginService.signIn(user);
      }


}
