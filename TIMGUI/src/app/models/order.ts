import { Client } from "./client"
import { OrderItem } from "./order-item"

export class Order {
  orderId: number
  clientId: number 
  clientName: string
  client:Client 
  orderDate :Date
  gst: number
  total: number
  orderItems: OrderItem
}
