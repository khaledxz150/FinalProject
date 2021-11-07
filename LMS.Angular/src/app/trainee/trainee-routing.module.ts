import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MyLeaningComponent } from './my-leaning/my-leaning.component';
import { ProfileComponent } from './profile/profile.component';
import { TraineeNavComponent } from './trainee-nav/trainee-nav.component';

const routes: Routes = [
  {
    path:''
    ,component:TraineeNavComponent
  },
  {
    path:'profile',
    component:ProfileComponent
  },
  {
    path:'learning',
    component:MyLeaningComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TraineeRoutingModule { }
