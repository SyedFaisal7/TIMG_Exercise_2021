import { HttpClient} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Order } from '../models/order';
import { OrderItem } from '../models/order-item';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  //baseapiurl: string = "http://localhost:7000/api/SMProducts";

  baseapiurl: string = environment.apiEndPoint + "Order";


  constructor(private http: HttpClient) { }


  getAllorders() { return this.http.get<Order[]>(this.baseapiurl + "/Orders"); }

  getOrderItems(orderId: number) { return this.http.get<OrderItem[]>(this.baseapiurl + "/OrderItem/" + orderId); }
}





