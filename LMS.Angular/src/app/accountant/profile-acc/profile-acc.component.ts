import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { TrainerService } from 'src/app/Service/trainer.service';

@Component({
  selector: 'app-profile-acc',
  templateUrl: './profile-acc.component.html',
  styleUrls: ['./profile-acc.component.css']
})
export class ProfileAccComponent implements OnInit {

  

  constructor(public trainerService: TrainerService,private dialog:MatDialog ) { }
 
//   const item = this.trainer.trainer.find(i => i.employeeId == empId);


//   this.dialog.open(EditTrainerComponent, { data: item },
//     )

// }


// UpdateTrainer()
// {
//   let user:any = localStorage.getItem('user');

//   let trainerId = JSON.parse(user);
//    if(trainerId){
//     this.trainerService.ReturnEmployeeInfo(parseInt(trainerId.employeeId))}

//   const item = this.trainerService.trainer.find(i => i.employeeId == trainerId.employeeId);

  
// // this.dialog.open(EditComponent,{data :item})
// //    }







  ngOnInit(): void {
    let user:any = localStorage.getItem('user');

    let trainerId = JSON.parse(user);
     if(trainerId){
      this.trainerService.ReturnEmployeeInfo(parseInt(trainerId.EmployeeId));

    }
  }
}
