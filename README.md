# Loan Application Management System

A desktop-based application developed in C# using Windows Forms and MSSQL for managing personal loan applications. This project simulates real-world loan processes including customer data handling, guarantor information tracking, and application status management in a structured and user-friendly interface.

## 📌 Features

- Create, edit, list and delete loan applications
- Link customers and guarantors to each application
- Associate product and collateral (guarantee) details with each application
- Manage and edit product and collateral data with full CRUD operations
- Search applications by reference number or customer ID
- Validate input data and ensure data integrity with database integration
- Clean and responsive Windows Forms UI
- Repository Pattern used for data access separation

## 🛠️ Technologies Used

- C# (.NET Framework)
- Windows Forms (WinForms)
- Microsoft SQL Server (MSSQL)
- ADO.NET for database communication
- Object-Oriented Programming (OOP)
- Repository Pattern

## 🚀 Getting Started

1. Clone the repository:
    git clone https://github.com/yasincankaya/Credit-Application-Management-System.git

2. Open the solution in Visual Studio.

3. Set up your MSSQL database using the models and configure the connection string in all repositories.

4. Run the application.

## 📁 Project Structure

/Credit-Application-Management-System/
│
├── Models/                      # Data models (e.g., Customer, Application, Guarantor)
├── Repositories/                # Data access logic (ADO.NET with Repository Pattern)
├── bin/                         # Compiled binaries
├── obj/                         # Build files
├── Properties/                  # Project settings
│
├── Form1.cs                     # Main UI Form
├── Program.cs                   # Application entry point
│
├── *.Designer.cs / *.resx       # Form layout and resources

## 📄 License

This project is for academic and learning purposes. Feel free to fork and modify it.

---

Developed as part of a personal project to improve my skills in desktop application development and database integration.
