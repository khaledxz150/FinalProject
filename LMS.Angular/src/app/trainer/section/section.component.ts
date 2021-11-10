import { Component, Input, OnInit } from '@angular/core';
import {ViewChild} from '@angular/core';
import {MatAccordion} from '@angular/material/expansion';
import {FormGroup, FormControl} from '@angular/forms';
import { SectionService } from 'src/app/Service/section.service';
import { UnitService } from 'src/app/Service/unit.service';



@Component({
  selector: 'app-section',
  templateUrl: './section.component.html',
  styleUrls: ['./section.component.css']
})

export class SectionComponent implements OnInit {
 
@ViewChild(MatAccordion) accordion!: MatAccordion;
// @Input () SectionId: string| undefined;
// @Input () CourseId: string| undefined;
// @Input ()SectionTimeStart : Date| undefined;
// @Input ()SectionTimeEnd:Date | undefined;
// @Input ()  SectionCapacity:number| undefined;
// @Input () NoLecture: number| undefined;
// @Input () StatusId: number| undefined;
// @Input () IsActive: boolean| undefined;
// @Input () CreationDate:Date| undefined;
// @Input () CreatedBy: number| undefined;
  

  displayedColumns: string[] = ['SectionId'];
  constructor(private sectionService: SectionService, private unitService: UnitService) { }

  sections:any=[{}];
  ngOnInit(): void {
    this.getAllSection();
    this.unitService.getAllSectionAndUnit();
    this.sections = this.sectionService.section;

  }
  getAllSection(){

  this.sectionService.getAllSection();

  }
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
