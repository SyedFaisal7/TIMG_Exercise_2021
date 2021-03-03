import { Component, OnInit } from '@angular/core';
import { Order } from '../../models/order';
import { OrderItem } from '../../models/order-item';
import { ApiService } from '../../service/api.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styles: [
  ]
})
export class HomeComponent implements OnInit {

  public Allorder: Order[] = [];
  public AllOrderItem: OrderItem[] = [];
  public search: string;
  public p: number=0;

  constructor(private api: ApiService) { }

  ngOnInit(): void {
    this.getOrder();

  }

  getOrder() {
    this.api.getAllorders()
      .subscribe(
        res => { this.Allorder = <Order[]>res; console.log(this.Allorder); },
        err => { } ,
        () => { }
      );
  }

  OrderItem(orderId: number) {
    this.api.getOrderItems(orderId)
      .subscribe(
        res => { this.AllOrderItem = <OrderItem[]>res; console.log(this.AllOrderItem); },
        err => { },
        () => { }
      );
  }

}
