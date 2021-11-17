import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AccountantModule } from './accountant/accountant.module';
import { AdminModule } from './admin/admin.module';
import { AuthenticationModule } from './authentication/authentication.module';
import { AuthorizationGuard } from './guard/authorization.guard';
import { ContactusComponent } from './pages/contactus/contactus.component';
import { HomeComponent } from './pages/home/home.component';
import { PagesModule } from './pages/pages.module';
import { PaymantModule } from './paymant/paymant.module';
import { TraineeModule } from './trainee/trainee.module';
import { TrainerModule } from './trainer/trainer.module';

const routes: Routes = [
  {
    path:'',
    redirectTo:'pages',
    pathMatch:'full'
  },
  {
    path:'pages',
    loadChildren: ()=>PagesModule
  }
  ,{
    path:'paypal',
    loadChildren:()=>PaymantModule
  }
  ,{
    path:'trainee',
    loadChildren:()=>TraineeModule
  }
  ,{
    path:'auth',
    loadChildren:()=>AuthenticationModule
  }
  ,{
    path:'admin',
    loadChildren:()=>AdminModule,
    canActivate: [AuthorizationGuard]
  },
  {
    path:'trainer',
    loadChildren:()=>TrainerModule,
    canActivate: [AuthorizationGuard]
  }
  ,
  {
    path:'accountant',
    loadChildren:()=>AccountantModule,
    canActivate: [AuthorizationGuard]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
