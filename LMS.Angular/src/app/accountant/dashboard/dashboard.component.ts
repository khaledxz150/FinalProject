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
    // this.contactusService.returnAllMessages();


  }

  ngOnInit(): void {



          this.contactusService.returnAllMessages();
          this.courseService.returnSoldCourses();
          this.trainerService.getTrainer();
          this.courseService.getCourses();

          // this.cols = [
          //           { field: 'cartId', header: 'CartId' },
          //           { field: 'courseName', header: 'Course Name' },
          //           { field: 'firstName', header: 'FirstName' },
          //           { field: 'lastName', header: 'lastName' },
          //           { field: 'traineeImage', header: 'traineeImage' },
          //       ];


  }


// recentSoldCourse(){
//   debugger
//   this.courseService.soldCourse.filter(course => course.creationDate == Date.now().toString())
//   debugger
// }
  // countOfSoldCourses:number = 0;


  //table

  // customers: Customer[];

  first = 0;

  rows = 10;

  // constructor(private customerService: CustomerService) { }

  // ngOnInit() {
  //     this.customerService.getCustomersLarge().then(customers => this.customers = customers);
  // }

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

  /*

  deleteCourse(courseId:number){

  let dialogRef = this.dialog.open(AlertDialogComponent);

  dialogRef.afterClosed().subscribe(result => {

    // NOTE: The result can also be nothing if the user presses the `esc` key or clicks outside the dialog
    if (result == 'confirm') {

      this.courseService.deleteCourse(courseId);
      window.location.reload();

    }
    })

}

  */

//////////////////////////////////////////////////////////////////


// products: Product[];

// selectedProducts: Product[];

// constructor(private productService: ProductService) { }

// cols: any[] = [];

// exportColumns: any[];

// ngOnInit() {
//     this.productService.getProductsSmall().then(data => this.products = data);

//     this.cols = [
//         { field: 'code', header: 'Code' },
//         { field: 'name', header: 'Name' },
//         { field: 'category', header: 'Category' },
//         { field: 'quantity', header: 'Quantity' }
//     ];

//     this.exportColumns = this.cols.map(col => ({title: col.header, dataKey: col.field}));
// }

// exportPdf() {
//     import("jspdf").then(jsPDF => {
//         import("jspdf-autotable").then(x => {
//             const doc = new jsPDF.default(0,0);
//             doc.autoTable(this.exportColumns, this.products);
//             doc.save('products.pdf');
//         })
//     })
// }

// exportExcel() {
//     import("xlsx").then(xlsx => {
//         const worksheet = xlsx.utils.json_to_sheet(this.cou);
//         const workbook = { Sheets: { 'data': worksheet }, SheetNames: ['data'] };
//         const excelBuffer: any = xlsx.write(workbook, { bookType: 'xlsx', type: 'array' });
//         this.saveAsExcelFile(excelBuffer, "products");
//     });
}

// saveAsExcelFile(buffer: any, fileName: string): void {
//     let EXCEL_TYPE = 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;charset=UTF-8';
//     let EXCEL_EXTENSION = '.xlsx';
//     const data: Blob = new Blob([buffer], {
//         type: EXCEL_TYPE
//     });
//     FileSaver.saveAs(data, fileName + '_export_' + new Date().getTime() + EXCEL_EXTENSION);
// }
// }



