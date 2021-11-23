import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { DomSanitizer } from '@angular/platform-browser';
import { AlertDialogComponent } from 'src/app/alert-dialog/alert-dialog.component';
import { Trainer } from 'src/app/models/Trainer';
import { TrainerService } from 'src/app/Service/trainer.service';

@Component({
  selector: 'app-add-trainer',
  templateUrl: './add-trainer.component.html',
  styleUrls: ['./add-trainer.component.css']
})
export class AddTrainerComponent implements OnInit {


  formGroup: FormGroup = new FormGroup({
    userName:new FormControl('',[Validators.required]),
    password:new FormControl('',[Validators.required]), 
    roleName:new FormControl('',[Validators.required]),
    image: new FormControl('', [Validators.required]),
    email: new FormControl('', [Validators.required]),
    fname: new FormControl('', [Validators.required]),
    lname: new FormControl('', [Validators.required]),
    phoneNumber: new FormControl('', [Validators.required]),
    basicSalary: new FormControl('', [Validators.required]),
    nationalSecurutiyNumber: new FormControl('', [Validators.required])
  });

  imageSrc: string = '';
  myForm = new FormGroup({
    name: new FormControl('', [Validators.required, Validators.minLength(3)]),
    file: new FormControl('', [Validators.required]),
    fileSource: new FormControl('', [Validators.required])
  });

  constructor(public trainerService: TrainerService, private dialog: MatDialog, private sanitizer: DomSanitizer) { }

  ngOnInit(): void {
  }

  Create() {

    let dialogRef = this.dialog.open(AlertDialogComponent);
    dialogRef.afterClosed().subscribe(result => {

      // NOTE: The result can also be nothing if the user presses the `esc` key or clicks outside the dialog
      if (result == 'confirm') {
        const emp: Trainer = this.formGroup.value;
        // value1.courseId = this.data.courseId;
     
        this.trainerService.AddTrainer(emp);
        console.log('IMAGE : ' + emp.image);
        window.location.reload();
      
      }
      })

   }
  trainers: Trainer = new Trainer()
  localUrl: any;
  onFileChanged(event: any) {
    const file = event.target.value
    let name = <string>file;
    if (event.target.files && event.target.files[0]) {
      var reader = new FileReader();
      reader.onload = (event: any) => {
        this.localUrl = event.target.result;
        this.trainers.image = this.localUrl
        //alert(this.localUrl)
        //this.url = this.localUrl.toString().substring(this.localUrl.toString().indexOf('base64') + 7);
        // alert('Image  : \r\n' + this.url)
        // alert('Name : \r\n' + name.substring(name.indexOf('fakepath') + 9, name.indexOf('.')))
        // alert('EXE : \r\n' + name.substring(name.indexOf('.')))
        // alert('base64 : \r\n' + this.localUrl.toString().substring(this.localUrl.toString().indexOf('base64') + 7))
        // alert('type : \r\n' + this.localUrl.toString().substring(0, this.localUrl.toString().indexOf('base64') - 1))
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

