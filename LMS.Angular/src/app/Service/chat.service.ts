import { Injectable, OnInit } from '@angular/core';
import * as signalR from '@microsoft/signalr';          // import signalR
import { HttpClient } from '@angular/common/http';
import { Message } from '../models/Message';

import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { environment } from 'src/environments/environment';
import { DomSanitizer } from '@angular/platform-browser';

@Injectable({
  providedIn: 'root'
})
export class ChatService {
 connection:signalR.HubConnection | undefined;
  data: Message [] = [];
 public hubConnection: signalR.HubConnection | undefined;

 constructor(private http: HttpClient,private toastr:ToastrService, private spinner: NgxSpinnerService,private router:Router,
  private sanitizer: DomSanitizer) { }

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
     this.hubConnection!.on('ReceiveOne', (message: Message) => {
      this.data.push(message);
     });
   }
   SendMessage(msg: Message) {
    this.http.post(environment.apiUrl + 'chat/send',msg).subscribe((res:any)=>{
    },err=>{
     console.log("no message has been sent")
    })


   }
 }
