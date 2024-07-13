# DeCil
Decord products shop. ReactJS, ASP.NET Core, Entity FrameWork, SQL Server, NodeJs, MongoDB

# git commit convention:
- feat: thêm một feature
- fix: fix bug cho hệ thống, vá lỗi trong codebase
- refactor: sửa code nhưng không fix bug cũng không thêm feature hoặc đôi khi bug cũng được fix từ việc refactor.
- docs: thêm/thay đổi document
- chore: những sửa đổi nhỏ nhặt không liên quan tới code
- style: những thay đổi không làm thay đổi ý nghĩa của code như thay đổi css/ui chẳng hạn.
- perf: code cải tiến về mặt hiệu năng xử lý
- vendor: cập nhật version cho các dependencies, packages.

# ASP.NET MVC:
- dotnet new webapi --use-controllers -o TodoApi
- dotnet dev-certs https --trust

# Segregate the APIs:
1. APIs for product catalog and cart
2. APIs for payment
3. APIs for customer  
* Duplicate tables if it's neccessary to imporve performance

# Scafford a controller

# Entity framword

