import { Component, OnInit } from '@angular/core';
import { Options } from '@angular-slider/ngx-slider';
import { CourseService } from 'src/app/Service/course.service';
import { Course } from 'src/app/models/course';
import { faAngleDoubleRight, faShoppingCart, faHeart, faQuoteRight, faStar, faUser, faBook, faTag, faChartLine} from '@fortawesome/free-solid-svg-icons';
import { TestimonialService } from 'src/app/Service/testimonial.service';
import { CategoryService } from 'src/app/Service/category.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css','../../../assets/css/default.css','../../../assets/css/slick.css','../../../assets/css/style.css']
})
export class HomeComponent implements OnInit {

  // Icons
  faAngleDoubleRight = faAngleDoubleRight
  faShoppingCart = faShoppingCart
  faHeart = faHeart
  faQuoteRight = faQuoteRight
  faStar = faStar
  faUser = faUser
  faBook = faBook
  faTag = faTag
  faChartLine = faChartLine


  responsiveOptions:any;
  // value: number = 100;
  // options: Options = {
  //   floor: 0,
  //   ceil: 200
  // }




//   imageObject: Array<object> = [{
//     image: 'assets/img/slider/1.jpg',
//     thumbImage: 'assets/img/slider/1_min.jpeg',
//     alt: 'alt of image',
//     title: 'title of image'
// }, {
//     image: '.../iOe/xHHf4nf8AE75h3j1x64ZmZ//Z==', // Support base64 image
//     thumbImage: '.../iOe/xHHf4nf8AE75h3j1x64ZmZ//Z==', // Support base64 image
//     title: 'Image title', //Optional: You can use this key if want to show image with title
//     alt: 'Image alt', //Optional: You can use this key if want to show image with alt
//     order: 1 //Optional: if you pass this key then slider images will be arrange according @input: slideOrderType
// }
// ];


  constructor(
    public courseService: CourseService,
    public testimonialService: TestimonialService,
    public categoryService: CategoryService
    ) {
    this.responsiveOptions = [
      {
          breakpoint: '1024px',
          numVisible: 3,
          numScroll: 3
      },
      {
          breakpoint: '768px',
          numVisible: 2,
          numScroll: 2
      },
      {
          breakpoint: '560px',
          numVisible: 1,
          numScroll: 1
      }
  ];

  }



  ngOnInit(): void {
    debugger
     this.courseService.getCourses();
     this.testimonialService.getTestimonial();
     this.categoryService.getCategories();

  }

}
