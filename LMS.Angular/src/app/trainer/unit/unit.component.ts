import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { UnitService } from 'src/app/Service/unit.service';
import { CreateUnitComponent } from './create-unit/create-unit.component';
import { EditUnitComponent } from './edit-unit/edit-unit.component';

@Component({
  selector: 'app-unit',
  templateUrl: './unit.component.html',
  styleUrls: ['./unit.component.css']
})
export class UnitComponent implements OnInit {


  constructor(public dialog: MatDialog, private unitService: UnitService) {}

  ngOnInit(): void {
  }

  addUnit() {
    const dialogRef = this.dialog.open(CreateUnitComponent);
    dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`);
    });
  }

  editUnit() {
    const dialogRef = this.dialog.open(EditUnitComponent);

    dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`);
    });
  }


  deleteUnit() {
    const dialogRef = this.dialog.open(EditUnitComponent);

    dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`);
    });
  }
  Create(){}


  Change(e: any){
    const cardInfoBtn = e.target.closest('.card__more-info')
    const cardLessBtn = e.target.closest('.card__less-info')
    
    if (cardInfoBtn) {
      cardInfoBtn.parentNode.parentNode.classList.add('card--open')
    }
    
    if (cardLessBtn) {
      cardLessBtn.parentNode.parentNode.classList.remove('card--open')
    }
    
  }
}




