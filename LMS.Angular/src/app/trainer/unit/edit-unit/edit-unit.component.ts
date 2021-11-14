import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Unit } from 'src/app/models/unit';
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
    FilePath: new FormControl('', [Validators.required])
  });

  Unit: Unit=new Unit();
  FileSrc: string | undefined;
 
  constructor(private courseService: CourseService, public unitService: UnitService) { }

  ngOnInit(): void {
    
  } 

  Create(){
  this.unitService.UpdateUnit(this.Unit);
  } 
  UpdateUnit(event: any, UnitId:number) {
    const reader = new FileReader();

    if (event.target.files && event.target.files.length) {
      const [file] = event.target.files;
      reader.readAsDataURL(file);

      reader.onload = () => {
        this.FileSrc = reader.result as string;    


        this.Unit={Id:1,SectionId: 1 , FilePath: this.FileSrc , isActive: true, CreationDate: new Date(), CreatedBy:1}
      };
    }
    
  }
}
