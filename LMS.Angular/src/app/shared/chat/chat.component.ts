import { Component, NgZone, OnInit } from '@angular/core';
import { Message } from 'src/app/models/Message';
import { ChatService } from 'src/app/Service/chat.service';

@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.css']
})
export class ChatComponent implements OnInit {

  constructor(public chatService: ChatService) {}
  msgDto:any;
  Userid =2;
  ngOnInit(): void {
    this.chatService.startConnection();
    this.chatService.addDataListener();
  }
  sendMessage(){

  }
  
  send(){
    const currentElememnt = document.getElementById("inputbox");
   const message :Message= {
     userId: 2,
     message: this.msgDto,
     traineeName: "Khaled",
     date: new Date()
   }

   this.chatService.SendMessage(message);
    






  }
}



