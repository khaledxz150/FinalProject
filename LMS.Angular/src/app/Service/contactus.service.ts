import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { environment } from 'src/environments/environment';
import { ContactUs } from 'src/app/models/contactus';


@Injectable({
  providedIn: 'root'
})
export class ContactusService {

  contactUsForm: FormGroup = new FormGroup({
    description: new FormControl('', [Validators.required]),
    email: new FormControl('', [Validators.required]),
    name: new FormControl('', [Validators.required]),
    subject: new FormControl('', [Validators.required]),
    phoneNumber : new FormControl('')
  });

  constructor(
    private http: HttpClient,
    private spinner:NgxSpinnerService,
    private toastr:ToastrService,
    private router:Router
  ) { }


  /**********Hit API*********** */
  // show spinner
  // hit api
  // after response: hide spinner
  // show toastr: small message
/*************************** */

  send(){

    const contactUs : ContactUs = this.contactUsForm.value;

    // debugger;
     this.spinner.show();

     this.http.post(environment.apiUrl + 'ContactUs/InsertMessage',contactUs).subscribe((res:any)=>{
      // debugger
      this.spinner.hide();
      this.toastr.success('Send Message successfully, Thank You :)');

    },err=>{
      this.spinner.hide();
      this.toastr.warning('Something wrong!, Please send message again');
    })
    debugger;
  }
}
