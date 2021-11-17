import { Component, OnInit } from '@angular/core';
import { faArrowUp, faShoppingCart, faUsers, faTicketAlt, faDollarSign, faTimes, faSearch} from '@fortawesome/free-solid-svg-icons';
import { PurchesService } from 'src/app/Service/purches.service';

@Component({
  selector: 'app-courserefund',
  templateUrl: './courserefund.component.html',
  styleUrls: ['./courserefund.component.css','../../../assets/css/style1.css']
})
export class CourserefundComponent implements OnInit {

  faArrowUp = faArrowUp
  faShoppingCart = faShoppingCart
  faUsers = faUsers
  faTicketAlt = faTicketAlt
  faDollarSign = faDollarSign
  faTimes = faTimes
  faSearch = faSearch
  checked: boolean =false;



  constructor(public purchesService:PurchesService) { }

  ngOnInit(): void {
    this.purchesService.GetMyRefunds(0);

  }

  ApproveRefundReason(courseRefundsId:number){
  this.purchesService.ApproveRefundReason(courseRefundsId);

  // this.purchesService.myRefunds.map((i=>{
  //   const {isApproved} = this.purchesService.myRefunds

  //   this.checked = isApproved;
  // }));
  }
}
