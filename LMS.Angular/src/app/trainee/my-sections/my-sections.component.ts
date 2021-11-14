import { Component, OnInit } from '@angular/core';
import {MatDialog} from '@angular/material/dialog';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AboutusComponent } from 'src/app/pages/aboutus/aboutus.component';
import { MySectionService } from 'src/app/Service/my-section.service';

@Component({
  selector: 'app-my-sections',
  templateUrl: './my-sections.component.html',
  styleUrls: ['./my-sections.component.css'
  , '../../../assets/css/default.css',
  '../../../assets/css/slick.css',
  '../../../assets/css/style.css'
  ,'../../../assets/css/animate.css']
})
export class MySectionsComponent implements OnInit {

  constructor(public dialog:MatDialog,private router:Router,
    private toastr:ToastrService,public mySectionService:MySectionService
    ) { }

  ngOnInit(): void {
    this.mySectionService.GetMySectionInfo(2);
    this.mySectionService.GetSectionUnit(1);
  }

  RateCourse(){
   //this.dialog.open(RateBoxComponent);
  }
  Exam(){
   /* this.dialog.open(ExamInfoComponent,{
      height: '80%',
      width: '60%'
  });*/
  }
}
