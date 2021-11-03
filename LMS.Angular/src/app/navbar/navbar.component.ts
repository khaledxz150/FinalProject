import { Component, OnInit } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css','../../assets/css/style.css']
})
export class NavbarComponent implements OnInit {

  constructor(
    private spinner: NgxSpinnerService
  ) {

    window.addEventListener("scroll", (event)=>{
      // debugger;
      const content:any = document.querySelector('#content');
      if (window.pageYOffset < content.clientHeight ) {
        content.classList.add('elementToFadeInAndOut');
      } else {
        // box.classList.remove('elementToFadeInAndOut');
      }
    });
  }

  ngOnInit(): void {
  }

  submit(){

    this.spinner.show();

    setTimeout(() => {


      this.spinner.hide();

    }, 1000);


   }
}
