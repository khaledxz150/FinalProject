import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

// import { SharedRoutingModule } from './shared-routing.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgxSpinnerModule } from 'ngx-spinner';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import {MatCardModule} from '@angular/material/card';
import {MatTabsModule} from '@angular/material/tabs';
import {MatButtonModule} from '@angular/material/button';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatIconModule} from '@angular/material/icon';

import {AccordionModule} from 'primeng/accordion';     //accordion and accordion tab

import { HttpClientModule } from '@angular/common/http';
import { NgxSliderModule } from '@angular-slider/ngx-slider';
import { NgImageSliderModule } from 'ng-image-slider';

import {CarouselModule} from 'primeng/carousel';
import {ButtonModule} from 'primeng/button';
import {ToastModule} from 'primeng/toast';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import {ImageModule} from 'primeng/image';
import {MatExpansionModule} from '@angular/material/expansion';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {MatTableModule} from '@angular/material/table';

import { MatSelectModule } from '@angular/material/select';
import {MatDialogModule} from '@angular/material/dialog';
import {CardModule} from 'primeng/card';


import {PanelModule} from 'primeng/panel';

import {TabViewModule} from 'primeng/tabview';
import {MatRadioModule} from '@angular/material/radio';
import { DataTablesModule } from 'angular-datatables';
<<<<<<< HEAD
=======

import { MatTimepickerModule } from 'mat-timepicker';
>>>>>>> parent of a084abdf (Revert "Merge branch 'main' of https://github.com/khaledxz150/FinalProject")

import interactionPlugin from '@fullcalendar/interaction';
import dayGridPlugin from '@fullcalendar/daygrid';
import { MbscModule } from 'ack-angular-mobiscroll';
// Import ng-circle-progress
import { NgxProgressModule } from '@ngx-lite/progress';
import { NavbarComponent } from '../navbar/navbar.component';
import { FooterComponent } from '../footer/footer.component';
import { SharedRoutingModule } from './shared-routing.module';

import {TableModule} from 'primeng/table';
import {MatNativeDateModule} from '@angular/material/core';
import { FullCalendarModule } from '@fullcalendar/angular';
import { Ng2SearchPipeModule } from 'ng2-search-filter';


FullCalendarModule.registerPlugins([
  interactionPlugin,
  dayGridPlugin
]);


@NgModule({
  declarations: [
    NavbarComponent,
    FooterComponent
  ],
  imports: [
    MbscModule,
    FullCalendarModule,
    DataTablesModule,
    CommonModule,
    FormsModule,
    NgxSpinnerModule,
    MatFormFieldModule,
    ReactiveFormsModule,
    MatInputModule,
    MatProgressSpinnerModule,
    MatCardModule,
    MatButtonModule,
    MatToolbarModule,
    MatIconModule,
    AccordionModule,
    HttpClientModule,
    NgxSliderModule,
    NgImageSliderModule,
    CarouselModule,
    ButtonModule,
    ToastModule,
    FontAwesomeModule,
    ImageModule,
    MatTabsModule,
    MatExpansionModule, MatDatepickerModule,MatTableModule,
    MatSelectModule,
    MatDialogModule,
    CardModule,
    PanelModule,
    TabViewModule,
<<<<<<< HEAD
    MatRadioModule
=======
    MatRadioModule,
    MatNativeDateModule,
    MatTimepickerModule,
    Ng2SearchPipeModule,
    NgxProgressModule,
    SharedRoutingModule,
    TabViewModule,
    MatNativeDateModule
>>>>>>> parent of a084abdf (Revert "Merge branch 'main' of https://github.com/khaledxz150/FinalProject")

    ],
  exports:[
    FullCalendarModule,
    Ng2SearchPipeModule,
    DataTablesModule,
    CommonModule,
    FormsModule,
    NgxSpinnerModule,
    MatFormFieldModule,
    ReactiveFormsModule,
    MatInputModule,
    MatProgressSpinnerModule,
    MatCardModule,
    MatButtonModule,
    MatToolbarModule,
    MatIconModule,
    AccordionModule,
    HttpClientModule,
    NgxSliderModule,
    NgImageSliderModule,
    CarouselModule,
    ButtonModule,
    ToastModule,
    FontAwesomeModule,
    ImageModule,
    MatTabsModule,
<<<<<<< HEAD
    MatExpansionModule,
    MatDatepickerModule,
=======
    MatExpansionModule, MatDatepickerModule,
>>>>>>> parent of a084abdf (Revert "Merge branch 'main' of https://github.com/khaledxz150/FinalProject")
    MatTableModule,
    MatSelectModule,
    MatDialogModule,
    CardModule,
    PanelModule,
    TabViewModule,
<<<<<<< HEAD
    MatRadioModule
=======
    MatRadioModule,
    MatTimepickerModule,
    NgxProgressModule,
    NavbarComponent,
    FooterComponent,
    MatNativeDateModule
>>>>>>> parent of a084abdf (Revert "Merge branch 'main' of https://github.com/khaledxz150/FinalProject")
  ]
})
export class SharedModule { }
