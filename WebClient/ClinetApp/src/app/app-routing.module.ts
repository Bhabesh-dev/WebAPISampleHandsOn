import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { DashboardComponent } from "./home/dashboard/dashboard.component";
import { RegistrationComponent } from "./user-registration/registration/registration.component";
import { UserRegistrationModule } from "./user-registration/user-registration.module";

const routes: Routes = [
  { path: "", component: DashboardComponent },

  { path: "home", component: DashboardComponent },
  { path: "register", redirectTo: "./user/registration.component" }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
