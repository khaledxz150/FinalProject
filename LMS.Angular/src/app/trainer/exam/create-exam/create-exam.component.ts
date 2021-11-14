import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-create-exam',
  templateUrl: './create-exam.component.html',
  styleUrls: ['./create-exam.component.css']
})
export class CreateExamComponent implements OnInit {
  
  formGroup: FormGroup = new FormGroup({

    ExamDate: new FormControl('', [Validators.required]),
    StartTime: new FormControl('', [Validators.required]),
    EndTime: new FormControl('', [Validators.required]),
    Mark: new FormControl('', [Validators.required]),
    Weight: new FormControl('', [Validators.required]),
  });
  
  constructor() { }

  ngOnInit(): void {
  }

  Create(){

  }

}
