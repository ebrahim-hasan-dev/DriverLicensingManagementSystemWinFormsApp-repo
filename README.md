# 🚗 Driver Licensing Management System (DLMS)

A professional, medium-scale ERP desktop application designed to automate and manage the process of issuing, renewing, and tracking driver licenses. Built with a focus on high-performance database management and a scalable **4-Tier Architecture**.

---

## 🏗 System Architecture

The project follows a strict **4-Tier Architecture** to ensure separation of concerns, maintainability, and scalability.

1.  **Presentation Layer (Windows Forms App):** Handles UI/UX and user interaction.
    *   *Dependencies:* Business Layer, Modules.
2.  **Business Layer (Class Library):** Contains the core logic, CRUD operations, and business rules.
    *   *Dependencies:* Data Access Layer, Modules.
3.  **Data Access Layer (Class Library):** Manages all direct communication with SQL Server via ADO.NET.
    *   *Dependencies:* Modules.
4.  **Modules Layer (Class Library):** A global project containing all shared entities/classes (no business logic).
    *   *Dependencies:* None (Independent).

---

## 🛠 Tech Stack & Tools

*   **Language/Framework:** C# (.NET Framework)
*   **Database:** SQL Server (SSMS 22)
*   **Data Access:** ADO.NET (Fully Parameterized)
*   **UI/UX:** Windows Forms with **Professional Custom User Controls**
*   **Design Tools:** 
    *   **ERDPlus:** For ERD and Relational Schema design.
    *   **dbdiagram.io:** For advanced relational schema visualization and practice.
*   **IDE:** Visual Studio 2022

---

## 🌟 Key Features & Services

### 📋 Application Management
*   **First-Time License:** Multi-stage process including Vision, Theory, and Practical tests.
*   **Renewal & Replacement:** Services for expired, lost, or damaged licenses, and in the case of renewing an expired license, the applicant must pass an vision test.
*   **International Licenses:** Issuance for valid domestic Class 3 license holders.
*   **Detain/Release System:** Managing license seizures and fine payments.
*   **Retake Test:** The system allows for retaking any type of test in case of failure, whether when renewing the license or when obtaining the license for the first time, with payment of the retake test fee, and this is done using the original application number.
*   **Searching:** The system allows you to use a filter system for faster searching, including applications, licenses, people, and users.

### 👤 Administration & Security
*   **User Management:** Advanced CRUD with account activation/deactivation and login logging.
*   **Person Management:** Advanced CRUD with unique National ID tracking to prevent data duplication.
*   **Settings Management:** Dynamic adjustment of application fees, test prices, and license validity.

---

## ⚙️ Technical Highlights

### 💻 Programming Excellence
*   **Custom User Controls:** Extensively used to prevent code repetition (DRY Principle) and improve UI consistency.
*   **Events & Delegates:** High-level implementation of custom events to handle communication between forms and controls efficiently.
*   **Enum Management:** Utilized strongly-typed Enums for:
    1.  Application Status (New, Completed, Cancelled).
    2.  Issue Reason (New, Renew, Lost, Damaged).
    3.  License Classes (The 7 different categories).
    4.  Test Types (Vision, Theory, Practical).
    5.  Application Types (The 7 core services).
    6.  **Test Registration Results:** Handled **12 distinct failure scenarios**.

### 🗄️ Database & Security
*   **Security:** Full implementation of **Parameterized Queries** to prevent SQL Injection.
*   **Creation:** There are two script files for creating all the tables, constraints, indexes, and keys—in short, all the objects in the database. I created the first file, and the second was created using SSMS 22 program.
*   **Performance:** Strategic use of **Indexing** for faster searches and **SQL Views** for complex multi-table joins.
*   **Data Integrity:** Multi-level validation at both the Application (C# Classes) and Database (SQL Constraints) levels.
*   **State Persistence:** Used `Properties.Settings` for "Remember Me" functionality in the Login system.

---

## 📊 Database Design

The database was meticulously planned using:
*   **ERDPlus** for the conceptual design.
*   **dbdiagram.io** for the relational schema to ensure maximum normalization.

> [!TIP]
> You can find all design assets in the `/Database Images` folder.

---

## 📂 Project Structure

The solution consists of 4 main projects following the N-Tier logic:

* **DLMApp_PresentationLayer:** The Windows Forms UI, containing forms (Login, Main, etc.), User Controls, and application configurations (`App.config`).
* **DLMApp_BusinessLayer:** Contains service classes (e.g., `ApplicationService`, `UserService`) that handle the logic and bridge the UI with the Data layer.
* **DLMApp_DataAccessLayer:** Contains repository classes (e.g., `ApplicationRepository`, `UserRepository`) that execute SQL commands via ADO.NET.
* **DLMApp_ModulesLayer:** Contains the shared entities and enums (e.g., `AppEnums`, `clsUser`) used across all layers.

**Additional Assets:**
* `/Database Scripts`: Contains the full SQL Setup script.
* `/Database Images`: Includes ERD and Relational Schema diagrams.
* `/People Images`: Sample images for system users and applicants.

```text
├── DLMApp_PresentationLayer     # Windows Forms UI & User Controls
├── DLMApp_BusinessLayer         # Business Logic & Rules
├── DLMApp_DataAccessLayer       # ADO.NET Data Operations
├── DLMApp_ModulesLayer          # Shared Entities & Classes
├── People Images                # All images used in the system
│── Database Images              # ERD & Schema Screenshots
|── Database Scripts             # Two database Script files 
```

## 🚀 Installation & Setup

1.  **Database Configuration:**
    *   Navigate to the `/Database Scripts` folder.
    *   Open `DLMProjectScript_IGenerated.sql` in **SSMS**.
    *   Execute the script to create the database, tables, and seed initial data (License classes, Application types, etc.).
2.  **Connection String:**
    *   Open the solution in **Visual Studio 2022**.
3.  **Run:**
    *   Set `DLM_PresentationLayer` as the StartUp project.
    *   Press `F5` to build and run.


### 🔐 Default Credentials
After execute the script, use the following administrator account to access the system and explore all features:

| Field | Value |
| :--- | :--- |
| **Username** | `admin` |
| **Password** | `123` |


### ⚠️ Important Execution Note
Do not change the name and path of this folder `People Images` as it is used to save individual photos within the program.


## 👤 About the Author

**Ebrahim Hasan**
A passionate Software Developer with a solid foundation in Computer Science. My journey started with learning the basics of the C++ language (Functional programming), then mastering **Algorithms, Object Oriented Programming and Data Structures** in C++, then learning C#, .NET and SQL Server Database, which paved the way for building complex systems using **C# and .NET**.

* **Expertise:** Desktop Applications (WinForms), SQL Server Database Design, and Logic Automation.
* **Key Projects:** Driver License Management System, Code Generator Tool.
* **Current Goal:** Transitioning into Web Full-stack Development (C#/.NET Backend).

---
📫 **Connect with me:**
* 📧 **Email:** [ebrahim.hasan.dev@gmail.com](mailto:ebrahim.hasan.dev@gmail.com)
* 💼 **LinkedIn:** [Your Profile Name](https://linkedin.com/in/ebrahim-hasan-dev)
