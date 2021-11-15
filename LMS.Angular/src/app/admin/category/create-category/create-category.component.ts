import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { DomSanitizer } from '@angular/platform-browser';
import { faCloudUploadAlt, faImages, faTimes } from '@fortawesome/free-solid-svg-icons';
import { AlertDialogComponent } from 'src/app/alert-dialog/alert-dialog.component';
import { Category } from 'src/app/models/category';
import { CategoryService } from 'src/app/Service/category.service';

@Component({
  selector: 'app-create-category',
  templateUrl: './create-category.component.html',
  styleUrls: ['./create-category.component.css']
})
export class CreateCategoryComponent implements OnInit {

//icons

faCloudUploadAlt = faCloudUploadAlt
faImages = faImages
faTimes = faTimes

formGroup: FormGroup = new FormGroup({
  // categoryId: new FormControl('', [Validators.required]),
  name:new FormControl('', [Validators.required]),
  image:new FormControl('', [Validators.required]),
  // createdBy: new FormControl('', [Validators.required])
});

constructor(
  public categoryService:CategoryService,
  private dialog: MatDialog,
  private sanitizer: DomSanitizer
  // @Inject(MAT_DIALOG_DATA) public data: any
) {
  this.categoryService.getCategories();
}

ngOnInit(): void {

  // if (this.data) {
  //   this.formGroup.controls.courseName.setValue(this.data.courseName);
  //   this.formGroup.controls.coursePrice.setValue(this.data.coursePrice);
  //   this.formGroup.controls.courseDescripction.setValue(this.data.courseDescripction);
  //   this.formGroup.controls.startDate.setValue(this.data.startDate);
  //   this.formGroup.controls.endDate.setValue(this.data.endDate);
  //   this.formGroup.controls.courseCateogry.setValue(this.data.courseCateogry);
  //   this.formGroup.controls.createdBy.setValue(this.data.createdBy);
  // }
}


Create(){

  let dialogRef = this.dialog.open(AlertDialogComponent);

  dialogRef.afterClosed().subscribe(result => {

    // NOTE: The result can also be nothing if the user presses the `esc` key or clicks outside the dialog
    if (result == 'confirm') {
      const category : Category = this.formGroup.value;
        category.createdBy = 1;

      this.categoryService.createCategory(category);
      console.log('IMAGE : ' + category.image);
      window.location.reload();

    }
    })


}

////image

imageSrc: string = '';
myForm = new FormGroup({
name: new FormControl('', [Validators.required, Validators.minLength(3)]),
file: new FormControl('', [Validators.required]),
fileSource: new FormControl('', [Validators.required])
});


categories: Category = new Category()

localUrl: any;
onFileChanged(event: any) {
const file = event.target.value
let name = <string>file;
if (event.target.files && event.target.files[0]) {
var reader = new FileReader();
reader.onload = (event: any) => {
  this.localUrl = event.target.result;
  this.categories.image = this.localUrl

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
