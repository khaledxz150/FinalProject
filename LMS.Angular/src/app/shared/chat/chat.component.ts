import { Component, Input, NgZone, OnInit } from '@angular/core';
import { faPaperPlane } from '@fortawesome/free-solid-svg-icons';
import { Message } from 'src/app/models/Message';
import { ChatService } from 'src/app/Service/chat.service';
import { ProfileService } from 'src/app/Service/profile.service';
import { SectionService } from 'src/app/Service/section.service';
import { TraineeService } from 'src/app/Service/trainee.service';
import { TrainerService } from 'src/app/Service/trainer.service';

@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.css']
})
export class ChatComponent implements OnInit {
  
  faPaperPlane = faPaperPlane
  constructor(public chatService: ChatService, public trainerService:TrainerService, public traineeService: TraineeService,
  public sectionService:SectionService, public profileService:ProfileService) {}
  msgDto:any;
  Userid = 0;
  ngOnInit(): void {
    this.chatService.startConnection();
    this.chatService.addDataListener();
    
    let user:any = localStorage.getItem('user');
    let trainerId = JSON.parse(user);
    this.Userid=parseInt(trainerId.TraineeId);
    if(this.Userid == 0) {
      this.Userid=parseInt(trainerId.EmployeeId);
      this.trainerService.ReturnEmployeeInfo(parseInt(trainerId.EmployeeId));
      this.Userid = parseInt(trainerId.EmployeeId);
    }
  }
  sendMessage(){
  }
  send(){
    let user:any = localStorage.getItem('user');
    let trainerId = JSON.parse(user);
    //filter
    let trainer = this.trainerService.employee[0];
    
     
if(trainer != undefined){
  debugger
   const currentElememnt = document.getElementById("inputbox");
   const message :Message= {
     userId:this.Userid,
     message: this.msgDto,
     traineeName: trainer.fName,
     date: new Date(),
     sectionId: this.traineeService.CurrentTraineeSection 
  };
   this.msgDto = '';
  this.chatService.SendMessage(message);
  this.msgDto = '';
}
  else{
  this.profileService.GetMyProfile(this.Userid)
  const currentElememnt = document.getElementById("inputbox");
  const message :Message= {
    userId:this.Userid,
    message: this.msgDto,
    traineeName: this.profileService.trainee.firstName,
    date: new Date(),
    sectionId: this.traineeService.CurrentTraineeSection 
  };
 this.chatService.SendMessage(message);
 this.msgDto = '';
}
this.msgDto = '';

  }
  
  }




