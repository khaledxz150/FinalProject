import { Component, OnInit } from '@angular/core';
import { MySectionService } from 'src/app/Service/my-section.service';

@Component({
  selector: 'app-task-info',
  templateUrl: './task-info.component.html',
  styleUrls: ['./task-info.component.css']
})
export class TaskInfoComponent implements OnInit {

  constructor(public mySectionService:MySectionService) { }

  ngOnInit(): void {
    
  }

}
