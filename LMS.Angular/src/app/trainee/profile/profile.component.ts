import { Component, OnInit } from '@angular/core';
import { ProfileService } from 'src/app/Service/profile.service';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css',
  '../../../assets/css/default.css',
  '../../../assets/css/slick.css',
  '../../../assets/css/style.css'
,'../../../assets/css/animate.css',
]
})
export class ProfileComponent implements OnInit {

  constructor(public profileService:ProfileService) { }

  ngOnInit(): void {
    debugger
    let user:any = localStorage.getItem('user');
    let trainee = JSON.parse(user);
    var trainerId = parseInt(trainee.TraineeId)
    //  if(traineeId){
    //  }
    debugger
    this.profileService.GetMyProfile(parseInt(trainee.TraineeId))
  }
  FileSrc: string | undefined;
  Uploadfile(event: any ) {
    const reader = new FileReader();
     console.log(event.target.value)
    if (event.target.files && event.target.files.length) {
      const [file] = event.target.files;
      reader.readAsDataURL(file);

      reader.onload = () => {
        this.FileSrc = reader.result as string;
        console.log(this.FileSrc)



    }

  }
   }

}
