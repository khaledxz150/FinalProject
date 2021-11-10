import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { CreateUnitComponent } from './create-unit/create-unit.component';

@Component({
  selector: 'app-unit',
  templateUrl: './unit.component.html',
  styleUrls: ['./unit.component.css']
})
export class UnitComponent implements OnInit {


  constructor(public dialog: MatDialog) {}

  ngOnInit(): void {

  }

  openDialog() {
    const dialogRef = this.dialog.open(CreateUnitComponent);

    dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`);
    });
  }

  Create(){}
}




