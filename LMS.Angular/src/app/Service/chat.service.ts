import { Injectable, OnInit } from '@angular/core';
import * as signalR from '@microsoft/signalr';          // import signalR
import { HttpClient } from '@angular/common/http';
import { Observable, Subject } from 'rxjs';
import { Message } from '../models/Message';
import { HttpClientModule } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ChatService {
 connection:signalR.HubConnection | undefined;
  data: Message | undefined;

 public hubConnection: signalR.HubConnection | undefined

 

   startConnection() {
     this.hubConnection = 
     new 
  signalR.HubConnectionBuilder() 
 // This url must point to your back-end hub                        
 .withUrl('http://localhost:54921/chatsocke') 
 .build();
 
     this.hubConnection
       .start()
       .then(() => console.log('Connection started'))
       .catch(err => console.log('Error while starting connection: ' + err))
   }
 
   addDataListener()  {
     this.hubConnection!.on('ReceiveOne', (data,data2) => {
       debugger
       console.log(data, data2);
     });
   }
 }
