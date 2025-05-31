
# 🏫 Enrolment & Billing System (VB.NET)

A comprehensive desktop application developed using **Visual Basic .NET (VB.NET)** to handle **student enrolment**, **billing**, and **payment tracking**. Suitable for schools, academies, or training institutes.

---

## ✨ Features

- 👨‍🎓 Student enrolment with full personal details
- 💵 Billing module with fee setup and invoice generation
- 🧾 Payment history tracking
- 📝 Generate receipts and reports
- 🏫 Manage courses, batches, or academic terms
- 🔐 Login authentication (if implemented)
- 📁 Stores data using Microsoft Access or SQL Server

---

## 🛠️ Tech Stack

- **VB.NET (.NET Framework)**
- **Windows Forms** (WinForms GUI)
- **Microsoft Access (.mdb/.accdb)** or **SQL Server** (database)
- **Crystal Reports** or built-in reporting (if used)
- **ADO.NET** for database interaction

---

## 🖥️ How to Run

1. Open the `.sln` or `.vbproj` file in **Visual Studio**.
2. Restore any missing references if prompted.
3. Build the project (`Ctrl + Shift + B`).
4. Run the application (`F5` or click ▶ Start).
5. Ensure your database file is in the correct directory or the connection string is updated in `App.config`.

---

## 📁 Typical Project Structure

```
EnrolmentBillingSystem/
├── EnrolmentBillingSystem.vbproj      # Main project file
├── frmMain.vb                         # Main dashboard or navigation
├── frmStudent.vb                      # Enrolment form
├── frmBilling.vb                      # Billing and invoice form
├── frmPayment.vb                      # Payment tracking form
├── Database/EnrolmentDB.mdb           # MS Access database (example)
├── App.config                         # Database connection settings
└── README.md
```

---

## ✅ TODO

- [ ] Add user roles (admin, cashier, registrar)
- [ ] Export reports to PDF
- [ ] Add backup/restore functionality
- [ ] Support for online enrolment

---

## 📃 License

This project is licensed under the **MIT License**.

---

> Crafted with 💼 and ❤️ using VB.NET & WinForms
