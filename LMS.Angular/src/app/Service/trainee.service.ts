import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class TraineeService {
//update
  trainee: any[] = [{}]
  CurrentTraineeSection:any;
  constructor(
    private http: HttpClient,
    private toastr: ToastrService
  ) { }

  dtOptions: any = {};

 ngOnInit(): void {


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

  getTrainee() {

    debugger;
    //  this.spinner.show();

    this.http.post(environment.apiUrl + 'Customer/ReturnTrainee/0', 0).subscribe((res: any) => {
      debugger
      // this.spinner.hide();
      debugger
      console.log(res)
      this.trainee = res;
      // console.log( "test",this.courses)
      // this.toastr.success('Data Retrived !!!');


    }, err => {
      // this.spinner.hide();
      // this.toastr.warning('Something wrong');
    })
    debugger;



  }


  AddTrainee(trainee: any) {

    debugger
    this.http.post(environment.apiUrl + 'Customer/InsertTrainee', trainee).subscribe((res: any) => {
      debugger
      // this.spiner.hide();
      this.toastr.success('Trainee Created successfully !!!');
      window.location.reload();

    }, err => {
      // this.spiner.hide();
      this.toastr.error('Something Wrong, Try Again!');
    })



  }
  //add put when delet/

  DeleteTrainee(trainee: number) {

    debugger
    this.http.put(environment.apiUrl + 'Customer/DeleteTrainee/' + trainee, trainee).subscribe((res: any) => {
      debugger
      // this.spiner.hide();
      this.toastr.success('Trainee Deleted successfully !!!');
      window.location.reload();

    }, err => {
      // this.spiner.hide();
      this.toastr.error('Something Wrong, Try Again!');
    })

  }

  EditTrainee(trainee: any) {

    this.http.put(environment.apiUrl + 'Customer/UpdateTrainee', trainee).subscribe((res: any) => {

      // this.spiner.hide();
      this.toastr.success('Trainee edit successfully !!!');
      window.location.reload();

    }, err => {
      // this.spiner.hide();
      this.toastr.error('Something Wrong, Try Again!');
    })
  }
  EditStatus(emp: number) {

    debugger
    this.http.put(environment.apiUrl + 'Customer/ChangeTraineeStatus/' + emp, emp).subscribe((res: any) => {
      debugger
      // this.spiner.hide();
      this.toastr.success('Edit Status Trainee successfully !!!');
      window.location.reload();

    }, err => {
      // this.spiner.hide();
      this.toastr.error('Something Wrong, Try Again!');
    })
  }






}
