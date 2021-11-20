import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ContactUs } from 'src/app/models/contactus';
import { AuthenticationService } from 'src/app/Service/authentication.service';
import { ContactusService } from 'src/app/Service/contactus.service';


@Component({
  selector: 'app-contactus',
  templateUrl: './contactus.component.html',
  styleUrls: ['./contactus.component.css','../../../assets/css/default.css','../../../assets/css/style.css']
})
export class ContactusComponent implements OnInit {


  constructor(public contactUsService: ContactusService, public auth:AuthenticationService) { }
  loggedIn:any|undefined;
  ngOnInit(): void {
    this.loggedIn=localStorage.getItem("user")
    let traineeId=JSON.parse(this.loggedIn)
    this.loggedIn=traineeId.traineeId
    console.log(this.loggedIn)
  }

  send(){

    // debugger;
    this.contactUsService.send();
  }
}
