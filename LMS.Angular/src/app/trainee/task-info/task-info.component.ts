import { Component, OnInit } from '@angular/core';
import { MySectionService } from 'src/app/Service/my-section.service';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-task-info',
  templateUrl: './task-info.component.html',
  styleUrls: ['./task-info.component.css']
})
export class TaskInfoComponent implements OnInit {
  selectedFile: File|null=null;
  formGroup: FormGroup = new FormGroup({
    FilePath: new FormControl(''),
    Note: new FormControl('', [Validators.required]),
  });
  FileSrc: string | undefined;
   data:any={

     traineeSectionId: 2,
     taskId: 1,
     note: "This is My own From Angular ",
     fileUrl: "",
   };
  constructor(public mySectionService:MySectionService) { }

  ngOnInit(): void {

  }

  Uploadfile(event: any ) {
    const reader = new FileReader();
     console.log(event.target.value)
    if (event.target.files && event.target.files.length) {
      const [file] = event.target.files;
      reader.readAsDataURL(file);

      reader.onload = () => {
        this.FileSrc = reader.result as string;
        console.log(this.FileSrc)
        this.data.fileUrl=this.FileSrc


    }

  }
   }
   OpenPdf(data:any, fileType:any) {
  const linkElement = document.createElement('a');
  linkElement.setAttribute('href', data);
  linkElement.setAttribute('download', `Unit${fileType}`);
  const clickEvent = new MouseEvent('click', {
   'view': window,
   'bubbles': true,
  'cancelable': false
 });
 linkElement.dispatchEvent(clickEvent);
    }


  UploadTaskSoultion(){
    this.data.note=this.formGroup.value.Note;

    this.mySectionService.UploadTaskSolutionByTrainee(this.data);
  }

}
