import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatAccordion } from '@angular/material/expansion';
import { faAngleDoubleRight, faShoppingCart, faHeart, faQuoteRight, faStar, faUser, faBook, faTag, faChartLine, faCalendar, faDollarSign, faPercentage, faEdit, faInfoCircle, faTrashAlt} from '@fortawesome/free-solid-svg-icons';
import { AlertDialogComponent } from 'src/app/alert-dialog/alert-dialog.component';
import { CourseService } from 'src/app/Service/course.service';
import { CreateTopicComponent } from './create-topic/create-topic.component';


@Component({
  selector: 'app-topic',
  templateUrl: './topic.component.html',
  styleUrls: ['./topic.component.css','../../../assets/css/style1.css']
})
export class TopicComponent implements OnInit {

  @ViewChild(MatAccordion) accordion!: MatAccordion;
  panelOpenState = false;



    // Icons
    faAngleDoubleRight = faAngleDoubleRight
    faShoppingCart = faShoppingCart
    faHeart = faHeart
    faQuoteRight = faQuoteRight
    faStar = faStar
    faUser = faUser
    faBook = faBook
    faTag = faTag
    faChartLine = faChartLine
    faCalendar = faCalendar
    faDollarSign = faDollarSign
    faPercentage = faPercentage
    faEdit =faEdit
    faInfoCircle = faInfoCircle
    faTrashAlt = faTrashAlt

  constructor(
    public courseService: CourseService,
    private dialog:MatDialog
    ) {
    this.courseService.getCourses();


   }

  ngOnInit(): void {
  }

  ShowTopic(courseId:number){
    this.courseService.getAllTopics(courseId);
  }
  deleteTopic(topicId:number){

    let dialogRef = this.dialog.open(AlertDialogComponent);

    dialogRef.afterClosed().subscribe(result => {

      // NOTE: The result can also be nothing if the user presses the `esc` key or clicks outside the dialog
      if (result == 'confirm') {

        this.courseService.deleteTopic(topicId);
        window.location.reload();

      }
      })

  }

  createTopic(){

    debugger
    this.dialog.open(CreateTopicComponent).afterClosed().subscribe((topic) =>{
      if(topic){

        let dialogRef = this.dialog.open(AlertDialogComponent);

        dialogRef.afterClosed().subscribe(result => {

          // NOTE: The result can also be nothing if the user presses the `esc` key or clicks outside the dialog
          if (result == 'confirm') {

            this.courseService.createTopic(topic);

          }
          })

      }
    });

    debugger
  }



  updateTopic(topicId:number){


    const topic = this.courseService.topic.find(i =>i.topicId == topicId);

    debugger
    this.dialog.open(CreateTopicComponent,{data:topic}).afterClosed().subscribe((updatedTopic) =>{
      if(updatedTopic){

        let dialogRef = this.dialog.open(AlertDialogComponent);

        dialogRef.afterClosed().subscribe(result => {

          // NOTE: The result can also be nothing if the user presses the `esc` key or clicks outside the dialog
          if (result == 'confirm') {

            updatedTopic.topicId = topic?.topicId;

            this.courseService.updateTopic(updatedTopic);

          }
          })

      }
    });

    debugger
  }
}




