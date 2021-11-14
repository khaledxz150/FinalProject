import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { DomSanitizer } from '@angular/platform-browser';
import { faBook, faBookmark, faCalendar, faChalkboard, faChartLine, faDollarSign, faImages, faPercentage, faTag, faTimes } from '@fortawesome/free-solid-svg-icons';
import { Course } from 'src/app/models/course';
import { CategoryService } from 'src/app/Service/category.service';
import { CourseService } from 'src/app/Service/course.service';
import { SectionService } from 'src/app/Service/section.service';

@Component({
  selector: 'app-create-course',
  templateUrl: './create-course.component.html',
  styleUrls: ['./create-course.component.css']
})
export class CreateCourseComponent implements OnInit {


//Icons

faBook = faBook
faChartLine = faChartLine
faTag = faTag
faCalendar = faCalendar
faPercentage = faPercentage
faChalkboard = faChalkboard
faDollarSign = faDollarSign
faBookmark = faBookmark
faImages = faImages
faTimes = faTimes

  formGroup: FormGroup = new FormGroup({
    // courseId: new FormControl('', [Validators.required]),
    courseName: new FormControl('', [Validators.required]),
    coursePrice: new FormControl('', [Validators.required]),
    courseDescripction: new FormControl(''),
    passMark: new FormControl('',[Validators.required]),
    image: new FormControl('', [Validators.required]),
    typeId : new FormControl('', [Validators.required]),
    levelId: new FormControl('', [Validators.required]),
    categoryId: new FormControl('', [Validators.required]),
    tagId: new FormControl('', [Validators.required]),
    createdBy: new FormControl(1)
  });

  constructor(
    public courseService: CourseService,
    public categoryService:CategoryService,
    // private dialog: MatDialog,
    private sanitizer: DomSanitizer,
    public sectionService:SectionService,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private dialog: MatDialogRef<CreateCourseComponent>
  ) {
    this.courseService.getCourses();
    this.categoryService.getCategories();
    this.courseService.getAllLevels();
    this.courseService.getAllTags();
    this.courseService.getAllTypes();
  }

  ngOnInit(): void {

    if (this.data) {
      // console.log("this.date = ",this.data)
      // this.formGroup.controls.courseId.setValue(this.data.courseId);
      this.formGroup.controls.coursePrice.setValue(this.data.coursePrice);
      this.formGroup.controls.courseName.setValue(this.data.courseName);
      this.formGroup.controls.courseDescripction.setValue(this.data.courseDescripction);
      this.formGroup.controls.image.setValue(this.data.image);
      this.formGroup.controls.typeId.setValue(this.data.typeId);
      this.formGroup.controls.passMark.setValue(this.data.passMark);
      this.formGroup.controls.levelId.setValue(this.data.levelId);
      this.formGroup.controls.tagId.setValue(this.data.tagId);
      this.formGroup.controls.categoryId.setValue(this.data.categoryId);
      // console.log("categoryId = ", this.data.categoryId)
      // console.log("categoryId = ",  this.formGroup.controls.categoryId.value)

    }
  }


saveItem() {
  const value = this.formGroup.value;
  if (this.data) {
    this.dialog.close({
      ...value

    })
  } else {
    this.dialog.close(value)
  }
}

////image

deleteImage(){
  this.imageSrc = ''
}

imageSrc: string = '';
myForm = new FormGroup({
  name: new FormControl('', [Validators.required, Validators.minLength(3)]),
  file: new FormControl('', [Validators.required]),
  fileSource: new FormControl('', [Validators.required])
});


courses: Course = new Course()
localUrl: any;
onFileChanged(event: any) {
  const file = event.target.value
  let name = <string>file;
  if (event.target.files && event.target.files[0]) {
    var reader = new FileReader();
    reader.onload = (event: any) => {
      this.localUrl = event.target.result;
      this.courses.image = this.localUrl

    }
    reader.readAsDataURL(event.target.files[0]);
  }
}

transform() {

  return this.sanitizer.bypassSecurityTrustResourceUrl(this.localUrl);
}

get f() {
  return this.myForm.controls;
}


onFileChange(event: any) {
  const reader = new FileReader();

  if (event.target.files && event.target.files.length) {
    const [file] = event.target.files;
    reader.readAsDataURL(file);

    reader.onload = () => {
      this.imageSrc = reader.result as string;
      this.formGroup.controls.image.setValue(this.imageSrc);
      this.myForm.patchValue({
        fileSource: reader.result
      });

      console.log(this.imageSrc);

    };
  }
}


}
