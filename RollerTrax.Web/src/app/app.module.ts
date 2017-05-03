import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { HeroDetailComponent } from './hero-detail.component';
import { HeroesComponent } from './heroes.component'
import { HeroService } from './hero.service'
import { DashboardComponent } from './dashboard.component'
import { TrackList } from './track-list.component'

@NgModule({

    imports: [
        BrowserModule,
        FormsModule,
        AppRoutingModule,
        HttpModule
    ],

    declarations: [
        AppComponent,
        DashboardComponent,
        HeroDetailComponent,
        HeroesComponent,
        TrackList
    ],

    bootstrap: [AppComponent],
    providers: [HeroService],

})
export class AppModule { }
