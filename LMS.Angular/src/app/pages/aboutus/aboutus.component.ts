import { Component, OnInit } from '@angular/core';
import { TrainerService } from 'src/app/Service/trainer.service';

@Component({
  selector: 'app-aboutus',
  templateUrl: './aboutus.component.html',
  styleUrls: ['./aboutus.component.css','../../../assets/css/default.css','../../../assets/css/style.css']
})
export class AboutusComponent implements OnInit {

  constructor(
    public trainerService: TrainerService
  ) { }

  ngOnInit(): void {
    this.trainerService.getTrainer();

  }



}
