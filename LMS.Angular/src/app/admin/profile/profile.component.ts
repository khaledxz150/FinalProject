import { Component, OnInit } from '@angular/core';
import { TrainerService } from 'src/app/Service/trainer.service';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

  constructor(public trainerService: TrainerService) { }

  ngOnInit(): void {
    let user:any = localStorage.getItem('user');

    let trainerId = JSON.parse(user);
     if(trainerId){
      this.trainerService.ReturnEmployeeInfo(parseInt(trainerId.EmployeeId));

    }
  }

}
