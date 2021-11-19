import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ExamService } from 'src/app/Service/exam.service';

@Component({
  selector: 'app-trainee-mark',
  templateUrl: './trainee-mark.component.html',
  styleUrls: ['./trainee-mark.component.css']
})
export class TraineeMarkComponent implements OnInit {

  constructor(@Inject(MAT_DIALOG_DATA) public data: any
  ,public examService:ExamService) { }

  ngOnInit(): void {
  }

}
