
[] category có phân cấp
[] chỉ có thể review sau khi mua hàng
[] chỉ saler hoặc admin hoặc người review có thể trả lời review
[] product có nhiều attribute, mỗi product attribute có mức giá thêm, hình ảnh, có 2 loại attribute cơ bản là size và color. có thể thêm sau này
[] khi thêm product, cần chọn category, thêm attribute, giá và hình ảnh cho attribute, thêm nhiều hình ảnh, khi chọn attribute có thể chọn hình ảnh đã thêm hoặc thêm mới hình ảnh
[] có thể thêm / xóa / sửa discount trong inventory
[] discount có 2 loại: giảm theo phần trăm hoặc giảm trực tiếp.
[] cửa hàng có thể thêm product vào inventory (thêm nhưng không bán)
[] Khi bán hàng, cần tạo gian hàng (booth), gian hàng có 1 hoặc nhiều sản phẩm. (có thể extend usecase thêm sản phẩm)
[] khi mua hàng, có thể chọn sản phẩm, số lượng, attribute
[] khách hàng có thể nhấn thêm vào cart, hoặc mua ngay (hệ thống tự động thêm vào cart và tới mục thanh toán).
[] nếu khách hàng hủy, hỏi khách hàng có muốn xóa khỏi giỏ hàng không. thêm tính năng ghi nhớ lựa chọn. thay đổi ở cài đặt. (lưu vào web storage)

[] voucher có áp dụng cho order cũng có 2 loại giảm giá, có một hoặc nhiều condition
[] voucher condition bao gồm: no condition, min price, product category

[] hệ thống tìm kiếm dựa theo tên sản phẩm và loại sản phẩm, sử dụng python 
[] hệ thống gợi ý dựa theo cart và order của người dùng, sử dụng python

[] khi khách hàng nhân thanh toán, hiển thị màn hình thanh toán bao gồm, giá tiền, QR code.
[] khi khách hàng thanh toán, cần check số tiền trong order.
[] khi thanh toán hoàn tất, màn hình hiển thị thống báo và redirect tới trang thông tin đơn hàng.

[] tạo backgroundjob chạy hàng ngày check trạng thái đơn hàng theo mã vận chuyển và đơn vị vận chuyển.

