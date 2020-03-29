import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { UserComponent } from "./user/user.component";
import { RegistrationComponent } from "./registration/registration.component";
import { AppRoutingModule } from "../app-routing.module";
import { SharedModule } from "../shared/shared.module";

@NgModule({
  declarations: [UserComponent, RegistrationComponent],
  imports: [CommonModule, SharedModule, AppRoutingModule],
  exports: [UserComponent, RegistrationComponent]
})
export class UserRegistrationModule {}
