import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ContactUs } from 'src/app/models/contactus';
import { ContactusService } from 'src/app/Service/contactus.service';


@Component({
  selector: 'app-contactus',
  templateUrl: './contactus.component.html',
  styleUrls: ['./contactus.component.css','../../../assets/css/default.css','../../../assets/css/style.css']
})
export class ContactusComponent implements OnInit {


  constructor(public contactUsService: ContactusService) { }

  ngOnInit(): void {
  }

  send(){

    // debugger;
    this.contactUsService.send();
  }
}
