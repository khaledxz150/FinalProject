import { Component, ElementRef, OnInit, VERSION, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { faEdit, faFileExcel, faFilePdf, faSearch, faTrash, faTrashAlt, faUserEdit } from '@fortawesome/free-solid-svg-icons';
import { AlertDialogComponent } from 'src/app/alert-dialog/alert-dialog.component';
import { TraineeService } from 'src/app/Service/trainee.service';
import { AddTrainerComponent } from '../trainer-info/add-trainer/add-trainer.component';
import { EditTrainerComponent } from '../trainer-info/edit-trainer/edit-trainer.component';
import { AddTraineeComponent } from './add-trainee/add-trainee.component';
import { EditTraineeComponent } from './edit-trainee/edit-trainee.component';
// import * as pdfMake from "pdfmake/build/pdfmake";
import * as pdfFonts from "pdfmake/build/vfs_fonts";
import * as pdfMake  from 'pdfmake/build/pdfmake';
import jsPDF from 'jspdf';
import autoTable from 'jspdf-autotable';
const htmlToPdfmake = require("html-to-pdfmake");
(pdfMake as any).vfs = pdfFonts.pdfMake.vfs;

import * as XLSX from 'xlsx';

@Component({
  selector: 'app-trainee-info',
  templateUrl: './trainee-info.component.html',
  styleUrls: ['./trainee-info.component.css', '../../../assets/css/tstyle.css']
})
export class TraineeInfoComponent implements OnInit {
  
  @ViewChild('pdfTable')
  pdfTable!: ElementRef;
  downloadAsPDF() {
    const pdfTable = this.pdfTable.nativeElement;
    var html = htmlToPdfmake(pdfTable.innerHTML);
    const documentDefinition = { content: html };
    pdfMake.createPdf(documentDefinition).download(); 
     
  }

  constructor(public Servicetrainee: TraineeService, private dialog: MatDialog) {
  }
  faEdit = faEdit
  faTrashAlt = faTrashAlt;

  filterTerm: any;
  title = 'angulardatatables';
  dtOptions: any = {};

  ngOnInit(): void {

    this.Servicetrainee.getTrainee();
    // this.Servicetrainee.trainee;

    this.dtOptions = {
      pagingType: 'full_numbers',
      pageLength: 3,
      processing: true,
      dom: 'Bfrtip',
      buttons: [
        'copy', 'csv', 'excel', 'print'
      ]
    };
  }
  //   deleteCourse(courseId:number){
  //   this.courseService.deleteCourse(courseId);
  // }
  public data = [
    { name: 'test', email: 'test@gmail.com', website: 'test.com' },
    { name: 'test', email: 'test@gmail.com', website: 'test.com' },
    { name: 'test', email: 'test@gmail.com', website: 'test.com' },
    { name: 'test', email: 'test@gmail.com', website: 'test.com' },
  ];

  name = 'Angular ' + VERSION.major;

  printPage() {
    window.print();
  }
  AddTrainee() {
    this.dialog.open(AddTraineeComponent, {
      height: '80%',
      width: '60%'
    })
  }
  DeleteTrainee(traineeId: number) {
    this.Servicetrainee.DeleteTrainee(traineeId);
  }

  // UpdateTrainer(){
  //   this.dialog.open(UpdateTrainerComponent,{
  //     height: '80%',
  //     width: '60%'
  // })
  // }


  UpdateTrainee(traineeId: number) {

    debugger
    const item = this.Servicetrainee.trainee.find(i => i.traineeId == traineeId);


    this.dialog.open(EditTraineeComponent, { data: item })
      // if(this.courseId)
    //    this.homeService.updatecourse(item);

  }
  faSearch = faSearch
  faFileExcel = faFileExcel
  faFilePdf = faFilePdf
  fatrash= faTrash
  faedit=faUserEdit

  @ViewChild('TABLE', { static: false }) TABLE: ElementRef | undefined;
   title1 = 'Excel';
  ExportTOExcel() {
    if(this.TABLE){
    const ws: XLSX.WorkSheet = XLSX.utils.table_to_sheet(this.TABLE.nativeElement);
    const wb: XLSX.WorkBook = XLSX.utils.book_new();
    XLSX.utils.book_append_sheet(wb, ws, 'Sheet1');
    XLSX.writeFile(wb, 'employee.xlsx');
    }
  }



  columns = [
    { title: "Nationality", dataKey: "nationality" },
    { title: "Image", dataKey: "image" },
    { title: "FirstName", dataKey: "firstName" },
    { title: "LastName", dataKey: "lastName" },
    { title: "Email", dataKey: "email" },
    { title: "PhoneNumber", dataKey: "phoneNumber" },
    // { title: "Salary", dataKey: "BasicSalary" },
    // { title: "Status", dataKey: "status" },
   
  ];

  trainers:any[]=[]

  exportPdf() {

    this.trainers = this.Servicetrainee.trainee
    const doc = new jsPDF('p','pt');

    autoTable(doc, {
      columns: this.columns,
      body: this.trainers,
      didDrawPage: (dataArg) => {
       doc.text('employee', dataArg.settings.margin.left, 10);
      }
  });
    doc.save('employee.pdf');
  }




  ChangeTraineeStatus(id: number) {

    let dialogRef = this.dialog.open(AlertDialogComponent);
    dialogRef.afterClosed().subscribe(result => {

      // NOTE: The result can also be nothing if the user presses the `esc` key or clicks outside the dialog
      if (result == 'confirm') {
        this.Servicetrainee.EditStatus(id);

      }


    })


  }


  date = new Date(2020, 1, 1);
  minDate = new Date(2000, 0, 1);
  maxDate = new Date(2020, 0, 1);
  public MinDateVal(event: any) {
    this.minDate = <Date>event;
  }

  public MaxDateVal(event: any) {
    this.maxDate = <Date>event;
  }

}
