import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormControl } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { faArrowUp, faDollarSign, faEdit, faFileExcel, faFilePdf, faSearch, faShoppingCart, faTicketAlt, faTimes, faTrash, faTrashAlt, faUserCog, faUserEdit, faUsers } from '@fortawesome/free-solid-svg-icons';
import { Observable } from 'rxjs';
import { AlertDialogComponent } from 'src/app/alert-dialog/alert-dialog.component';
import { Trainer } from 'src/app/models/Trainer';
import { TrainerService } from 'src/app/Service/trainer.service';
import { AddTrainerComponent } from './add-trainer/add-trainer.component';
import { EditTrainerComponent } from './edit-trainer/edit-trainer.component';
import { DataTablesModule } from 'angular-datatables'
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import * as pdfFonts from "pdfmake/build/vfs_fonts";
import * as pdfMake from 'pdfmake/build/pdfmake';
import autoTable from 'jspdf-autotable';
import jsPDF from 'jspdf';
import * as XLSX from 'xlsx';
const htmlToPdfmake = require("html-to-pdfmake");
(pdfMake as any).vfs = pdfFonts.pdfMake.vfs;
@Component({
  selector: 'app-trainer-info',
  templateUrl: './trainer-info.component.html',
  styleUrls: ['./trainer-info.component.css', '../../../assets/css/tstyle.css']
})
export class TrainerInfoComponent implements OnInit {
  constructor(public trainer: TrainerService, private dialog: MatDialog, public http: HttpClient, private dt: DataTablesModule) { }
  faEdit = faEdit
  faTrashAlt = faTrashAlt
  trainerArr: any[] = [{}];
  filterTerm: any;
  dtOptions: any = {};


  @ViewChild('pdfTable')
  pdfTable!: ElementRef;
  downloadAsPDF() {
    const pdfTable = this.pdfTable.nativeElement;
    var html = htmlToPdfmake(pdfTable.innerHTML);
    const documentDefinition = { content: html };
    pdfMake.createPdf(documentDefinition).download();

  }

  ngOnInit(): void {
    this.trainer.getTrainer();

    this.dtOptions = {
      pagingType: 'full_numbers',
      pageLength: 1,
      processing: true,
      dom: 'Bfrtip',
      buttons: [
        'copy', 'csv', 'excel', 'print'
      ]
    };

  }

  getTrainer() {


    this.http.post(environment.apiUrl + 'Employee/GetAllEmployess/0', 0).subscribe((res: any) => {
      console.log(res)
      this.trainerArr = res;
    }, err => {
    })
    debugger;



  }

  AddTrainer() {

    this.dialog.open(AddTrainerComponent, {
      height: '80%',
      width: '60%'
    })
  }


  DeleteTrainer(empId: number) {
    let dialogRef = this.dialog.open(AlertDialogComponent);
    dialogRef.afterClosed().subscribe(result => {

      // NOTE: The result can also be nothing if the user presses the `esc` key or clicks outside the dialog
      if (result == 'confirm') {
        this.trainer.DeleteTrainer(empId);
      }
    })

  }
  faArrowUp = faArrowUp
  faShoppingCart = faShoppingCart
  faUsers = faUsers
  faTicketAlt = faTicketAlt
  faDollarSign = faDollarSign
  faTimes = faTimes
  faSearch = faSearch
  faFileExcel = faFileExcel
  faFilePdf = faFilePdf
  fatrash = faTrash
  faedit = faUserEdit
  fausercog=faUserCog
  @ViewChild('TABLE', { static: false }) TABLE: ElementRef | undefined;
  title = 'Excel';
  ExportTOExcel() {
    if (this.TABLE) {
      const ws: XLSX.WorkSheet = XLSX.utils.table_to_sheet(this.TABLE.nativeElement);
      const wb: XLSX.WorkBook = XLSX.utils.book_new();
      XLSX.utils.book_append_sheet(wb, ws, 'Sheet1');
      XLSX.writeFile(wb, 'employee.xlsx');
    }
  }



  columns = [
    { title: "SSN", dataKey: "nationalSecurutiyNumber" },
    { title: "Image", dataKey: "image" },
    { title: "FirstName", dataKey: "fname" },
    // { title: "LastName", dataKey: "lname" },
    { title: "Email", dataKey: "email" },
    { title: "PhoneNumber", dataKey: "phoneNumber" },
    // { title: "Salary", dataKey: "BasicSalary" },
    // { title: "Status", dataKey: "status" },

  ];

  trainers: any[] = []

  exportPdf() {

    this.trainers = this.trainer.trainer
    const doc = new jsPDF('p', 'pt');

    autoTable(doc, {
      columns: this.columns,
      body: this.trainers,
      didDrawPage: (dataArg) => {
        doc.text('employee', dataArg.settings.margin.left, 10);
      }
    });
    doc.save('employee.pdf');
  }










  UpdateTrainer(empId: number) {

    let dialogRef = this.dialog.open(AlertDialogComponent);
    dialogRef.afterClosed().subscribe(result => {

      // NOTE: The result can also be nothing if the user presses the `esc` key or clicks outside the dialog
      if (result == 'confirm') {
        const item = this.trainer.trainer.find(i => i.employeeId == empId);


        this.dialog.open(EditTrainerComponent, { data: item },
          )
         
      }
    })
  }


  ChangeTrainerStatus(id: number) {

    let dialogRef = this.dialog.open(AlertDialogComponent);
    dialogRef.afterClosed().subscribe(result => {

      // NOTE: The result can also be nothing if the user presses the `esc` key or clicks outside the dialog
      if (result == 'confirm') {
        this.trainer.EditStatus(id);


      }
    })




  }

  /////////////////////////Test Search///////////////////////////

  // displayFn(trainer: Trainer): string {
  //   return trainer && trainer.fname ? trainer.fname : '';
  // }

  // private _filter(fname: string): Trainer[] {
  //   const filterValue = fname.toLowerCase();

  //   return this.options.filter(option => option.name.toLowerCase().includes(filterValue));
  // }


}

