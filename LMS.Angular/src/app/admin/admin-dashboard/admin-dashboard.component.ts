import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormControl } from '@angular/forms';
import { faArrowUp, faShoppingCart, faUsers, faTicketAlt, faDollarSign, faBook, faSearch, faFileExcel, faFilePdf} from '@fortawesome/free-solid-svg-icons';
import { CourseService } from 'src/app/Service/course.service';
import * as XLSX from 'xlsx';
import jsPDF from "jspdf";
import autoTable from "jspdf-autotable"
@Component({
  selector: 'app-admin-dashboard',
  templateUrl: './admin-dashboard.component.html',
  styleUrls: ['./admin-dashboard.component.css','../../../assets/css/style1.css']
})
export class AdminDashboardComponent implements OnInit {

  faArrowUp = faArrowUp
  faShoppingCart = faShoppingCart
  faUsers = faUsers
  faTicketAlt = faTicketAlt
  faDollarSign = faDollarSign
  faBook = faBook
  faSearch = faSearch
  faFileExcel = faFileExcel
  faFilePdf = faFilePdf
  constructor(public courseService:CourseService) {

    this.courseService.returnSoldCourses;
   }

  ngOnInit(): void {
    this.courseService.returnSoldCourses();
    this.courseService.getCourses();
  }

  startDate = new FormControl('');
  endDate = new FormControl('');

  filterSoldCourseBetweenDate(){

    this.courseService.filterSoldCourseBetweenDate(this.startDate,this.endDate);

  }



  clear(){
    this.courseService.soldCourse = this.courseService.annualSoldCourses;
  }


  @ViewChild('TABLE', { static: false }) TABLE: ElementRef | undefined;
  title = 'Excel';
  ExportTOExcel() {
    if(this.TABLE){
    const ws: XLSX.WorkSheet = XLSX.utils.table_to_sheet(this.TABLE.nativeElement);
    const wb: XLSX.WorkBook = XLSX.utils.book_new();
    XLSX.utils.book_append_sheet(wb, ws, 'Sheet1');
    XLSX.writeFile(wb, 'Sales.xlsx');
    }
  }



  columns = [
    { title: "Id", dataKey: "checkoutId" },
    { title: "Image", dataKey: "traineeImage" },
    { title: "FirstName", dataKey: "firstName" },
    { title: "LastName", dataKey: "lastName" },
    { title: "PhoneNumber", dataKey: "phoneNumber" },
    { title: "PhoneNumber", dataKey: "courseName" },
    { title: "CoursePrice", dataKey: "coursePrice" },
    { title: "Date", dataKey: "creationDate" }
  ];

  soldCourses:any[]=[]

  exportPdf() {

    this.soldCourses = this.courseService.soldCourse
    const doc = new jsPDF('p','pt');

    autoTable(doc, {
      columns: this.columns,
      body: this.soldCourses,
      didDrawPage: (dataArg) => {
       doc.text('Sales', dataArg.settings.margin.left, 10);
      }
  });
    doc.save('sales.pdf');
  }
}
