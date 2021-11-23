import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { AlertDialogComponent } from 'src/app/alert-dialog/alert-dialog.component';
import { TrainerService } from 'src/app/Service/trainer.service';

@Component({
  selector: 'app-edit-trainer',
  templateUrl: './edit-trainer.component.html',
  styleUrls: ['./edit-trainer.component.css']
})
export class EditTrainerComponent implements OnInit {

 
  formGroup: FormGroup = new FormGroup({
    userName:new FormControl(''),
    roleName:new FormControl(''),
    password:new FormControl(''),
    image: new FormControl(''),
    email: new FormControl(''),
    fname: new FormControl(''),
    lname: new FormControl(''),
    phoneNumber: new FormControl(''),
    basicSalary: new FormControl(''),
    nationalSecurutiyNumber: new FormControl('')

  });
  imageSrc: string = '';
  myForm = new FormGroup({
    name: new FormControl('', [Validators.required, Validators.minLength(3)]),
    file: new FormControl('', [Validators.required]),
    fileSource: new FormControl('', [Validators.required])
  });

  constructor(public trainerService: TrainerService, @Inject(MAT_DIALOG_DATA) public data: any,private dialog :MatDialog) { }

  ngOnInit(): void {
    if (this.data) {
      this.formGroup.controls.userName.setValue(this.data.userName);
      this.formGroup.controls.password.setValue(this.data.password);
      this.formGroup.controls.roleName.setValue(this.data.roleName);
      this.formGroup.controls.image.setValue(this.data.image);
      this.formGroup.controls.email.setValue(this.data.email);
      this.formGroup.controls.fname.setValue(this.data.fname);
      this.formGroup.controls.lname.setValue(this.data.lname);
      this.formGroup.controls.phoneNumber.setValue(this.data.phoneNumber);
      this.formGroup.controls.basicSalary.setValue(this.data.basicSalary);
      this.formGroup.controls.nationalSecurutiyNumber.setValue(this.data.nationalSecurutiyNumber);
      this.imageSrc = this.data.image;

    }
  }




  Update() {
    
    //////////////////After open dialog show alert//////////////////
    
 
        const emp: any = this.formGroup.value;
        emp.employeeId = this.data.employeeId;
        this.trainerService.EditTrainer(emp);
        console.log('IMAGE : ' + emp.image);
        window.location.reload();
   
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
