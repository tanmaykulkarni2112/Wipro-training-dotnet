# Abstract_Interface_Static_Interface

This repository is created to **learn and organize Object-Oriented Programming concepts in .NET**, specifically:

- Abstract classes
- Inheritance
- Polymorphism
- (Later) Interfaces and static behavior

The focus of this repository is **project structure and navigation first**, implemented using **.NET CLI and VS Code**, without Visual Studio.

---

## 🧠 Conceptual Goal

We want to create:

- A **single solution**
- A **Console Application** as the entry point
- A **Class Library** that contains:

  - An abstract `Employee` base concept
  - Two different concrete implementations inheriting from it

No UI, no frameworks — just **clean OOP structure**.

---

## 📁 Final Target Structure

```
Abstract_Interface_Static_Interface/
│
├── AbstractInterfaceSolution.sln
│
├── EmployeeApp/
│   └── (Console Application – entry point)
│
├── EmployeeDomain/
│   └── (Class Library – abstract class + derived classes)
│
└── README.md
```

---

## 🏗️ Step-by-Step Initialization (CLI Only)

All commands are executed from the terminal.

---

### Step 1️⃣ Create the Root Folder

```bash
mkdir Abstract_Interface_Static_Interface
cd Abstract_Interface_Static_Interface
```

This folder will act as the **solution root**.

---

### Step 2️⃣ Create the Solution File

```bash
dotnet new sln -n AbstractInterfaceSolution
```

This creates:

```
AbstractInterfaceSolution.sln
```

📌 A solution is only a **container** — it does not run by itself.

---

### Step 3️⃣ Create the Console Application (Entry Point)

```bash
dotnet new console -n EmployeeApp
```

Purpose of this project:

- Contains `Main`
- Starts the program
- Uses logic defined in other projects

---

### Step 4️⃣ Create the Class Library (Domain Layer)

```bash
dotnet new classlib -n EmployeeDomain
```

Purpose of this project:

- Holds business/domain logic
- Contains abstract classes and derived implementations
- Has **no entry point**

---

### Step 5️⃣ Add Projects to the Solution

Attach both projects to the solution:

```bash
dotnet sln AbstractInterfaceSolution.sln add EmployeeApp/EmployeeApp.csproj
dotnet sln AbstractInterfaceSolution.sln add EmployeeDomain/EmployeeDomain.csproj
```

At this point, the solution knows about:

- `EmployeeApp`
- `EmployeeDomain`

---

### Step 6️⃣ Define Project Dependency Direction

The **Console App must depend on the Class Library**.

```bash
dotnet add EmployeeApp reference EmployeeDomain
```

This establishes the dependency:

```
EmployeeApp  ─────▶  EmployeeDomain
```

📌 The domain layer remains independent and reusable.

---

## 🧩 Conceptual Design (No Code)

Inside **EmployeeDomain**, the plan is to create:

- One **abstract Employee base**
- Two different concrete employee types

  - Each inherits from the abstract base
  - Each behaves differently

This setup is used to understand:

- Abstract class enforcement
- Runtime polymorphism
- Base vs derived behavior

---

## ▶️ Build & Run Verification

From the **solution root**:

### Build the entire solution

```bash
dotnet build
```

### Run the console application

```bash
dotnet run --project EmployeeApp
```

This confirms:

- Solution is wired correctly
- Project references are valid
- Entry point is functioning

---

## 🎯 Why This Structure Is Important

This structure mirrors **real-world .NET applications**:

- Entry points are thin
- Business logic is isolated
- Code is reusable and testable
- New projects (tests, APIs) can be added easily

This is the **same pattern used in enterprise systems**.

---
