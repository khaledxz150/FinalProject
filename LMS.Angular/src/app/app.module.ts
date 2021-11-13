import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common';  

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { PipelinePipe } from './Pipeline/pipeline.pipe';
import { SharedModule } from './shared/shared.module';
import { FooterComponent } from './footer/footer.component';
import { NavbarComponent } from './navbar/navbar.component';
import { NgHttpLoaderModule } from 'ng-http-loader';

import { ToastrModule } from 'ngx-toastr';

import { DeleteTrainerComponent } from './admin/trainer-info/delete-trainer/delete-trainer.component';
import { AddTrainerComponent } from './admin/trainer-info/add-trainer/add-trainer.component';
import { EditTrainerComponent } from './admin/trainer-info/edit-trainer/edit-trainer.component';
import { AlertDialogComponent } from './alert-dialog/alert-dialog.component';

@NgModule({
  declarations: [
    AppComponent,
    PipelinePipe,
    AddTrainerComponent,
    EditTrainerComponent,
    DeleteTrainerComponent,
    AlertDialogComponent,
    // FooterComponent,
    // NavbarComponent,

    

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    SharedModule,
    NgHttpLoaderModule.forRoot(),
    ToastrModule.forRoot(),
    CommonModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
