import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import jwtDecode from 'jwt-decode';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { environment } from 'src/environments/environment';
import { User } from '../models/User';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  constructor(    private http:HttpClient,
    public jwtHelper: JwtHelperService,
    private router: Router,
    private toastr:ToastrService,
    private spinner: NgxSpinnerService,
    ) { }


  username = new FormControl('');
  password = new FormControl('');
  // response:any;
  submit(){
  var response1:any;
        var body ={
            username:this.username.value.toString(),
            password:this.password.value.toString()

        };

  // const headerDict={
  //   'Content-Type':'application/json',
  //   'Accept':'appliaction/json'
  // }
  // const requestOption = {
  //   headers:new HttpHeaders(headerDict)
  // }

  // localStorage.setItem('token','response.token');
//{ responseType: 'text' }
  // this.spinner.show();
  this.http.post('http://localhost:54921/api/User/Authentiaction/',body,{ responseType: 'text' }).subscribe((res:any)=>{
  // this.spinner.hide();
    debugger
  response1 = res;
  const response = {
    token:response1.toString()
  };
  localStorage.setItem('token',response.token);
  let data:any = jwtDecode(response.token);
  // this.homeService.message ='You are Logged In..'



     localStorage.setItem('user',JSON.stringify({...data}))
     if(data.role == 'Admin'){
      this.toastr.success('logged in');
      this.router.navigate(['admin']);

     }
     else if(data.role == 'Accountant'){
      this.toastr.success('logged in');
      this.router.navigate(['accountant']);
     }
      else if(data.role == 'Trainee'){
      this.toastr.success('Logged in');
      this.router.navigate(['trainee']);
     }
     else if(data.role == 'Trainer'){
      this.toastr.success('logged in');
      this.router.navigate(['trainer']);
     }



  console.log(data);
  },err=>{
    // this.spinner.hide();
    this.toastr.error(err.status);
  })
}




logout() {
  // call api => logout
  localStorage.clear();
  this.router.navigate(['auth/login'])
}

formGroup: FormGroup = new FormGroup({
  // courseId: new FormControl('', [Validators.required]),
  username: new FormControl(''),
  firstName: new FormControl(''),
  lastName: new FormControl(''),
  email: new FormControl(''),
  imageName: new FormControl(''),
  nationality : new FormControl(''),
  phoneNumber: new FormControl(''),
  password: new FormControl(''),

});


register(){
  const user : User = this.formGroup.value;
  user.username = user.email;
  user.roleId = 5;

  // debugger;
   this.spinner.show();

   this.http.post(environment.apiUrl + 'Customer/InsertTrainee',user).subscribe((res:any)=>{
    // debugger
    this.spinner.hide();
    this.router.navigate(['auth/login'])
    this.toastr.success('Created Account Successfully!');

  },err=>{
    this.spinner.hide();
    this.toastr.warning('Something wrong!, Please Try again!');
  })
  debugger;
}

}
