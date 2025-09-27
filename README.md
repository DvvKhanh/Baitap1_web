# Đậu Văn Khánh - K225480106099
# K58KTP - Môn: Phát triển ứng dụng trên nền web
# BÀI TẬP VỀ NHÀ 01: TẠO SOLUTION GỒM CÁC PROJECT SAU:
## 1. DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).
## 2. Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE
## 3. Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE
## 4. Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.

# BÀI LÀM:
## 1. Tạo DLL đa năng, keyword: c# window library -> Class Library (.NET Framework)

- Mục tiêu: Tạo một DLL để xử lý toàn bộ logic của game Snake: quản lý rắn, thức ăn, di chuyển, tính điểm…
- Trong Visual Studio 2022, tìm và chọn Class Library -> nhấn Next.

<img width="1265" height="831" alt="image" src="https://github.com/user-attachments/assets/201d0c0d-01ad-4054-a150-e6e2b99d4f35" />

- Sau khi nhấn Next, nó sẽ hiện ra cửa sổ sau:
<img width="1261" height="840" alt="image" src="https://github.com/user-attachments/assets/53386bcc-dea5-4aa0-9e83-8e068b0548a6" />

- Trong cửa sổ cần đặt tên Project và Location (nơi lưu project) -> nhấn Create
- Sau đó Visual Studio sẽ tạo sẵn một file Class1.cs (có thể đổi tên nếu muốn), rồi tiến hành viết code

<img width="1920" height="1200" alt="Screenshot 2025-09-27 204011" src="https://github.com/user-attachments/assets/9f02853f-b8b5-49d8-8612-a92ac479fddb" />

- Chú ý: Tất cả các class và hàm muốn cho project khác sử dụng phải để public.
- Sau khi viết code xong, ta nhấn Build trên thanh công cụ -> Build Solution (hoặc Ctrl + Shift + B).
- Sau khi Build xong, sẽ có file SnakeClassLibrary.dll
<img width="768" height="42" alt="image" src="https://github.com/user-attachments/assets/57c64d16-51fa-470b-9dbf-45b751ddf508" />

## 2. Tạo Console app, sử dụng .NET Framework 2.0 và sử dụng được DLL trên:
- Mục tiêu: Dùng DLL để chơi Snake trên màn hình dòng lệnh (đen sì).
- Trong Solution -> chuột phải chọn Add -> chọn New project

<img width="1920" height="1200" alt="image" src="https://github.com/user-attachments/assets/6ebc935b-db01-422e-89f7-0d10af1c923b" />

- Sau đó tìm và chọn Console App (.NET Framework) -> nhấn Next

<img width="1245" height="818" alt="image" src="https://github.com/user-attachments/assets/456d53dd-c6ab-4f40-9eeb-ce93c270c3bb" />

- Sau đó tiến hành đặt tên project -> nhấn Create
- Khi tạo xong thì sẽ xuất hiện file Program.cs -> tiến hành viết code trong file Program.cs

<img width="1920" height="1200" alt="image" src="https://github.com/user-attachments/assets/1d5b3a7d-56af-4f70-998f-2ff758a1f9ef" />

- Khi viết code xong cần tham chiếu đến DLL: nhấn chuột phải References trong Console App → Add Reference… → Browse → chọn file SnakeClassLibrary.dll -> nhấn OK

<img width="979" height="674" alt="image" src="https://github.com/user-attachments/assets/6e5ea40e-71c6-4077-8f8b-2dec92e19b9b" />

- Sau khi tham chiếu đến DLL xong, thì tiến hành Build → Build Solution (Ctrl+Shift+B). Chạy bằng F5 (debug) hoặc Ctrl+F5 (run without debug).

## 3. Windows Form Application
- Mục tiêu: Xây dựng giao diện cửa sổ để chơi Snake.
- Trong Solution -> chuột phải chọn Add -> chọn New project

- Tạo project: cần tìm và chọn Windows Forms App (.NET Framework) -> Next

<img width="1260" height="837" alt="image" src="https://github.com/user-attachments/assets/7311b12a-6207-4d44-9660-651e73e4d0d0" />

- Sau đó tiến hành đặt tên project -> nhấn Create

- Sau khi tạo xong, chuột phải References → Add Reference… → Browse → chọn file SnakeClassLibrary.dll -> nhấn OK

<img width="975" height="674" alt="image" src="https://github.com/user-attachments/assets/570a553b-8121-47b2-8e37-0d3096740008" />

- Để thiết kế giao diện game, mở Form1.cs trong Design: trên thanh công cụ chọn View -> Toolbox rồi kéo Panel (vùng vẽ bàn chơi), Button (Start/Restart), Label (Hiển thị điểm).

<img width="1920" height="1200" alt="image" src="https://github.com/user-attachments/assets/e949b088-7528-4439-a280-c0301a194286" />

- 
