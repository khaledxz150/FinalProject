import { Component, OnInit } from '@angular/core';
import { faCog, faUser } from '@fortawesome/free-solid-svg-icons';
import { AuthenticationService } from 'src/app/Service/authentication.service';

@Component({
  selector: 'app-side-bar',
  templateUrl: './side-bar.component.html',
  styleUrls: ['./side-bar.component.css','../../../assets/css/style1.css']
})
export class SideBarComponent implements OnInit {

  sidebar:Element | null = null;
  closeBtn:Element | null = null;
  searchBtn:Element | null = null;


   //Icons
   faCog= faCog
   faUser = faUser

 constructor(public loginService:AuthenticationService) {

  }
  ngOnInit(): void {
    this.searchBtn = document.querySelector(".bx-search");
    this.closeBtn= document.querySelector("#btn");
    this.sidebar = document.querySelector(".sidebar");
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

 logout(){
  this.loginService.logout();
}
}
