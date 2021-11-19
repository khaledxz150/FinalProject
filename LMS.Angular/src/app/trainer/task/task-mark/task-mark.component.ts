import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-task-mark',
  templateUrl: './task-mark.component.html',
  styleUrls: ['./task-mark.component.css']
})
export class TaskMarkComponent implements OnInit {
  formGroup: FormGroup = new FormGroup({
    Note: new FormControl(''),
    Mark: new FormControl('', [Validators.required]),
  });
  constructor() { }

  ngOnInit(): void {
  }

}
