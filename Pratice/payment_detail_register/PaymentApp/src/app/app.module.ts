import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { PaymentDetailsComponent } from './payment-details/payment-details.component';
import { PaymentDetailFormComponent } from './payment-details/payment-detail-form/payment-detail-form.component';

@NgModule({
  declarations: [
    PaymentDetailsComponent,
    PaymentDetailFormComponent,
  ],
  imports: [
    BrowserModule,
  ],
  bootstrap: [
    AppComponent,
  ],
})
export class AppModule { }
