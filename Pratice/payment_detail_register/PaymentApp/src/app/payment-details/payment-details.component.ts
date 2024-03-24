import { Component, OnInit } from '@angular/core';
import { PaymentDetailService } from '../shared/payment-detail.service';
import { error } from 'console';

@Component({
  selector: 'app-payment-details',
  templateUrl: './payment-details.component.html',
  styles: [

  ]
})
export class PaymentDetailsComponent {
  constructor(public service: PaymentDetailService){

  }

  ngOnInit(): void{
    this.service.refreshList();
  }
}
