import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { ExamService } from 'src/app/Service/exam.service';
import { SectionService } from 'src/app/Service/section.service';

@Component({
  selector: 'app-task-soultions',
  templateUrl: './task-soultions.component.html',
  styleUrls: ['./task-soultions.component.css']
})
export class TaskSoultionsComponent implements OnInit {

  constructor(public examService:ExamService,
    private dialog: MatDialog,private router:Router
    ,public sections:SectionService) { }

  ngOnInit(): void {
    this.sections.GetTraineeSectionTaskAnswer()
  }

  OpenPdf(data:any) {
    const linkElement = document.createElement('a');
    linkElement.setAttribute('href', data);
    linkElement.setAttribute('download', `.pdf`);
    const clickEvent = new MouseEvent('click', {
     'view': window,
     'bubbles': true,
    'cancelable': false
   });
   linkElement.dispatchEvent(clickEvent);
   }

}
