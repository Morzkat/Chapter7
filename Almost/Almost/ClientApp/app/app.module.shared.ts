//Angular Components
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule, Routes } from '@angular/router';

//App Components
import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { HistoriesComponent } from './components/histories/histories.component';

//App Services
import { HistoriesService } from './services/histories.services';

//App Routes
const appRoutes:Routes =
[
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: 'home', component: HomeComponent },
    { path: 'histories', component: HistoriesComponent },
    { path: '**', redirectTo: 'home' }
]

@NgModule({
    declarations: 
    [
        AppComponent,
        NavMenuComponent,
        HistoriesComponent,
        HomeComponent
    ],

    imports: 
    [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot(appRoutes)
    ],

    providers:
    [
        HistoriesService
    ]
})
export class AppModuleShared {}
