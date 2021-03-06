import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from 'src/app/Service/authentication.service';

@Component({
  selector: 'app-trainer-side-bar',
  templateUrl: './trainer-side-bar.component.html',
  styleUrls: ['./trainer-side-bar.component.css']
})
export class TrainerSideBarComponent implements OnInit {

  sidebar:Element | null = null;
   closeBtn:Element | null = null;
   searchBtn:Element | null = null;

  constructor(public auth:AuthenticationService) {

   }
   ngOnInit(): void {
     this.searchBtn = document.querySelector(".bx-search");
     this.closeBtn= document.querySelector("#btn");
     this.sidebar = document.querySelector(".sidebar");
  }

  MoveOut(){
    this.auth.logout();
  }

  btnclicked(){
    this.sidebar!.classList.toggle("open");
    this.menuBtnChange();
  }

  // following are the code to change sidebar button(optional)
  menuBtnChange(this: any) {
   if(this.sidebar.classList.contains("open")){
     this.closeBtn.classList.replace("bx-menu", "bx-menu-alt-right");//replacing the iocns class
   }else {
     this.closeBtn.classList.replace("bx-menu-alt-right","bx-menu");//replacing the iocns class
   }
  }


}
