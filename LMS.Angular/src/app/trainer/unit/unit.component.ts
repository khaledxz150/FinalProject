import { Component, Input, OnInit, ViewChild } from '@angular/core';
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
  @Input() Sectionid = 0;


  constructor(public dialog: MatDialog, public unitService: UnitService) {
  }
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
    const dialogRef = this.dialog.open(EditUnitComponent,{data:UnitId});

    dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`);
    });
  }
  Create(){}




  ViewUnit(sectionId:number){
    debugger
    this.unitService.getAllTrainerSectionUnit(sectionId);
    
    }

    OpenPdf(data:any, fileType:any) {
     const linkElement = document.createElement('a');
     linkElement.setAttribute('href', data);
     linkElement.setAttribute('download', `Unit${fileType}`);
     const clickEvent = new MouseEvent('click', {
      'view': window,
      'bubbles': true,
     'cancelable': false
    });
    linkElement.dispatchEvent(clickEvent);
    }
}




