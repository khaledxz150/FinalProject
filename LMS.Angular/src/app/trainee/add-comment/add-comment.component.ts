import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MySectionService } from 'src/app/Service/my-section.service';
import { MySectionsComponent } from '../my-sections/my-sections.component';
@Component({
  selector: 'app-add-comment',
  templateUrl: './add-comment.component.html',
  styleUrls: ['./add-comment.component.css']
})
export class AddCommentComponent implements OnInit {
  formGroup: FormGroup = new FormGroup({
    comment:new FormControl('', [Validators.required]),
  });
  constructor(public mySection:MySectionService) { }

  ngOnInit(): void {
  }
  Close(){
    window.location.reload()
  }

  PostComment(){
    console.log(this.formGroup.value.comment)
    this.mySection.comment=this.formGroup.value.comment;
    this.mySection.SaveComment();
    window.location.reload()
  }

}
