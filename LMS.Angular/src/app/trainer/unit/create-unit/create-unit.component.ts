import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Unit } from 'src/app/models/unit';
import { CategoryService } from 'src/app/Service/category.service';
import { CourseService } from 'src/app/Service/course.service';
import { SectionService } from 'src/app/Service/section.service';
import { UnitService } from 'src/app/Service/unit.service';

@Component({
  selector: 'app-create-unit',
  templateUrl: './create-unit.component.html',
  styleUrls: ['./create-unit.component.css']
})
export class CreateUnitComponent implements OnInit {

  selectedFile: File|null=null;
  formGroup: FormGroup = new FormGroup({
    FilePath: new FormControl('', [Validators.required])
  });

  Unit: Unit=new Unit();
  FileSrc: string | undefined;
 
  constructor(private courseService: CourseService,
    public categoryService:CategoryService, public unitService: UnitService, public sectionService: SectionService) { }

  ngOnInit(): void {
    
  } 

  Create(){
this.unitService.insertUnit(this.Unit);
debugger
  }
 
  
  Uploadfile(event: any, ) {
    const reader = new FileReader();

    if (event.target.files && event.target.files.length) {
      const [file] = event.target.files;
      reader.readAsDataURL(file);

      reader.onload = () => {
        this.FileSrc = reader.result as string;    


        this.Unit={SectionId: this.sectionService.SelectedSection 
          , FilePath: this.FileSrc , isActive: true, CreationDate: new Date(), CreatedBy:1}
   
      };
    }
    
  }
  
}


 

