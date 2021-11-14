import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { faEdit, faTrashAlt } from '@fortawesome/free-solid-svg-icons';
import { Observable } from 'rxjs';
import { AlertDialogComponent } from 'src/app/alert-dialog/alert-dialog.component';
import { Trainer } from 'src/app/models/Trainer';
import { TrainerService } from 'src/app/Service/trainer.service';
import { AddTrainerComponent } from './add-trainer/add-trainer.component';
import { EditTrainerComponent } from './edit-trainer/edit-trainer.component';
import {DataTablesModule} from 'angular-datatables'
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-trainer-info',
  templateUrl: './trainer-info.component.html',
  styleUrls: ['./trainer-info.component.css','../../../assets/css/tstyle.css']
})
export class TrainerInfoComponent implements OnInit {
  constructor(public trainer: TrainerService, private dialog: MatDialog,public http:HttpClient,  private dt :DataTablesModule) { }
  faEdit = faEdit
  faTrashAlt = faTrashAlt
 trainerArr :any[]=[{}];
  // myControl = new FormControl();
  // options: Trainer[] = [];
  // filteredOptions: Observable<Trainer[]>;
 dtOptions:any = {};

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

    // debugger;
    // //  this.spinner.show();

    this.http.post(environment.apiUrl + 'Employee/GetAllEmployess/0', 0).subscribe((res: any) => {
      // debugger
      // this.spinner.hide();
      // debugger
      console.log(res)
      this.trainerArr = res;
      // console.log( "test",this.courses)
      // this.toastr.success('Data Retrived !!!');
     }, err => {
      // this.spinner.hide();
      // this.toastr.warning('Something wrong');
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



  UpdateTrainer(empId: number) {

    let dialogRef = this.dialog.open(AlertDialogComponent);
    dialogRef.afterClosed().subscribe(result => {

      // NOTE: The result can also be nothing if the user presses the `esc` key or clicks outside the dialog
      if (result == 'confirm') {
        const item = this.trainer.trainer.find(i => i.employeeId == empId);
        debugger
        this.dialog.open(EditTrainerComponent, { data: item })
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
  
