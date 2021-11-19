import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { SectionService } from 'src/app/Service/section.service';

@Component({
  selector: 'app-task-mark',
  templateUrl: './task-mark.component.html',
  styleUrls: ['./task-mark.component.css']
})
export class TaskMarkComponent implements OnInit {
  currentTaskId:number|undefined;
  formGroup: FormGroup = new FormGroup({

    Note: new FormControl(''),
    Mark: new FormControl('', [Validators.required]),
  });
  constructor(@Inject(MAT_DIALOG_DATA) public data: any,public Mysections:SectionService) { }

  ngOnInit(): void {
    this.currentTaskId=this.data
  }
 //Last Update En Shaa Allah

  Create(){
    const obj={
      traineeSectionTaskId:  this.currentTaskId,
      mark: this.formGroup.value.Mark,
      trainerNote:this.formGroup.value.Note
   }
   this.Mysections.InsertTaskMarkForTrainee(obj)

  }

}
