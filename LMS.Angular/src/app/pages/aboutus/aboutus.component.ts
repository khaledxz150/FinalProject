import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from 'src/app/Service/authentication.service';
import { TrainerService } from 'src/app/Service/trainer.service';

@Component({
  selector: 'app-aboutus',
  templateUrl: './aboutus.component.html',
  styleUrls: ['./aboutus.component.css','../../../assets/css/default.css','../../../assets/css/style.css']
})
export class AboutusComponent implements OnInit {

  constructor(
    public trainerService: TrainerService, public auth:AuthenticationService
  ) { }
  loggedIn:any|undefined;
     ngOnInit(): void {
    this.trainerService.getTrainer();
    this.loggedIn=localStorage.getItem("user")
    let traineeId=JSON.parse(this.loggedIn)
    this.loggedIn=traineeId.traineeId
    console.log(this.loggedIn)

  }




}
