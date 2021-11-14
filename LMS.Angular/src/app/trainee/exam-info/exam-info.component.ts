import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-exam-info',
  templateUrl: './exam-info.component.html',
  styleUrls: ['./exam-info.component.css']
})
export class ExamInfoComponent implements OnInit {

  constructor(private dialog:MatDialog) { }

  ngOnInit(): void {

  }


}
