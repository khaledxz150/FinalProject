import { Component, OnInit } from '@angular/core';
import { faArrowUp, faShoppingCart, faUsers, faTicketAlt, faDollarSign, faTimes, faSearch} from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-purchase',
  templateUrl: './purchase.component.html',
  styleUrls: ['./purchase.component.css','../../../assets/css/style1.css']
})
export class PurchaseComponent implements OnInit {

  faArrowUp = faArrowUp
  faShoppingCart = faShoppingCart
  faUsers = faUsers
  faTicketAlt = faTicketAlt
  faDollarSign = faDollarSign
  faTimes = faTimes
  faSearch = faSearch
  constructor() { }

  ngOnInit(): void {
  }

}
