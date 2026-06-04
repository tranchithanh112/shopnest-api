# LỘ TRÌNH IT REMOTE — TRẦN CHÍ THÀNH
## Mục tiêu: Từ 20 triệu → Remote 1000-2000 USD (25-50 triệu)
## Thời gian: 8 tuần x 15 phút/ngày

---

## BẠN ĐANG Ở ĐÂU

- C# .NET backend, maintain project quản trị tàu
- Đang phụ thuộc AI khi code (vibe coding)
- Phỏng vấn chưa trả lời được
- NHƯNG: đã ship product thật, hiểu domain maritime, biết dùng AI tăng tốc
- .NET backend rất hot ở thị trường remote Âu-Mỹ, ít dev cạnh tranh

---

## SIDE PROJECT: 🎮 GAME QUẢN LÝ ĐỘI TÀU

Tưởng tượng bạn là chủ 1 công ty vận tải biển.
Bạn xây API backend để quản lý đội tàu của mình — mua tàu, điều tàu chạy tuyến,
tính nhiên liệu, theo dõi doanh thu, thuê/sa thải thuyền trưởng.

Vì sao project này hay:
- Có yếu tố GAME → thú vị, không nhàm chán
- Dùng domain maritime bạn đã hiểu → không mất thời gian tìm hiểu
- Áp dụng được TẤT CẢ concepts cần học (SOLID, DI, EF Core, JWT, REST API)
- Đẩy lên GitHub → portfolio CỰC MẠNH vì rất niche
- Có thể mở rộng dần: thêm tính năng mới mỗi tuần

### Các tính năng (làm từ từ, mỗi tuần thêm 1-2 cái):

**Tuần 1-2 (học SOLID + DI):**
- CRUD Vessels (tạo/sửa/xóa tàu) — tên, loại tàu, sức chứa, nhiên liệu
- CRUD Captains (thuyền trưởng) — tên, kinh nghiệm, lương
- Assign captain vào vessel
- Áp dụng: Clean Architecture, Dependency Injection, Interface

**Tuần 3-4 (học EF Core):**
- Voyages (chuyến đi) — tàu nào, từ cảng nào đến cảng nào, ngày đi/đến
- Tính fuel consumption theo khoảng cách + trọng tải
- Relationships: Vessel → Captain, Vessel → Voyages
- Áp dụng: EF Core relationships, migrations, LINQ queries

**Tuần 5-6 (học REST API + JWT):**
- User registration + login (JWT authentication)
- Mỗi user là 1 "công ty", quản lý đội tàu riêng
- Dashboard API: tổng tàu, tổng chuyến, tổng doanh thu, tàu đang rảnh
- Áp dụng: REST best practices, JWT, authorization

**Tuần 7-8 (SQL + hoàn thiện):**
- Revenue tracking — mỗi chuyến tàu tạo ra bao nhiêu tiền
- Leaderboard API — xếp hạng công ty theo doanh thu
- Statistics API — thống kê theo tháng, theo tuyến, theo loại tàu
- Áp dụng: SQL queries phức tạp, GROUP BY, aggregation

**Bonus (nếu hứng thú):**
- Tích hợp AI: gợi ý tuyến đường tối ưu, dự đoán chi phí
- Real-time notification khi tàu đến cảng
- Deploy lên Azure free tier
- Swagger documentation đẹp

---

## KẾ HOẠCH HỌC CHI TIẾT

### Tuần 1-2: SOLID + Dependency Injection

**Ngày 1:** Video "Dependency Injection .NET" — 15 phút
  → Hiểu: Scoped, Transient, Singleton khác nhau thế nào

**Ngày 2:** Tạo project .NET 8, setup Clean Architecture cơ bản
  → Tách folders: API / Application / Domain / Infrastructure

**Ngày 3:** Tạo Vessel entity + IVesselRepository interface + VesselService
  → Áp dụng: Dependency Inversion (chữ D)

**Ngày 4:** Nghỉ 🧠

**Ngày 5:** Tạo Captain entity, assign vào Vessel
  → Áp dụng: Single Responsibility (mỗi service 1 việc)

**Ngày 6-7:** Nghỉ / review code đã viết

### Tuần 3-4: Entity Framework Core

**Ngày 1:** Video "EF Core Relationships" — 15 phút
**Ngày 2:** Setup EF Core, tạo DbContext, migration đầu tiên
**Ngày 3:** Tạo Voyage entity, relationship Vessel → Voyages (One-to-Many)
**Ngày 4:** Nghỉ 🧠
**Ngày 5:** Viết query LINQ: lấy tất cả voyages của 1 vessel, tính tổng fuel
**Ngày 6-7:** Nghỉ / review

### Tuần 5-6: REST API + JWT Authentication

**Ngày 1:** Video "REST API Best Practices" — 15 phút
**Ngày 2:** Chuẩn hóa lại endpoints (GET/POST/PUT/DELETE đúng chuẩn)
**Ngày 3:** Video "JWT Authentication .NET" — 15 phút
**Ngày 4:** Nghỉ 🧠
**Ngày 5:** Implement JWT login/register, protect endpoints
**Ngày 6-7:** Nghỉ / review

### Tuần 7-8: SQL + Dashboard + Mock Interview

**Ngày 1:** sqlbolt.com — 5 bài SQL (JOIN, GROUP BY)
**Ngày 2:** Viết Revenue tracking + Statistics API
**Ngày 3:** sqlbolt.com — 5 bài SQL tiếp (subquery, aggregation)
**Ngày 4:** Nghỉ 🧠
**Ngày 5:** Mock interview với Claude: "Phỏng vấn tôi .NET backend junior-mid, 5 câu"
**Ngày 6-7:** Fix câu trượt, hoàn thiện README trên GitHub

---

## QUY TẮC CHỐNG QUÊN

1. **Học → code ngay vào project** (không học suông)
2. **Học 3 ngày, nghỉ 1 ngày** (não cần nghỉ để nhớ)
3. **Cuối tuần viết 3-5 dòng tóm tắt** (viết = nhớ x3)
4. **Vẫn dùng AI, nhưng TỰ NGHĨ 2 PHÚT trước** rồi mới hỏi

---

## SAU 8 TUẦN → APPLY

### Nền tảng:
- **LinkedIn** — bật Open to Work, filter remote .NET
- **Turing.com** — test đầu vào, match job remote Mỹ
- **Toptal** — khó hơn, lương cao (3000-6000 USD)
- **RemoteOK, WeWorkRemotely**
- **Upwork** — freelance nhỏ ban đầu để có review

### Mục tiêu thực tế:
- Job đầu tiên: 1000-1500 USD/tháng (25-37 triệu)
- Sau 1 năm remote: 2000-3000 USD/tháng (50-75 triệu)

---

## SOLID — ĐÃ HỌC NGÀY 1 ✅

- **S** — 1 class, 1 lý do thay đổi
- **O** — Mở rộng bằng code mới, không sửa code cũ
- **L** — Class con thay class cha, chương trình vẫn chạy đúng
- **I** — Tách interface nhỏ, đừng ép implement thừa
- **D** — Phụ thuộc vào interface, không phụ thuộc class cụ thể

---

## CHECKLIST

### Tuần này:
- [x] Xem SOLID ✅
- [ ] Xem Dependency Injection — 15 phút
- [ ] Tạo repo GitHub: fleet-commander-api (hoặc tên bạn thích)
- [ ] Setup .NET 8 project, tách folders Clean Architecture
- [ ] Tạo Vessel entity + IVesselRepository

### Ghi nhớ:
> "15 phút/ngày. Không hơn. Không kém. Kiên trì 8 tuần."
> "Dùng AI được, nhưng tự nghĩ 2 phút trước."
> "Mỗi concept học xong → code ngay vào project → không quên."
