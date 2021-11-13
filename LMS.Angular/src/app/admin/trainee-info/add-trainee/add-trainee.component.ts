import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { DomSanitizer } from '@angular/platform-browser';
import { Trainee } from 'src/app/models/Trainee';
import { TraineeService } from 'src/app/Service/trainee.service';


@Component({
  selector: 'app-add-trainee',
  templateUrl: './add-trainee.component.html',
  styleUrls: ['./add-trainee.component.css']
})
export class AddTraineeComponent implements OnInit {

  constructor(public traineeService: TraineeService, private sanitizer: DomSanitizer) { }

  formGroup: FormGroup = new FormGroup({

    imageName: new FormControl('', [Validators.required]),
    email: new FormControl('', [Validators.required]),
    firstName: new FormControl('', [Validators.required]),
    lastName: new FormControl('', [Validators.required]),
    phoneNumber: new FormControl('', [Validators.required]),
    // basicSalary: new FormControl('', [Validators.required]),
    nationality: new FormControl('', [Validators.required])

  });

  imageSrc: string = '';
  myForm = new FormGroup({
    name: new FormControl('', [Validators.required, Validators.minLength(3)]),
    file: new FormControl('', [Validators.required]),
    fileSource: new FormControl('', [Validators.required])
  });

  ngOnInit(): void {
  }

  Create() {

    const trainee: Trainee = this.formGroup.value;
    // value1.courseId = this.data.courseId;
 
    this.traineeService.AddTrainee(trainee);
    console.log('IMAGE : ' + trainee.imageName);
    window.location.reload();
  }
  trainees: Trainee = new Trainee()
  localUrl: any;
  onFileChanged(event: any) {
    const file = event.target.value
    let name = <string>file;
    if (event.target.files && event.target.files[0]) {
      var reader = new FileReader();
      reader.onload = (event: any) => {
        this.localUrl = event.target.result;
        this.trainees.imageName = this.localUrl
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
        this.formGroup.controls.imageName.setValue(this.imageSrc);
        this.myForm.patchValue({
          fileSource: reader.result
        });

        console.log(this.imageSrc);

      };
    }
  }


}
