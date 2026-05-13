# 🛒 E-Ticaret API

ASP.NET Core 8 ve Clean Architecture prensipleri kullanılarak geliştirilmiş modern bir e-ticaret backend projesidir.

Bu proje; kullanıcı, kategori, ürün ve sipariş yönetimini, CQRS deseni ve katmanlı mimari ile birlikte ele alır.

---

## 🚀 Kullanılan Teknolojiler

* ASP.NET Core 8
* Entity Framework Core
* MSSQL
* MediatR (CQRS)
* Swagger UI
* Clean Architecture

---

## 📦 Projede Gerçekleştirilenler

* Kullanıcı, ürün, kategori ve sipariş yönetimi geliştirildi
* CQRS pattern kullanılarak Command ve Query ayrımı yapıldı
* MediatR ile katmanlar arası bağımlılık azaltıldı
* Clean Architecture (API, Application, Domain, Infrastructure) yapısı kuruldu
* Entity ilişkileri oluşturuldu (User - Order - Product - Category)
* Sipariş oluşturma sürecinde iş kuralları (business logic) uygulandı
* Ürün bazlı sipariş sistemi geliştirildi
* Sipariş toplam tutarı otomatik olarak hesaplandı
* Repository pattern ile veri erişim katmanı soyutlandı
* RESTful API endpointleri oluşturuldu
* Swagger ile API test edilebilir hale getirildi

---

## 🧠 Mimari

Controller
   ↓
Command / Query
   ↓
Handler
   ↓
Domain (iş kuralları)
   ↓
Repository
   ↓
Database

---

## 👩‍💻 Geliştirici

Melek Gürel
