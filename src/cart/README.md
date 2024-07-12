## API
- PUT /cart/update
- POST /cart/add
- GET /cart
- DELETE /cart/remove/{product_id}
- DELETE /cart/clear

- GET /cart/total
- POST /cart/checkout: Thực hiện thanh toán cho các sản phẩm trong giỏ hàng của người dùng. Có thể bao gồm xác nhận đơn hàng, xử lý thanh toán và cập nhật trạng thái đơn hàng.

- GET /cart/session
- GET /cart/session/{session_id}
- DELETE /cart/session/{session_id} 
- PUT /cart/shipping-address
- GET /cart/shipping-address