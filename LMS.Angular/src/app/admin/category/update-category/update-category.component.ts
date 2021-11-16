import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { DomSanitizer } from '@angular/platform-browser';
import { faCloudUploadAlt, faImages, faTimes } from '@fortawesome/free-solid-svg-icons';
import { AlertDialogComponent } from 'src/app/alert-dialog/alert-dialog.component';
import { Category } from 'src/app/models/category';
import { CategoryService } from 'src/app/Service/category.service';

@Component({
  selector: 'app-update-category',
  templateUrl: './update-category.component.html',
  styleUrls: ['./update-category.component.css']
})
export class UpdateCategoryComponent implements OnInit {


    //icons

    faCloudUploadAlt = faCloudUploadAlt
    faImages = faImages
    faTimes = faTimes
    formGroup: FormGroup = new FormGroup({
     //  categoryId: new FormControl('', [Validators.required]),
      name:new FormControl('', [Validators.required]),
      image:new FormControl('', [Validators.required]),
      // createdBy: new FormControl('', [Validators.required])
    });

    constructor(
      public categoryService:CategoryService,
      private dialog: MatDialog,
      private sanitizer: DomSanitizer,
      @Inject(MAT_DIALOG_DATA) public data: any
    ) {
      this.categoryService.getCategories();
    }

    ngOnInit(): void {

      if (this.data) {
        this.formGroup.controls.name.setValue(this.data.name);
        this.formGroup.controls.image.setValue(this.data.image);
       //  console.log(this.data.image)
      }
    }


    updateCategory(){

      let dialogRef = this.dialog.open(AlertDialogComponent);

      dialogRef.afterClosed().subscribe(result => {

        // NOTE: The result can also be nothing if the user presses the `esc` key or clicks outside the dialog
        if (result == 'confirm') {
          const category : Category = this.formGroup.value;
          category.categoryId =this.data.categoryId;
           //  category.createdBy = 1;

          this.categoryService.updateCategory(category);
          console.log('IMAGE : ' + category.image);
          window.location.reload();

        }
        })


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
