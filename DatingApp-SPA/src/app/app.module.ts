import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ValueComponent } from './value/value.component';

import {HttpClientModule} from '@angular/common/http'; /*Import*/

@NgModule({
   declarations: [
      AppComponent,
      ValueComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule      /*Import, for us to have http GET request from server*/
   ],
   providers: [],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
