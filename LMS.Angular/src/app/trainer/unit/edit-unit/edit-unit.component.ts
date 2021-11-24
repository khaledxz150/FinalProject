import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { CourseService } from 'src/app/Service/course.service';
import { SectionService } from 'src/app/Service/section.service';
import { UnitService } from 'src/app/Service/unit.service';

@Component({
  selector: 'app-edit-unit',
  templateUrl: './edit-unit.component.html',
  styleUrls: ['./edit-unit.component.css']
})
export class EditUnitComponent implements OnInit {

  
  formGroup: FormGroup = new FormGroup({
    SectionId: new FormControl('', [Validators.required]),
    FilePath: new FormControl('', [Validators.required]),
    IsActive : new FormControl('', [Validators.required]),
    createdBy: new FormControl('', [Validators.required]),
  });
  constructor(private courseService: CourseService,
    public sectionService: SectionService, public unitService: UnitService, @Inject(MAT_DIALOG_DATA) public data: any) { }

  ngOnInit(): void {
  }
  Create(){
    this.unitService.DeleteUnit(this.data)
  }

}
