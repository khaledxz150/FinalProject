import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Trainee } from 'src/app/models/Trainee';
import { TraineeService } from 'src/app/Service/trainee.service';
import { TrainerService } from 'src/app/Service/trainer.service';

@Component({
  selector: 'app-edit-trainee',
  templateUrl: './edit-trainee.component.html',
  styleUrls: ['./edit-trainee.component.css']
})
export class EditTraineeComponent implements OnInit {

  
  formGroup: FormGroup = new FormGroup({
    // traineeId:new FormControl(''),
    roleName:new FormControl(''),
    password:new FormControl(''),
    UserName:new FormControl(''),
    imageName: new FormControl(''),
    email: new FormControl(''),
    firstName: new FormControl(''),
    lastName: new FormControl(''),
    phoneNumber: new FormControl(''),
    // basicSalary: new FormControl('', [Validators.required]),
    nationality: new FormControl('')

  });

  imageSrc: string = '';
  myForm = new FormGroup({
    name: new FormControl('', [Validators.required, Validators.minLength(3)]),
    file: new FormControl('', [Validators.required]),
    fileSource: new FormControl('', [Validators.required])
  });

  constructor(public traineeService: TraineeService, @Inject(MAT_DIALOG_DATA) public data: any) { }

  ngOnInit(): void {
    if (this.data) {
      this.formGroup.controls.password.setValue(this.data.password);
      this.formGroup.controls.UserName.setValue(this.data.UserName);
      this.formGroup.controls.roleName.setValue(this.data.roleName);
      this.formGroup.controls.imageName.setValue(this.data.imageName);
      this.formGroup.controls.email.setValue(this.data.email);
      this.formGroup.controls.firstName.setValue(this.data.firstName);
      this.formGroup.controls.lastName.setValue(this.data.lastName);
      this.formGroup.controls.phoneNumber.setValue(this.data.phoneNumber);
      this.formGroup.controls.nationality.setValue(this.data.nationality);
      this.imageSrc = this.data.imageName;

    }
  }
  Update() {
    const trainee: Trainee = this.formGroup.value;
    trainee.traineeId = this.data.traineeId;
    this.traineeService.EditTrainee(trainee);
    console.log('IMAGE : ' + trainee.imageName);
    window.location.reload();
  }

  onFileChange(event: any) {
    const reader = new FileReader();

    if (event.target.files && event.target.files.length) {
      const [file] = event.target.files;
      reader.readAsDataURL(file);

      reader.onload = () => {
        this.imageSrc = reader.result as string;
        this.formGroup.controls.imageName.setValue(this.imageSrc);
        this.myForm.patchValue({
          fileSource: reader.result
        });

        console.log(this.imageSrc);

      };
    }

  }
}
