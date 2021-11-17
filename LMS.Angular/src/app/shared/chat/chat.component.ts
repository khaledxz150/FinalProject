import { Component, NgZone, OnInit } from '@angular/core';
import { ChatService } from 'src/app/Service/chat.service';

@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.css']
})
export class ChatComponent implements OnInit {

  constructor(private chatService: ChatService) {}

  ngOnInit(): void {
    this.chatService.startConnection();
    this.chatService.addDataListener();
  }
  sendMessage(){
    this.chatService.hubConnection!.invoke("SendRequest", [1, "p1"]);
  }
}



