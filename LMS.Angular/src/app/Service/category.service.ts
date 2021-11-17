import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  category:any[]=[{}]

  constructor(
    private http: HttpClient,
    private toastr:ToastrService,
    private spinner: NgxSpinnerService,

  ) { }

  getCategories(){

    // const contactUs : ContactUs = this.contactUsForm.value;

    debugger;
    this.spinner.show();

    this.http.post(environment.apiUrl + 'Course/GetAllCategories/1',1).subscribe((res:any)=>{
      // debugger

      console.log(res)
      this.category = res;
      this.spinner.hide()


    },err=>{
      this.spinner.hide();
      this.toastr.warning('Something wrong');
    })
    debugger;




  }

  deleteCategory(categoryId:number){

    this.spinner.show();


    this.http.put(environment.apiUrl + 'Course/DeleteCategory/'+categoryId,categoryId).subscribe((res:any)=>{
      // debugger
      // this.spinner.hide();
      // this.toastr.success('Send Message successfully, Thank You :)');
      debugger
      console.log(res)
      this.category = res;
      // console.log( "test",this.courses)
      window.location.reload();
      this.spinner.hide();
      this.toastr.success('Category Deleted successfully !!!');



    },err=>{
      this.spinner.hide();
      this.toastr.error('Something Wrong, Try Again!');
    })
    debugger;

  }


  createCategory(category:any){
    debugger

    this.spinner.show();

    this.http.post(environment.apiUrl + 'Course/InsertCategory/',category).subscribe((res:any)=>{
      debugger
      this.spinner.hide();
      this.toastr.success('Category Created successfully !!!');


    },err=>{
      this.spinner.hide();
      this.toastr.error('Something Wrong, Try Again!');
    })
  }


  updateCategory(category:any){
    debugger
    this.spinner.show();
    this.http.put(environment.apiUrl + 'Course/UpdateCategory',category).subscribe((res:any)=>{
      debugger
      this.spinner.hide();
      this.toastr.success('Category Updated successfully !!!');


    },err=>{
      this.spinner.hide();
      this.toastr.error('Something Wrong, Try Again!');
    })

  }
}
