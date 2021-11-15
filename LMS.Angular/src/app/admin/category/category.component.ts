import { Component, OnInit } from '@angular/core';
import { faAngleDoubleRight, faShoppingCart, faHeart, faQuoteRight, faStar, faUser, faBook, faTag, faChartLine, faCalendar, faDollarSign, faPercentage, faEdit} from '@fortawesome/free-solid-svg-icons';
import { CourseService } from 'src/app/Service/course.service';
import { MatDialog } from '@angular/material/dialog';
import { CategoryService } from 'src/app/Service/category.service';
import { CreateCategoryComponent } from './create-category/create-category.component';
import { UpdateCategoryComponent } from './update-category/update-category.component';
import { AlertDialogComponent } from 'src/app/alert-dialog/alert-dialog.component';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css','../../../assets/css/style1.css']
})
export class CategoryComponent implements OnInit {



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
  faCalendar = faCalendar
  faDollarSign = faDollarSign
  faPercentage = faPercentage
  faEdit =faEdit
  constructor(public categoryService: CategoryService, private dialog:MatDialog) {
    this.categoryService.getCategories();
  }

  ngOnInit(): void {
  }

  deleteCategory(categoryId:number){
    let dialogRef = this.dialog.open(AlertDialogComponent);

    dialogRef.afterClosed().subscribe(result => {

      // NOTE: The result can also be nothing if the user presses the `esc` key or clicks outside the dialog
      if (result == 'confirm') {

        this.categoryService.deleteCategory(categoryId);

        window.location.reload();

      }
      })

  }

  createCategory(){
    this.dialog.open(CreateCategoryComponent)
  }


  updateCategory(categoryId:number){
    const item = this.categoryService.category.find(i => i.categoryId == categoryId);

    this.dialog.open(UpdateCategoryComponent, { data: item });
  }

}
