import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { faArrowUp, faShoppingCart, faUsers, faTicketAlt, faDollarSign, faTimes, faBook} from '@fortawesome/free-solid-svg-icons';
import { AlertDialogComponent } from 'src/app/alert-dialog/alert-dialog.component';
import { DateFormatPipe } from 'src/app/Pipeline/date-format.pipe';
import { ContactusService } from 'src/app/Service/contactus.service';
import { CourseService } from 'src/app/Service/course.service';
import { TrainerService } from 'src/app/Service/trainer.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css','../../../assets/css/style1.css']
})
export class DashboardComponent implements OnInit {

  faArrowUp = faArrowUp
  faShoppingCart = faShoppingCart
  faUsers = faUsers
  faTicketAlt = faTicketAlt
  faDollarSign = faDollarSign
  faTimes = faTimes
  faBook = faBook

  constructor(public contactusService: ContactusService, private dialog:MatDialog, public courseService:CourseService, public trainerService:TrainerService) {

    this.courseService.returnSoldCourses();

  }

  ngOnInit(): void {

          this.contactusService.returnAllMessages();
          this.trainerService.getTrainer();
          this.courseService.getCourses();
          // this.courseService.returnSoldCourses();



  }



  first = 0;

  rows = 10;



  next() {
      this.first = this.first + this.rows;
  }

  prev() {
      this.first = this.first - this.rows;
  }

  reset() {
      this.first = 0;
  }

  isLastPage(): boolean {
      return this.contactusService.message ? this.first === (this.contactusService.message.length - this.rows): true;
  }

  isFirstPage(): boolean {
      return this.contactusService.message ? this.first === 0 : true;
  }


  deleteMessage(messageId:number){
    let dialogRef = this.dialog.open(AlertDialogComponent);

    dialogRef.afterClosed().subscribe(result => {

      // NOTE: The result can also be nothing if the user presses the `esc` key or clicks outside the dialog
      if (result == 'confirm') {

        this.contactusService.deleteMessage(messageId);
        window.location.reload();

      }
      })
  }


}





