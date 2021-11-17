import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MySectionService } from 'src/app/Service/my-section.service';
@Component({
  selector: 'app-rate-box',
  templateUrl: './rate-box.component.html',
  styleUrls: ['./rate-box.component.css'
  , '../../../assets/css/default.css',
  '../../../assets/css/slick.css',
  '../../../assets/css/style.css'
  ,'../../../assets/css/animate.css']
})
export class RateBoxComponent implements OnInit {
  formGroup: FormGroup = new FormGroup({
    star:new FormControl(''),
    note:new FormControl('')
  });
  constructor(public mySection:MySectionService) { }

  ngOnInit(): void {
  }

  Rate(){
    console.log(this.formGroup.value.star)
    console.log(this.formGroup.value.note)

    this.mySection.SaveRate(this.formGroup.value.star,this.formGroup.value.note);

  }

}
