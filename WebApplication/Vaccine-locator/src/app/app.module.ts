import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FAQComponent } from './FAQ/FAQ.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { HomeComponent } from './home/home.component';
import { FormsModule } from '@angular/forms';
import { DetailsComponent } from './details/details.component';
import { AddcenterComponent } from './addcenter/addcenter.component';
import { AppService } from './app-service.service';
import { HttpClientModule } from '@angular/common/http';
import { GoogleMapsModule } from '@angular/google-maps'

@NgModule({
    imports: [
        BrowserModule,
        AppRoutingModule,
        FormsModule,
        HttpClientModule,
        GoogleMapsModule
    ],
    declarations: [
        AppComponent,
        NavBarComponent,
        FAQComponent,
        HomeComponent,
        DetailsComponent,
        AddcenterComponent
    ],
    providers: [
        AppService
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }
