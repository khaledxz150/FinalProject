import { Component, NgZone, OnInit } from '@angular/core';
import { faPaperPlane } from '@fortawesome/free-solid-svg-icons';
import { Message } from 'src/app/models/Message';
import { ChatService } from 'src/app/Service/chat.service';
import { TrainerService } from 'src/app/Service/trainer.service';

@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.css']
})
export class ChatComponent implements OnInit {

  faPaperPlane = faPaperPlane
  constructor(public chatService: ChatService, public trainerService:TrainerService) {}
  msgDto:any;
  Userid =2;
  ngOnInit(): void {
    this.chatService.startConnection();
    this.chatService.addDataListener();
    this.trainerService.ReturnEmployeeInfo(0);
  }
  sendMessage(){

  }

  send(){
debugger
    let user:any = localStorage.getItem('user');

    let trainerId = JSON.parse(user);

    //filter
    let trainer = this.trainerService.employee.find(i=>i.employeeId == parseInt(trainerId.EmployeeId))
if(trainer){
    const currentElememnt = document.getElementById("inputbox");
   const message :Message= {
     userId: parseInt(trainerId.EmployeeId),
     message: this.msgDto,
     traineeName: trainer.fName,
     date: new Date()
   }

   this.chatService.SendMessage(message);
debugger
  this.msgDto = ''
  }





  }
}



