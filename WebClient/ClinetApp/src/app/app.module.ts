import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { SharedModule } from "./shared/shared.module";
import { HomeModule } from "./home/home.module";
import { UserRegistrationModule } from "./user-registration/user-registration.module";

@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,
    SharedModule,
    HomeModule,
    UserRegistrationModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}
