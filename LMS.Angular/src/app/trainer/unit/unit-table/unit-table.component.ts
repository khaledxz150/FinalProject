import { Component, Input, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { CreateUnitComponent } from '../create-unit/create-unit.component';
import { EditUnitComponent } from '../edit-unit/edit-unit.component';

@Component({
  selector: 'app-unit-table',
  templateUrl: './unit-table.component.html',
  styleUrls: ['./unit-table.component.css']
})  
export class UnitTableComponent implements OnInit {
  @Input () FilePath:String|undefined;
  @Input () SectionId:number|undefined;
  @Input () Id:number|undefined;
  @Input () CreationDate:Date|undefined;
  constructor(public dialog: MatDialog) {}

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


  
  

}
