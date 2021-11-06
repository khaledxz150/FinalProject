import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-category-card',
  templateUrl: './category-card.component.html',
  styleUrls: ['./category-card.component.css','../../../../assets/css/default.css','../../../../assets/css/slick.css','../../../../assets/css/style.css']
})
export class CategoryCardComponent implements OnInit {


  @Input() categoryId:number | undefined;
  @Input() categoryName:string |undefined;
  @Input() categoryImage:string | undefined;
  @Input() numberOfCourses:number  = 25;

  constructor() { }

  ngOnInit(): void {
  }

}
