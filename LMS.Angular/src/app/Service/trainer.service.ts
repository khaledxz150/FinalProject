import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ToastrService } from 'ngx-toastr';
import { environment } from 'src/environments/environment';
import { AlertDialogComponent } from '../alert-dialog/alert-dialog.component';
import {DataTablesModule} from 'angular-datatables'
@Injectable({
  providedIn: 'root'
})
export class TrainerService {
  dtOptions: any []=[{}]
  trainer: any[] = [{}]
  top4Trainer:any[]=[]

  constructor(
    private http: HttpClient,
    private toastr: ToastrService
    , protected dialog: MatDialog
  ) { }


  getTrainer() {

    debugger;
    //  this.spinner.show();

    this.http.post(environment.apiUrl + 'Employee/GetAllEmployess/0', 0).subscribe((res: any) => {
      debugger
      // this.spinner.hide();
      debugger
      console.log(res)
      this.trainer = res;
      this.top4Trainer = res.slice(0,4)

      // console.log( "test",this.courses)
      // this.toastr.success('Data Retrived !!!');
     }, err => {
      // this.spinner.hide();
      // this.toastr.warning('Something wrong');
    })
    debugger;



  }


  AddTrainer(emp: any) {

    debugger
    this.http.post(environment.apiUrl + 'Employee/AddNewEmployee', emp).subscribe((res: any) => {
      debugger
      // this.spiner.hide();
      this.toastr.success('Trainer Created successfully !!!');


    }, err => {
      // this.spiner.hide();
      this.toastr.error('Something Wrong, Try Again!');
    })



  }
  //add put when delet/

  DeleteTrainer(empId: number) {

    debugger
    this.http.put(environment.apiUrl + 'Employee/DeleteEmployee/' + empId, empId).subscribe((res: any) => {
      debugger
      // this.spiner.hide();
      this.toastr.success('Trainer Deleted successfully !!!');
      window.location.reload();

    }, err => {
      // this.spiner.hide();
      this.toastr.error('Something Wrong, Try Again!');
    })

  }

  EditTrainer(emp: any) {

    debugger
    this.http.put(environment.apiUrl + 'Employee/UpdateEmployee', emp).subscribe((res: any) => {

      // this.spiner.hide();


      this.toastr.success('Trainer Edit successfully !!!');
      window.location.reload();



    }, err => {
      // this.spiner.hide();
      this.toastr.error('Something Wrong, Try Again!');
    })
  }
  EditStatus(emp: number) {

    debugger
    this.http.put(environment.apiUrl + 'Employee/ChangeTrainerStatus/' + emp, emp).subscribe((res: any) => {
      debugger
      // this.spiner.hide();
      this.toastr.success('Edit Status Trainer successfully !!!');
      window.location.reload();

    }, err => {
      // this.spiner.hide();
      this.toastr.error('Something Wrong, Try Again!');
    })
  }
}
