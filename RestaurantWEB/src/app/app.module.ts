import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { OrdersComponent } from './orders/orders.component';
import { OrderComponent } from './orders/order/order.component';
import { OrderItemsComponent } from './orders/order-items/order-items.component';

@NgModule({
  declarations: [
    OrdersComponent,
    OrderComponent,
    OrderItemsComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [OrdersComponent]
})
export class AppModule { }
