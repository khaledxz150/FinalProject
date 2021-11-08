import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminModule } from './admin/admin.module';
import { AuthenticationModule } from './authentication/authentication.module';
import { ContactusComponent } from './pages/contactus/contactus.component';
import { HomeComponent } from './pages/home/home.component';
import { PagesModule } from './pages/pages.module';
import { TraineeModule } from './trainee/trainee.module';

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
    path:'client',
    loadChildren:()=>TraineeModule
  }
  ,{
    path:'auth',
    loadChildren:()=>AuthenticationModule
  }
  ,{
    path:'admin',
    loadChildren:()=>AdminModule
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
