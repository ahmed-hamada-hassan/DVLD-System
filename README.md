# DVLD (Driver & Vehicle Licensing Department)

> **Project Goal:** [A comprehensive Windows Forms application for managing driver and vehicle licensing operations, including license applications, testing processes, user management, and driver records. This system streamlines the workflow of a licensing department from application submission through test scheduling and license issuance.]

## Table of Contents
* [Solution Structure](#solution-structure)
* [Getting Started](#getting-started)
* [How to Use](#how-to-use)

---

## 🏛️ Solution Structure

This solution follows a **3-tier architecture** pattern with clear separation of concerns between data access, business logic, and presentation layers.

### 1. 

* **Project Type:** Class Library (.NET Framework 4.8)
* **Purpose:** Data access layer responsible for all database operations using ADO.NET with SQL Server.
* **Key Components (Files/Classes):**
  * : Manages the database connection string for SQL Server connectivity.
  * : Handles CRUD operations for application types including retrieval, updates, and fee management.
  * : Manages license data operations including retrieving licenses by ApplicationID, DriverID, PersonID, and active license queries.
  * : Provides data access methods for user authentication and management operations.
  * : Handles database operations for person/applicant records.
  * : Manages driver-specific data access operations.
  * : Provides data access for test records and test scheduling.
* **Dependencies:** None (base layer)

### 2. 

* **Project Type:** Class Library (.NET Framework 4.8)
* **Purpose:** Contains business logic, domain models, validation rules, and service classes that bridge the presentation and data access layers.
* **Key Components (Files/Classes):**
  * **User BL:**
    * : User entity with properties for UserID, PersonID, UserName, PasswordHash, PasswordSalt, IsActive, and Password.
  * **People BL:**
    * : Person entity with comprehensive demographic information including NationalNo, names, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, and ImagePath.
  * **Applications BL:**
    * : Defines application types with ApplicationID, ApplicationName, and ApplicationFees.
    * : Business logic for managing application types, including GetApplicationTypeByIDAsync and UpdateApplicationTypeInfoAsync methods.
  * **License BL:**
    * : License entity with LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, and CreatedByUserID.
    * : Business logic for license operations including retrieval and management.
    * : Specialized class for local driving license applications.
  * **Drivers BL:**
    * : Driver entity with DriverID, PersonID, CreatedByUserID, and CreationDate.
  * **Test Types:**
    * : Test type entity with TestTypeID, TestTypeTitle, TestTypeDescription, and TestTypeFees.
    * : Business logic for test type management with async operations.
  * **Tests:**
    * : Manages test scheduling, execution, and trial counting.
    * : Handles test appointment scheduling and management.
* **Dependencies:** References 

### 3. 

* **Project Type:** Windows Forms Application (.NET Framework 4.8)
* **Purpose:** Main user interface providing forms for managing all aspects of the driver licensing system.
* **Key Components (Files/Classes):**
  * **Entry Point:**
    * : Application entry point with Main() method, launches frmLoginScreen and maintains CurrentUser session.
  * **Authentication:**
    * : User authentication form for system access.
  * **Main Interface:**
    *  (Form2.cs): Main application window with menu system for accessing all features.
  * **People Management:**
    * : Interface for viewing and managing person records.
  * **Application Management:**
    * : Manage different types of license applications.
    * : Form for updating application type details with validation (title 3-150 chars, positive fees).
    * : Create new local driving license applications.
    * : View and manage local license applications.
    * : Create international license applications.
    * : Manage international license applications.
  * **Test Management:**
    * : Manage test types (Vision, Written, Road tests).
    * : Update test type information with comprehensive validation for title, description, and fees.
    * : Schedule test appointments (Vision, Written, Road) with appointment type enumeration.
    * : Interface for conducting and recording test results.
    * : Schedule specific test sessions for applicants.
    * : Handle retake test scheduling for failed attempts.
  * **License Management:**
    * : Process license renewal applications.
    * : Handle lost or damaged license replacements.
    * : Manage license detention/suspension.
    * : Process release of detained licenses.
    * : View all detained licenses.
  * **Driver Management:**
    * : Interface for viewing and managing driver records.
  * **User Management:**
    * : System user administration interface.
  * **Shared Controls:**
    * : Reusable user control displaying application and applicant details.
* **Dependencies:** References , 

---

## 🚀 Getting Started

### Prerequisites

Based on the project files, the following are required:

* **.NET Framework 4.8 SDK** or higher
* **Visual Studio 2019 or later** (or Visual Studio 2026 as indicated by your environment)
* **SQL Server 2016 or later** (any edition including Express)
* **Database Setup:** A SQL Server database named  must exist and be accessible

### Installation & Build

1. **Clone the repository** to your local machine.

2. **Configure Database Connection:**
   - Navigate to 
   - Update the connection string with your SQL Server credentials:
     
   - Replace server name, user ID, and password as needed for your environment.

3. **Database Setup:**
   - Create a database named  in your SQL Server instance
   - Run the database schema scripts (if provided) to create necessary tables:
     - 
     - 
     - 
     - 
     - 
     - 
     - 
     - 
     - 
     - Related views (e.g., )

4. **Open the Solution:**
   - Open  in Visual Studio 2026 (or your installed version)

5. **Restore NuGet Packages:**
   - Right-click on the solution in Solution Explorer
   - Select **Restore NuGet Packages**
   - Or simply build the solution (Visual Studio will restore automatically)

6. **Build the Solution:**
   - Press  or select **Build > Build Solution**
   - Ensure all three projects compile without errors

---

## 💻 How to Use

### Running the Application

1. **Set Startup Project:**
   - In Solution Explorer, right-click on 
   - Select **Set as Startup Project**

2. **Run the Application:**
   - Press  to run in debug mode, or  to run without debugging
   - The application will launch with 

3. **Login:**
   - Enter valid user credentials (UserName and Password)
   - The system uses salted password hashing for security
   - Upon successful authentication, the main screen will appear

### Key Features

* **People Management:** Add, edit, view, and search person/applicant records
* **Application Processing:** Create and manage different types of license applications
* **Test Scheduling:** Schedule Vision, Written, and Road tests for applicants
* **Test Execution:** Conduct tests and record pass/fail results with retake functionality
* **License Issuance:** Issue, renew, and replace driving licenses (local and international)
* **License Detention:** Detain and release licenses based on violations or requirements
* **Driver Management:** View and manage driver records and license history
* **User Administration:** Manage system users and access permissions
* **Application Types & Test Types:** Configure fees and requirements for different services

### Running Tests

* This solution does not appear to include a dedicated test project
* Manual testing should be performed through the Windows Forms interface
* Database integrity should be verified after performing CRUD operations

### Architecture Notes

* **Async/Await Pattern:** The application extensively uses async/await for database operations to maintain UI responsiveness
* **3-Tier Architecture:** Strict separation between Data Access, Business Logic, and Presentation layers
* **Validation:** Input validation is implemented using regular expressions with visual feedback (ErrorProvider, color-coded textboxes)
* **Session Management:** Current user session is maintained via  static property
* **Error Handling:** User-friendly MessageBox dialogs for operation feedback and error messages

---

## 📋 Additional Notes

* **Database Connectivity:** The application uses ADO.NET with , , and  for data access
* **Form Patterns:** Most management forms follow a consistent pattern with DataGridView for listing and modal dialogs for add/edit operations
* **Reusable Components:** User controls are used for common UI patterns (e.g., )
* **Test Types:** The system supports three test types: Vision (ID: 1), Written (ID: 2), and Road (ID: 3)
* **Security:** Passwords are stored using hash and salt mechanisms for enhanced security

---

*This README was auto-generated based on analysis of the DVLD solution structure and source code.*
