import { Order } from "./order"
import { Product } from "./product"

export class OrderItem {

  orderItemId: number
  productCode: string 
  product:Product
  quantity: number
  totalPrice: number
  orderId: number
  order:Order

}
