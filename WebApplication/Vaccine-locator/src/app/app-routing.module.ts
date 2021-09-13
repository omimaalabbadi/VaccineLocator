import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AddAlertsComponent } from "./add-alerts/add-alerts.component";
import { AddcenterComponent } from "./addcenter/addcenter.component";
import { DetailsComponent } from "./details/details.component";
import { FAQComponent } from "./FAQ/FAQ.component";
import { HomeComponent } from "./home/home.component";

const routes: Routes = [
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: 'home', component: HomeComponent },
    { path: 'directions', component: DetailsComponent },
    { path: 'addcenter', component: AddcenterComponent  },
    { path: 'FAQ', component: FAQComponent },
    { path: 'add-alerts', component: AddAlertsComponent },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
