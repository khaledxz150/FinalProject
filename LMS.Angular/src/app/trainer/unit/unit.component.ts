import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatAccordion } from '@angular/material/expansion';
import { UnitService } from 'src/app/Service/unit.service';
import { CreateUnitComponent } from './create-unit/create-unit.component';
import { EditUnitComponent } from './edit-unit/edit-unit.component';

@Component({
  selector: 'app-unit',
  templateUrl: './unit.component.html',
  styleUrls: ['./unit.component.css']
})
export class UnitComponent implements OnInit {


  constructor(public dialog: MatDialog, public unitService: UnitService) {}
  @ViewChild(MatAccordion) accordion!: MatAccordion;

  ngOnInit(): void {
  }

  addUnit(SectionID:number) {
    const dialogRef = this.dialog.open(CreateUnitComponent);
    dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`);
    });
  }

  editUnit(UnitId:number) {
    
    const dialogRef = this.dialog.open(EditUnitComponent);

    dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`);
    });
  }


  deleteUnit(UnitId:number) {
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




