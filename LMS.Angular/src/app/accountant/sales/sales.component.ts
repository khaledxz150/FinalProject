import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { CourseService } from 'src/app/Service/course.service';
import { faArrowUp, faShoppingCart, faUsers, faTicketAlt, faDollarSign, faTimes, faSearch} from '@fortawesome/free-solid-svg-icons';
import { AlertDialogComponent } from 'src/app/alert-dialog/alert-dialog.component';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-sales',
  templateUrl: './sales.component.html',
  styleUrls: ['./sales.component.css','../../../assets/css/style1.css']
})
export class SalesComponent implements OnInit {

  faArrowUp = faArrowUp
  faShoppingCart = faShoppingCart
  faUsers = faUsers
  faTicketAlt = faTicketAlt
  faDollarSign = faDollarSign
  faTimes = faTimes
  faSearch = faSearch


  // campaignOne: FormGroup;
  // campaignTwo: FormGroup;

  availableYears:any[]=[{}]
  constructor( private dialog:MatDialog, public courseService:CourseService) {

    let max = new Date().getFullYear();
    let min = max - 57;
      max = max + 1;

    for(var i=min; i<=max; i++){
    this.availableYears.push({"id":i});
    }
    debugger



    // const today = new Date();
    // const month = today.getMonth();
    // const year = today.getFullYear();

  //   this.campaignOne = new FormGroup({
  //     start: new FormControl(new Date(year, month, 13)),
  //     end: new FormControl(new Date(year, month, 16)),
  // });

  // this.campaignTwo = new FormGroup({
  //   start: new FormControl(new Date(year, month, 15)),
  //   end: new FormControl(new Date(year, month, 19)),
  // });
  }
  ngOnInit(): void {
          this.courseService.returnSoldCourses();
          this.courseService.getCourses();
  }

  // name:new FormControl('', [Validators.required]),
  year = new FormControl('');

  filterSoldCourse(){
    let selectionYear = this.year;
    this.courseService.filterSoldCourse(selectionYear);

  }



  startDate = new FormControl('');
  endDate = new FormControl('');

  filterSoldCourseBetweenDate(){

    this.courseService.filterSoldCourseBetweenDate(this.startDate,this.endDate);

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
      return this.courseService.soldCourse ? this.first === (this.courseService.soldCourse.length - this.rows): true;
  }

  isFirstPage(): boolean {
      return this.courseService.soldCourse ? this.first === 0 : true;
  }

}
