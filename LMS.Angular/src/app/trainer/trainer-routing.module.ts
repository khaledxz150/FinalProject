import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SectionComponent } from './section/section.component';
import { UnitComponent } from './unit/unit.component';

const routes: Routes = [
  {
    path:'',
    component:SectionComponent
  },
  {
    path:'unit',
    component:UnitComponent
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TrainerRoutingModule { }
