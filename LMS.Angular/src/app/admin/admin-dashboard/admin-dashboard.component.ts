import { Component, OnInit } from '@angular/core';
import { faArrowUp, faShoppingCart, faUsers, faTicketAlt, faDollarSign} from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-admin-dashboard',
  templateUrl: './admin-dashboard.component.html',
  styleUrls: ['./admin-dashboard.component.css','../../../assets/css/style1.css']
})
export class AdminDashboardComponent implements OnInit {

  faArrowUp = faArrowUp
  faShoppingCart = faShoppingCart
  faUsers = faUsers
  faTicketAlt = faTicketAlt
  faDollarSign = faDollarSign
  constructor() { }

  ngOnInit(): void {
  }

}
