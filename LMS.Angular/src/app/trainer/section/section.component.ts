import { Component, OnInit } from '@angular/core';
import {ViewChild} from '@angular/core';
import {MatAccordion} from '@angular/material/expansion';
import {FormGroup, FormControl} from '@angular/forms';
export interface PeriodicElement {
  Course: string;
  time: string;
  lecturesDone : string;
  rating:string;
}

const ELEMENT_DATA: PeriodicElement[] = [
  {Course: 'C++', time: '1 - 5 pm', lecturesDone:'5/7', rating:'4/5'},
  {Course: 'C++', time: '1 - 5 pm', lecturesDone:'5/7', rating:'4/5'},
  {Course: 'C++', time: '1 - 5 pm', lecturesDone:'5/7', rating:'4/5'},
  {Course: 'C++', time: '1 - 5 pm', lecturesDone:'5/7', rating:'4/5'},
  {Course: 'C++', time: '1 - 5 pm', lecturesDone:'5/7', rating:'4/5'},
];

@Component({
  selector: 'app-section',
  templateUrl: './section.component.html',
  styleUrls: ['./section.component.css']
})

export class SectionComponent implements OnInit {
  @ViewChild(MatAccordion) accordion!: MatAccordion;
  displayedColumns: string[] = ['Course', 'time', 'lecturesDone','rating'];
  dataSource = ELEMENT_DATA;
  constructor() { }

  ngOnInit(): void {

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
