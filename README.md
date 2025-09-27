# Đậu Văn Khánh - K225480106099
# K58KTP - Môn: Phát triển ứng dụng trên nền web
# BÀI TẬP VỀ NHÀ 01: TẠO SOLUTION GỒM CÁC PROJECT SAU:
## 1. DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).
## 2. Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE
## 3. Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE
## 4. Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.

# BÀI LÀM:
## 1. Tạo DLL đa năng, keyword: c# window library -> Class Library (.NET Framework)

<img width="1265" height="831" alt="image" src="https://github.com/user-attachments/assets/201d0c0d-01ad-4054-a150-e6e2b99d4f35" />

- Trong Visual Studio 2022, tìm Class Library -> nhấn Next.

- Sau khi nhấn Next, nó sẽ hiện ra cửa sổ sau:
<img width="1261" height="840" alt="image" src="https://github.com/user-attachments/assets/53386bcc-dea5-4aa0-9e83-8e068b0548a6" />

- Trong cửa sổ cần đặt tên Project và Location (nơi lưu project) -> nhấn Create
- Sau đó Visual Studio sẽ tạo sẵn một file Class1.cs (có thể đổi tên nếu muốn), rồi tiến hành viết code

<img width="1920" height="1200" alt="Screenshot 2025-09-27 204011" src="https://github.com/user-attachments/assets/9f02853f-b8b5-49d8-8612-a92ac479fddb" />

- Chú ý: Tất cả các class và hàm muốn cho project khác sử dụng phải để public.
- Sau khi viết code xong, ta nhấn Build trên thanh công cụ -> Build Solution (hoặc Ctrl + Shift + B).
- Sau khi Build xong, sẽ có file SnakeClassLibrary.dll
<img width="768" height="42" alt="image" src="https://github.com/user-attachments/assets/57c64d16-51fa-470b-9dbf-45b751ddf508" />
