import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
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


  username = new FormControl('', [Validators.required]);
  password = new FormControl('', [Validators.required]);

  submit(){
  var response1:any;
        var body ={
            username:this.username.value.toString(),
            password:this.password.value.toString()
  };


  this.spinner.show();
  this.http.post('http://localhost:54921/api/User/Authentiaction/',body,{ responseType: 'text' }).subscribe((res:any)=>{

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


 this.spinner.hide();
  console.log(data);
  },err=>{
    this.spinner.hide();
    this.toastr.error(err.status);
  })
}
logout() {
  // call api => logout
  localStorage.clear();
  this.router.navigate(['auth/login'])
}

formGroup: FormGroup = new FormGroup({

  username: new FormControl(''),
  firstName: new FormControl('', [Validators.required]),
  lastName: new FormControl('', [Validators.required]),
  email: new FormControl('', [Validators.required,Validators.email]),
  imageName: new FormControl(''),
  nationality : new FormControl('', [Validators.required]),
  phoneNumber: new FormControl('', [Validators.required,Validators.pattern("^[0-9]*$")]),
  password: new FormControl('', [Validators.required,Validators.minLength(8)]),

});


register(){

  debugger
  const user : User = this.formGroup.value;
  user.username = user.email;
  user.roleId = 5;

  // debugger;
   this.spinner.show();

   this.http.post(environment.apiUrl + 'Customer/InsertTrainee',user).subscribe((res:any)=>{
    // debugger

    this.router.navigate(['auth/login'])
    this.spinner.hide();
    this.toastr.success('Created Account Successfully!');

  },err=>{
    this.spinner.hide();
    this.toastr.warning('Something wrong!, Please Try again!');
  })
  debugger;
}

login:any[]=[];
ReturnLogin(){
  this.http.get(environment.apiUrl + 'User/ReturnLogin').subscribe((res:any)=>{
    // debugger

    this.login = res;
  })


}

checkUserName(){
  debugger
  let check = this.login.find(i=>i.username == this.formGroup.controls.email.value);
  if(check){
    this.toastr.warning("This email is used")
  }else{
    this.register()
  }
  debugger
}
}
