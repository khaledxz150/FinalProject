import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { SectionService } from 'src/app/Service/section.service';

@Component({
  selector: 'app-edit-task',
  templateUrl: './edit-task.component.html',
  styleUrls: ['./edit-task.component.css']
})
export class EditTaskComponent implements OnInit {

  constructor( @Inject(MAT_DIALOG_DATA) public data: any, public secctionService: SectionService) { }

  ngOnInit(): void {
  }

  Create(){
    this.secctionService.DeleteTask(this.data);
  }

}
