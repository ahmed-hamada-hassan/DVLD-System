# DVLD (Driver & Vehicle Licensing Department)

> **Project Goal:** [A comprehensive Windows Forms application for managing driver and vehicle licensing operations, including license applications, testing processes, user management, and driver records. This system streamlines the workflow of a licensing department from application submission through test scheduling and license issuance.]

## Table of Contents
* [Solution Structure](#solution-structure)
* [Getting Started](#getting-started)
* [How to Use](#how-to-use)
* [Login Info](#login-info)

---

## Solution Structure

This solution follows a **3-tier architecture** pattern with clear separation of concerns between data access, business logic, and presentation layers.

### 1. DVLD_DataAccessLayer

* **Project Type:** Class Library (.NET Framework 4.8)
* **Purpose:** Data access layer responsible for all database operations using ADO.NET with SQL Server.
* **Key Components (Files/Classes):**
  * `clsDataAccessSettings.cs`: Manages the database connection string for SQL Server connectivity.
  * `clsApplicationTypeData.cs`: Handles CRUD operations for application types including retrieval, updates, and fee management.
  * `clsLicenseData.cs`: Manages license data operations including retrieving licenses by ApplicationID, DriverID, PersonID, and active license queries.
  * `clsUserData.cs`: Provides data access methods for user authentication and management operations.
  * `clsPersonData.cs`: Handles database operations for person/applicant records.
  * `clsDriverData.cs`: Manages driver-specific data access operations.
  * `clsTestData.cs`: Provides data access for test records and test scheduling.
* **Dependencies:** None (base layer)

### 2. DVLD_BusinessLayer

* **Project Type:** Class Library (.NET Framework 4.8)
* **Purpose:** Contains business logic, domain models, validation rules, and service classes that bridge the presentation and data access layers.
* **Key Components (Files/Classes):**
  * **User BL:**
    * `clsUser.cs`: User entity with properties for UserID, PersonID, UserName, PasswordHash, PasswordSalt, IsActive, and Password.
  * **People BL:**
    * `clsPerson.cs`: Person entity with comprehensive demographic information including NationalNo, names, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, and ImagePath.
  * **Applications BL:**
    * `clsApplicationType.cs`: Defines application types with ApplicationID, ApplicationName, and ApplicationFees.
    * `clsApplicationTypeLogics.cs`: Business logic for managing application types, including GetApplicationTypeByIDAsync and UpdateApplicationTypeInfoAsync methods.
  * **License BL:**
    * `clsLicense.cs`: License entity with LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, and CreatedByUserID.
    * `clsLicenseLogics.cs`: Business logic for license operations including retrieval and management.
    * `clsLocalDrivingLicenseApplication.cs`: Specialized class for local driving license applications.
  * **Drivers BL:**
    * `clsDriver.cs`: Driver entity with DriverID, PersonID, CreatedByUserID, and CreationDate.
  * **Test Types:**
    * `clsTestType.cs`: Test type entity with TestTypeID, TestTypeTitle, TestTypeDescription, and TestTypeFees.
    * `clsTestTypeLogics.cs`: Business logic for test type management with async operations.
  * **Tests:**
    * `clsTest.cs`: Manages test scheduling, execution, and trial counting.
    * `clsTestAppointment.cs`: Handles test appointment scheduling and management.
* **Dependencies:** References `DVLD_DataAccessLayer`

### 3. DVLD

* **Project Type:** Windows Forms Application (.NET Framework 4.8)
* **Purpose:** Main user interface providing forms for managing all aspects of the driver licensing system.
* **Key Components (Files/Classes):**
  * **Entry Point:**
    * `Program.cs`: Application entry point with Main() method, launches frmLoginScreen and maintains CurrentUser session.
  * **Authentication:**
    * `frmLoginScreen.cs`: User authentication form for system access.
  * **Main Interface:**
    * `Form2.cs` (Form2.cs): Main application window with menu system for accessing all features.
  * **People Management:**
    * `frmManagePeople.cs`: Interface for viewing and managing person records.
  * **Application Management:**
    * `frmManageApplicationTypes.cs`: Manage different types of license applications.
    * `frmUpdateApplicationType.cs`: Form for updating application type details with validation (title 3-150 chars, positive fees).
    * `frmNewLocalDrivingLicenseApplication.cs`: Create new local driving license applications.
    * `frmManageLocalLicenseApplications.cs`: View and manage local license applications.
    * `frmNewInternationalLicenseApplication.cs`: Create international license applications.
    * `frmManageInternationalLicenseApplications.cs`: Manage international license applications.
  * **Test Management:**
    * `frmManageTestTypes.cs`: Manage test types (Vision, Written, Road tests).
    * `frmUpdateTestType.cs`: Update test type information with comprehensive validation for title, description, and fees.
    * `frmScheduleTest.cs`: Schedule test appointments (Vision, Written, Road) with appointment type enumeration.
    * `frmTakeTest.cs`: Interface for conducting and recording test results.
    * `frmScheduleTestAppointment.cs`: Schedule specific test sessions for applicants.
    * `frmRetakeTest.cs`: Handle retake test scheduling for failed attempts.
  * **License Management:**
    * `frmRenewLicense.cs`: Process license renewal applications.
    * `frmReplaceLostOrDamagedLicense.cs`: Handle lost or damaged license replacements.
    * `frmDetainLicense.cs`: Manage license detention/suspension.
    * `frmReleaseDetainedLicense.cs`: Process release of detained licenses.
    * `frmListDetainedLicenses.cs`: View all detained licenses.
  * **Driver Management:**
    * `frmManageDrivers.cs`: Interface for viewing and managing driver records.
  * **User Management:**
    * `frmManageUsers.cs`: System user administration interface.
  * **Shared Controls:**
    * `ctrlApplicationInfo.cs`: Reusable user control displaying application and applicant details.
* **Dependencies:** References `DVLD_BusinessLayer`, `DVLD_DataAccessLayer`

---

## Getting Started

### Prerequisites

Based on the project files, the following are required:

* **.NET Framework 4.8 SDK** or higher
* **Visual Studio 2019 or later** (or Visual Studio 2026 as indicated by your environment)
* **SQL Server 2016 or later** (any edition including Express)
* **Database Setup:** A SQL Server database named `DVLD` must exist and be accessible

### Installation & Build

1. **Clone the repository** to your local machine.

2. **Configure Database Connection:**
   - Navigate to `DVLD_DataAccessLayer\clsDataAccessSettings.cs`
   - Update the connection string with your SQL Server credentials:
     `"Server=YOUR_SERVER;Database=DVLD;User Id=YOUR_USER;Password=YOUR_PASSWORD;"`
   - Replace server name, user ID, and password as needed for your environment.

3. **Database Setup:**
   This project uses a SQL Server database backup file (`.bak`) located in the `DriversAndVehiclesLicensesDepartment (DVLD)\DVLD DataAccessLayer` directory.
   You need to restore this backup to your local SQL Server instance.

**Using SQL Server Management Studio (SSMS):**

1.  Open SSMS and connect to your SQL Server instance.
2.  Right-click on the **Databases** folder in the Object Explorer and select **"Restore Database..."**.
3.  In the "Restore Database" window, select **"Device"** as the source.
4.  Click the "..." button to select the backup device.
5.  In the "Select backup devices" window, click **"Add"**.
6.  Navigate to the project folder, go to `DriversAndVehiclesLicensesDepartment (DVLD)\DVLD DataAccessLayer`, and select the `.bak` file.
7.  Click **"OK"** on all open windows to return to the main "Restore Database" window.
8.  In the **"Database"** field under the "Destination" section, type the name you want for your database, which should be **`DVLD`**.
9.  (Optional but Recommended) Go to the **"Options"** page from the left-hand menu and check **"Overwrite the existing database (WITH REPLACE)"** if you are restoring over a database with the same name.
10. Click **"OK"** to begin the restore process.

4. **Open the Solution:**
   - Open `DriversAndVehiclesLicensesDepartment (DVLD).sln` in Visual Studio 2026 (or your installed version)

5. **Restore NuGet Packages:**
   - Right-click on the solution in Solution Explorer
   - Select **Restore NuGet Packages**
   - Or simply build the solution (Visual Studio will restore automatically)

6. **Build the Solution:**
   - Press `Ctrl+Shift+B` or select **Build > Build Solution**
   - Ensure all three projects compile without errors

---

## How to Use

### Running the Application

1. **Set Startup Project:**
   - In Solution Explorer, right-click on `DVLD`
   - Select **Set as Startup Project**

2. **Run the Application:**
   - Press `F5` to run in debug mode, or `Ctrl+F5` to run without debugging
   - The application will launch with `frmLoginScreen`

3. **Login:**
   - Enter valid user credentials (UserName and Password)
   - The system uses salted password hashing for security
   - Upon successful authentication, the main screen `Form2` will appear

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
* **Session Management:** Current user session is maintained via `Program.CurrentUser` static property
* **Error Handling:** User-friendly MessageBox dialogs for operation feedback and error messages

---

## Additional Notes

* **Database Connectivity:** The application uses ADO.NET with `SqlConnection`, `SqlCommand`, and `SqlDataReader` for data access
* **Form Patterns:** Most management forms follow a consistent pattern with DataGridView for listing and modal dialogs for add/edit operations
* **Reusable Components:** User controls are used for common UI patterns (e.g., `ctrlApplicationInfo`)
* **Test Types:** The system supports three test types: Vision (ID: 1), Written (ID: 2), and Road (ID: 3)
* **Security:** Passwords are stored using hash and salt mechanisms for enhanced security

---

## Login Info

The application's default login credentials are provisioned within the `DVLD.bak` database file. After restoring the database, you can find the user accounts in the `Users` table.

A default administrative account is typically included:

* **Username:** `kkkkk`
* **Password:** `123456`

**Note:** As mentioned in the [How to Use](#how-to-use) section, the system uses salted password hashing. The password `1234` is what you enter at the login screen. The database stores the corresponding hash and salt for this user, not the plain text password.
