# DeCil
Decord products shop. ReactJS, ASP.NET Core, Entity FrameWork, SQL Server, NodeJs, MongoDB

# git commit convention:
- feat: thêm một feature
- fix: fix bug cho hệ thống, vá lỗi trong codebase
- refactor: sửa code nhưng không fix bug cũng không thêm feature hoặc đôi khi bug cũng được fix từ việc refactor.
- doc: thêm/thay đổi document
- chore: những sửa đổi nhỏ nhặt không liên quan tới code
- style: những thay đổi không làm thay đổi ý nghĩa của code như thay đổi css/ui chẳng hạn.
- perf: code cải tiến về mặt hiệu năng xử lý
- vendor: cập nhật version cho các dependencies, packages.

# ASP.NET MVC:
- dotnet new webapi --use-controllers -o TodoApi
- dotnet dev-certs https --trust

# Microservices:
- order flow: ThanhToanClick() -> create order -> create bank bill and get id -> create payment for bill -> user pay -> get bill status from bank -> update payment status -> update order status

- Order services: publish orderCreated event, listen to billPaid event.
- Payment services: publish billPaid event, listent to orderCreated event
- case 1: user dont pay : after 15 minute redirect to order info
- case 2: user paid, every thing okay, redirect to order info
    - use http pending or socket tới payment service
- case 3: user paid, payment services crash. thống báo tới người mua, kiểm tra các giao dịch ngân hàng khi service khởi động lại.


# Scafford a controller

# Entity framword

